using Hafta1.Odev1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafta1.Odev1.Controllers
{
    [Route("api/bookstore")]
    [ApiController]
    public class BookStore : ControllerBase
    {
        private object rbook;

        [HttpGet("{bookname}/{id}")] //api/library/{bookname}/{id}
        public IActionResult GetbyId(string bookname, int id)
        {
            return Ok(new { bookname = bookname, id = id }); //return 200 status code
        }
        [HttpPost]
        public IActionResult Create([FromBody] Book book)
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Patch(int id, [FromBody] Book book)
        {
            if (rbook != null)
            {
                book.ApplyTo(rbook);
                return NotFound();
            }
            return Ok();
        }
        [HttpPost("{id}")] 
        public IActionResult CreatedI([FromQuery] Book book)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Deleted(int id,[FromBody] Book book)
        {
            return Ok();
        }
    }
}
