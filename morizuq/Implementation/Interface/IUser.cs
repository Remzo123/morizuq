using morizuq.DTO.RequestModel;
using morizuq.DTO.ResponseModel;

namespace morizuq.Implementation.Interface
{
    public interface IUser
    {
        Task<BaseResponseModel<Guid>> Createuser(CreateUser request);
    }
}
