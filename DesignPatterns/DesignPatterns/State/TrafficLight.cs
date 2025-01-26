namespace DesignPatterns.State
{
    public class TrafficLight
    {
        public IState State { get; set; }

        public TrafficLight()
        {
            State = new RedState();  // Initial state is Red
        }

        public void Change()
        {
            State.ChangeState(this);
        }
    }


    public class GreenState : IState
    {
        public void ChangeState(TrafficLight trafficLight)
        {
            Console.WriteLine("Green light - Go!");
            trafficLight.State = new YellowState();  // Transition to Yellow
        }
    }

    public class YellowState : IState
    {
        public void ChangeState(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow light - Slow down!");
            trafficLight.State = new RedState();  // Transition to Red
        }
    }

    public class RedState : IState
    {
        public void ChangeState(TrafficLight trafficLight)
        {
            Console.WriteLine("Red light - Stop!");
            trafficLight.State = new GreenState();  // Transition to Green
        }
    }
}

