using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oooooo.Controllers
{
    public class BackVoteController : Controller
    {
        // GET: BackVote
        public ActionResult voteList()
        {
            var vote = from v in (new dbecoDailyEntities()).tVote
                       select v;
            return View(vote);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}