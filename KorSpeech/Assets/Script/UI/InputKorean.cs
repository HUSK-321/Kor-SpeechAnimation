using UnityEngine;
using UnityEngine.UI;
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
        private TextMeshProUGUI outpuTextField;
        [SerializeField]
        private TTS googleTTS;
        [SerializeField]
        private AnimatorLipShaper lipShaper;

        private void Awake()
        {
            koreanInputField = GetComponentInChildren<TMP_InputField>();
            outpuTextField = GetComponentInChildren<TextMeshProUGUI>();
            googleTTS = GetComponent<GoogleTTS>();
        }

        public void SubmitToGoogleTTS()
        {
            string inputToPronunce = wordToPronunce.StringToPronunciation(koreanInputField.text);
            outpuTextField.text = inputToPronunce;
            googleTTS.PlayTTSAudio(koreanInputField.text, lipShaper.StartLipShapeAnimation, inputToPronunce);
        }
    }
}