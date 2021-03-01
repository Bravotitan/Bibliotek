using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Bog



    {
        string name;
        
        public string Navn
        {
            get => name;
            set => name = value;
        }
        string author;

        public string Author
        {
            get => author;
            set => author = value;

        }

        int pages;

        public int Pages
        {
            get=> pages;
            set => pages = value;
         
        }
        
        
    }
}
