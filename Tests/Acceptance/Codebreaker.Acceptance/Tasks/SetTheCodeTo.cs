using System;
using SpecSalad;

namespace Codebreaker.Acceptance.Tasks
{
    public class SetTheCodeTo : ApplicationTask
    {
        public override object Perform_Task()
        {
            var code = Details.Value();

            Role.SetSecretCodeTo(code);

            return true;
        }
    }
}