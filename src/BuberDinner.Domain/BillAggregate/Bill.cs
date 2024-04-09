using BuberDinner.Domain.BillAggregate.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.GuestAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;

namespace BuberDinner.Domain.BillAggregate;

public sealed class Bill : AggregateRoot<BillId, Guid>
{
    public HostId HostId { get; }
    public DinnerId DinnerId { get; }
    public GuestId GuestId { get; }
    public Price Price { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Bill(
        BillId billId,
        HostId hostId,
        DinnerId dinnerId,
        GuestId guestId,
        Price price,
        DateTime createdDateTime,
        DateTime updatedDate)
        : base(billId)
    {
        HostId = hostId;
        DinnerId = dinnerId;
        GuestId = guestId;
        Price = price;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDate;
    }

    public static Bill Create(
        HostId hostId,
        DinnerId dinnerId,
        GuestId guestId,
        decimal amount,
        string currency)
    {
        return new(
            BillId.CreateUnique(),
            hostId,
            dinnerId,
            guestId,
            new Price(amount, currency),
            DateTime.UtcNow,
            DateTime.UtcNow
        );
    }
}