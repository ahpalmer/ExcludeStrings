namespace ExcludeMachines;

internal class Program
{
    static void Main(string[] args)
    {
        ExcludeMachines();
    }

    public static void ExcludeMachines()
    {
        List<string> machines = Utility.CreateStringList("machineNames.txt");
        List<string> excludeMachines = Utility.CreateStringList("excludeMachines.txt");
        List<string> result = machines.Except(excludeMachines).ToList();

        Console.WriteLine(result.Count());
        foreach (string machine in result)
        {
            Console.WriteLine(machine);
        }
    }
}
