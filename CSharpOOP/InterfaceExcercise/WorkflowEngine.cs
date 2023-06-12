using System;

namespace CSharpOOP.InterfaceExcercise
{
    public interface IActivity
    {
        void Execute();
    }

    public class WorkflowEngine
    {
        public void Run(List<IActivity> workflow)
        {
            foreach (var activity in workflow)
            {
                activity.Execute();
            }
        }
    }

    public class Activity1 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activity 1");
        }
    }

    public class Activity2 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activity 2");
        }
    }

    public class Activity3 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activity 3");
        }
    }

}
