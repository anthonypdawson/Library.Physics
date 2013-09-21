
using Microsoft.Xna.Framework;

namespace Library.Physics.Controllers
{
    public interface IPhysicsController
    {
        Vector2 ModifyAcceleration(Vector2 acceleration);
    }

    public class GravityController : IPhysicsController
    {
        public Vector2 ModifyAcceleration(Vector2 acceleration)
        {
            return new Vector2(1, 0.9f) * acceleration;
        }
    }
}
