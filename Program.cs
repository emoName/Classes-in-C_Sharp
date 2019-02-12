using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Traker a;
            
            Base b ;

            //b = new Base();
            //Console.WriteLine();
            //b.GetMesage();
            //b.ShowMessage();
            //b.ShowMessage1();
            //a = b.MyProperty;
            //b.MyProperty = a;
            //Console.WriteLine();

            /* 
             * static Fild
             * static constructor
             * Fild 
             * Constructor
             * method

            */


            //b = new Child1();
            //Console.WriteLine();
            //b.GetMesage();
            //b.ShowMessage();
            //b.ShowMessage1();
            //a = b.MyProperty;
            //b.MyProperty = a;
            //Console.WriteLine();

            /*
This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :
This is : Child1 :: child1StaticFild : Static :
This is : Child1 :: Constructor :: Static :
This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :
This is : Child1 :: child1Fild :
This is : Child1 :: child1FildReadOnly : ReadOnly :
This is : Base :: baseFild : Static : ReadOnly :
This is : Base :: baseFild : Static :
This is : Base :: Constructor :: Static :
This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :
This is : Base :: baseFild :
This is : Base :: baseFild : ReadOnly :
Call from Child1
This is : Child1 :: Constructor ::
This is : Child1 :: Constructor :: child1FildReadOnly :: initialization :

This is : Base :: GetMessage :virtual :
This is : Base :: ShowMessage ::
This is : Child1 :: ShowMessage :: Overload : override : DefaultMessage :
Tis is : Child1 :: GetProprety : override :
Tis is : Child1 :: SetProprety : override :

SFIRSIT !!!



            */

            //b = new Child2();
            //Console.WriteLine();

            //b.GetMesage();
            //b.ShowMessage();
            //b.ShowMessage1();
            //a = b.MyProperty;
            //b.MyProperty = a;

            //Console.WriteLine();




            /*
This is : Child2 :: child2StaticFild : static :
This is : Child2 :: Constructor :: Static :
This is : Child2 :: child2Fild :
This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :
This is : Child1 :: child1StaticFild : Static :
This is : Child1 :: Constructor :: Static :
This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :
This is : Child1 :: child1Fild :
This is : Child1 :: child1FildReadOnly : ReadOnly :
This is : Base :: baseFild : Static : ReadOnly :
This is : Base :: baseFild : Static :
This is : Base :: Constructor :: Static :
This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :
This is : Base :: baseFild :
This is : Base :: baseFild : ReadOnly :
This is : Base :: Constructor ::
This is : Base :: Constructor :: baseFildReadOnly :: initialization :
Call from Child2
This is : Child2 :: Constructor ::

This is : Base :: GetMessage :virtual :
This is : Base :: ShowMessage ::
This is : Child2 :: ShowMessage :: Overload : override : DefaultMessage :yffjfkk
Tis is : Child1 :: GetProprety : override :
Tis is : Child1 :: SetProprety : override :

SFIRSIT !!!
             
             */
            //b = new Child3();
            //Console.WriteLine();

            //b.GetMesage();
            //b.ShowMessage();
            //b.ShowMessage1();
            //a = b.MyProperty;
            //b.MyProperty = a;

            //Console.WriteLine();


            /*
This is : Child3 :: child3Fild : static :
This is : Child3 :: Constructor :: Static :
This is : Child3 :: child3Fild :
This is : Child2 :: child2StaticFild : static :
This is : Child2 :: Constructor :: Static :
This is : Child2 :: child2Fild :
This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :
This is : Child1 :: child1StaticFild : Static :
This is : Child1 :: Constructor :: Static :
This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :
This is : Child1 :: child1Fild :
This is : Child1 :: child1FildReadOnly : ReadOnly :
This is : Base :: baseFild : Static : ReadOnly :
This is : Base :: baseFild : Static :
This is : Base :: Constructor :: Static :
This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :
This is : Base :: baseFild :
This is : Base :: baseFild : ReadOnly :
Call from Child1
This is : Child1 :: Constructor ::
This is : Child1 :: Constructor :: child1FildReadOnly :: initialization :
Call from Child3
This is : Child3 :: Constructor ::

This is : Base :: GetMessage :virtual :
This is : Base :: ShowMessage ::
This is : Child2 :: ShowMessage :: Overload : override : DefaultMessage :yffjfkk
Tis is : Child1 :: GetProprety : override :
Tis is : Child1 :: SetProprety : override :

SFIRSIT !!!


           */
            //  Child1 iBase = new Child1();
            ////  IBase iBase = child1;

            //  Console.WriteLine();

            //  iBase.GetMesage();
            //  iBase.ShowMessage();
            //  iBase.ShowMessage1();
            //  a = iBase.MyProperty;
            //  iBase.MyProperty = a;

            //  Console.WriteLine();




            /*
             * 
             * This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :
This is : Child1 :: child1StaticFild : Static :
This is : Child1 :: Constructor :: Static :
This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :
This is : Child1 :: child1Fild :
This is : Child1 :: child1FildReadOnly : ReadOnly :
This is : Base :: baseFild : Static : ReadOnly :
This is : Base :: baseFild : Static :
This is : Base :: Constructor :: Static :
This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :
This is : Base :: baseFild :
This is : Base :: baseFild : ReadOnly :
Call from Child1
This is : Child1 :: Constructor ::
This is : Child1 :: Constructor :: child1FildReadOnly :: initialization :

This is : Child1 :: GetMessage :virtual : new :
This is : Child1 :: ShowMessage :: new :
This is : Child1 :: ShowMessage :: Overload : override : DefaultMessage :
Tis is : Child1 :: GetProprety : override :
Tis is : Child1 :: SetProprety : override :

SFIRSIT !!!



             * 
             * 
             * INTERFATA 
             * 
            This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :
This is : Child1 :: child1StaticFild : Static :
This is : Child1 :: Constructor :: Static :
This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :
This is : Child1 :: child1Fild :
This is : Child1 :: child1FildReadOnly : ReadOnly :
This is : Base :: baseFild : Static : ReadOnly :
This is : Base :: baseFild : Static :
This is : Base :: Constructor :: Static :
This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :
This is : Base :: baseFild :
This is : Base :: baseFild : ReadOnly :
Call from Child1
This is : Child1 :: Constructor ::
This is : Child1 :: Constructor :: child1FildReadOnly :: initialization :

This is : Base :: GetMessage :virtual :
This is : Base :: ShowMessage ::
This is : Base :: ShowMessage :: Overload : DefaultMessage :
Tis is : Child1 :: GetProprety : override :
Tis is : Child1 :: SetProprety : override :


           */
            Child2 child2 = new Child2();
            IBase iBase = child2;

            Console.WriteLine();

            iBase.GetMesage();
            iBase.ShowMessage();
            iBase.ShowMessage1();
            a = iBase.MyProperty;
            iBase.MyProperty = a;

            Console.WriteLine();



            /*
            This is : Child2 :: child2StaticFild : static :
This is : Child2 :: Constructor :: Static :
This is : Child2 :: child2Fild :
This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :
This is : Child1 :: child1StaticFild : Static :
This is : Child1 :: Constructor :: Static :
This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :
This is : Child1 :: child1Fild :
This is : Child1 :: child1FildReadOnly : ReadOnly :
This is : Base :: baseFild : Static : ReadOnly :
This is : Base :: baseFild : Static :
This is : Base :: Constructor :: Static :
This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :
This is : Base :: baseFild :
This is : Base :: baseFild : ReadOnly :
This is : Base :: Constructor ::
This is : Base :: Constructor :: baseFildReadOnly :: initialization :
Call from Child2
This is : Child2 :: Constructor ::

This is : Child2 :: GetMessage :override :
This is : Child2 :: ShowMessage :: new : Virtual :
This is : Child2 :: ShowMessage :: Overload : override : DefaultMessage :yffjfkk
Tis is : Child2 :: GetProprety : new :
Tis is : Child2 :: SetProprety : new :



           */
            //Child3 iBase = new Child3();
            ////  IBase iBase = child1;

            //Console.WriteLine();

            //iBase.GetMesage();
            //iBase.ShowMessage();
            //iBase.ShowMessage1();
            //a = iBase.MyProperty;
            //iBase.MyProperty = a;

            //Console.WriteLine();



            /*
            This is : Child3 :: Constructor :: Static :
This is : Child3 :: child3Fild :
This is : Child2 :: child2StaticFild : static :
This is : Child2 :: Constructor :: Static :
This is : Child2 :: child2Fild :
This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :
This is : Child1 :: child1StaticFild : Static :
This is : Child1 :: Constructor :: Static :
This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :
This is : Child1 :: child1Fild :
This is : Child1 :: child1FildReadOnly : ReadOnly :
This is : Base :: baseFild : Static : ReadOnly :
This is : Base :: baseFild : Static :
This is : Base :: Constructor :: Static :
This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :
This is : Base :: baseFild :
This is : Base :: baseFild : ReadOnly :
Call from Child1
This is : Child1 :: Constructor ::
This is : Child1 :: Constructor :: child1FildReadOnly :: initialization :
Call from Child3
This is : Child3 :: Constructor ::

This is : Child3 :: GetMessage :new :
This is : Child3 :: ShowMessage :: override : Virtual :
This is : Child3 :: ShowMessage :: Overload : new : DefaultMessage :
This is : Child3 :: GetProprety : new :
This is : Child3 :: SetProprety : new :


           */








            Console.WriteLine("SFIRSIT !!!");
            Console.ReadLine();
        }
    }
}
