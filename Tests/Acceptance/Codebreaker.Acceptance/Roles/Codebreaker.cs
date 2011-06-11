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

        public void StartTheGame(string code = "0")
        {
            _screen = new StubScreen();
            var codeGenerator = new Mock<ISecretCodeGenerator>();

            codeGenerator.Setup(x => x.GenerateCode()).Returns(code);

            _game = new Game(_screen, codeGenerator.Object);

            _game.Start();
        }

        public void SetSecretCodeTo(string code)
        {
            StartTheGame(code);
        }

        public IEnumerable<string> LookAtOutput()
        {
            return ((StubScreen)_screen).ReadMessages;
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