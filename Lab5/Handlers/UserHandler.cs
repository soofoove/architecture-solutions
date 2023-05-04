using Lab5.Models;
using Lab5.Responses;

namespace Lab5.Handlers
{
    public class UserHandler : AbstractHandler
    {
        protected override EntityBase GetExistingObjectFromDb(int id)
        {
            return new User() { Id = id };
        }

        protected override bool IsValid(EntityBase existingObject, EntityBase request)
        {
            var existingModel = (User)existingObject;
            var requestModel = (User)request;

            //New User
            if (existingModel == null)
            {
                return true;
            }

            if (existingModel.Email != requestModel.Email)
            {
                return false;
            }

            return true;
        }

        protected override bool UpdateObjectInDb(EntityBase request)
        {
            //TODO: implement
            return true;
        }
    }
}
