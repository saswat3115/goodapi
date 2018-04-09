using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodApi.Models;

namespace GoodApi.DataAccess
{
    public class TweetData : ITweetData
    {
        public List<Tweet> GetTweetByDate(DateTime startDate, DateTime endDate)
        {
            return Tweets.Where(t => t.Stamp >= startDate && t.Stamp <= endDate).ToList();
        }


        public List<Tweet> Tweets = new List<Tweet>()
        {
            new Tweet() { Id = "1", Stamp = Convert.ToDateTime("2018-04-09T08:00:34.837Z"), Text = "sample text 1"},
            new Tweet() { Id = "2", Stamp = Convert.ToDateTime("2017-04-09T08:00:34.837Z"), Text = "sample text 2"},
            new Tweet() { Id = "3", Stamp = Convert.ToDateTime("2016-04-09T08:00:34.837Z"), Text = "sample text 3"},
            new Tweet() { Id = "4", Stamp = Convert.ToDateTime("2015-04-09T08:00:34.837Z"), Text = "sample text 4"},
            new Tweet() { Id = "5", Stamp = Convert.ToDateTime("2014-04-09T08:00:34.837Z"), Text = "sample text 5"},
        };

        
    }
}