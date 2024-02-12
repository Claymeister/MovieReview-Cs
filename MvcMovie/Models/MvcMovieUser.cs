using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace MvcMovie.Models
{
    public class MvcMovieUser : IdentityUser
    {
        [Required]
        [PersonalData]
        public string Nickname { get; set; }

        // Navigation property
        public ICollection<Review>? Reviews { get; set; }

    }

    public class MvcMovieUserManager : UserManager<MvcMovieUser>
    {
        public MvcMovieUserManager(IUserStore<MvcMovieUser> store, IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<MvcMovieUser> passwordHasher, IEnumerable<IUserValidator<MvcMovieUser>> userValidators,
            IEnumerable<IPasswordValidator<MvcMovieUser>> passwordValidators, ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<MvcMovieUser>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }

        public async Task<string> GetNickname(ClaimsPrincipal user)
        {
            var appUser = await GetUserAsync(user);
            return appUser?.Nickname;
        }
    }
}
