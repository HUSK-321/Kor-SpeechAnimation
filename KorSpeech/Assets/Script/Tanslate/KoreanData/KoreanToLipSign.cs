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
    }
}