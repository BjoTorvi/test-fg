using System;

namespace TestGithubActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Dont tell anybody, but {Environment.GetEnvironmentVariable("env_secret")}");
        }
    }
}
