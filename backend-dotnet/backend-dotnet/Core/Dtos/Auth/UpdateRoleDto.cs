using System.ComponentModel.DataAnnotations;

namespace backend_dotnet.Core.Dtos.Auth
{
    public class UpdateRoleDto
    {
        [Required(ErrorMessage ="Username is require ")]
        public string UserName { get; set; }
        public RoleType NewRole { get; set; }
    }

    public enum RoleType
    {
        ADMIN,
        MANAGER,
        USER
    }
}
