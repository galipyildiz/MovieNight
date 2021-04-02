using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _35.MovieNight.Utilities
{
    //https://reactjsexample.com/content/images/2018/05/pagination-ui-component-for-react.gif
    //https://reactjsexample.com/content/images/2018/05/pagination-ui-component-for-react.gif
    //https://codepen.io/yigith/pen/LYbPeZQ
    //https://github.com/yigith/MeetMe/blob/master/MeetMe/Utilities/WebUtilities.cs

    public static class WebUtilities
    {
        public static int[] Pagination(int current, int last)
        {
            int delta = 2;
            int left = current - delta;
            int right = current + delta + 1;
            var range = new List<int>();
            var rangeWithDots = new List<int>();
            int? l = null;

            for (var i = 1; i <= last; i++)
            {
                if (i == 1 || i == last || i >= left && i < right)
                {
                    range.Add(i);
                }
            }

            foreach (var i in range)
            {
                if (l != null)
                {
                    if (i - l == 2)
                    {
                        rangeWithDots.Add(l.Value + 1);
                    }
                    else if (i - l != 1)
                    {
                        rangeWithDots.Add(-1);
                    }
                }
                rangeWithDots.Add(i);
                l = i;
            }

            return rangeWithDots.ToArray();
        }
    }
}