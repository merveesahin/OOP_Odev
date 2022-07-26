using System;
using System.Collections.Generic;
using System.Text;
using static OOP_Ödev.Program;

namespace OOP_Ödev
{
    public class Otomobil
    {
        private int hiz;
        public event HizEventHandler HizAsildi;
        
        public int Hiz
        {
            get
            {
                return hiz;
            }
            set
            {
                hiz = value;
                if (hiz >= 80 && HizAsildi != null)
                {
                    HizAsildi(this, new HizArgs(value));
                    
                }
            }
        }
    }
}
