using ApiTuya.Domain.Entities;
using ApiTuya.Infrastructure.Repositories.UserRepository;

namespace ApiTuya.Application.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task<User> Create(User createUser, CancellationToken cancellationToken)
        {
            await _UserRepository.Create(createUser, cancellationToken);
            return null;
        }

        public async Task<User> Get(int id, CancellationToken cancellationToken)
        {
            User? CurrentUser = await _UserRepository.GetByID(id, cancellationToken);
            if (CurrentUser != null)
            {
                return CurrentUser;
            }
            return null;
        }

        public async Task<User> Update(User updateRequest, CancellationToken cancellationToken)
        {
            User entity = await _UserRepository.GetByID(updateRequest.Id, cancellationToken);
            await _UserRepository.Update(updateRequest, cancellationToken);

            return entity;
        }

        public async Task<ICollection<User>> GetAll(CancellationToken cancellationToken)
        {
            IEnumerable<User> CurrentUsers = await _UserRepository.GetAll(cancellationToken);
            if (CurrentUsers != null)
            {
                return (ICollection<User>)CurrentUsers;
            }
            return null;
        }
    }
}