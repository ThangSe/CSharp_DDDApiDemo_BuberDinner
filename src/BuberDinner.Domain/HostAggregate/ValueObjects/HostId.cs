using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.UserAggregate.ValueObjects;

namespace BuberDinner.Domain.HostAggregate.ValueObjects;

public sealed class HostId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private HostId(Guid value)
    {
        Value = value;
    }

    public static HostId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static HostId Create(Guid value)
    {
        return new HostId(value);
    }
    public static HostId Create(UserId userId)
    {
        return new HostId(userId.Value);
    }
    public static HostId Create(string hostId)
    {
        return new HostId(Guid.Parse(hostId));
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}