using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //interface IShape
    //{
    //    void Area();
    //    double Perimeter();
    //}
    //public class Circle:IShape
    //{
    //    public double Radius {  get; set; }
    //    public void Area()
    //    {
    //        Console.WriteLine("Area of a Circle is" + (Math.PI * Radius * Radius));
    //    }
    //    public double Perimeter()
    //    {
    //        return 2*Math.PI*Radius;
    //    }
    //}
    //class Rectangle:IShape
    //{
    //    public double Length { get; set; }
    //    public double Width {  get; set; }
    //    public void Area()
    //    {
    //        Console.WriteLine("Area of rectangle is:" + Length * Width);
    //    }
    //    public double Perimeter()
    //    {
    //        return 2*(Length*Width);
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IShape obj=new Circle { Radius=5};
    //        obj.Area();
    //        Console.WriteLine("perimeter of a circle:"+obj.Perimeter());
    //        IShape obj2=new Rectangle { Width=5,Length=6};
    //        obj2.Area();
    //        Console.WriteLine("Paerimeter of a rectangle:"+obj2.Perimeter());
    //    }
    //}
    //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-


    //class ExpressionBodiedMembers
    //{
    //    //Expressionbodiedmembers 
    //    public void PrintMessage() => Console.WriteLine("Hello World..!");
    //    public int Square(int x) => x * x;
    //    public ExpressionBodiedMembers() => Console.WriteLine("constructor Called");
    //}
    //  internal class Program
    // {
    //    static void Main(string[] args)
    //    {
    //       ExpressionBodiedMembers obj=new ExpressionBodiedMembers();
    //       obj.PrintMessage();
    //       Console.WriteLine(obj.Square(5));
    //    }
    //  }
    //
    //
    //
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //interface IphoneBasic
    //{
    //    void Calling();
    //    void Receiving();
    //    void SendMessage();
    //    void EndCall();
    //}
    //class IphoneSE : IphoneBasic
    //{
    //    public void Calling()
    //    {
    //        Console.WriteLine("IphoneSE is Calling");
    //    }
    //    public void Receiving()
    //    {
    //        Console.WriteLine("IphoneSE is receiving");
    //    }
    //    public void SendMessage()
    //    {
    //        Console.WriteLine("IphoneSE is sending messages");
    //    }
    //    public void EndCall()
    //    {
    //        Console.WriteLine("IphoneSE is ending the call");
    //    }
    //}
    //interface  IphoneAdvanced
    //{
    //    void FaceId();
    //    void Videocall();
    //    void AirDrops();
    //}
    //class Iphone16 : IphoneBasic, IphoneAdvanced
    //{
    //    public void Calling()
    //    {
    //        Console.WriteLine("Iphone16 is Calling");
    //    }
    //    public void Receiving()
    //    {
    //        Console.WriteLine("Iphone16 is receiving");
    //    }
    //    public void SendMessage()
    //    {
    //        Console.WriteLine("Iphone16 is sending messages");
    //    }
    //    public void EndCall()
    //    {
    //        Console.WriteLine("Iphone16 is ending the call");
    //    }
    //    public void FaceId()
    //    {
    //        Console.WriteLine("iphone 16 face id");
    //    }
    //    public void Videocall()
    //    {
    //        Console.WriteLine("ipnone 16 video call");
    //    }
    //    public void AirDrops()
    //    {
    //        Console.WriteLine("iphone 16 air drop files");
    //    }


    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IphoneBasic obj = new IphoneSE();
    //        obj.Calling();
    //        obj.Receiving();
    //        obj.SendMessage();
    //        obj.EndCall();
    //        obj=new Iphone16();
    //        obj.Calling();
    //        obj.Receiving();
    //        obj.SendMessage();
    //        obj.EndCall();
    //       IphoneAdvanced obj2= new Iphone16();
    //        obj2 .FaceId();
    //        obj2.Videocall();
    //        obj2.AirDrops();
    //    }
    //}
    //
    //
    //
    //
    //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--==-=-=-=-=-=-=-=-=-=-=-=-=-=-
    interface IpaymentGateway
    {
        void Processpayment();
    }
    class Paypal: IpaymentGateway
    {
        
        public void Processpayment()
        {
            Console.WriteLine("paypal payment....");
        }
    }
    class UPIGateway:IpaymentGateway
    {
        public void Processpayment()
        {
            Console.WriteLine("UPIGateway payment....");
        }
    }
    class CreditCard:IpaymentGateway
    {
        public void Processpayment()
        {
            Console.WriteLine("CredirCard payment...");
        }
    }
    class DebitCard:IpaymentGateway
    {
        public void Processpayment()
        {
            Console.WriteLine("Debitcard payment...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IpaymentGateway obj = new Paypal();
            obj.Processpayment();
             obj = new UPIGateway();
            obj.Processpayment();
           obj =new CreditCard();
            obj.Processpayment() ;
         obj = new DebitCard();
            obj.Processpayment();

        }
    }

}
