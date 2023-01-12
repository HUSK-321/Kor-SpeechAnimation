using System.Collections.Generic;

namespace KorSpeech.Translate.KoreanData
{
    public class KoreanToLipSign
    {
        public static readonly Dictionary<char, string> korToLipSign = new Dictionary<char, string>()
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
            {'ㅉ', "Origin"},

            {'ㅏ', "a"},
            {'ㅐ', "outerE"},
            {'ㅑ', "a"},
            {'ㅒ', "outerE"},
            {'ㅓ', "aa"},

            {'ㅔ', "innerE"},
            {'ㅕ', "aa"},
            {'ㅖ', "outerE"},
            {'ㅗ', "o"},
            {'ㅘ', "a"},

            {'ㅙ', "outerE"},
            {'ㅚ', "outerE"},
            {'ㅛ', "o"},
            {'ㅜ', "u"},
            {'ㅝ', "aa"},

            {'ㅞ', "innerE"},
            {'ㅟ', "i"},
            {'ㅠ', "u"},
            {'ㅡ', "Origin"},
            {'ㅢ', "Origin"},

            {'ㅣ', "i"},

            {'ㄳ', "Origin"},
            {'ㄵ', "Origin"},
            {'ㄼ', "Origin"},
            {'ㄽ', "Origin"},
            
            {'ㄾ', "Origin"},
            {'ㅄ', "Origin"},
            // 어말 끝에서 이럼
            {'ㄺ', "Origin"},
            {'ㄻ', "Origin"},
            {'ㄿ', "Origin"},

            {' ', "Origin"}
        };
        /*
        public static readonly Dictionary<char, string> firstSeongToLipSign = new Dictionary<char, string>()
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
        public static readonly Dictionary<char, string> midSeongToLipSign = new Dictionary<char, string>()
        {
            {'ㅏ', "ㅏ"},
            {'outerE', "outerE"},
            {'ㅑ', "ㅏ"},
            {'ㅒ', "outerE"},
            {'aa', "aa"},

            {'innerE', "innerE"},
            {'ㅕ', "aa"},
            {'ㅖ', "outerE"},
            {'ㅗ', "ㅗ"},
            {'ㅘ', "ㅏ"},

            {'ㅙ', "outerE"},
            {'ㅚ', "outerE"},
            {'ㅛ', "ㅗ"},
            {'ㅜ', "ㅜ"},
            {'ㅝ', "aa"},

            {'ㅞ', "innerE"},
            {'ㅟ', "ㅣ"},
            {'ㅠ', "ㅜ"},
            {'ㅡ', "ㅡ"},
            {'ㅢ', "ㅡ"},

            {'ㅣ', "ㅣ"}
        };

        public static readonly Dictionary<char, char> endSeongToLipSign = new Dictionary<char, char>()
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
        */
    }
}