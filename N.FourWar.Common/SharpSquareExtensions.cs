using Igloo.SharpSquare.Core;
using Igloo.SharpSquare.Entities;

namespace N.FourWar.Common
{
    public static class SharpSquareExtensions
    {
        /// <summary>
        /// Returns "self" user.
        /// </summary>
        public static User GetUser(this SharpSquare api)
        {
            return api.GetUser("self");
        }
    }
}