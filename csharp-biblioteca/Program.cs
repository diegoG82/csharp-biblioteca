
using csharp_biblioteca;


//CREAZIONE BIBLIOTECA
Biblioteca biblioteca = new Biblioteca();


//CREO UN LIBRO
Libro clean = new Libro(1234, "CleanCode", 2020, "Programmazione", "Scaffale nord", "Nome", "Cognome", 200);

//CREO UN DVD
Dvd adrenalina = new Dvd(4321, "Adrenalina Blu", 1996, "Sportivo", "Scaffale est", "Nome", "Cognome", 120);

//AGGIUNTA LIBRO E DVD AL DATABASE FITTIZI
biblioteca.AggiungiDoc(clean);
biblioteca.AggiungiDoc(adrenalina);

//TEST PAGINE LIBRO
Console.WriteLine($"il {clean.Titolo} ha {clean.Pagine} pagine");

//TEST DURATA DVD 
Console.WriteLine($"{adrenalina.Titolo} dura {adrenalina.Durata} minuti");

while (true)
{
    Console.WriteLine("Che operazione devi effettuare? (a = aggiungi doc, u = aggiungi utente, p = aggiungi prestito, r = cerca prestito,  c = cerca doc,  e = esci)");
    string sceltaop = Console.ReadLine();
    if (sceltaop == "a")
    {
        Console.WriteLine("inserisci il titolo del documento: ");
        string titolo = Console.ReadLine();
        Documento doc = new(titolo);
        biblioteca.AggiungiDoc(doc);
    }
    else if (sceltaop == "u")
    {
        Console.WriteLine("inserisci il nome dell'utente: ");
        string utente = Console.ReadLine();
        if (!biblioteca.Utenti.Contains(utente))
        {
            biblioteca.AggiungiUtente(utente);
            Console.WriteLine($"Utente {utente} aggiunto!");
        }
        else
        {
            Console.WriteLine("Questo utente esiste già.");
        }
    }



    else if (sceltaop == "p")
    {
        Console.WriteLine("Inserisci il nome dell'utente: ");
        string utente = Console.ReadLine();
        Console.WriteLine("Inserisci il titolo del documento da prestare: ");
        string titolo = Console.ReadLine();
        Documento doc = biblioteca.CercaDoc(titolo);

        if (doc != null)
        {
            Console.WriteLine("Inserisci la data di inizio del prestito (formato: dd-mm-yyyy): ");
            DateTime dataInizio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la data di fine del prestito (formato: dd-mm-yyyy): ");
            DateTime dataFine = DateTime.Parse(Console.ReadLine());

            Prestito prestito = new Prestito(utente, doc, dataInizio, dataFine);
            biblioteca.AggiungiPrestito(prestito);

            Console.WriteLine("Prestito assegnato!");
        }
        else
        {
            Console.WriteLine("Nessun documento trovato con quel titolo.");
        }
    }

    else if (sceltaop == "r")
    {
        Console.WriteLine("Inserisci il nome dell'utente per cercare il prestito: ");
        string utente = Console.ReadLine();
        Prestito prestito = biblioteca.CercaPrestito(utente);

        if (prestito != null)
        {
            Console.WriteLine($"Prestito trovato: {prestito.Utente} ha preso in prestito {prestito.Documento.Titolo} dal {prestito.DataInizio:dd/MM/yyyy} al {prestito.DataFine:dd/MM/yyyy}");
        }
        else
        {
            Console.WriteLine("Nessun prestito trovato per quell'utente.");
        }
    }


    else if (sceltaop == "c")
    {
        Console.WriteLine("inserisci il titolo che cerchi: ");
        string titolo = Console.ReadLine();
        Documento doc = biblioteca.CercaDoc(titolo);
        if (doc != null)
        {
            Console.WriteLine($"Documento {doc.Titolo} trovato!");
        }
        else
        {
            Console.WriteLine("Nessun documento trovato");
        }
    }
    else if (sceltaop == "e")
    {
        break;
    }
}





