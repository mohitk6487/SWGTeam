using System;


    class VikasLogical
    {
        public static void Work()
        {
            bool Mynamevikas = true;
            bool MySirnameChandel = true;

            if (Mynamevikas && MySirnameChandel)
                    {
                Console.WriteLine("You are only right, if i am wrong");
            }
           

            bool isshoesbrandAdidas=true;
            if (!isshoesbrandAdidas)
                Console.WriteLine("Its a Nike");
            else
                Console.WriteLine("Its a Adidas");

        }
      
    }


//&& both need to be true
//|| or operator any one need to be true
// not ooerator ! it invert the boolean value
//it will go inside the if statement if  condition is false. If its true then no result.