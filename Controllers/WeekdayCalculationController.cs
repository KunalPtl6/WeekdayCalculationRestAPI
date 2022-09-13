using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeekdayCalculationRestAPI.Common;
using WeekdayCalculationRestAPI.Modal;

namespace WeekdayCalculationRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeekdayCalculationController : ControllerBase
    {

        [HttpGet(Name = "GetWeekdayFromCurrentDate")]
        public async Task<ActionResult<WeekdayReturnList>> GetWeekdayFromCurrentDate()
        {
            //current date
            DateTime dt = DateTime.Now;

            WeekdayReturnList objWeekdayReturnList = new WeekdayReturnList();
            await Task.Run(() => objWeekdayReturnList.WeekdayList = CommonMethod.GetWeekdayListFromDate(dt));
            return objWeekdayReturnList;
        }

        [HttpPost(Name = "GetWeekdayFromInputDate")]
        public async Task<ActionResult<WeekdayReturnList>> GetWeekdayFromInputDate(string insertedDate)
        {
            //input date
            DateTime dt = Convert.ToDateTime(insertedDate);

            WeekdayReturnList objWeekdayReturnList = new WeekdayReturnList();
            await Task.Run(() => objWeekdayReturnList.WeekdayList = CommonMethod.GetWeekdayListFromDate(dt));
            return objWeekdayReturnList;
        }

    }
}
