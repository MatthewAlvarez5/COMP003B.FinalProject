namespace COMP003B.FinalProject.Models
{
    public class GameDeveloper
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int DeveloperId { get; set; }
        public int GenreId { get; set; }

        public virtual Game? Game { get; set; }
        public virtual Developer? Developer { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}