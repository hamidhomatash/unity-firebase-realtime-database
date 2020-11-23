using System;

namespace FirebaseREST
{
    public class TokenData
    {
        /// <summary>Unique ID of the user<Summary>
        public string UId { get; }
        public string IdToken { get; }
        public string RefreshToken { get; }
        public string ExpiresIn { get; }
        public DateTime RefreshedAt { get; }

        public bool IsExpired
        {
            get
            {
                return DateTime.Now - RefreshedAt > TimeSpan.FromSeconds(double.Parse(ExpiresIn));
            }
        }

        public TokenData(string uId, string idToken, string refreshToken, string expiresIn, DateTime refreshedAt)
        {
            UId = uId;
            IdToken = idToken;
            RefreshToken = refreshToken;
            ExpiresIn = expiresIn;
            RefreshedAt = refreshedAt;
        }
    }
}