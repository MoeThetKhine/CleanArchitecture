
namespace DotNet8.Clean.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{

	#region Content

	protected IActionResult Content(object obj)
	{
		return Content(obj.ToJson(), "application/json");
	}

	#endregion
}
