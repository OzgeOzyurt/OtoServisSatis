using OtoServisSatis.Data;
using OtoServisSatis.Service.Abstract;
using OtoServisSatis.Data.Concrete;

namespace OtoServisSatis.Service.Concrete
{
    public class UserService : UserRepository, IUserService
    {
        public UserService(DatabaseContext context) : base(context)
        {
        }
    }
}
