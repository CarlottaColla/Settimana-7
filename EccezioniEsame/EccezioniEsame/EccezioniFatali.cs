using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EccezioniEsame
{
    public class EccezioniFatali
    {
        //creo una stringa di connesione non valida
        const string connectionString = @"Persist Security Info = False; Server = .";
        public static void ConnessioneAlDB()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                //...
            }
            //Se la classe è maggiore di 19 allora le eccezioni sono fatali
            //Devo mettere 3 catch: uno che prende SqlException fatali (più specifico)
            //uno che prende le SqlException generiche
            //Uno che prende qualsiasi eccezione per sicurezza
            catch (SqlException exc) when (exc.Class > 19)
            {
                Console.WriteLine("Generata eccezione fatale");
                //Se la stringa di connessione non è valida genera un'eccezione fatale
            }
            catch (SqlException exc)
            {
                Console.WriteLine("Generata eccezione non fatale");
            }
            catch
            {
                Console.WriteLine("Generata un eccezione diversa da SqlException");
            }
        }


        //Metodo per utilizzare l'eccezione custom
        public static void EccezioneCustomEs(string utenteNome)
        {
            try
            {
                if (utenteNome == null)
                {
                    throw new EccezioneCustom("Utente non trovato");
                }
            }
            catch (EccezioneCustom exc)
            {
                Console.WriteLine("Eccezione custom generata");
            }
            catch
            {
                Console.WriteLine("Altra eccezione trovata");
            }
            
        }

    }
}
