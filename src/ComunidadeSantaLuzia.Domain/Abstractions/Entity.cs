namespace ComunidadeSantaLuzia.Domain.Abstractions;

public class Entity
{
    public Guid Id { get; init; }

    protected Entity() { }
    protected Entity(Guid id) => Id = id;
}
