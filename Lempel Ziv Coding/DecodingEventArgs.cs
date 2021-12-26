using System.Collections.Generic;

namespace LempelZivCoding
{
    class DecodingEventArgs
    {
        string encodedSequence;
        string currentDecodedSequence;
        string currentDecodedPhrase;
        IEnumerable<string> curretnCodeBook;

        public DecodingEventArgs(string encodedSequence, string currentDecodedSequence, string currentDecodedPhrase, IEnumerable<string> currentCodeBook)
        {
            this.encodedSequence = encodedSequence;
            this.currentDecodedSequence = currentDecodedSequence;
            this.currentDecodedPhrase = currentDecodedPhrase;
            this.curretnCodeBook = currentCodeBook;
        }

        public string EncodedSequence => encodedSequence;

        public string CurrentDecodedSequence => currentDecodedSequence;

        public string CurrentDecodedPhrase => currentDecodedPhrase;

        public IEnumerable<string> CurrentCodeBook => curretnCodeBook;
    }

}
