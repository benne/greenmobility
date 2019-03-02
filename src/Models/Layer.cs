namespace BenneIO.GreenMobility.Models
{
    public class Layer
    {
        public Layer(string id, LayerContent content)
        {
            Id = id;
            Content = content;
        }

        public string Id { get; }

        public LayerContent Content { get; }
    }
}