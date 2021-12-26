using System;
using System.Collections.Generic;

namespace LempelZivCoding
{
    class EncodingEventArgs : EventArgs
    {
        string inputSequence;
        string currentEncodedSequence;
        string currentEncodedPhrase;
        IEnumerable<string> curretnCodeBook;

        public EncodingEventArgs(string inputSequence, string currentEncodedSequence, string currentEncodedPhrase, IEnumerable<string> currentCodeBook)
        {
            this.inputSequence = inputSequence;
            this.currentEncodedSequence = currentEncodedSequence;
            this.currentEncodedPhrase = currentEncodedPhrase;
            this.curretnCodeBook = currentCodeBook;
        }

        public string InputSequence => inputSequence;

        public string CurrentEncodedSequence => currentEncodedSequence;

        public string CurrentEncodedPhrase => currentEncodedPhrase;

        public IEnumerable<string> CurrentCodeBook => curretnCodeBook;
    }

}
