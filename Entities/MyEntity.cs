namespace EnumDemo.Entities;

public sealed class MyEntity
{
    public required long Id { get; set; }

    public required MyEnum Value { get; set; }
}
