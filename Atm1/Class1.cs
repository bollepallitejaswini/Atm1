using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class partial
    {
        private int _accno;
        private string _name;
        private string _atm;
        private int _amt;
        private int _age;
        private int _camt;
        private int _wamt;
        private string _with;
        public int accno
        {
            set { _accno = value; }
            get { return _accno; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string atm
        {
            get { return _atm; }
            set { _atm = value; }
        }
        public int amt
        { get { return _amt; } set { _amt = value; } }


        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int camt
        { get { return _camt; } set { _camt = value; } }
        public string with
        {
            get { return _with; }
            set { _with = value; }
        }
        public int wamt
        {
            get { return _wamt; }
            set { _wamt = value; }
        }
    }
}
