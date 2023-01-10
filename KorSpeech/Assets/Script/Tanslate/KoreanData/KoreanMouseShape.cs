using System.Collections.Generic;

namespace KorSpeech.Translate.KoreanData
{
    public class KoreanMouseShape
    {
        public static readonly Dictionary<char, bool> CloseMouse = new Dictionary<char, bool>()
        {
            {'ㄱ', false},
            {'ㄴ', false},
            {'ㄷ', false},
            {'ㄹ', false},
            {'ㅁ', true},

            {'ㅂ', true},
            {'ㅅ', false},
            {'ㅇ', false},
            {'ㅈ', false},
            {'ㅊ', false},

            {'ㅋ', false},
            {'ㅌ', false},
            {'ㅍ', true},
            {'ㅎ', false},
            {'ㄲ', false},

            {'ㄸ', false},
            {'ㅃ', true},
            {'ㅆ', false},
            {'ㅉ', false}
        };

        // 1 - 이, 2 - 에, 3 - 애, 4 - 아, 5 - 어, 6 - 오, 7 - 우, 8 - 으
        public static readonly Dictionary<char, byte> VowelsMouseShape = new Dictionary<char, byte>()
        {
            {'ㅏ', 0b0000_1000},
            {'ㅐ', 0b0000_0100},
            {'ㅑ', 0b0000_1000},
            {'ㅒ', 0b0000_0100},
            {'ㅓ', 0b0001_0000},

            {'ㅔ', 0b0000_0010},
            {'ㅕ', 0b0001_0000},
            {'ㅖ', 0b0000_0100},
            {'ㅗ', 0b0010_0000},
            {'ㅘ', 0b0000_1000},

            {'ㅙ', 0b0000_0100},
            {'ㅚ', 0b0000_0100},
            {'ㅛ', 0b0010_0000},
            {'ㅜ', 0b0100_0000},
            {'ㅝ', 0b0001_0000},

            {'ㅞ', 0b0000_0010},
            {'ㅟ', 0b0000_0001},
            {'ㅠ', 0b0100_0000},
            {'ㅡ', 0b1000_0000},
            {'ㅢ', 0b1000_0000},

            {'ㅣ', 0b0000_0001}
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