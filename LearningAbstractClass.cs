using System;

namespace BezaoOOP
{
    public class LearningAbstractClass
    {
    }

    public class ControllerRequest
    {
        public int PowerButton { get; init; }
        public int ButtonOne { get; init; }
        public int ButtonTwo { get; init; }
        public int ButtonThree { get; init; }
        public int ButtonFour { get; init; }
    }

    //Create an abstract controller

    public abstract class Controller
    {
        protected bool isOn = false;

        public int BatteryLevel { get; private set; } = 10;            
        
        public int PowerButton { get; init; }
        public int ButtonOne { get; init; }
        public int ButtonTwo { get; init; }
        public int ButtonThree { get; init; }
        public int ButtonFour { get; init; }

        public Controller()
        {
            PowerButton = 0;
            ButtonOne = 1;
            ButtonFour = 4;
            ButtonTwo = 2;
            ButtonThree = 3;
        }
        public Controller(ControllerRequest request)
        {
            PowerButton = request.PowerButton;
            ButtonOne = request.ButtonOne;
            ButtonTwo = request.ButtonTwo;
            ButtonThree = request.ButtonThree;
            ButtonFour = request.ButtonFour;
        }        

        public virtual void OnPowerButton()
        {
            BatteryLevel -= 1;
            isOn = !isOn;
            string message = isOn ? "Power On" : "Power Off";
            Console.WriteLine(message);
        }
        public abstract void OnButtonOne();

        public abstract void OnButtonTwo();

        public abstract void OnButtonThree();

        public abstract void OnButtonFour(); 
        
        public void ReduceBatteryLevel()
        {
            BatteryLevel -= 1;
        }
    }

    //TvController
    //Game Controller

    public class TvController : Controller
    {
        public override void OnButtonFour()
        {
            ReduceBatteryLevel();
            Console.WriteLine("Next");
        }

        public override void OnButtonOne()
        {
            ReduceBatteryLevel();
            Console.WriteLine("Volume Up");
        }

        public override void OnButtonThree()
        {
            ReduceBatteryLevel();
            Console.WriteLine("Previous");
        }

        public override void OnButtonTwo()
        {
            ReduceBatteryLevel();
            Console.WriteLine("Volume Down");
        }
    }

    public static class ControllerBatteryChecker
    {
        public static void CheckBattery(Controller controller)
        {
            Console.WriteLine($"The battery level is {controller.BatteryLevel}");
        }
    }

    public abstract class GameController : Controller
    {
        public sealed override void OnButtonFour()
        {
            throw new NotImplementedException();
        }

        public override void OnButtonOne()
        {
            Console.WriteLine("Left");
        }

        public abstract override void OnButtonThree();        

        public override void OnButtonTwo()
        {
            Console.WriteLine("Right");
        }

        public override void OnPowerButton()
        {
            if (!isOn)
            {
                base.OnPowerButton();
            }

            Console.WriteLine("You go no where, Game is already on");
           // base.OnPowerButton();

        }
    }

    public sealed class Ps5 : GameController
    {
        public override void OnButtonThree()
        {
            Console.WriteLine("Speed Increased");
        }
    }

    

    public class Application
    {
        public static void Run()
        {
            TvController tvController = new TvController();          

            ControllerBatteryChecker.CheckBattery(tvController);
            tvController.OnPowerButton();
            tvController.OnButtonFour();
            tvController.OnButtonOne();
            tvController.OnButtonThree();
            tvController.OnButtonTwo();
            tvController.OnPowerButton();
            ControllerBatteryChecker.CheckBattery(tvController);

        }
    }

}
