using System.Linq;

namespace CodeBreaker
{
    public class Marker
    {
        readonly string _secret;
        readonly string _guess;

        public Marker(string secret, string guess)
        {
            _secret = secret;
            _guess = guess;
        }

        public int NumberMatchCount()
        {
            return _guess.Where((t, i) => NumberMatch(i)).Count();
        }

        public int ExactMatchCount()
        {
            return _guess.Where((t, i) => ExactMatch(i)).Count();
        }

        bool NumberMatch(int index)
        {
            return _secret.Contains(_guess[index].ToString()) && !ExactMatch(index);
        }

        bool ExactMatch(int index)
        {
            return _guess[index] == _secret[index];
        }
    }
}