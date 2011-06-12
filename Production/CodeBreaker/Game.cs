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
            var marker = new Marker(_secret, guess);

            _output.WriteLine(new string('+', marker.ExactMatchCount()) + new string('-', marker.NumberMatchCount()));
        }
    }
}