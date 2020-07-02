using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    interface ITwitterService
    {
        bool authenticate(string id, string mdp);
        List<Tweet> getTweets();
    }
}
