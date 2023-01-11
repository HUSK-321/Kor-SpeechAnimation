using UnityEngine;
using KorSpeech.Translate;
using System.Text;

namespace KorSpeech.Test
{
    public class KoreanWordSliceTest : MonoBehaviour
    {
        private IWordToPronunce wordToPronunce = new KoreanToPronunce();

        [ContextMenu("Check Korean Word Slice")]
        public void TestKoreanWordSlice()
        {
            KoreanSliceAndLogSuccess("가", "ㄱㅏ", 1);
            KoreanSliceAndLogSuccess("안녕하세요", "ㅇㅏㄴㄴㅕㅇㅎㅏㅅㅔㅇㅛ", 1);
            KoreanSliceAndLogSuccess("뷁", "ㅂㅞㄺ", 1);
            KoreanSliceAndLogSuccess("아니 진짜", "ㅇㅏㄴㅣ ㅈㅣㄴㅉㅏ", 1);
            KoreanSliceAndLogSuccess("영eng어", "ㅇㅕㅇㅇㅓ", 1);
            KoreanSliceAndLogSuccess("영eng어%", "ㅇㅕㅇㅇㅓ", 1);
            KoreanSliceAndLogSuccess("이건 어떨까\n", "ㅇㅣㄱㅓㄴ ㅇㅓㄸㅓㄹㄲㅏ", 1);
        }

        private void KoreanSliceAndLogSuccess(string lhs, string rhs, int testNum)
        {
            var testString = wordToPronunce.StringToPronunciation(lhs);
            bool testSuccess = TestFunction.IsSame<string>(testString, rhs);
            Debug.Log($"Is test{testNum} success : {testSuccess}");
        }
    }
}