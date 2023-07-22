using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GymHub.Web.Controllers
{
    public class BaseController : Controller
    {
        protected Guid GetUserId()
        {
            Guid userId = Guid.Empty;

            if (User != null)
            {
                string idString = User.FindFirstValue(ClaimTypes.NameIdentifier);


                Guid.TryParse(idString, out userId);
            }

            return userId;
        }
    }
}
