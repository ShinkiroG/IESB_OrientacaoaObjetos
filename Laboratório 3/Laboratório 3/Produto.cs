using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3
{
    class Produto
    {

        protected string title;
        protected string description = "Produto de Shinkiro Store:";
        protected float price;

        public void InformaPreco()
        {

            Console.WriteLine(price);

        }

        public virtual void InformaDescription()
        {


            Console.WriteLine("");



        }




    }







}
