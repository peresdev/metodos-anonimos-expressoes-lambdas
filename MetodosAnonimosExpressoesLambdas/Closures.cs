using System;

namespace MetodosAnonimosExpressoesLambdas
{
    class Closures
    {
        static void Main()
        {
            //int x = 10;
            //Action a = () => Console.WriteLine(x);
            //x = 5;
            //a();

            Action[] actions = new Action[5];

            for(int i = 0; i < 5; i++)
            {
                //int j = i;
                actions[i] = () => Console.WriteLine(i);
            }

            foreach(Action a in actions)
            {
                a();
            }
        }
    }
}
