using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace JakubWoszczynaZad6.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {

        JakubWoszczynaZad5Entities db = new JakubWoszczynaZad5Entities();

        /// <summary>
        /// Metoda zwracająca listę wszystkich zamówień do wyświetlenia
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")]
        [ResponseType(typeof(List<Order>))]
        public IHttpActionResult Get()
        {
            return Ok(db.Orders.ToList());

        }
        /// <summary>
        /// Metoda zwracająca jedno zamówienie znajdywane po numerze ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("{id:int}", Name = "GetOrder")]
        [ResponseType(typeof(List<Order>))]
        public IHttpActionResult Get(int id)
        {
            var ord = db.Orders.ToList().SingleOrDefault(x => x.ID == id);

            if (ord == null)
            {
                return NotFound();
            }
            return Ok(ord);
        }

        /// <summary>
        /// Metoda dodająca nowe zamówienie wraz z lista produktów
        /// </summary>
        /// <param name="ord"></param>
        /// <returns></returns>
        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody] Order ord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            db.Orders.Add(ord);

            db.SaveChanges();

            return CreatedAtRoute("GetOrder", new { ID = ord.ID }, ord);
        }

    }
}
