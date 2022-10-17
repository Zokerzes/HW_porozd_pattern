using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_porozd_pattern
{
    abstract class Document
    { 
        public string Name = string.Empty;

        abstract public Document Create();
        abstract public Document Open();
        abstract public Document Save();
        abstract public Document SaveAs();
        abstract public Document Print();
        abstract public Document Close();
    }

    class TextDocument : Document
    {
        public override Document Close()
        {
            throw new NotImplementedException();
        }

        public override Document Create()
        {
            throw new NotImplementedException();
        }

        public override Document Open()
        {
            throw new NotImplementedException();
        }

        public override Document Print()
        {
            throw new NotImplementedException();
        }

        public override Document Save()
        {
            throw new NotImplementedException();
        }

        public override Document SaveAs()
        {
            throw new NotImplementedException();
        }
    }

    class GraficDocument : Document
    {
        public override Document Close()
        {
            throw new NotImplementedException();
        }

        public override Document Create()
        {
            throw new NotImplementedException();
        }

        public override Document Open()
        {
            throw new NotImplementedException();
        }

        public override Document Print()
        {
            throw new NotImplementedException();
        }

        public override Document Save()
        {
            throw new NotImplementedException();
        }

        public override Document SaveAs()
        {
            throw new NotImplementedException();
        }
    }

    abstract class Redactor
    {
        public string Type; //grafic or text
        public abstract Document FactoryMethod();
    }

    class TextRedactor : Redactor
    {
        public override Document FactoryMethod() 
        {

            Type = "TextDocument";

            return new TextDocument(); 
        }
    }
    class GraficRedactor : Redactor
    {

        public override Document FactoryMethod() 
        {

            Type = "GraficDocument";

            return new GraficDocument(); 
        
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
