using System.Text;
using KorSpeech.Translate.KoreanData;
using UnityEngine;

namespace KorSpeech.Translate
{
    public class KoreanToPronunce : IWordToPronunce
    {
        private readonly int KOR_UNICODE_START = 0xAC00;  
        private readonly int KOR_UNICODE_END = 0xD7AF;

        public string StringToPronunciation(string input)
        {
            StringBuilder result = new StringBuilder();

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    result.Append(' ');
                    continue;
                }
                SliceOneKorWord(input[i], result);
            }

            return result.ToString();
        }

        private void SliceOneKorWord(char word, StringBuilder array)
        {
            if(word > KOR_UNICODE_END || word < KOR_UNICODE_START)    return;
            int indexGap = word - KOR_UNICODE_START;

            int first = indexGap / 21 / 28;
            int mid  = (indexGap - (first * 21 * 28)) / 28;
            int end   = indexGap - (first * 21 * 28) - (mid * 28) - 1;
            array.Append(KoreanSeong.firstSeong[first]);
            array.Append(KoreanSeong.midSeong[mid]);

            if(end >= 0)
                array.Append(KoreanSeong.endSeong[end]);
        }

        private void ConsonantAssimiliation(StringBuilder array)
        {
            for(int i = 0; i < array.Length - 2; i++)
            {
                if(array[i + 1] == 'ㅇ' && array[i + 2] == 'ㅣ')
                {
                    if(array[i] == 'ㄷ')
                    {
                        array[i] = 'ㅈ';
                    }
                    if(array[i] == 'ㅌ' || array[i] == 'ㄾ')
                    {
                        array[i] = 'ㅊ';
                    }
                    continue;
                }
                if(array[i] == 'ㅁ' || array[i] == 'ㅇ' || array[i] == 'ㄱ' || array[i] == 'ㅂ')
                {
                    if(array[i + 1] == 'ㄹ')
                        array[i + 1] = 'ㄴ';
                }
            }
        }
    }
}