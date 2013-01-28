
using Microsoft.Xna.Framework;
namespace Library.Physics
{
    /// <summary>
    /// Data used to determine different statuses of an entity
    /// </summary>
    public class QueryData<T> where T:IEntity
    {
        public Vector2 Size;

        public bool IsActive(T ent)
        {
            return !(ent.Equals(null));
        }

        public bool InView(T ent)
        {
            return (ent.Position.IsGreaterThanOrEqual(new Vector2(0)) && ent.Position.IsLessThanOrEqual(Size)) ;
        }
    }
    
    public interface IEntity
    {
        Vector2 Position { get; }

        float Mass { get; }
        float Height { get; }
        float Width { get; }
        float Scale { get; }

        float Top { get; }
        float Bottom { get; }
        float Left { get; }
        float Right { get; }
    }

    public interface IActor
    {
        
    }
}
