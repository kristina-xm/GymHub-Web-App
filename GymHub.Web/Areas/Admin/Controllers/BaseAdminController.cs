using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static GymHub.Common.GeneralApplicationConstants;

namespace GymHub.Web.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class BaseAdminController : Controller
    {
       
    }
}
