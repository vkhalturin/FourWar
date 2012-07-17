namespace N.FourWar.Foursquare
{
    public class FoursquareApi
    {
        public string AddAuthToken(string sourceUrl, string authToken)
        {
            if (sourceUrl.EndsWith("?"))
            {
                return string.Concat(sourceUrl, "oauth_token=", authToken);
            }

            return string.Concat(sourceUrl, "?oauth_token=", authToken);
        }
    }
}
