using Mvc_School_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mvc_School_app.Controllers.api
{

    public class PupilController : ApiController
    {
     

        // GET: api/Pupil
        public IHttpActionResult Get()
        {
            return Ok(new { Pupil.Pupils } );
        }

        // GET: api/Pupil/5
        public IHttpActionResult Get(int id)
        {
            Pupil pupilId = Pupil.Pupils.Find(item => item.id == id);
            return Ok(new { pupilId });
        }

        // POST: api/Pupil
        public IHttpActionResult Post([FromBody] Pupil pupil)
        {
            Pupil.Pupils.Add(pupil);
            return Ok("ADD TO LIST");
        }

        // PUT: api/Pupil/5
        public IHttpActionResult Put(int id, [FromBody] Pupil pupil)
        {
          //put
            return Ok();
        }

        // DELETE: api/Pupil/5
        public IHttpActionResult Delete(int id)
        {
            Pupil DeleteFromPupil = Pupil.Pupils.Find(item => item.id == id);
            Pupil.Pupils.Remove(DeleteFromPupil);
            return Ok("ELETED FROM LIST");

        }
    }
}
