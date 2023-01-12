using UnityEngine;
using System.Collections.Generic;

namespace KorSpeech.Translate.KoreanData
{
    public struct LipPosition
    {
        public Vector2 upper;
        public Vector2 under;
        public Vector2 left;
        public Vector2 right;
        public LipPosition(Vector2 upperLip, Vector2 underLip)
        {
            upper = upperLip;
            under = underLip;

            left = new Vector2(0.3929544f, 2.45583f);
            right = new Vector2(0.4476874f, -2.263482f);
        }
    }

    public class SignToLipPosition : MonoBehaviour
    {
        public static Dictionary<string, LipPosition> lipPosition = new Dictionary<string, LipPosition>();

        private void Awake()
        {
            InitializeLip();
        }
        private void InitializeLip()
        {
            var lip = new LipPosition(new Vector2(1.235408f, 9.245166e-08f), new Vector2(-0.1686016f, 0.003972911f));
            lipPosition.Add("Origin", lip);
            lipPosition.Add("i", lip);
            lipPosition.Add(" ", lip);

            lip.upper.x = 0.9864296f; lip.upper.y = -0.002553403f; 
            lip.under.x = 0.1430493f; lip.under.y = -0.03433235f;
            lipPosition.Add("Close", lip);

            lip.upper.x = 1.5f; lip.upper.y = 9.245166e-08f; 
            lip.under.x = -0.5f; lip.under.y = 0.003972911f;
            lipPosition.Add("innerE", lip);

            lip.upper.x = 1.7f; lip.upper.y = 9.245166e-08f; 
            lip.under.x = -0.6f; lip.under.y = 0.003972911f;
            lipPosition.Add("outerE", lip);

            lip.upper.x = 1.928448f; lip.upper.y = -0.01840806f; 
            lip.under.x = -1.015607f; lip.under.y = 0.06196249f;
            lipPosition.Add("a", lip);

            lip.upper.x = 2.052938f; lip.upper.y = -0.01713133f; 
            lip.under.x = -1.015607f; lip.under.y = 0.06196249f;
            lipPosition.Add("aa", lip);

            lip.upper.x = 1.824714f; lip.upper.y = -0.01947165f; 
            lip.under.x = -0.3101662f; lip.under.y = 0.06919718f;
            lip.left.x = 0.3809319f; lip.left.y = 1.604943f;
            lip.right.x = 0.4408786f; lip.right.y = -1.599541f;
            lipPosition.Add("o", lip);

            lip.upper.x = 1.286111f; lip.upper.y = -0.1079974f; 
            lip.under.x = -0.08108358f; lip.under.y = -0.01145557f;
            lipPosition.Add("u", lip);
        }
    
    }
}