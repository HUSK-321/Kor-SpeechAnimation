using UnityEngine;
using UnityEngine.UI;
using TMPro;
using KorSpeech.Translate;
using KorSpeech.TTSUtils;

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

        private void Awake()
        {
            koreanInputField = GetComponentInChildren<TMP_InputField>();
            outpuTextField = GetComponentInChildren<TextMeshProUGUI>();
            googleTTS = GetComponent<GoogleTTS>();
        }

        public void SubmitToGoogleTTS()
        {
            Debug.Log($"{wordToPronunce.StringToPronunciation(koreanInputField.text)}");
            outpuTextField.text = wordToPronunce.StringToPronunciation(koreanInputField.text);
            googleTTS.PlayTTSAudio(koreanInputField.text, () => {});
        }
    }
}