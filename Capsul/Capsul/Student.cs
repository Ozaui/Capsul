using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsul
{
    public class Student
    {
        private string name;
        private int height;

        public int HEIGHT
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}