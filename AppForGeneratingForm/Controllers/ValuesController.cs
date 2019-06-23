using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public JObject Get()
        {
            string FormJSONDummyData = string.Empty;
            FormJSONDummyData = File.ReadAllText(@"D:/LuftBorn/Current Work/01_Angular_Forms_Drag_Drop/GenerateForm/Data/Data.json");
            JObject json = JObject.Parse(FormJSONDummyData);
            return json;


        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
