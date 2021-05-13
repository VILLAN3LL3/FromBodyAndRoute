using Microsoft.AspNetCore.Mvc;

namespace FromBodyAndRoute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPut("{Id}")]
        public ActionResult<UserDto> Put(UserDto userDto)
        {
            return Ok(userDto);
        }
    }

    public class UserDto
    {
        [FromRoute]
        public int Id { get; set; }
        [FromBody]
        public UserBodyDto Body { get; set; }
    }

    public class UserBodyDto
    {
        public string Name { get; set; }
        public string FavoriteDish { get; set; }
    }
}
