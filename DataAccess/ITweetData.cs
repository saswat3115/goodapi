using GoodApi.Models;
using System;
using System.Collections.Generic;

namespace GoodApi.DataAccess
{
    public interface ITweetData
    {
        List<Tweet> GetTweetByDate(DateTime startDate, DateTime endDate);
    }
}
