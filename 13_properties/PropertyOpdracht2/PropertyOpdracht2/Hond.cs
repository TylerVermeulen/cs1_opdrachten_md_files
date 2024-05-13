namespace PropertyOpdracht1
{
    internal class Hond
    {
         //maak hier een property Naam, de set moet private zijn!
        public Hond(string naam)
        {
            this.Naam = naam;
        }

        private string Naam { get; internal set; }
    }
}