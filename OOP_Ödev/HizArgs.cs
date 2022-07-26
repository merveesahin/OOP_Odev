using System;

namespace OOP_Ödev
{
    public delegate void HizEventHandler(object sender, HizArgs arg);
    public class HizArgs
    {
        private int güncelHiz;
        public DateTime Zaman
        {
            get
            {
                return DateTime.Now;
            }
        }
        public int GüncelHiz
        {
            get
            {
                return güncelHiz;
            }
        }
        public HizArgs(int guncelHizi)
        {
            güncelHiz = guncelHizi;
        }
    }
}