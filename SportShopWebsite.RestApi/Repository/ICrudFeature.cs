using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Repository
{
    public interface ICrudFeature<Type>
    {
        public Task<Type> Add(Type type);
        public Task Update(Type type);
        public Task Delete(int id);

        public Task<IEnumerable<Type>> GetAll();
        public Task<Type> GetById(int id);
    }
}
