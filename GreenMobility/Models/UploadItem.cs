namespace BenneIO.GreenMobility.Models
{
    public class UploadItem
    {
        public UploadItem(long? id, string url, string token)
        {
            Id = id;
            Url = url;
            Token = token;
        }

        public long? Id { get; }

        public string Url { get; }

        public string Token { get; }
    }
}