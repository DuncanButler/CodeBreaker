using System;
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

        public void StartTheGame()
        {
            _screen = new StubScreen();
            var codeGenerator = new Mock<ISecretCodeGenerator>();
            codeGenerator.Setup(x => x.GenerateCode()).Returns("0");
            var game = new Game(_screen, codeGenerator.Object);

            game.Start();
        }

        public IEnumerable<string> LookAtOutput()
        {
            return ((StubScreen)_screen).ReadMessages;
        }

        public void SetSecretCodeTo(string code)
        {
            _screen = new StubScreen();

            var codeGenerator = new Mock<ISecretCodeGenerator>();
            codeGenerator.Setup(x => x.GenerateCode()).Returns(code);

            _game = new Game(_screen, codeGenerator.Object);
        }

        public void SubmitGuess(string guess)
        {
            _game.Guess(guess);
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