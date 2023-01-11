using UnityEngine;
using UnityEngine.UI;
using TMPro;
using KorSpeech.Translate;

namespace KorSpeech.UI
{
    public class InputKorean : MonoBehaviour
    {
        private IWordToPronunce wordToPronunce = new KoreanToPronunce();
        [SerializeField]
        private TMP_InputField koreanInputField;
        [SerializeField]
        private TextMeshProUGUI outpuTextField;

        private void Awake()
        {
            koreanInputField = GetComponent<TMP_InputField>();
        }

        private void Start()
        {
            koreanInputField.onSubmit.AddListener(SubmitKorean);
        }

        public void SubmitKorean(string text)
        {
            outpuTextField.text = wordToPronunce.StringToPronunciation(text);
        }
    }
}