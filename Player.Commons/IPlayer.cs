namespace Player.Commons
{
    public interface IPlayer
    {
        string Description { get; set; }
        int ID { get; set; }
        string Title { get; set; }

        void Play();

      
    }
}
