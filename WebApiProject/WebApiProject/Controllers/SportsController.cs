using SportDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class SportsController : ApiController
    {
       
            public IEnumerable<Sport> Get()
            {
                using (SportContextDBEntities entities = new SportContextDBEntities())
                {
                    return entities.Sports.ToList();
                }
            }

            public Sport Get(int id)
            {
                using (SportContextDBEntities entities = new SportContextDBEntities())
                {
                    return entities.Sports.FirstOrDefault(e => e.SportID == id);
                }
            }

        public HttpResponseMessage Put(int id, Sport sport)
        {
            try
            {
                using (SportContextDBEntities entities = new SportContextDBEntities())
                {
                    var entity = entities.Sports.FirstOrDefault(e => e.SportID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Sport with Id " + id.ToString() + " not found to update");
                    }
                    else
                    {
                        entity.Description = sport.Description;

                        entities.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}
