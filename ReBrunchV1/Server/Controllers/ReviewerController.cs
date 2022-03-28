using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReBrunchV1.Server.Data;
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
        private readonly DataContext _reviewerContext;
        public ReviewerController(DataContext reviewerContext)   //In order to Go to DB get the data.
        {
            _reviewerContext = reviewerContext;
        }

        [HttpGet]
        public ActionResult<List<Reviewer>> GetAllReviewers()
        {
            return Ok(_reviewerContext.Reviewers);
        }

        [HttpGet("{id}")]
        public ActionResult<Reviewer> GetSingleReviewer(int id)
        {
            var reviewer = _reviewerContext.Reviewers.FirstOrDefault(p => p.Id.Equals(id));

            if (reviewer == null)
            {
                return NotFound("This reviewer doesn't exist.");

            }

            return Ok(reviewer);
        }
    }
}
