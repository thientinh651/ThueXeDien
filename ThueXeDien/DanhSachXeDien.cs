using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXeDien
{
    internal class DanhSachXeDien
    {
        private List<XeDien > dsXeDien=new List<XeDien>();

        public DanhSachXeDien() { this.dsXeDien = new List<XeDien>(); }
        public DanhSachXeDien(List<XeDien> ds) { this.dsXeDien = ds; }

        public List<XeDien> DSXeDien
        {
            get { return dsXeDien; }
            set { dsXeDien = value; }
        }


        public bool checkTrungMa(string ma)
        {
            foreach (XeDien xeDien in dsXeDien)
            {
                if (xeDien.Equals(ma))
                {
                    return true;
                }
            }
            return false;
        }
        public bool them(XeDien x)
        {
            foreach(XeDien xe in dsXeDien)
            {
                if (checkTrungMa(x.MaXe))
                {
                    Console.WriteLine("Ma xe "+x.MaXe+" da ton tai"); return false;
                }
            }
            return true;
        }
        public bool xoa(int viTri)
        {
            dsXeDien.RemoveAt(viTri);
            return true;
        }

    }
}
