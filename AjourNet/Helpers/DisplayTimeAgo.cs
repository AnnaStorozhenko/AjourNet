using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Helpers
{
    public static class DisplayTimeAgoHelper
    {
        public static MvcHtmlString TimeAgo(this DateTime date)
        {
            TimeSpan timeSince = DateTime.Now.Subtract(date);

            if (timeSince.TotalMinutes < 1)
                return new MvcHtmlString(String.Format("just now"));
            if (timeSince.TotalMinutes < 2)
                return new MvcHtmlString(String.Format("1 minute ago"));
            if (timeSince.TotalMinutes < 60)
                return new MvcHtmlString(String.Format("{0} minutes ago", timeSince.Minutes));
            if (timeSince.TotalMinutes < 120)
                return new MvcHtmlString(String.Format("1 hour ago"));
            if (timeSince.TotalHours < 24)
                return new MvcHtmlString(String.Format("{0} hours ago", timeSince.Hours));
            if (timeSince.TotalDays == 1)
                return new MvcHtmlString(String.Format("yesterday"));
            if (timeSince.TotalDays < 7)
                return new MvcHtmlString(String.Format("{0} days ago", timeSince.Days));
            if (timeSince.TotalDays < 14)
                return new MvcHtmlString(String.Format("last week"));

            return new MvcHtmlString(String.Format("{0} {1:MMM} {2:yyyy}", date.Day.ToString(), date, date.Year.ToString()));

        }

    }
}