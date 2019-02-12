using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Classes_in_C_Sharp
{
    //--------------------------------------------------------------------TRAKER-----------------------------------------------------------------------------
  public  class Traker
    {
        public Traker(string text)
        {
            Thread.Sleep(400);
            Console.WriteLine(text);
        }

        public void WhoIam(String s) { Thread.Sleep(400); Console.WriteLine(s); }
    }
    //--------------------------------------------------------------------INTERFACE----------------------------------------------------------------
    interface IBase
    {
        void ShowMessage1(string s = "This is : IBase :: ShowMessage :: Overload : DefaultMessage :");
        void ShowMessage();
        void GetMesage();


        Traker MyProperty { get; set; }

    }
    //---------------------------------------------------------------BBBBAAAASSSEEEEEE-----------------------------------------------------------------
    public class Base : IBase
    {
                                      Traker baseFild = new Traker("This is : Base :: baseFild :");
             public  readonly Traker baseFildReadOnly = new Traker("This is : Base :: baseFild : ReadOnly :");
 public static readonly Traker baseStaticFildReadOnly = new Traker("This is : Base :: baseFild : Static : ReadOnly :");
                         static Traker baseStaticFild = new Traker("This is : Base :: baseFild : Static :");
                                public  const String constString = "This is : Base :: constStrang :";
        // Refereance Type cant be Const
       // public const Traker constTraker = new Traker("xgfchgvjbj");


        protected Traker _traker;
        // property
        public virtual Traker MyProperty {
                                   get
            {
                        return new Traker("Tis is : Base :: GetProprety :"); }
                                   set
            {
                     _traker = new Traker("Tis is : Base :: SetProprety :");
            }
        }

        // Cant inhered if Defult Constructor is private or internal
     public  Base()
        {
                        Console.WriteLine("This is : Base :: Constructor :: ");
            baseFildReadOnly = new Traker("This is : Base :: Constructor :: baseFildReadOnly :: initialization :");

        }
        public Base(String s)
        {
            Thread.Sleep(400);
            Console.WriteLine(s);
        }
        static Base()
        {
                        Console.WriteLine("This is : Base :: Constructor :: Static :");
      baseStaticFildReadOnly = new Traker("This is : Base :: Constructor :: baseStaticFildReadOnly :: initialization :");
        }
        public void ShowMessage()
        {

                        Console.WriteLine("This is : Base :: ShowMessage ::");
        }
        //overload
 public virtual void ShowMessage1(string s= "This is : Base :: ShowMessage :: Overload : DefaultMessage :")
        {
            s = "This is : Base :: ShowMessage :: Overload : DefaultMessage :";
                        Console.WriteLine(s);
        //    baseFildReadOnly.WhoIam("This is : Base :: ShowMessage :: baseFildReadOnly : ReadOnly :");

            // readonly is one per class and cant be accesed iven in same class
          //  this.baseStaticFildReadOnly.WhoIam("");

        }

        virtual public void GetMesage()
        {
            // Fild is ReadOnly
        //    this.baseFildReadOnly = new Traker("");
                        Console.WriteLine("This is : Base :: GetMessage :virtual :");
        }
        // a static memmber can not be maked as override ,abstract  , virtual
        //virtual static public void GetMessageStatic()  {        }

        // Can not be "sealed" because is not override
        //public sealed void GetMessage()        {        }

            // Cant be abstract because it's Class is not Abstract
        //public abstract void GetMessage();



        ~Base()
        {
            Console.WriteLine("This is : Base :: Distructor :");
            Thread.Sleep(2000);
        }

        //Dstructor  Can't  be abstract or contain parameters  :)
        //abstract ~Base(int a);


    }

    //-----------------------------------------------------------------111111111111111-------------------------------------------------------------------------
  public  class Child1 : Base
    {
        //public string s;
        Traker child1Fild = new Traker("This is : Child1 :: child1Fild :");
        public readonly Traker child1FildReadOnly = new Traker("This is : Child1 :: child1FildReadOnly : ReadOnly :");
        public static readonly Traker child1StaticFildReadOnly = new Traker("This is : Child1 :: child1StaticFildReadOnly : Static : ReadOnly :");
        static Traker child1StaticFild = new Traker("This is : Child1 :: child1StaticFild : Static :");

        public Child1(): base("Call from Child1")
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child1 :: Constructor :: ");
            child1FildReadOnly = new Traker("This is : Child1 :: Constructor :: child1FildReadOnly :: initialization :");
        }
        public Child1(String s)
        {
            Thread.Sleep(400);
            Console.WriteLine(s);
        }

        static Child1()
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child1 :: Constructor :: Static :");
            child1StaticFildReadOnly = new Traker("This is : Child1 :: Constructor :: child1StaticFildReadOnly :: initialization :");
        }

        public override Traker MyProperty
        {
            get
            {
                return new Traker("Tis is : Child1 :: GetProprety : override :");
            }
            set
            {
                _traker = new Traker("Tis is : Child1 :: SetProprety : override :");
            }
        }


        public new void ShowMessage()
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child1 :: ShowMessage :: new :");
        }

         public override void ShowMessage1(string s = "This is : Child1 :: ShowMessage :: Overload : override : DefaultMessage :")
        {
            s = "This is : Child1 :: ShowMessage :: Overload : override : DefaultMessage :";
            Console.WriteLine(s);

        }


        virtual public new void GetMesage()
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child1 :: GetMessage :virtual : new :");
        }




        ~Child1()
        {
            Console.WriteLine("This is : Child1 :: Distructor :");
            Thread.Sleep(2000);
          
        }
    }
    //----------------------------------------------------------------222222222222------------------------------------------------------------------------
  public  class Child2 : Child1 ,IBase
    {

        Traker child2Fild = new Traker("This is : Child2 :: child2Fild :");
      static  Traker child2StaticFild = new Traker("This is : Child2 :: child2StaticFild : static :");

        public Child2(): base ("Call from Child2")
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child2 :: Constructor :: ");

        }
        public Child2(String s)
        {
            Thread.Sleep(400);
            Console.WriteLine(s);
        }
         static Child2()
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child2 :: Constructor :: Static :");
        }

        public new Traker MyProperty
        {
            get
            {
                return new Traker("Tis is : Child2 :: GetProprety : new :");
            }
            set
            {
                _traker = new Traker("Tis is : Child2 :: SetProprety : new :");
            }
        }


       virtual  public new void ShowMessage()
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child2 :: ShowMessage :: new : Virtual :");
        }

        public override void ShowMessage1(string s = "This is : Child2 :: ShowMessage :: Overload : override : DefaultMessage :")
        {
            s = "This is : Child2 :: ShowMessage :: Overload : override : DefaultMessage :";
            Thread.Sleep(400);
            Console.WriteLine(s+"yffjfkk");

        }

         public override void GetMesage()
        {
            Thread.Sleep(400);
            Console.WriteLine("This is : Child2 :: GetMessage :override :");
        }





        ~Child2()
        {
            Console.WriteLine("This is : Child2 :: Distructor :");
            Thread.Sleep(2000);
        }

    }
    //-------------------------------------------------------------------------3333333333333333----------------------------------------------
   public class Child3 : Child2,IBase
    {
        
             Traker child2Fild = new Traker("This is : Child3 :: child3Fild :");
static Traker child2StaticFild = new Traker("This is : Child3 :: child3Fild : static :");

        public Child3() :           base("Call from Child3")
        {
                           Console.WriteLine("This is : Child3 :: Constructor :: "); 

        }

        static Child3()
        {

                           Console.WriteLine("This is : Child3 :: Constructor :: Static :");
        }

        public new Traker MyProperty
        {
            get
            {
                           return new Traker("This is : Child3 :: GetProprety : new :");
            }
            set
            {
                        _traker = new Traker("This is : Child3 :: SetProprety : new :");
            }
        }


         public override void ShowMessage()
        {
            Thread.Sleep(400);
                            Console.WriteLine("This is : Child3 :: ShowMessage :: override : Virtual :");
        }

        public new void ShowMessage1(string s = "This is : Child3 :: ShowMessage :: Overload : new : DefaultMessage :")
        {
            s = "This is : Child3 :: ShowMessage :: Overload : new : DefaultMessage :";
            Thread.Sleep(400);
            Console.WriteLine(s);

        }

         public new void GetMesage()
        {
            Thread.Sleep(400);
                             Console.WriteLine("This is : Child3 :: GetMessage :new :");
        }

        ~Child3()
        {
            Console.WriteLine("This is : Child3 :: Distructor :");
            Thread.Sleep(2000);
        }

    }
//----------------------------------------------------------------------------------------------------------------------------------
}
