namespace task7;

class Program
{
    static void Main(string[] args)
    {
        List<User> users = [
            new() { UserName = "FloatFisher", Password = "IoriRiver5g#" },
            new() { UserName = "IndustrialMetal", Password = "MutterLinks234$" },
            new() { UserName = "OllamaHost", Password = "Rtx5060Vram8gb!" },
            new() { UserName = "DfaParser", Password = "RegexEngine2026" },
            new() { UserName = "EldenLord", Password = "TarnishedSteam1" },
            new() { UserName = "ArchDualBoot", Password = "WaylandXfce#" },
            new() { UserName = "ProteinChef", Password = "MchadiChicken100" },
            new() { UserName = "HacktoberDev", Password = "GitPullRequest!" },
            new() { UserName = "UnityBuilder", Password = "LowPoly1940s*" }
        ];
        
        var result = users.OrderBy(x => x.UserName)
                           .ThenBy(x => x.Password.Length)
                           .Take(5);

        foreach (var user in result)
        {
            Console.WriteLine(user);
        }
    }
    
}