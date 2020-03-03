using EF_CONFIG.Data;
using EF_CONFIG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using KC_APP2.Services;

namespace KC_API.Controllers
{
    public class KnifeCaptureController : ApiController
    {
        private readonly DataContext _context;
        public KnifeCaptureController()
        {
            _context = new DataContext();
        }

        [HttpPost]
        [Route("kc_api/post")]
        public IHttpActionResult KC_DevicePost([FromBody] LocalPostData LocalPostData)
        {
            return Json(new DevicePostResp(_context, LocalPostData));
        }

        [HttpGet]
        [Route("Index")]
        public IHttpActionResult DefaultApi()
        {
            return Json("Hello world, Welcom KnifeCapture API");
        }

        [HttpGet]
        [Route("kc_api/initial/{machines}")]
        public IHttpActionResult KnifeCaptureGetInitials( string machines)
        {
            KC_Resp Resp = new KC_Resp(_context, machines);
            return Json(Resp);
        }

        [HttpGet]
        [Route("kc_api/{machine_name}/{deviceId}/{knife_pos}/{knife_type}/{knife_picked}/{local_value}")]
        public IHttpActionResult SubmitKnifeCapture(string machine_name,int deviceId, int knife_pos, int knife_type, int knife_picked, int local_value)
        {
            KC_Resp Resp = new KC_Resp(_context, deviceId, machine_name, knife_pos, knife_type, knife_picked, local_value);
            //return Ok(Resp);
            return Json(Resp);
        }
    }
}