using System;
using System.Collections.Generic;
using CodeBreaker;
using SpecSalad;

namespace Codebreaker.Acceptance.Roles
{
    public class Codebreaker: ApplicationRole
    {
        IOutput _screen;

        public void StartTheGame()
        {
            _screen = new StubScreen();
            var game = new Game(_screen);

            game.Start();
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