using System;
using System.Linq;
using System.Web;

namespace CustomerSurvey.Helpers
{
    public static class CookieHelper
    {
        public static void SetCookie(string cookieName, string cookieValue)
        {
            var domain = GetCookieDomainFromUrl(HttpContext.Current.Request.Url);

            var cookie = new HttpCookie(cookieName)
            {
                Value = cookieValue,
                Domain = domain,
                Expires = DateTime.UtcNow.AddYears(1)
            };

            HttpContext.Current.Response.Cookies.Set(cookie);
        }

        private static string GetCookieDomainFromUrl(Uri url)
        {
            string[] hostParts = url.Host.Split('.');
            string domain = String.Join(".", hostParts.Skip(0));
            return "." + domain;
        }

        public static string GetCookie(string cookieName)
        {
            var cookie = HttpContext.Current.Request.Cookies.Get(cookieName);

            if (cookie == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(cookie.Value))
            {
                return cookie.Value;
            }

            ExpireCookie(cookieName);
            return null;
        }

        public static void ExpireCookie(string cookieName)
        {
            var domain = GetCookieDomainFromUrl(HttpContext.Current.Request.Url);
            var cookie = new HttpCookie(cookieName)
            {
                Domain = domain,
                Expires = DateTime.UtcNow.AddYears(-1)
            };

            HttpContext.Current.Response.Cookies.Set(cookie);
        }
    }
}