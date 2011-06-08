using System;
using SpecSalad;

namespace Codebreaker.Acceptance.Tasks
{
    public class SubmitAGuess : ApplicationTask
    {
        public override object Perform_Task()
        {
            var guess = Details.Value();

            Role.SubmitGuess(guess);

            return true;
        }
    }
}