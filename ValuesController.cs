using Newtonsoft.Json;
using RestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            value = "[\r\n{\r\nfirstName: \"Kasun\",\r\nlastName: \"Wanniarachchi\",\r\nage: 20,\r\nid: 5\r\n},\r\n{\r\nfirstName: \"Jayani\",\r\nlastName: \"Dasanayake\",\r\nage: 20,\r\nid: 6\r\n},\r\n{\r\nfirstName: \"Sanath\",\r\nlastName: \"Jayasuriaya\",\r\nage: 20,\r\nid: 7\r\n}\r\n]";
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(value);
            Store.StoreCustomer(customers);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
