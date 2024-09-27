using Microsoft.EntityFrameworkCore;
using morizuq.DTO.RequestModel;
using morizuq.DTO.ResponseModel;
using morizuq.Implementation.Interface;
using morizuq.Models;
using morizuq.Models.Data;

namespace morizuq.Implementation.Service
{
    public class UserService:IUser
    {
        private readonly ApplicationDBcontext _dbContext;
        public UserService(ApplicationDBcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BaseResponseModel<Guid>> Createuser(CreateUser request)
        {
            try
            {
                var create = new User()
                {
                    Email = request.Email,
                    Name = request.Name,
                    PhoneNumber = request.PhoneNumber,
                    address = request.Address,
                };
                await _dbContext.Users.AddAsync(create);
                if (_dbContext.SaveChanges() > 0)
                {
                    return new BaseResponseModel<Guid>
                    {
                        Message = "created Succesfully",
                        Success = true,
                        Data = create.Id,
                    };
                }
                return new BaseResponseModel<Guid>
                {
                    Message = "failed",
                    Success = false,
                };
            }
            catch (Exception ex)
            {

                return new BaseResponseModel<Guid>
                {
                    Message = "failed",
                    Success = false,
                };
            }
           

        }
    }
}
