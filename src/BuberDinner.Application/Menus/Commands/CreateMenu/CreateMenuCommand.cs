using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate;
using BuberDinner.Domain.MenuAggregate.Entities;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Menus.Commands.CreateMenu;

public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
{
    private readonly IMenuRepository _menuRepository;
    private readonly IGenericRepository<Menu> _genericRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateMenuCommandHandler(
        IGenericRepository<Menu> genericRepository,
        IUnitOfWork unitOfWork,
        IMenuRepository menuRepository)
    {
        _genericRepository = genericRepository;
        _unitOfWork = unitOfWork;
        _menuRepository = menuRepository;
    }
    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
        // Create Menu
        var menu = Menu.Create(
            name: request.Name,
            description: request.Description,
            hostId: HostId.Create(Guid.Parse(request.HostId)),
            sections: request.Sections.ConvertAll(section => MenuSection.Create(
                section.Name,
                section.Description,
                section.Items.ConvertAll(item => MenuItem.Create(
                    item.Name,
                    item.Description)))));
        // Persist Menu
        _genericRepository.Add(menu);
        _unitOfWork.Save();
        await _unitOfWork.CommitAsync();
        // Return Menu
        return menu;
    }
}