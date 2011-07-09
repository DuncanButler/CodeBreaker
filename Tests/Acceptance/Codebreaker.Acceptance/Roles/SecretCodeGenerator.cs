using CodeBreaker;
using Moq;
using SpecSalad;

namespace Codebreaker.Acceptance.Roles
{
    public class SecretCodeGenerator : ApplicationRole
    {
        public void SetSecretCodeTo(string code)
        {
            var codeGenerator = new Mock<ISecretCodeGenerator>();

            codeGenerator.Setup(x => x.GenerateCode()).Returns(code);

            this.StoreValue("SecretCodeGenerator", codeGenerator.Object);
        }
    }
}