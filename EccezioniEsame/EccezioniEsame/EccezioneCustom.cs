using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EccezioniEsame
{
    //Va sempre messo perchè le eccezioni sono serializzabili 
    [Serializable]
    //Deriva da Exception così può richiamare i metodi base
    class EccezioneCustom : Exception
    {
        //Servono 4 costruttori: vuoto, con un messaggio, con un messaggio e l'eccezione che l'ha generato 
        //e quello per la serializzazione
        public EccezioneCustom() : base() { }

        public EccezioneCustom(string messaggio) : base(messaggio) { }

        public EccezioneCustom(string messaggio, Exception inner) : base(messaggio, inner) { }
        
        protected EccezioneCustom(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
