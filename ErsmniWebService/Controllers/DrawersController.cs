using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ErsmniWebService.Models;

namespace ErsmniWebService.Controllers
{
    public class DrawersController : ApiController
    {
        private ErsmniWebServiceContext db = new ErsmniWebServiceContext();

        // GET: api/Drawers
        public IQueryable<Drawer> GetDrawrs()
        {
            return db.Drawrs;
        }

        // GET: api/Drawers/5
        [ResponseType(typeof(Drawer))]
        public IHttpActionResult GetDrawer(string id)
        {
            Drawer drawer = db.Drawrs.Find(id);
            if (drawer == null)
            {
                return NotFound();
            }

            return Ok(drawer);
        }

        // PUT: api/Drawers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDrawer(string id, Drawer drawer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != drawer.id)
            {
                return BadRequest();
            }

            db.Entry(drawer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrawerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Drawers
        [ResponseType(typeof(Drawer))]
        public IHttpActionResult PostDrawer(Drawer drawer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Drawrs.Add(drawer);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (DrawerExists(drawer.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = drawer.id }, drawer);
        }

        // DELETE: api/Drawers/5
        [ResponseType(typeof(Drawer))]
        public IHttpActionResult DeleteDrawer(string id)
        {
            Drawer drawer = db.Drawrs.Find(id);
            if (drawer == null)
            {
                return NotFound();
            }

            db.Drawrs.Remove(drawer);
            db.SaveChanges();

            return Ok(drawer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DrawerExists(string id)
        {
            return db.Drawrs.Count(e => e.id == id) > 0;
        }
    }
}