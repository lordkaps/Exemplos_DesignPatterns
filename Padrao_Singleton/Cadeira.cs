using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Singleton
{
    public class Cadeira
    {
        private static readonly Cadeira instance = new Cadeira();
        public int Quantidade { get; set; }

        protected Cadeira() { }

        public static Cadeira Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
