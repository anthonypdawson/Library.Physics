
namespace Library.Physics.Controllers
{
    public interface IPhysicsController
    {
        Vector ModifyAcceleration(Vector acceleration);
    }

    public class GravityController : IPhysicsController
    {
        public Vector ModifyAcceleration(Vector acceleration)
        {
            return new Vector(1, 0.9f) * acceleration;
        }
    }
}
