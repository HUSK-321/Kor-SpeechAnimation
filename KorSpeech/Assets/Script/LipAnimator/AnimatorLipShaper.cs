using UnityEngine;
using KorSpeech.Translate.KoreanData;

namespace KorSpeech.LipAnimator
{
    public class AnimatorLipShaper : MonoBehaviour
    {
        [SerializeField]
        private float oneCharDuration = .5f;
        private float elapsedTime = 0.0f;
        [SerializeField]
        private Animator anim;
        private bool nowPlayAnimation = false;
        private int nowPronunceIndex = 0;
        private string nowSpeaking;

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        private void Update()
        {
            if(!nowPlayAnimation)    return;

            elapsedTime += Time.deltaTime;
            if(elapsedTime < oneCharDuration)   return;
            
            if(nowPronunceIndex >= nowSpeaking.Length)
            {
                elapsedTime = 0.0f;
                nowPlayAnimation = false;
                return;
            }

            var triggerSign = KoreanToLipSign.korToLipSign[nowSpeaking[nowPronunceIndex]];
            anim.SetTrigger(triggerSign);
            elapsedTime = 0.0f;
            nowPronunceIndex++;
        }

        public void StartLipShapeAnimation(string text)
        {
            if(text.Length < 2) return;

            nowSpeaking = text;

            nowPronunceIndex = 0;
            nowPlayAnimation = true;
        }
        
    }
}