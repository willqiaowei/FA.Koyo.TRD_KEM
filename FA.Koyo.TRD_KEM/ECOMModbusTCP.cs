using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace FA.Koyo.TRD_KEM
{
    public class ECOMModbusTCP
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct LPIPAdr
        {
            public Byte by1;
            public Byte by2;
            public Byte by3;
            public Byte by4;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LPRegAdr
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] strType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] strRegAdr;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LECOMPPPARAM
        {
            public LPIPAdr stIpA;
            public short shPortNo;
            public ushort wStationNumber;
            public ushort wTimeoutTime;
            public Byte byRetry;
            public ushort wReturnStatus;
            public ushort wReciveErrorCode;
            public LPRegAdr stRegAdr;
        }

        //打开连接
        [DllImport("ECOMModbusTCP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern short emtOpen(ref LECOMPPPARAM lpEcomParam);

        //断开连接
        [DllImport("ECOMModbusTCP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern short emtClose(ref LECOMPPPARAM lpEcomParam);
        
        //读取数据
        [DllImport("ECOMModbusTCP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern short emtRead_PLC(ref LECOMPPPARAM lpPortParam, [MarshalAs(UnmanagedType.LPArray)] ushort[] lpBuf, short byNumber);

        //写入数据
        [DllImport("ECOMModbusTCP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern short emtWrite_PLC(ref LECOMPPPARAM lpPortParam, [MarshalAs(UnmanagedType.LPArray)] ushort[] lpBuf, short byNumber);

        //写入数据
        [DllImport("ECOMModbusTCP.dll", CallingConvention = CallingConvention.Cdecl)]
   
        public static extern short emtWrite_PLC_BYTE(ref LECOMPPPARAM lpPortParam, [MarshalAs(UnmanagedType.LPArray)] Byte[] lpBuf, Int16 byNumber);

    }

}
