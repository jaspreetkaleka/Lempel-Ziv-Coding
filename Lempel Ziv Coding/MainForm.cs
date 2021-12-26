using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LempelZivCoding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        IEnumerable<string> CB2;
        IEnumerable<string> CB8;
        IEnumerable<string> CB16;

        #region "Encode"

        private void encodeButton_Click(object sender, EventArgs e)
        {
            encodeButton.Hide();
            decodeButton.Hide();

            var encodeThread = new Thread(new ThreadStart(EncodingThread));
            encodeThread.Start();
        }

        private void EncodingThread()
        {
            this.Invoke(new MethodInvoker(delegate
                {
                    b2EcTextBox.Clear();
                    b8EcTextBox.Clear();
                    b16EcTextBox.Clear();
                    b2DcTextBox.Clear();
                    b8DcTextBox.Clear();
                    b16DcTextBox.Clear();
                    decodedTextMessageTextBox.Clear();

                    ET2Label.Text = "0 ms";
                    ET8Label.Text = "0 ms";
                    ET16Label.Text = "0 ms";

                    DT2Label.Text = "0 ms";
                    DT8Label.Text = "0 ms";
                    DT16Label.Text = "0 ms";

                    R2Label.Text = "0 %";
                    R8Label.Text = "0 %";
                    R16Label.Text = "0 %";

                    Application.DoEvents();

                    if (textMessageTextBox.TextLength != 0)
                    {
                        binarySequenceTextBox.Text = TextToBinary(textMessageTextBox.Text);
                    }

                    Application.DoEvents();

                    double bSeqLen = binarySequenceTextBox.TextLength;

                    if (updateConcurrentlyCheckBox.Checked)
                    {
                        LZ78.Encoding += new LZ78.EncodingEventHandler(LZ78_Encoding_Base2);
                        LZ78.EncodingComplete += new LZ78.EncodingCompleteEventHandler(LZ78_EncodingComplete_Base2);

                        LZ78.BeginEncoding(binarySequenceTextBox.Text, LZ78.NumberBase.Two);
                    }
                    else
                    {
                        //Encoding Base-2
                        var start = DateTime.Now;
                        b2EcTextBox.Text = LZ78.Encode(binarySequenceTextBox.Text, out CB2, LZ78.NumberBase.Two);
                        R2Label.Text = ((double)b2EcTextBox.TextLength / bSeqLen).ToString("P", CultureInfo.CreateSpecificCulture("en-IN"));
                        ET2Label.Text = DateTime.Now.Subtract(start).TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";

                        Application.DoEvents();

                        //Encoding Base-8
                        start = DateTime.Now;
                        b8EcTextBox.Text = LZ78.Encode(binarySequenceTextBox.Text, out CB8, LZ78.NumberBase.Eight);
                        R8Label.Text = ((double)b8EcTextBox.TextLength / bSeqLen).ToString("P", CultureInfo.CreateSpecificCulture("en-IN"));
                        ET8Label.Text = DateTime.Now.Subtract(start).TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";

                        Application.DoEvents();

                        //Encoding Base-16
                        start = DateTime.Now;
                        b16EcTextBox.Text = LZ78.Encode(binarySequenceTextBox.Text, out CB16, LZ78.NumberBase.Sixteen);
                        R16Label.Text = ((double)b16EcTextBox.TextLength / bSeqLen).ToString("P", CultureInfo.CreateSpecificCulture("en-IN"));
                        ET16Label.Text = DateTime.Now.Subtract(start).TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";

                        encodeButton.Show();
                        decodeButton.Show();
                        Application.DoEvents();
                    }
                }));
        }
 
        private void LZ78_Encoding_Base2(object sender, EncodingEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
                {
                    b2EcTextBox.AppendText(e.CurrentEncodedPhrase);
                    EL2Label.Text = e.CurrentEncodedSequence.Count().ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
                }));
        }

        private void LZ78_EncodingComplete_Base2(object sender, EncodingCompleteEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
                {
                    R2Label.Text = ((double)e.EncodedSequence.Count() / (double)e.InputSequence.Count()).ToString("P", CultureInfo.CreateSpecificCulture("en-IN"));
                    ET2Label.Text = e.EncodingTime.TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";
                    CB2 = e.CodeBook; 
                    LZ78.Encoding -= LZ78_Encoding_Base2;
                    LZ78.EncodingComplete -= LZ78_EncodingComplete_Base2;
                    LZ78.Encoding += new LZ78.EncodingEventHandler(LZ78_Encoding_Base8);
                    LZ78.EncodingComplete += new LZ78.EncodingCompleteEventHandler(LZ78_EncodingComplete_Base8);
                    LZ78.BeginEncoding(e.InputSequence, LZ78.NumberBase.Eight);
                }
            ));
        }

        private void LZ78_Encoding_Base8(object sender, EncodingEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                b8EcTextBox.AppendText(e.CurrentEncodedPhrase);
                EL8Label.Text = e.CurrentEncodedSequence.Count().ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
            }));
        }

        private void LZ78_EncodingComplete_Base8(object sender, EncodingCompleteEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                R8Label.Text = ((double)e.EncodedSequence.Count() / (double)e.InputSequence.Count()).ToString("P", CultureInfo.CreateSpecificCulture("en-IN"));
                ET8Label.Text = e.EncodingTime.TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";
                CB8 = e.CodeBook;
                LZ78.Encoding -= LZ78_Encoding_Base8;
                LZ78.EncodingComplete -= LZ78_EncodingComplete_Base8;
                LZ78.Encoding += new LZ78.EncodingEventHandler(LZ78_Encoding_Base16);
                LZ78.EncodingComplete += new LZ78.EncodingCompleteEventHandler(LZ78_EncodingComplete_Base16);
                LZ78.BeginEncoding(e.InputSequence, LZ78.NumberBase.Sixteen);
            }
            ));
        }

        private void LZ78_Encoding_Base16(object sender, EncodingEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                b16EcTextBox.AppendText(e.CurrentEncodedPhrase);
                EL16Label.Text = e.CurrentEncodedSequence.Count().ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
            }));
        }

        private void LZ78_EncodingComplete_Base16(object sender, EncodingCompleteEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                R16Label.Text = ((double)e.EncodedSequence.Count() / (double)e.InputSequence.Count()).ToString("P", CultureInfo.CreateSpecificCulture("en-IN"));
                ET16Label.Text = e.EncodingTime.TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";
                CB16 = e.CodeBook;
                LZ78.Encoding -= LZ78_Encoding_Base16;
                LZ78.EncodingComplete -= LZ78_EncodingComplete_Base16;
                encodeButton.Show();
                decodeButton.Show();
            }
            ));
        }

        private void CB2Button_Click(object sender, EventArgs e)
        {
            if (CB2 != null)
            {
                var cdBkVwFrm = new CodebookViewerForm(CB2, 2);
                cdBkVwFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Perform Encoding first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB8Button_Click(object sender, EventArgs e)
        {
            if (CB8 != null)
            {
                var cdBkVwFrm = new CodebookViewerForm(CB8, 8);
                cdBkVwFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Perform Encoding first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB16Button_Click(object sender, EventArgs e)
        {
            if (CB16 != null)
            {
                var cdBkVwFrm = new CodebookViewerForm(CB16, 16);
                cdBkVwFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Perform Encoding first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void b2EcTextBox_TextChanged(object sender, EventArgs e)
        {
            EL2Label.Text = b2EcTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void b8EcTextBox_TextChanged(object sender, EventArgs e)
        {
            EL8Label.Text = b8EcTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void b16EcTextBox_TextChanged(object sender, EventArgs e)
        {
            EL16Label.Text = b16EcTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void b2DcTextBox_TextChanged(object sender, EventArgs e)
        {
            DL2Label.Text = b2DcTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void b8DcTextBox_TextChanged(object sender, EventArgs e)
        {
            DL8Label.Text = b8DcTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void b16DcTextBox_TextChanged(object sender, EventArgs e)
        {
            DL16Label.Text = b16DcTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void textMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            LtextMsgLabel.Text = textMessageTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void binarySequenceTextBox_TextChanged(object sender, EventArgs e)
        {
            ELbinarySeqLabel.Text = binarySequenceTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }

        private void decodedTextMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            LdecodedTextMsgLabel.Text = decodedTextMessageTextBox.TextLength.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
        }
       
        #endregion

        #region "Decode"

        private void decodeButton_Click(object sender, EventArgs e)
        {
            encodeButton.Hide();
            decodeButton.Hide();

            var decodeThread = new Thread(new ThreadStart(DecodingThread));
            decodeThread.Start();
        }
       
        private void DecodingThread()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                b2DcTextBox.Clear();
                b8DcTextBox.Clear();
                b16DcTextBox.Clear();
                decodedTextMessageTextBox.Clear();

                DT2Label.Text = "0 ms";
                DT8Label.Text = "0 ms";
                DT16Label.Text = "0 ms";

                Application.DoEvents();

                if (updateConcurrentlyCheckBox.Checked)
                {
                    LZ78.Decoding += new LZ78.DecodingEventHandler(LZ78_Decoding_Base2);
                    LZ78.DecodingComplete += new LZ78.DecodingCompleteEventHandler(LZ78_DecodingComplete_Base2);

                    LZ78.BeginDecoding(b2EcTextBox.Text, LZ78.NumberBase.Two);
                }
                else
                {
                    //Decoding Base-2
                    var start = DateTime.Now;
                    b2DcTextBox.Text = LZ78.Decode(b2EcTextBox.Text, LZ78.NumberBase.Two);
                    DT2Label.Text = DateTime.Now.Subtract(start).TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";

                    Application.DoEvents();

                    //Decoding Base-8
                    start = DateTime.Now;
                    b8DcTextBox.Text = LZ78.Decode(b8EcTextBox.Text, LZ78.NumberBase.Eight);
                    DT8Label.Text = DateTime.Now.Subtract(start).TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";

                    Application.DoEvents();

                    //Decoding Base-16
                    start = DateTime.Now;
                    b16DcTextBox.Text = LZ78.Decode(b16EcTextBox.Text, LZ78.NumberBase.Sixteen);
                    DT16Label.Text = DateTime.Now.Subtract(start).TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";

                    Application.DoEvents();

                    if (b2DcTextBox.TextLength != 0)
                    {
                        decodedTextMessageTextBox.Text = BinaryToText(b2DcTextBox.Text);
                    }
                    else if (b8DcTextBox.TextLength != 0)
                    {
                        decodedTextMessageTextBox.Text = BinaryToText(b8DcTextBox.Text);
                    }
                    else
                    {
                        decodedTextMessageTextBox.Text = BinaryToText(b16DcTextBox.Text);
                    }
                    encodeButton.Show();
                    decodeButton.Show();

                    Application.DoEvents();
                }
            }));
        }

        private void LZ78_Decoding_Base2(object sender, DecodingEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                b2DcTextBox.AppendText(e.CurrentDecodedPhrase);
                DL2Label.Text = e.CurrentDecodedSequence.Count().ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
            }));
        }

        private void LZ78_DecodingComplete_Base2(object sender, DecodingCompleteEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                DT2Label.Text = e.DecodingTime.TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";
                LZ78.Decoding -= LZ78_Decoding_Base2;
                LZ78.DecodingComplete -= LZ78_DecodingComplete_Base2;
                LZ78.Decoding += new LZ78.DecodingEventHandler(LZ78_Decoding_Base8);
                LZ78.DecodingComplete += new LZ78.DecodingCompleteEventHandler(LZ78_DecodingComplete_Base8);
                LZ78.BeginDecoding(b8EcTextBox.Text, LZ78.NumberBase.Eight);
            }
            ));
        }

        private void LZ78_Decoding_Base8(object sender, DecodingEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                b8DcTextBox.AppendText(e.CurrentDecodedPhrase);
                DL8Label.Text = e.CurrentDecodedSequence.Count().ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
            }));
        }

        private void LZ78_DecodingComplete_Base8(object sender, DecodingCompleteEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                b2DcTextBox.Text = e.DecodedSequence;
                DT8Label.Text = e.DecodingTime.TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";
                LZ78.Decoding -= LZ78_Decoding_Base8;
                LZ78.DecodingComplete -= LZ78_DecodingComplete_Base8;
                LZ78.Decoding += new LZ78.DecodingEventHandler(LZ78_Decoding_Base16);
                LZ78.DecodingComplete += new LZ78.DecodingCompleteEventHandler(LZ78_DecodingComplete_Base16);
                LZ78.BeginDecoding(b16EcTextBox.Text, LZ78.NumberBase.Sixteen);
            }
            ));
        }

        private void LZ78_Decoding_Base16(object sender, DecodingEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                b16DcTextBox.AppendText(e.CurrentDecodedPhrase);
                DL16Label.Text = e.CurrentDecodedSequence.Count().ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
            }));
        }

        private void LZ78_DecodingComplete_Base16(object sender, DecodingCompleteEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                DT16Label.Text = e.DecodingTime.TotalMilliseconds.ToString("N0", CultureInfo.CreateSpecificCulture("en-IN")) + " ms";
                LZ78.Decoding -= LZ78_Decoding_Base16;
                LZ78.DecodingComplete -= LZ78_DecodingComplete_Base16;

                Application.DoEvents();

                decodedTextMessageTextBox.Text = BinaryToText(b16DcTextBox.Text);

                encodeButton.Show();
                decodeButton.Show();
            }
            ));
        }

        #endregion

        #region "Miscellaneous"

        public string TextToBinary(string textString)
        {
            var binaryString = new StringBuilder();
            var utf8ByteArray = Encoding.UTF8.GetBytes(textString);

            for (var i = 0; i < utf8ByteArray.Length; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    binaryString.Append((utf8ByteArray[i] & 0x80) > 0 ? "1" : "0");
                    utf8ByteArray[i] <<= 1;
                }
            }
            return binaryString.ToString();
        }

        private string BinaryToText(string binary)
        {
            var bitCount = binary.Length;
            var byteCount = (bitCount % 8 == 0) ? (bitCount / 8) : (bitCount / 8 + 1);

            var byteArray = new byte[byteCount];

            int byteIndex = 0, bitIndex = 0;

            foreach (var c in binary)
            {
                if (c == '1')
                {
                    byteArray[byteIndex] |= (byte)(1 << (7 - bitIndex));
                }

                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }

            var dd = Encoding.UTF8.GetString(byteArray, 0, byteIndex);
            return dd;
        }

        #endregion

        private void b2_EC_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            decodedTextMessageTextBox.Text = BinaryToText(b2EcTextBox.Text).Replace("\0", Environment.NewLine);
        }

    }
}
