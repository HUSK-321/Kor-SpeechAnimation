using UnityEngine;
using TMPro;
using KorSpeech.Translate;
using KorSpeech.TTSUtils;
using KorSpeech.LipAnimator;

namespace KorSpeech.UI
{
    public class InputKorean : MonoBehaviour
    {
        private IWordToPronunce wordToPronunce = new KoreanToPronunce();
        [SerializeField]
        private TMP_InputField koreanInputField;
        [SerializeField]
        private TTS googleTTS;
        [SerializeField]
        private AnimatorLipShaper lipShaper;

        private void Awake()
        {
            koreanInputField = GetComponentInChildren<TMP_InputField>();
            googleTTS = GetComponent<GoogleTTS>();
        }

        private void Update()
        {
            if(!Input.GetKeyDown(KeyCode.KeypadEnter)) return;

            SubmitToGoogleTTS();
        }

        public void SubmitToGoogleTTS()
        {
            string inputToPronunce = wordToPronunce.StringToPronunciation(koreanInputField.text);
            googleTTS.PlayTTSAudio(koreanInputField.text, lipShaper.StartLipShapeAnimation, inputToPronunce);
        }
    }
}