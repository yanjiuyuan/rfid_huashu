using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DingTalk.Controllers
{
    /// <summary>
    /// 生产下单
    /// </summary>
    [RoutePrefix("ProductionOrder")]
    public class ProductionOrderController : ApiController
    {
        
        [Route("Save")]
        [HttpPost]
        public object Save([FromBody] List<Pick> pickList)
        {
            try
            {

                EFHelper<Pick> eFHelper = new EFHelper<Pick>();
                foreach (var pick in pickList)
                {
                    eFHelper.Add(pick);
                }
                return new NewErrorModel()
                {
                    error = new Error(0, "保存成功！", "") { },
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
