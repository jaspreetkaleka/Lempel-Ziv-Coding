using System;
using System.Collections.Generic;

namespace LempelZivCoding
{
    class DecodingCompleteEventArgs
    {
        string encodedSequence;
        string decodedSequence;
        int numberBase;
        IEnumerable<string> codeBook;
        TimeSpan decodingTime;

        public DecodingCompleteEventArgs(string encodedSequence, string decodedSequence, int numberBase, IEnumerable<string> codeBook, TimeSpan decodingTime)
        {
            this.decodedSequence = encodedSequence;
            this.decodedSequence = decodedSequence;
            this.numberBase = numberBase;
            this.codeBook = codeBook;
            this.decodingTime = decodingTime;
        }

        public string EncodedSequence => encodedSequence;

        public string DecodedSequence => decodedSequence;

        public int NumberBase => numberBase;

        public IEnumerable<string> CodeBook => codeBook;

        public TimeSpan DecodingTime => decodingTime;
    }
}