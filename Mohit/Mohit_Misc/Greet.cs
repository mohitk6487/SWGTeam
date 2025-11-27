using System;
    class Greet
    {
        public static String Hello()
        {
            String wish = "Hello";
            DateTime now = DateTime.Now;
            if (now.Hour >= 4 && now.Hour < 12)
            {
                wish = "Good Morning";
            }
            else if (now.Hour >= 12 && now.Hour < 17)
            {
                wish = "Good Afternoon";
            }
            else if (now.Hour >= 17 && now.Hour < 21)
            {
                wish = "Good Evening";
            }
            else
            {
                wish = "Hello";
             }
            return wish;
        }
    }

