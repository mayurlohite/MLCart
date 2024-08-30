using AspEcommerce.Core.Interface.Services.Statistics;
using Microsoft.AspNetCore.Mvc;

namespace AspEcommerce.Web.Areas.Admin.Controllers
{
    public class ChartController : AdminController
    {
        #region Fields

        private readonly IOrderCountService _orderCountService;
        private readonly IVisitorCountService _visitorCountService;

        #endregion

        #region Constructor

        public ChartController(
            IOrderCountService orderCountService,
            IVisitorCountService visitorCountService)
        {
            _orderCountService = orderCountService;
            _visitorCountService = visitorCountService;
        }

        #endregion

        #region Methods

        public IActionResult GetVisitorCount()
        {
            var results = _visitorCountService.GetAllVisitorCount(7)
                .OrderBy(x => x.Date);

            return Json(results);
        }

        public IActionResult GetOrderCount()
        {
            var results = _orderCountService.GetAllOrderCount(7)
                .OrderBy(x => x.Date);

            return Json(results);
        }

        #endregion
    }
}
