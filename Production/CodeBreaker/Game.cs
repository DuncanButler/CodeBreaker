using System;

namespace CodeBreaker
{
    public class Game
    {
        readonly IOutput _output;
        readonly ISecretCodeGenerator _codeGenerator;
        string _secret;

        public Game(IOutput output, ISecretCodeGenerator codeGenerator)
        {
            _output = output;
            _codeGenerator = codeGenerator;
        }

        public void Start()
        {
            _secret = _codeGenerator.GenerateCode();

            _output.WriteLine("Welcome to Codebreaker!");
            _output.WriteLine("Enter guess:");
        }

        public void Guess(string guess)
        {
            string mark = "";

            for (int i = 0; i < guess.Length; i++)
                if (ExactMatch(guess, i))
                    mark += "+";

            for (var i = 0; i < guess.Length; i++)
                if (NumberMatch(guess, i))
                    mark += "-";

            _output.WriteLine(mark);
        }

        bool NumberMatch(string guess, int index)
        {
            return _secret.Contains(guess[index].ToString()) && ! ExactMatch(guess, index);
        }

        bool ExactMatch(string guess, int index)
        {
            return guess[index] == _secret[index];
        }
    }
}