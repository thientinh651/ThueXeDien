using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXeDien
{
    internal class XeDien
    {
        private string maXe;
        private bool trangThai;

        public XeDien() {
            this.maXe = null;
            this.trangThai = false;
        }
        public XeDien(string maXe, bool trangThai)
        {
            this.maXe = maXe;
            this.trangThai = trangThai;
        }

        public string MaXe
        {
            get { return this.maXe; }
            set { this.maXe = value; }
        }
        public bool TrangThai
        {
            get { return this.trangThai; }
            set { this.trangThai = value; }
        }






    }
}
