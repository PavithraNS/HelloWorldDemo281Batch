using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //access-modifier class-keyword className
    public class Human
    {
        //instance variables
        //access-modifier datatype variableName
        public string name;
        public float height;
        public long phoneNumber;

        //access-modifier returntype methodName
        public void Talk()
        {
            Console.WriteLine("Human can talk");
        }

        public void HumanDetails()
        {
            Console.WriteLine("name:{0} height:{1} phone:{2}",name,height,phoneNumber);
        }
    }
}
