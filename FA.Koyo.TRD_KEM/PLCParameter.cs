using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.Koyo.TRD_KEM
{
    public class PLCParameter
    {
        private string _IP;
        private string _PLC_Model;
        private string _Expansion_Board_Model;

        [CategoryAttribute("常规"), DescriptionAttribute("PLC型号"), ReadOnlyAttribute(true)]
        public string PLC_Model
        {
            get
            {
                return _PLC_Model;
            }
            set
            {
                _PLC_Model = value;
            }
        }

        [CategoryAttribute("常规"), DescriptionAttribute("扩展板型号"), ReadOnlyAttribute(true)]
        public string ExpansionBoardModel
        {
            get
            {
                return _Expansion_Board_Model;
            }
            set
            {
                _Expansion_Board_Model = value;
            }
        }

        [CategoryAttribute("常规"), DescriptionAttribute("IP"), ReadOnlyAttribute(false)]
        public string PLC_IP
        {
            get
            {
                return _IP;
            }
            set
            {
                _IP = value;
            }
        }
       

    }
}
