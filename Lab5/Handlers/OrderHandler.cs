using Lab5.Models;
using Lab5.Responses;
using System.Text.Json;

namespace Lab5.Handlers
{
    public class OrderHandler : AbstractHandler
    {
        protected override Order GetExistingObjectFromDb(int id)
        {
            return new Order() { Id = id };
        }

        protected override bool IsValid(EntityBase existingObject, EntityBase request)
        {
            //TODO: implement
            return true;
        }

        protected override bool UpdateObjectInDb(EntityBase request)
        {
            //TODO: implement
            return true;
        }

        protected override OrderResponse CreateResponse(bool updateSucceeded, EntityBase request)
        {
            var baseResponse = base.CreateResponse(updateSucceeded, request);

            return new OrderResponse
            {
                Status = baseResponse.Status,
                Message = baseResponse.Message,
                OrderJson = JsonSerializer.Serialize(request)
            };
        }
    }
}
