﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIVScode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //25082019 code changes
        //code changes
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
         // PUT api/values/5
        [HttpPut("{id}")]
        public void Put1(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteAdd(int id)
        {
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteSub(int id)
        
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteDiv(int id)
        {
            
        }
        
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteMul(int id)
        {
        }
       
    }
}
