using CodeSample.BusinessTypes;
using CodeSample.DataAccess;
using CodeSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeSample.Controllers
{
    [RoutePrefix("api/HomeApi")]
    public class HomeApiController : ApiController
    {
        // GET: api/HomeApi
        [System.Web.Http.HttpGet()]
        public IHttpActionResult GetAll()
        {
            IHttpActionResult ret = null;


            return ret;
        }

        // GET: api/HomeApi/5
        [HttpGet()]
        [Route("Get")]
        public IHttpActionResult Get(string id)
        {
            IHttpActionResult ret = null;
            if (id.Length > 2)
            {
                var row = id.Substring(0, id.IndexOf("_"));
                int column = int.Parse(id.Substring(id.IndexOf("_") + 1));

                var vm = new CoordinateViewModel();
                vm.Entity = CoordinateData.GetCoordinateEntity(column, row);
                if (vm.Entity != null)
                {
                    ret = Ok(vm.Entity);
                }
                else
                {
                    ret = NotFound();
                }
            }

            return ret;
        }

        // POST: api/HomeApi
        [HttpPost()]
        [Route("api/HomeApi/Search")]
        public IHttpActionResult Search(string row, int col)
        {
            IHttpActionResult ret = null;
            // CoordinateData
            var vm = new CoordinateViewModel();
            //vm.Entity = CoordinateData.GetCoordinateEntity(obj._y, obj._x); 
            // Search for Coordinate

            if (vm.Entity != null)
            {
                ret = Ok(vm.Entity);
            }
            else
            {
                ret = NotFound();
            }

            return ret;
        }

        // PUT: api/HomeApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HomeApi/5
        public void Delete(int id)
        {
        }
    }


   
}
