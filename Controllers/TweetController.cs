using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoodApi.Models;
using System.Web.Http.Cors;
using GoodApi.DataAccess;

namespace GoodApi.Controllers
{
    [EnableCors(origins:"*", headers: "*", methods: "GET")]
    [RoutePrefix("api/v{version:apiVersion(1)}")]
    public class TweetController : ApiController
    {

        private ITweetData _tweetData;

        public TweetController(ITweetData tweetData)
        {
            this._tweetData = tweetData;
        }


        [HttpGet]        
        [Route("Tweets")]
        public List<Tweet> GetTweet([FromUri]DateTime startDate, [FromUri]DateTime endDate)
        {
            return _tweetData.GetTweetByDate(startDate, endDate);
        }
    }
}
