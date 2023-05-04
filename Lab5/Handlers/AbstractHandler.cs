using Lab5.Models;
using Lab5.Responses;

namespace Lab5.Handlers
{
    public abstract class AbstractHandler
    {
        public BaseResponse Handle(EntityBase request)
        {
            var existingObject = GetExistingObjectFromDb(request.Id);

            if (!IsValid(existingObject, request))
            {
                ValidationFailedHook(request);

                return new BaseResponse
                {
                    Status = 400,
                    Message = "Validation failed"
                };
            }

            var updateSucceeded = UpdateObjectInDb(request);

            return CreateResponse(updateSucceeded, request);
        }

        protected abstract EntityBase GetExistingObjectFromDb(int id);

        protected abstract bool IsValid(EntityBase existingObject, EntityBase request);

        protected void ValidationFailedHook(object request) { }

        protected abstract bool UpdateObjectInDb(EntityBase request);

        protected virtual BaseResponse CreateResponse(bool updateSucceeded, EntityBase request)
        {
            if (updateSucceeded)
            {
                return new BaseResponse
                {
                    Status = 200,
                    Message = "Object was successfully updated in DB"
                };
            }

            return new BaseResponse
            {
                Status = 500,
                Message = $"Object update failed: Id={request.Id}. Please contact support"
            };
        }

    }
}
