using DingTalk.EF;
using DingTalk.Models;
using DingTalk.Models.DingModels;
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
        /// <summary>
        /// 表单保存
        /// </summary>
        /// <param name="productionOrderTable"></param>
        /// <returns></returns>
        [Route("Save")]
        [HttpPost]
        public NewErrorModel Save(ProductionOrderTable productionOrderTable)
        {
            try
            {
                DDContext dDContext = new DDContext();
                if (productionOrderTable.ProductionOrderDetails == null || productionOrderTable.ProductionOrderDetails.Count == 0)
                {
                    return new NewErrorModel()
                    {
                        error = new Error(1, "ProductionOrderDetail参数有误！", "") { },
                    };
                }
                else
                {
                    dDContext.ProductionOrderTable.Add(productionOrderTable);
                    dDContext.ProductionOrderDetail.AddRange(productionOrderTable.ProductionOrderDetails);
                    dDContext.SaveChanges();
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

        /// <summary>
        /// 表单读取
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        [Route("Read")]
        [HttpGet]
        public NewErrorModel Read(string taskId)
        {
            try
            {
                DDContext dDContext = new DDContext();
                ProductionOrderTable productionOrderTable = dDContext.ProductionOrderTable.Where(t => t.TaskId == taskId).FirstOrDefault();
                productionOrderTable.ProductionOrderDetails = dDContext.ProductionOrderDetail.Where(t => t.TaskId == taskId).ToList();
                return new NewErrorModel()
                {
                    data= productionOrderTable,
                    error = new Error(0, "读取成功！", "") { },
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 表单修改
        /// </summary>
        /// <param name="productionOrderTable"></param>
        /// <returns></returns>
        [Route("Modify")]
        [HttpPost]
        public NewErrorModel Modify(ProductionOrderTable productionOrderTable)
        {
            try
            {
                DDContext dDContext = new DDContext();
                dDContext.Entry<ProductionOrderTable>(productionOrderTable).State = System.Data.Entity.EntityState.Modified;
                if (productionOrderTable.ProductionOrderDetails != null && productionOrderTable.ProductionOrderDetails.Count > 0)
                {
                    foreach (var item in productionOrderTable.ProductionOrderDetails)
                    {
                        dDContext.Entry<ProductionOrderDetail>(item).State = System.Data.Entity.EntityState.Modified;
                    }
                }
                dDContext.SaveChanges();

                return new NewErrorModel()
                {
                    error = new Error(0, "修改成功！", "") { },
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
