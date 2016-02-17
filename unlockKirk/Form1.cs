using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unlockKirk
{
    public partial class Form1 : Form
    {
        byte[] binaryData;
       // byte[] bDecompressed;
        public Form1()
        {
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Unlock Kirk Version {0}", version);
        }

        private void btDecode_Click(object sender, EventArgs e)
        {
            btnDecode.Text = "Hit the button ";
            btnDecode.Enabled = false;
            // try the decode
            decodeB64();
            if (cbWriteOutHex.Checked) 
            {
                int iDataLen = binaryData.GetLength(0);
                rTBoutgoing.Text += "number of bytes is " + iDataLen.ToString();
                int iMax = iDataLen / 16;
                for (int i = 0; i < iMax; i++)
                {
                    writeLine(i);
                }
            }
            OmniGridData myGridData = new OmniGridData(binaryData);
            rTBoutgoing.Text += myGridData.GetHeaderStr(0);
        }
        private void decodeB64()
        {
            try
            {
                binaryData =
                   System.Convert.FromBase64String(rTBIncoming.Text);
            }
            catch (System.ArgumentNullException)
            {
                rTBoutgoing.Text += "Base 64 string is null.";
                return;
            }
            catch (System.FormatException)
            {
                rTBoutgoing.Text += "Base 64 string length is not " +
                   "4 or is not an even multiple of 4.";
                return;
            }
        }
        private void writeLine(int iLine)
        {
            // write new line
            rTBoutgoing.Text += "\r\n";
            // write out binary data in hex
            int iPosition = iLine * 16;
            string strTemp = "";
            int icount;
            for (icount = 0; icount < 16; icount++)
            {
                strTemp += BitConverter.ToString(binaryData, iPosition + icount, 1) + " ";
            }
            for (icount = 0; icount < 16; icount++)
            {
                if (binaryData[iPosition + icount] < 0x0E)
                {
                    strTemp += "*";
                }
                else
                {
                    strTemp += System.Text.Encoding.ASCII.GetString(binaryData, iPosition + icount, 1);
                }
            }
            rTBoutgoing.Text += strTemp;
            //
        }

        private void btnTestHeader_Click(object sender, EventArgs e)
        {
            // Clearing text
            rTBoutgoing.Text = "";
            byte[] baEight = Enumerable.Repeat((byte)0x00, 8).ToArray();
            rTBoutgoing.Text = Convert.ToBase64String(baEight);
        }
        //private static byte[] Decompress(byte[] input)
        //{
        //    byte[] bOutput;

        //    using (MemoryStream memStream = new MemoryStream(input))
        //    {
        //        if (memStream.CanSeek)
        //        {
        //            memStream.Seek(0, SeekOrigin.Begin);
        //        }
        //        using (DeflateStream decomp = new DeflateStream(memStream, CompressionMode.Decompress, true))
        //        {
        //            byte[] bTemp;
        //            decomp.Read(bTemp, 0, (int)decomp.Length);

        //            decomp.Flush();
        //            decomp.Close();
        //        }

        //    }
        //    return bOutput;
        //}


    }
}
