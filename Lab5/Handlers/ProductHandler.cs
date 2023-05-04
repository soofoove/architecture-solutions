using Lab5.Models;
using Lab5.Responses;

namespace Lab5.Handlers
{
    public class ProductHandler : AbstractHandler
    {
        protected override Product GetExistingObjectFromDb(int id)
        {
            return new Product() { Id = id };
        }

        protected override bool IsValid(EntityBase existingObject, EntityBase request)
        {
            //TODO: implement
            return true;
        }

        protected new void ValidationFailedHook(object request) 
        { 
            //TODO: send message to Administrator
        }

        protected override bool UpdateObjectInDb(EntityBase request)
        {
            //TODO: implement
            return true;
        }
    }
}
