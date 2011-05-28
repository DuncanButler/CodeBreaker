using System;
using SpecSalad;

namespace Codebreaker.Acceptance.Tasks
{
    public class SeeScreenText: ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.LookAtOutput();            
        }
    }
}