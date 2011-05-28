using System;
using SpecSalad;

namespace Codebreaker.Acceptance.Tasks
{
    public class StartTheGame : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.StartTheGame();

            return true;
        }
    }
}