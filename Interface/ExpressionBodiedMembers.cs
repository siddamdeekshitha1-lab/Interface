using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    internal class ExpressionBodiedMembers
    {
        //Expressionbodiedmembers 
        public void PrintMessage() => Console.WriteLine("Hello World..!");
        public int Square(int x) => x*x;
        public ExpressionBodiedMembers() => Console.WriteLine("constructor Called");
    }
   
    
}
