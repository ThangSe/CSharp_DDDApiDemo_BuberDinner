namespace BuberDinner.Contracts.Menus;

public record MenuResponse(
    string Id,
    string Name,
    string Description,
    float? AverageRating,
    string HostId,
    List<MenuSectionResponse> Sections,
    List<string> DinnerIds,
    List<string> MenuReviewIds,
    DateTime CreatedDateTime,
    DateTime UpdateDateTime);

public record MenuSectionResponse(
    string Id,
    string Name,
    string Description,
    List<MenuItemResponse> Items);

public record MenuItemResponse(
    string Id,
    string Name,
    string Description);