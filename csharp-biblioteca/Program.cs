
using csharp_biblioteca;


//CREAZIONE BIBLIOTECA
Biblioteca biblioteca = new Biblioteca();


//CREO UN LIBRO
Libro libro = new Libro(1234, "CleanCode", 2020, "Programmazione", "Scaffale nord", "Nome", "Cognome", 200);

//CREO UN DVD
Dvd dvd = new Dvd(4321, "Adrenalina Blu", 1996, "Sportivo", "Scaffale est", "Nome", "Cognome", 120);

//AGGIUNTA LIBRO E DVD AL DATABASE FITTIZIO
biblioteca.AggiungiDoc(libro);
biblioteca.AggiungiDoc(dvd);



while (true)
{
    Console.WriteLine("Che operazione devi effettuare? (a = aggiungi doc, u = aggiungi utente, p = aggiungi prestito, c = cerca doc,  e = esci)");
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
        Console.WriteLine("Inserisci il prestito: ");
        string prestito = Console.ReadLine();
        if (!biblioteca.Prestiti.Contains(prestito))
        {
            biblioteca.AggiungiPrestito(prestito);
            Console.WriteLine($"Prestito {prestito} aggiunto!");
        }
        else
        {
            Console.WriteLine("Questo prestito esiste già.");
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





