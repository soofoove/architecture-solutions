using Lab6.Components;
using Lab6.Visitors;

namespace Lab6
{
    public class Client
    {
        public static void Process(string name, List<IVisitable> visitables, IVisitor visitor)
        {
            Console.WriteLine(name + Environment.NewLine);

            var report = string.Empty;

            foreach (var component in visitables)
            {
                report += component.Accept(visitor) + Environment.NewLine;
            }

            Console.WriteLine(report);
        }
    }
}
