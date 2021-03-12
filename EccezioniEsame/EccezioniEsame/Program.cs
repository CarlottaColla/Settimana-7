using System;

namespace EccezioniEsame
{
    class Program
    {
        static void Main(string[] args)
        {
            EccezioniFatali.ConnessioneAlDB();
            Utente utente = new Utente();
            EccezioniFatali.EccezioneCustomEs(utente.Nome);
        }
    }
}
