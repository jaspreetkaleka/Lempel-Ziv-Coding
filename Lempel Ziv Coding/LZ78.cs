using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LempelZivCoding
{
    static class LZ78
    {
        public enum NumberBase
        {
            Two,
            Eight,
            Sixteen
        };

        #region "Delegates, Events"

        public delegate void EncodingEventHandler(object sender, EncodingEventArgs e);
        public static event EncodingEventHandler Encoding;

        public delegate void EncodingCompleteEventHandler(object sender, EncodingCompleteEventArgs e);
        public static event EncodingCompleteEventHandler EncodingComplete;

        public delegate void DecodingEventHandler(object sender, DecodingEventArgs e);
        public static event DecodingEventHandler Decoding;

        public delegate void DecodingCompleteEventHandler(object sender, DecodingCompleteEventArgs e);
        public static event DecodingCompleteEventHandler DecodingComplete;

        #endregion

        #region "Encode"

        public static string Encode(string inputSequence, out IEnumerable<string> codebook, NumberBase numBase = NumberBase.Two)
        {
            if (string.IsNullOrEmpty(inputSequence))
            {
                codebook = new List<string>();
                return "";
            }

            var numberBase = (numBase == NumberBase.Two) ? 2 : (numBase == NumberBase.Eight) ? 8 : 16;

            var encodedSequence = new StringBuilder();

            var ht = new Hashtable {{"", 0}};

            var codeBook = new List<string> {""};

            var phrase = "";

            foreach (var c in inputSequence)
            {
                if (ht[phrase + c] != null)
                {
                    phrase += c;
                }
                else
                {
                    codeBook.Add(phrase + c);
                    ht.Add(phrase + c, codeBook.Count - 1);
                    encodedSequence.Append(Convert.ToString(Convert.ToInt32(ht[phrase]), numberBase).PadLeft(Convert.ToInt32(Math.Ceiling(Math.Log(codeBook.Count - 1, numberBase))), '0') + c);
                    phrase = "";
                }
            }
            codeBook.Add(phrase);
            encodedSequence.Append(Convert.ToString(Convert.ToInt32(ht[phrase]), numberBase).PadLeft(Convert.ToInt32(Math.Ceiling(Math.Log(codeBook.Count - 1, numberBase))), '0'));
            codebook = codeBook;
            return encodedSequence.ToString();
        }

        public static void BeginEncoding(string inputSequence, NumberBase numBase = NumberBase.Two)
        {
            var numberBase = (numBase == NumberBase.Two) ? 2 : (numBase == NumberBase.Eight) ? 8 : 16;

            var beginEncoding = new Thread(new ParameterizedThreadStart(BeginEncodingThread));
            beginEncoding.Start(numberBase.ToString() + ";" + inputSequence);
        }

        private static void BeginEncodingThread(object o)
        {
            var start = DateTime.Now;

            var inputSequence = o.ToString();
            int numberBase = Convert.ToUInt16(inputSequence.Substring(0, inputSequence.IndexOf(";")));
            inputSequence = inputSequence.Substring(inputSequence.IndexOf(";") + 1);

            if (string.IsNullOrEmpty(inputSequence))
            {
                EncodingComplete(null, new EncodingCompleteEventArgs("", "", numberBase, new List<string>(), DateTime.Now.Subtract(start)));
                return;
            }

            var encodedSequence = new StringBuilder();

            var ht = new Hashtable {{"", 0}};

            var codeBook = new List<string> {""};

            var phrase = "";
            var currentEncodedPhrase = "";

            foreach (var c in inputSequence)
            {
                if (ht[phrase + c] != null)
                {
                    phrase += c;
                }
                else
                {
                    codeBook.Add(phrase + c);
                    ht.Add(phrase + c, codeBook.Count - 1);
                    currentEncodedPhrase = Convert.ToString(Convert.ToInt32(ht[phrase]), numberBase).PadLeft(Convert.ToInt32(Math.Ceiling(Math.Log(codeBook.Count - 1, numberBase))), '0') + c;
                    encodedSequence.Append(currentEncodedPhrase);
                    Encoding(null, new EncodingEventArgs(inputSequence, encodedSequence.ToString(), currentEncodedPhrase, codeBook));
                    phrase = "";
                }
            }
            codeBook.Add(phrase);
            currentEncodedPhrase = Convert.ToString(Convert.ToInt32(ht[phrase]), numberBase).PadLeft(Convert.ToInt32(Math.Ceiling(Math.Log(codeBook.Count - 1, numberBase))), '0');
            encodedSequence.Append(currentEncodedPhrase);
            Encoding(null, new EncodingEventArgs(inputSequence, encodedSequence.ToString(), currentEncodedPhrase, codeBook));
            EncodingComplete(null, new EncodingCompleteEventArgs(inputSequence, encodedSequence.ToString(), numberBase, codeBook, DateTime.Now.Subtract(start)));
        }

        #endregion

        #region "Decode"

        public static string Decode(string encodedSequence, NumberBase numBase = NumberBase.Two)
        {
            if (string.IsNullOrEmpty(encodedSequence))
            {
                return "";
            }

            var numberBase = (numBase == NumberBase.Two) ? 2 : (numBase == NumberBase.Eight) ? 8 : 16;

            var decodedSequence = new StringBuilder();

            var codeBook = new List<string>();
            codeBook.Add("");
            codeBook.Add(encodedSequence[1].ToString());
            encodedSequence = encodedSequence.Substring(2);

            decodedSequence.Append(codeBook[1]);

            var codeBookIndex = 0;
            var bitsToExtract = 0;

            while (true)
            {
                bitsToExtract = Convert.ToInt32(Math.Floor(Math.Log(codeBook.Count - 1, numberBase))) + 2;

                if (bitsToExtract > encodedSequence.Count())
                {
                    if (encodedSequence.Length > 0)
                    {
                        codeBookIndex = Convert.ToInt32(encodedSequence, numberBase);
                    }
                    else
                    {
                        codeBookIndex = 0;
                    }

                    decodedSequence.Append(codeBook[codeBookIndex]);
                    break;
                }

                codeBookIndex = Convert.ToInt32(encodedSequence.Substring(0, bitsToExtract - 1), numberBase);
                
                var newCodeBookEntry = codeBook[codeBookIndex] + encodedSequence.Substring(bitsToExtract - 1, 1);

                codeBook.Add(newCodeBookEntry);
                decodedSequence.Append(newCodeBookEntry);

                encodedSequence = encodedSequence.Substring(bitsToExtract);
            }
            return decodedSequence.ToString();
        }

        public static void BeginDecoding(string encodedSequence, NumberBase numBase = NumberBase.Two)
        {
            var numberBase = (numBase == NumberBase.Two) ? 2 : (numBase == NumberBase.Eight) ? 8 : 16;

            var beginDecoding = new Thread(new ParameterizedThreadStart(BeginDecodingThread));
            beginDecoding.Start(numberBase.ToString() + ";" + encodedSequence);
        }

        private static void BeginDecodingThread(object o)
        {
            var start = DateTime.Now;

            var encodedSequence = o.ToString();
            int numberBase = Convert.ToUInt16(encodedSequence.Substring(0, encodedSequence.IndexOf(";")));
            encodedSequence = encodedSequence.Substring(encodedSequence.IndexOf(";") + 1);

            if (string.IsNullOrEmpty(encodedSequence))
            {
                DecodingComplete(null, new DecodingCompleteEventArgs("", "", numberBase, new List<string>(), DateTime.Now.Subtract(start)));
                return;
            }

            var decodedSequence = new StringBuilder();

            var codeBook = new List<string>();
            codeBook.Add("");
            codeBook.Add(encodedSequence[1].ToString());
            encodedSequence = encodedSequence.Substring(2);

            decodedSequence.Append(codeBook[1]);
            Decoding(null, new DecodingEventArgs(encodedSequence, decodedSequence.ToString(), codeBook[1], codeBook));

            var codeBookIndex = 0;
            var newCodeBookEntry = "";

            while (true)
            {
                var bitsToExtract = Convert.ToInt32(Math.Floor(Math.Log(codeBook.Count - 1, numberBase))) + 2;
                codeBookIndex = Convert.ToInt32(encodedSequence.Substring(0, bitsToExtract - 1), numberBase);

                if (bitsToExtract > encodedSequence.Count())
                {
                    decodedSequence.Append(codeBook[codeBookIndex]);
                    Decoding(null, new DecodingEventArgs(encodedSequence, decodedSequence.ToString(), codeBook[codeBookIndex], codeBook));
                    break;
                }

                newCodeBookEntry = codeBook[codeBookIndex] + encodedSequence.Substring(bitsToExtract - 1, 1);

                codeBook.Add(newCodeBookEntry);
                decodedSequence.Append(newCodeBookEntry);

                Decoding(null, new DecodingEventArgs(encodedSequence, decodedSequence.ToString(), newCodeBookEntry, codeBook));

                encodedSequence = encodedSequence.Substring(bitsToExtract);
            }
            DecodingComplete(null, new DecodingCompleteEventArgs(encodedSequence, decodedSequence.ToString(), numberBase, codeBook, DateTime.Now.Subtract(start)));
        }

        #endregion

    }
}
