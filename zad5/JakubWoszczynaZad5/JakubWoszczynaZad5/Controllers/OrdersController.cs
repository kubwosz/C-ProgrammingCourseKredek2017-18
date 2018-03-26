using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace JakubWoszczynaZad5.Controllers
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

            var prod = new Product()
            {
                Category = "telewizor",
                Cost = 20200,
                Weight = 100
            };

            List<Product> _products = new List<Product>();
            _products.Add(prod);
            ord.Products = _products;

            db.SaveChanges();

            return CreatedAtRoute("GetOrder", new { ID = ord.ID }, ord);
        }
        /// <summary>
        /// Metoda edytująca dane, które zostają podane w ciele, np. w programie Postman
        /// </summary>
        /// <param name="ord"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Put([FromBody] Order ord, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderToEdit = db.Orders.SingleOrDefault(x => x.ID == id);
            if (orderToEdit == null)
            {
                return NotFound();
            }
            orderToEdit.ClientName = ord.ClientName;
            orderToEdit.ClientSurname = ord.ClientSurname;
            orderToEdit.NumberOfOrder = ord.NumberOfOrder;

            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
        /// <summary>
        /// Metoda usuwająca zamówienie po numerze ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var order = db.Orders.SingleOrDefault(x => x.ID == id);
            if (order == null)
            {
                return NotFound();
            }
            db.Orders.Remove(order);

            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }


    }
}
