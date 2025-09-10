using Confluent.Kafka;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N2.Core.Configuration;
using N2.Core.Controllers.Basic;
using N2.Core.Extensions;
using N2.Core.Filters;
using N2.Core.Quartz;
using N2.Core.Utilities;
using N2.Entity;
using N2.Sys.IServices;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace N2.Sys.Controllers
{
    [Route("api/Sys_Factory")]
    public partial class Sys_FactoryController : Controller
    {
        readonly IHttpClientFactory _httpClientFactory;
        WebResponseContent webResponse = new WebResponseContent();
        public Sys_FactoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet, Route("GetDeviceInfoList"), AllowAnonymous]
        public async Task<IActionResult> GetDeviceInfoListAsync()
        {
            try
            {
                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Get, AppSetting.APIUrl + "/api/PLC/GetDeviceInfoList", null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }

        /// <summary>
        /// 获取设备参数
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        [HttpPost, Route("GetDeviceInfoById"), AllowAnonymous]
        public async Task<IActionResult> GetDeviceInfoById(string DeviceID)
        {
            try
            {
                if (string.IsNullOrEmpty(DeviceID))
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/GetDeviceInfoById?gId=" + DeviceID, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }

        /// <summary>
        /// 获取电表参数
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        [HttpPost, Route("GetMeterDeviceInfoById"), AllowAnonymous]
        public async Task<IActionResult> GetMeterDeviceInfoById(string DeviceID)
        {
            try
            {
                if (string.IsNullOrEmpty(DeviceID))
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/GetMeterDeviceInfoById?gId=" + DeviceID, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }

        /// <summary>
        /// 获取制氮机设备参数
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        [HttpPost, Route("GetN2DeviceInfoById"), AllowAnonymous]
        public async Task<IActionResult> GetN2DeviceInfoById(string DeviceID)
        {
            try
            {
                if (string.IsNullOrEmpty(DeviceID))
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/GetN2DeviceInfoById?gId=" + DeviceID, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }

        /// <summary>
        /// 设备检测
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <param name="type">1：气体检测，2：气密性检测，3：压差清零</param>
        /// <param name="parp">0：停止/1：启动</param>
        /// <returns></returns>
        [HttpPost, Route("DeviceTestById"), AllowAnonymous]
        public async Task<IActionResult> DeviceTestById([FromBody] PageData pageData)
        {
            try
            {
                if (pageData?.DeviceID == null)
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/DeviceTestById?gId=" + pageData?.DeviceID + "&type=" + pageData?.type + "&parp=" + pageData?.parp, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }

        /// <summary>
        /// 阀门检测
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <param name="type">99：阀门组合模式 1：手动阀门1，2：手动阀门2，3：手动阀门3，4：手动阀门4，5：手动阀门5</param>
        /// <param name="parp">模式-1：内环流，模式-2：排气，模式-3：下补气，模式-4：下充上排，模式-5：总关闭，阀门-0停，阀门-1开，阀门-2关</param>
        /// <returns></returns>
        [HttpPost, Route("ValveTest"), AllowAnonymous]
        public async Task<IActionResult> ValveTest([FromBody] PageData pageData)
        {
            try
            {
                if (pageData?.DeviceID == null)
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/ValveTest?gId=" + pageData?.DeviceID + "&type=" + pageData?.type + "&parp=" + pageData?.parp, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }

        /// <summary>
        /// 电磁阀检测
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <param name="type">99：设备模式，98：气泵，97：风机，96：氮气仪， 1：电磁阀1，2：电磁阀2，3：电磁阀3，4：电磁阀4，5：电磁阀5，6 抽气时间，7 稳定时间，8 检测时间</param>
        /// <param name="parp">99：手动/自动</param>
        /// <returns></returns>
        [HttpPost, Route("SolenoidValveTest"), AllowAnonymous]
        public async Task<IActionResult> SolenoidValveTest([FromBody] PageData pageData)
        {
            try
            {
                if (pageData?.DeviceID == null)
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/SolenoidValveTest?gId=" + pageData?.DeviceID + "&type=" + pageData?.type + "&parp=" + pageData?.parp, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }


        /// <summary>
        /// 参数设置
        /// </summary>
        /// <param name="pageData"></param>
        /// <returns></returns>
        [HttpPost, Route("SetingTest"), AllowAnonymous]
        public async Task<IActionResult> SetingTest([FromBody] PageData1 pageData)
        {
            try
            {
                if (pageData?.DeviceID == null)
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/SetingTest?gId=" + pageData?.DeviceID + "&type=" + pageData?.type + "&parp=" + pageData?.parp, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }

        /// <summary>
        /// 制氮机调试
        /// </summary>
        /// <param name="pageData"></param>
        /// <returns></returns>
        [HttpPost, Route("N2DeviceTest"), AllowAnonymous]
        public async Task<IActionResult> N2DeviceTest([FromBody] PageData pageData)
        {
            try
            {
                if (pageData?.DeviceID == null)
                {
                    return Json(webResponse.Error("接口参数不能为空"));
                }

                string httpMessage = await _httpClientFactory.SendAsync(HttpMethod.Post, AppSetting.APIUrl + "/api/PLC/N2DeviceTest?gId=" + pageData?.DeviceID + "&type=" + pageData?.type + "&parp=" + pageData?.parp, null, 180, null);

                if (!string.IsNullOrEmpty(httpMessage))
                {
                    RetData retdata = JsonConvert.DeserializeObject<RetData>(httpMessage);
                    return Json(webResponse.OK(null, retdata.data));
                }
                else
                {
                    return Json(webResponse.Error("接口异常"));
                }

            }
            catch (Exception ex)
            {
                return Json(webResponse.Error("接口异常"));
            }

        }
    }
}
