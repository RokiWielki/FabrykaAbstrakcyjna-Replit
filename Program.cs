using System;
using System.Text;


namespace FabrykaAbstrakcyjna
{
    
    interface ILetters
    {
        public string ShowAlfa();
    }
    interface INums
    {
        public int ShowNum();
    }

    //
    //
    //

    class AlphabetFactory
    {

        private SystemFactory systemFactory;

        //
        //

        public AlphabetFactory(SystemFactory systemFactory)
        {
            //
        }

        public void Generate()
        {
            numbers = systemFactory.CreateNum();
            //
        }

    }


    abstract class SystemFactory
    {
        public abstract ILetters CreateAlfa();
        public abstract INums CreateNum();
    }


    //
    // ...
    //


    class CyrylicaFactory : SystemFactory
    {
        public override ILetters CreateAlfa()
        {
            return new CyrylicaLetters();
        }

        public override INums CreateNum()
        {
            return new CyrylicaNumbers();
        }
    }

    class LacinkaFactory : SystemFactory
    {
        public override ILetters CreateAlfa()
        {
            return new LacinkaLetters();
        }

        public override INums CreateNum()
        {
            return new LacinkaNumbers();
        }
    }

    class GrekaFactory : SystemFactory
    {
        public override ILetters CreateAlfa()
        {
            return new GrekaLetters();
        }

        public override INums CreateNum()
        {
            return new GrekaNumbers();
        }
    }

    class CyrylicaLetters : ILetters
    {
        string letters;

        public CyrylicaLetters()
        {
            letters = "cyrylica";
        }

        //
        //
        //
    }
    class LacinkaLetters : ILetters
    {
        string letters;

        public LacinkaLetters()
        {
            letters = "abcde";
        }

        //
        //
        //
    }
    class GrekaLetters : ILetters
    {
        string letters;

        public GrekaLetters()
        {
            letters = "alfa,beta";
        }

        //
        //
        //
    }


    //
    // ...
    //

    class CyrylicaNumbers : INums
    {
        string numbers;

        //
        //
        //  

        public string ShowNum()
        {
            return numbers;
        }
    }
    class LacinkaNumbers : INums
    {
        string numbers;

        //
        //
        //  

        public string ShowNum()
        {
            return numbers;
        }
    }

    class GrekaNumbers : INums
    {
        string numbers;

        //
        //
        //  

        public string ShowNum()
        {
            return numbers;
        }
    }


    


    //
    // ...
    //


    public class Application
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            AlphabetFactory alphabet_lacinka = new AlphabetFactory(new LacinkaFactory());
            //
            //

            //
            alphabet_cyrylica.Generate();
            //

            //
            //
            Console.WriteLine(alfabet_greka.letters.ShowAlfa() + " " + alfabet_greka.numbers.ShowNum());
        }
    }


}
