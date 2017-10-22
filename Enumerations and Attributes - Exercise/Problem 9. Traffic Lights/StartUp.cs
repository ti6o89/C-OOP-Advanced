using System;
using System.Collections.Generic;

namespace Problem_9.Traffic_Lights
{
    class StartUp
    {
        static void Main()
        {
            List<TrafficLight> allTraficlights = new List<TrafficLight>();

            string[] inputSignal = Console.ReadLine().Split();
            int stateChangeCount = int.Parse(Console.ReadLine());

            foreach (var signal in inputSignal)
            {
                LightColor initialColorState = (LightColor)Enum.Parse(typeof(LightColor), signal);
                allTraficlights.Add(new TrafficLight(initialColorState));
            }

            for (int i = 0; i < stateChangeCount; i++)
            {
                foreach (var trafficLight in allTraficlights)
                {
                    trafficLight.ChangeState();
                }
                Console.WriteLine(String.Join(" ", allTraficlights));
            }
        }
    }
}
