using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace unlockKirk
{
    class OmniGridData
    {
        [StructLayout(LayoutKind.Explicit)]
        struct IntByteUnion
        {
            [FieldOffset(0)]
            public uint ui;

            [FieldOffset(0)]
            public byte b0;

            [FieldOffset(1)]
            public byte b1;

            [FieldOffset(2)]
            public byte b2;

            [FieldOffset(3)]
            public byte b3;
        }
        public uint uiAfterFunction = 0;
        public byte[] myBlob;
        public OmniGridData(byte[] bBlob)
        {
            myBlob = bBlob;
        }
        public string GetHeaderStr(uint uiPointer)
        {
            if (uiPointer != uiAfterFunction)
                return "Get Header doesn't work on that format";

            /// Spells out "Kirk"
            uint CompressedStreamSignature = 0x06b72694b;

            IntByteUnion ibu;
            ibu.ui = 0;
            ibu.b0 = myBlob[0];
            ibu.b1 = myBlob[1];
            ibu.b2 = myBlob[2];
            ibu.b3 = myBlob[3];

            // pointer has moved by 4
            uiAfterFunction = 4;

            // Is this the signature?
            if (ibu.ui == CompressedStreamSignature && uiPointer == 0)
                return "Header == 'Kirk'";
            
            return "invalid Header";
            
        }
        public uint GetSize(uint uiPointer)
        {
            if(uiPointer != uiAfterFunction)
                return 0;

            IntByteUnion ibu;
            ibu.ui = 0;
            ibu.b0 = myBlob[4];
            ibu.b1 = myBlob[5];
            ibu.b2 = myBlob[6];
            ibu.b3 = myBlob[7];
            uiAfterFunction = 8;
            return ibu.ui;
        }
    }
}
