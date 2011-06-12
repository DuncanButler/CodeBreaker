using CodeBreaker;
using Machine.Specifications;

namespace Codebreaker.Specifications
{
    [Subject("Marker")]
    public class extact_match_count_with_no_matches : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234","5555");
                };

        It returns_zero =
            () => _marker.ExactMatchCount().ShouldEqual(0);
    }

    [Subject("Marker")]
    public class Extact_match_count_with_one_match : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234","1555");
                };

        It returns_one =
            () => _marker.ExactMatchCount().ShouldEqual(1);
    }

    [Subject("Marker")]
    public class Extact_match_count_with_one_number_match : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234","2555");
                };

        It returns_zero =
            () => _marker.ExactMatchCount().ShouldEqual(0);
    }

    [Subject("Marker")]
    public class Extact_match_count_with_one_exact_match_and_one_number_match : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234","1525");
                };
        
        It returns_one =
            () => _marker.ExactMatchCount().ShouldEqual(1);
    }

    [Subject("Marker")]
    public class Number_match_count_with_no_matches : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234","5555");
                };

        It returns_zero =
            () => _marker.NumberMatchCount().ShouldEqual(0);
    }

    [Subject("Marker")]
    public class Number_match_count_with_one_match : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234","2555");
                };

        It returns_one =
            () => _marker.NumberMatchCount().ShouldEqual(1);
    }

    [Subject("Marker")]
    public class Number_match_count_with_one_exact_match : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234","1555");
                };

        It returns_zero =
            () => _marker.NumberMatchCount().ShouldEqual(0);
    }

    [Subject("Marker")]
    public class Number_match_count_with_one_exact_match_and_ : MarkerContext
    {
        Establish context =
            () =>
                {
                    _marker = new Marker("1234", "1525");
                };

        It returns_one =
            () => _marker.NumberMatchCount().ShouldEqual(1);
    }

    public class MarkerContext
    {
        protected static Marker _marker;         
    }
}