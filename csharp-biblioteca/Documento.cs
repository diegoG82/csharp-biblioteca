namespace csharp_biblioteca
{
    public class Documento
    {
        // PROPRIETA' E STATO

        public string Id { get; set; }
        public string Titolo { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public string Scaffale { get; set; }
        public string NomeAutore { get; set; }
        public string CognomeAutore { get; set; }

        //COSTRUTTORE

        public Documento(string Id, String Titolo, string Anno, string Settore, string Scaffale, string NomeAutore, String CognomeAutore)

        {
            this.Id = Id;
            this.Titolo = Titolo;
            this.Anno = Anno;
            this.Settore = Settore;
            this.Scaffale=Scaffale;
            this.NomeAutore = NomeAutore;
            this.CognomeAutore=CognomeAutore;

        }

    }
}
