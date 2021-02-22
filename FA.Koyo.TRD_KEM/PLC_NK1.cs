using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA.Koyo.TRD_KEM
{
    public class PLC_NK1
    {
        public ECOMModbusTCP.LECOMPPPARAM PParam; //NK1各属性集合
        public static short ShRet;
        public bool PLCInitil(ushort stationNumber,string ip)
        {
            PParam = new ECOMModbusTCP.LECOMPPPARAM();
            try
            {
                string[] IP = ip.Split('.');

                PParam.stIpA.by1 = Convert.ToByte(IP[0]);
                PParam.stIpA.by2 = Convert.ToByte(IP[1]);
                PParam.stIpA.by3 = Convert.ToByte(IP[2]);
                PParam.stIpA.by4 = Convert.ToByte(IP[3]);

                PParam.shPortNo = 502;//端口号
                PParam.wStationNumber = stationNumber;  //局号
                PParam.wTimeoutTime = 3000;  //uint 通信溢出时间
                PParam.byRetry = Convert.ToByte(3);   //重试次数
                PParam.stRegAdr.strRegAdr = new char[256];
                PParam.stRegAdr.strType = new char[256];


                ShRet = ECOMModbusTCP.emtOpen(ref PParam);
                if (ShRet == 0)
                {
                    return  true;
                }
                else
                {
                    return  false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return  false;
            }
        }
        
        public void SetRegAdr(char strType, string strRegAdr)
        {
            PParam.stRegAdr.strType[0] = strType;
            //PParam.stRegAdr.strRegAdr = strRegAdr;
            for (int i = 0; i < strRegAdr.ToCharArray().Length; i++)
            {
                PParam.stRegAdr.strRegAdr[i] = strRegAdr.ToCharArray()[i];
            }
        }
        
    }
}
