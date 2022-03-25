using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReBrunchV1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReBrunchV1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewerController : ControllerBase
    {
        public List<Reviewer> Reviewers { get; set; } = new List<Reviewer>
        {
            new Reviewer { Id = 1, FirstName = "Mário", LastName = "Pereira", BirthDate = new DateTime(1990, 07, 04), Email= "mario@gmail.com", JoinedDate = new DateTime(2022, 01, 01), Role = 1},
            new Reviewer { Id = 2, FirstName = "Ana", LastName = "Serrano", BirthDate = new DateTime(1990, 03, 07), Email= "anaserrano@gmail.com", JoinedDate = new DateTime(2022, 02, 05), Role = 2}
        };

        [HttpGet]
        public ActionResult<List<Reviewer>> GetAllReviewers()
        {
            return Ok(Reviewers);
        }

        [HttpGet("{id}")]
        public ActionResult<Reviewer> GetSingleReviewer(int id)
        {
            var reviewer = Reviewers.FirstOrDefault(p => p.Id.Equals(id));

            if (reviewer == null)
            {
                return NotFound("This reviewer doesn't exist.");

            }

            return Ok(reviewer);
        }
    }
}
