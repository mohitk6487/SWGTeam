using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sukhi_2;


internal class Constructors: AccessModifiers
{
        int i;
    public Constructors(int i) :this(40,50)         //this keyword is used to call another constructor from a constructor, differentiated by parameters
    { 
        this.i = i+10;                          //this.i refers to class level variable, i refers to parameter
        Console.WriteLine($"\n\tI am a constructor called by class obj when created. \n\tPrinting value of class variable i:{this.i} and my parameter variable i:{i}");

    }
    public Constructors(int i, int j): base()        //base keyword is used to call parent class constructor from child class constructor
    {
     
        Console.WriteLine($"\n\tI am a constructor, who is called by a constructor that is called by class obj so executed after executing parent class constructor that I called. \n\tPrinting value of i:{i} and j:{j}");


    }
}

