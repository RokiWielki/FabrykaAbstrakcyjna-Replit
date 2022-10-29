using System;
using System.Text;


namespace FabrykaAbstrakcyjna
{
    
    interface ILetters
    {
        public string ShowAlfa();
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
        //
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


    //
    // ...
    //


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
