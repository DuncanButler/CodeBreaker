using CodeBreaker;
using FakeItEasy;
using Machine.Specifications;

namespace Codebreaker.Specifications
{
    [Subject("Game")]
    public class calling_Guess : GameContext
    {
        Because of =
            () => _game.Guess("1234");

        It sends_the_mark_to_the_output =
            () => A.CallTo(() => _output.WriteLine("++++")).MustHaveHappened();
    }

    public class GameContext
    {

        Establish context =
       () =>
       {          
           _output = A.Fake<IOutput>();

           var codeGenerator = A.Fake<ISecretCodeGenerator>();
           A.CallTo(() => codeGenerator.GenerateCode()).Returns("1234");

           _game = new Game(_output, codeGenerator);
           _game.Start();
       };

        protected static IOutput _output;
        protected static Game _game;
    }
}