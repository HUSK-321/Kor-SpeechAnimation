using UnityEngine;
using KorSpeech.Translate;
using System.Text;

namespace KorSpeech.Test
{
    public class KoreanWordSliceTest : MonoBehaviour
    {
        private IWordToPronunce wordToPronunce = new KoreanToPronunce();
        private int testNum = 1;

        [ContextMenu("Check Korean Word Slice")]
        public void TestKoreanWordSlice()
        {
            KoreanSliceAndLogSuccess("가", "ㄱㅏ");
            KoreanSliceAndLogSuccess("안녕하세요", "ㅇㅏㄴㄴㅕㅇㅎㅏㅅㅔㅇㅛ");
            KoreanSliceAndLogSuccess("뷁", "ㅂㅞㄺ");
            KoreanSliceAndLogSuccess("아니 진짜", "ㅇㅏㄴㅣ ㅈㅣㄴㅉㅏ");
            KoreanSliceAndLogSuccess("영eng어", "ㅇㅕㅇㅇㅓ");
            KoreanSliceAndLogSuccess("영eng어%", "ㅇㅕㅇㅇㅓ");
            KoreanSliceAndLogSuccess("이건 어떨까\n", "ㅇㅣㄱㅓㄴ ㅇㅓㄸㅓㄹㄲㅏ");
            KoreanSliceAndLogSuccess("여기에 글자 입력", "ㅇㅕㄱㅣㅇㅔ ㄱㅡㄹㅈㅏ ㅇㅣㅂㄹㅕㄱ");
        }

        private void KoreanSliceAndLogSuccess(string lhs, string rhs)
        {
            var testString = wordToPronunce.StringToPronunciation(lhs);
            bool testSuccess = TestFunction.IsSame<string>(testString, rhs);
            Debug.Log($"Is test{testNum++} success : {testSuccess}");
        }
    }
}