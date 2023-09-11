namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        public int Pagine { get; set; }
        public Libro(int Id, string Titolo, int Anno, string Settore, string Scaffale, string NomeAutore, string CognomeAutore, int Pagine) : base(Id, Titolo, Anno, Settore, Scaffale, NomeAutore, CognomeAutore)
        {
            this.Pagine = Pagine;
        }

       

       
    }
}
