namespace csharp_biblioteca
{
    public class Dvd : Documento
    {

        public int Durata { get; set; }
        public Dvd(int Id, string Titolo, int Anno, string Settore, string Scaffale, string NomeAutore, string CognomeAutore, int Durata) : base(Id, Titolo, Anno, Settore, Scaffale, NomeAutore, CognomeAutore)
        {
            this.Durata = Durata;
        }
    }




}

