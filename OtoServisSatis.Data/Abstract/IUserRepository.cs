using OtoServisSatis.Entities;
using System.Linq.Expressions;

namespace OtoServisSatis.Data.Abstract
{
    public interface IUserRepository : IRepository<Kullanici>
    {
        Task<List<Kullanici>> GetCustomCustomerList();
        Task<List<Kullanici>> GetCustomCustomerList(Expression<Func<Kullanici, bool>> expression);
    }
}
