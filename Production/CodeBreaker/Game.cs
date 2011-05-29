using System;

namespace CodeBreaker
{
    public class Game
    {
        readonly IOutput _output;

        public Game(IOutput output)
        {
            _output = output;
        }

        public void Start()
        {
            _output.WriteLine("Welcome to Codebreaker!");
            _output.WriteLine("Enter guess:");
        }
    }
}