using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class UsersBL
    {
        private readonly MongoService<User> _repository;

        internal UsersBL()
        {
            _repository = new MongoService<User>();
        }
        public static UsersBL Instance = new UsersBL();

        public async Task<IEnumerable<User>> FindAll()
        {
            var result = await _repository.FindAll();
            return result;
        }
        public async Task Create(User user)
        {
            await _repository.Create(user);
        }

        public async Task<User> FindById(string id)
        {
            return await _repository.FindById(id);
        }

        public async Task<User> FindActiveById(string id)
        {
            return await _repository.FindActiveById(id);
        }

        public async Task Save(User user, string id)
        {
            await _repository.Save(user, id);
        }

        public async Task Save(User user)
        {
            await Save(user, user.Id);
        }

        public async Task LogicalRemove(string id)
        {
            await _repository.LogicalRemove(id);
        }

        public async Task Remove(string id)
        {
            await _repository.Remove(id);
        }
    }
}
