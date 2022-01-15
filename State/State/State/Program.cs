using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State Pattern example");

            Context ctx = new Context(new IAmOff()); // starting as Off
            ctx.TurnOnRequest(); // turn on
            ctx.TurnOnRequest(); // do nothing. already on
            ctx.TurnOffRequest(); // turn off
            ctx.TurnOffRequest(); // break the switch ...
            ctx.TurnOnRequest(); // do nothing (broken)
            ctx.TurnOffRequest(); // do nothing (broken)
        }
    }
    public interface ILightState
    {
        ILightState TurnOn();

        ILightState TurnOff();
    }
    public class IAmOn : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Turning off the light....");
            return new IAmOff();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("already on...");
            return this;
        }
    }
    public class IAmOff : ILightState
    {

        public ILightState TurnOff()
        {
            Console.WriteLine("The light broke...");
            return new IAmBroken();
        }
        public ILightState TurnOn()
        {
            Console.WriteLine("Turning On the light after off....");
            return new IAmOn();
        }
    }

    public class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Broken !! Please call Technician");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Broken !! Please call Technician");
            return this;
        }
    }
    public class Context
    {
        private ILightState _State;
        public Context(ILightState lightState)
        {
            _State = lightState;
        }

        public void TurnOnRequest()
        {
            _State.TurnOn();
        }

        public void TurnOffRequest()
        {
            _State.TurnOff();
        }
    }
}
