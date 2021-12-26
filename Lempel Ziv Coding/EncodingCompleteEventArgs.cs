using System;
using System.Collections.Generic;

namespace LempelZivCoding
{
    class EncodingCompleteEventArgs : EventArgs
    {
        string inputSequence;
        string encodedSequence;
        int numberBase;
        IEnumerable<string> codeBook;
        TimeSpan encodingTime;

        public EncodingCompleteEventArgs(string inputSequence, string encodedSequence,int numberBase, IEnumerable<string> codeBook, TimeSpan encodingTime)
        {
            this.inputSequence = inputSequence;
            this.encodedSequence = encodedSequence;
            this.numberBase = numberBase;
            this.codeBook = codeBook;
            this.encodingTime = encodingTime;
        }

        public string InputSequence => inputSequence;

        public string EncodedSequence => encodedSequence;

        public int NumberBase => numberBase;

        public IEnumerable<string> CodeBook => codeBook;

        public TimeSpan EncodingTime => encodingTime;
    }

}
