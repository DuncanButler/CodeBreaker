using System.Collections.Generic;
using CodeBreaker;
using Moq;
using SpecSalad;

namespace Codebreaker.Acceptance.Roles
{
    public class Codebreaker: ApplicationRole
    {
        IOutput _screen;
        Game _game;

        ISecretCodeGenerator SecretCodeGenerator
        {
            get
            {
                var toReturn = (ISecretCodeGenerator) Retrieve("SecretCodeGenerator");

                if (toReturn == null)
                {
                    var mock  = new Mock<ISecretCodeGenerator>();
                    mock.Setup(x => x.GenerateCode()).Returns("0");

                    toReturn = mock.Object;
                }

                return toReturn;
            }
        }

        public void StartTheGame()
        {
            _screen = new StubScreen();

            _game = new Game(_screen, SecretCodeGenerator);

            _game.Start();
        }

        public void SubmitGuess(string guess)
        {
            StartTheGame();

            _game.Guess(guess);
        }

        public IEnumerable<string> LookAtOutput()
        {
            return ((StubScreen)_screen).ReadMessages;
        }
    }

    public class StubScreen : IOutput
    {
        readonly IList<string> _readMessages = new List<string>();

        public void WriteLine(string message)
        {
            _readMessages.Add(message);
        }

        public IEnumerable<string> ReadMessages { get { return _readMessages; } }
    }
}