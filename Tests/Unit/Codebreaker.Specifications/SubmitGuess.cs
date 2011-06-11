using CodeBreaker;
using FakeItEasy;
using Machine.Specifications;

namespace Codebreaker.Specifications
{
    [Subject("CodeBreaker")]
    public class Submitting_an_incorrect_guess : CodeBreakerContext
    {
        Because of =
            () => _game.Guess("5555");

        It outputs_to_the_screen_an_empty_string =
            () => A.CallTo(() => _output.WriteLine("")).MustHaveHappened();
    }

    [Subject("CodeBreaker")]
    public class Submitting_an_guess_with_one_number_match : CodeBreakerContext
    {
        Because of =
            () => _game.Guess("2555");

        It outputs_to_the_screen_a_single_minus_sign =
            () => A.CallTo(() => _output.WriteLine("-")).MustHaveHappened();
    }

    [Subject("CodeBreaker")]
    public class Submitting_a_guess_with_an_exact_match : CodeBreakerContext
    {
        Because of =
            () => _game.Guess("1555");

        It outputs_to_the_screen_a_single_plus =
            () => A.CallTo(() => _output.WriteLine("+")).MustHaveHappened();
    }

    [Subject("$Subject of Specification$")]
    public class Submitting_a_guess_with_two_number_matches : CodeBreakerContext
    {
        Because of =
            () => _game.Guess("2355");

        It ouputs_to_the_screen_two_minus_signs =
            () => A.CallTo(() => _output.WriteLine("--")).MustHaveHappened();
    }

    public class CodeBreakerContext
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