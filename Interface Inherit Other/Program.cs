namespace Interface_Inherit_Other
{
    public interface IPhotoDevice
    {
        void TakePhoto();
    }

    public interface ICallDevice
    {
        void MakeCall();
    }
    public interface IEmailDevice
    {
        void SendEamil();
    }

    public interface IGPSDevice
    {
        void UseGPS();
    }

    public interface ISmartPhone : ICallDevice, IPhotoDevice, IEmailDevice, IGPSDevice
    {

    }
    public class SmartPhone : ISmartPhone
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

    public class Computer : IEmailDevice
    {
        public void SendEamil()
        {
            Console.WriteLine("Send an Email .... ");
        }
    }

    public class Camera : IPhotoDevice
    {
        public void TakePhoto()
        {
            Console.WriteLine("Take Photo .... ");
        }
    }

    public interface IAdvinceCamera : IPhotoDevice, IEmailDevice
    {

    }
    public class AdvinceCamera : IAdvinceCamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Take Photo .... ");
        }

        public void SendEamil()
        {
            Console.WriteLine("Send an Email .... ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            Console.WriteLine("Smart phone :");
            smartPhone.MakeCall();
            smartPhone.TakePhoto();
            smartPhone.SendEamil();
            smartPhone.UseGPS();
            Computer computer = new Computer();
            Console.WriteLine("Computer  :");
            computer.SendEamil();
            Camera camera = new Camera();
            Console.WriteLine("Camera  :");
            camera.TakePhoto();
            AdvinceCamera Adcamera = new AdvinceCamera();
            Console.WriteLine("Advance Camera  :");
            Adcamera.TakePhoto();
            Adcamera.SendEamil();

            Console.ReadKey();
        }
    }
}
