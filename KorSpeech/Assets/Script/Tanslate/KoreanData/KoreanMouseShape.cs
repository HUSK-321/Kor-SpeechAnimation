using System.Collections.Generic;

namespace KorSpeech.Translate.KoreanData
{
    public class KoreanMouseShape
    {
        public static readonly Dictionary<char, string> CloseMouse = new Dictionary<char, string>()
        {
            {'ㄱ', "Origin"},
            {'ㄴ', "Origin"},
            {'ㄷ', "Origin"},
            {'ㄹ', "Origin"},
            {'ㅁ', "Close"},

            {'ㅂ', "Close"},
            {'ㅅ', "Origin"},
            {'ㅇ', "Origin"},
            {'ㅈ', "Origin"},
            {'ㅊ', "Origin"},

            {'ㅋ', "Origin"},
            {'ㅌ', "Origin"},
            {'ㅍ', "Close"},
            {'ㅎ', "Origin"},
            {'ㄲ', "Origin"},

            {'ㄸ', "Origin"},
            {'ㅃ', "Close"},
            {'ㅆ', "Origin"},
            {'ㅉ', "Origin"}
        };

        // 1 - 이, 2 - 에, 3 - 애, 4 - 아, 5 - 어, 6 - 오, 7 - 우, 8 - 으
        public static readonly Dictionary<char, string> VowelsMouseShape = new Dictionary<char, string>()
        {
            {'ㅏ', "ㅏ"},
            {'ㅐ', "ㅐ"},
            {'ㅑ', "ㅏ"},
            {'ㅒ', "ㅐ"},
            {'ㅓ', "ㅓ"},

            {'ㅔ', "ㅔ"},
            {'ㅕ', "ㅓ"},
            {'ㅖ', "ㅐ"},
            {'ㅗ', "ㅗ"},
            {'ㅘ', "ㅏ"},

            {'ㅙ', "ㅐ"},
            {'ㅚ', "ㅐ"},
            {'ㅛ', "ㅗ"},
            {'ㅜ', "ㅜ"},
            {'ㅝ', "ㅓ"},

            {'ㅞ', "ㅔ"},
            {'ㅟ', "ㅣ"},
            {'ㅠ', "ㅜ"},
            {'ㅡ', "ㅡ"},
            {'ㅢ', "ㅡ"},

            {'ㅣ', "ㅣ"}
        };

        public static readonly Dictionary<char, char> EndSound = new Dictionary<char, char>()
        {
            {'ㄱ', 'ㄱ'},
            {'ㄲ', 'ㄱ'},
            {'ㄴ', 'ㄴ'},
            {'ㄷ', 'ㄷ'},
            {'ㄹ', 'ㄹ'},

            {'ㅁ', 'ㅁ'},
            {'ㅂ', 'ㅂ'},
            {'ㅅ', 'ㄷ'},
            {'ㅆ', 'ㄷ'},
            {'ㅇ', 'ㅇ'},

            {'ㅈ', 'ㄷ'},
            {'ㅊ', 'ㄷ'},
            {'ㅋ', 'ㄱ'},
            {'ㅌ', 'ㄷ'},
            {'ㅍ', 'ㅂ'},

            {'ㅎ', 'ㅎ'},
            {'ㄳ', 'ㄱ'},
            {'ㄵ', 'ㄴ'},
            {'ㄼ', 'ㄹ'},
            {'ㄽ', 'ㄹ'},
            
            {'ㄾ', 'ㄹ'},
            {'ㅄ', 'ㅂ'},
            // 어말 끝에서 이럼
            {'ㄺ', 'ㄱ'},
            {'ㄻ', 'ㅁ'},
            {'ㄿ', 'ㅂ'}
        };

    }
}