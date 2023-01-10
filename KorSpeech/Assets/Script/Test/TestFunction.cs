using System.Collections;
using System.Collections.Generic;

namespace KorSpeech.Test
{
    public class TestFunction
    {
        public static bool IsSame<T>(T lhs, T rhs)
        {
            return lhs.Equals(rhs);
        }
    }
}

