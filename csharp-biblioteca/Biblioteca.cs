﻿using System.ComponentModel.Design;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        //LISTA DOCUMENTI
        public List<Documento> Documenti { get; set; } = new List<Documento>();
        //LISTA UTENTI
        public List<string> Utenti { get; set; }
        //LISTA PRESTITI
        public List<string> Prestiti { get; set; }

        public Biblioteca()
        {

            Documenti = new List<Documento>();
            Utenti = new List<string>();
            Prestiti = new List<string>();

        }



        //AGGIUNTA DOCUMENTO
        public void AggiungiDoc(Documento documento)
        {
            Documenti.Add(documento);
        }

        //AGGIUNTA UTENTE
        public void AggiungiUtente(string utente)
        {
            Utenti.Add(utente);
        }

        //AGGIUNTA PRESTITO
        public void AggiungiPrestito(string prestito)
        {
            Prestiti.Add(prestito);
        }

        public Documento CercaPerTitolo(string titolo)
        {
            foreach (var doc in Documenti)
            {
                if (doc.Titolo == titolo)
                {
                    return doc;
                }


            }
            return null;

        }
        public string CercaPrestito(string nome, string cognome)
        {
            string nomeCognome = nome + " " + cognome;
            foreach (var prestito in Prestiti)
            {
                if (prestito.Contains(nomeCognome))
                {
                    return prestito;
                }

            }
            return null;
        }


        public Documento CercaDoc(string titolo)
        {
            foreach (Documento doc in Documenti)
            {
                if (doc.Titolo == titolo)
                {
                    return doc;
                }
            }
            return null;
        }
    }
}




