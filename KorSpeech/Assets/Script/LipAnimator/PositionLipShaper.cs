using UnityEngine;
using KorSpeech.Translate.KoreanData;

namespace KorSpeech.LipAnimator
{
    public class PositionLipShaper : MonoBehaviour
    {
        [SerializeField]
        private float oneCharDuration = .5f;
        private float elapsedTime = 0.0f;
        [SerializeField]
        private Transform leftBone;
        [SerializeField]
        private Transform rightBone;
        [SerializeField]
        private Transform upperBone;
        [SerializeField]
        private Transform underBone;
        private LipPosition curLipPosition;
        public LipPosition targetLipPosition;
        private bool nowPlayAnimation = false;
        private int nowPronunceIndex = 0;
        private string nowSpeaking;

        private void Update()
        {
            if(!nowPlayAnimation)    return;

            elapsedTime += Time.deltaTime;            
            float completePercentage = elapsedTime / oneCharDuration;
            if(completePercentage > 1.0f)
            {
                SetNextLipAnimation();
            }

            LerpLip(completePercentage);
        }

        public void StartLipShapeAnimation(string text)
        {
            if(text.Length < 2) return;

            nowSpeaking = text;

            var sign = KoreanToLipSign.korToLipSign[text[0]];
            curLipPosition = SignToLipPosition.lipPosition[sign];
            SetCurLipPosition();

            sign = KoreanToLipSign.korToLipSign[text[1]];
            targetLipPosition = SignToLipPosition.lipPosition[sign];

            nowPronunceIndex = 2;
            nowPlayAnimation = true;
        }

        private void SetNextLipAnimation()
        {
            nowPronunceIndex++;
            if(nowPronunceIndex >= nowSpeaking.Length)
            {
                nowPlayAnimation = false;
                return;
            }
            elapsedTime = 0.0f;
            curLipPosition = targetLipPosition;
            var sign = KoreanToLipSign.korToLipSign[nowSpeaking[nowPronunceIndex]];
            targetLipPosition = SignToLipPosition.lipPosition[sign];
        }

        private void LerpLip(float completePercentage)
        {
            leftBone.localPosition = Vector2.Lerp(curLipPosition.left, targetLipPosition.left, completePercentage);
            rightBone.localPosition = Vector2.Lerp(curLipPosition.right, targetLipPosition.right, completePercentage);
            upperBone.localPosition = Vector2.Lerp(curLipPosition.upper, targetLipPosition.upper, completePercentage);
            underBone.localPosition = Vector2.Lerp(curLipPosition.under, targetLipPosition.under, completePercentage);
        }

        private void SetCurLipPosition()
        {
            leftBone.localPosition = curLipPosition.left;
            rightBone.localPosition = curLipPosition.right;
            upperBone.localPosition = curLipPosition.upper;
            underBone.localPosition = curLipPosition.under;
        }
    }
}