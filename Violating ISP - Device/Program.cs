namespace Violating_ISP___Device
{
    public interface IDevice
    {
        void MakeCall();
        void TakePhoto();
        void SendEamil();
        void UseGPS();
    }

    public class SmartPhone : IDevice
    {
        public void MakeCall()
        {
            Console.WriteLine("Calling .... ");
        }

        public void SendEamil()
        {
            Console.WriteLine("Send Email .... ");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Take Photo .... ");
        }

        public void UseGPS()
        {
            Console.WriteLine("Use GPS .... ");
        }
    }

    public class Computer : IDevice
    {
        public void MakeCall()
        {
            throw new NotImplementedException();
        }

        public void SendEamil()
        {
            Console.WriteLine("Send an Email .... ");
        }

        public void TakePhoto()
        {
            throw new NotImplementedException();
        }

        public void UseGPS()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice smartPhone = new SmartPhone();
            smartPhone.MakeCall();
            smartPhone.TakePhoto();
            smartPhone.SendEamil();
            smartPhone.UseGPS();
            IDevice computer = new Computer();
            computer.SendEamil();
            computer.TakePhoto();// this is woring because this can not do this
            computer.UseGPS();   // this is woring because this can not do this
            computer.MakeCall(); // this is woring because this can not do this

            Console.WriteLine("Hello, World!");
        }
    }
}
