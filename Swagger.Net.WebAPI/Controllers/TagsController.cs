﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Swagger.Net.WebApi.Controllers
{
    public class TagsController : ApiController
    {
        /// <summary>
        /// Get all of the Tags
        /// </summary>
        /// <remarks>
        /// Some extra notes
        /// </remarks>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a single Tag by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(byte id)
        {
            return "value";
        }

        /// <summary>
        /// Create a new Tag
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Update a Tag by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(IEnumerable<int> id)
        {
        }

        /// <summary>
        /// Remove a Tag by it's id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(IEnumerable<int> id)
        {
        }
    }
}
