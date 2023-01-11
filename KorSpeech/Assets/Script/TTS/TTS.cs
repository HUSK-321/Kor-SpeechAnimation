using System;
using UnityEngine;

namespace KorSpeech.TTSUtils
{
    public abstract class TTS : MonoBehaviour
    {
        [SerializeField]
        protected AudioSource TTSAudioClip;

        private void Awake()
        {
            TTSAudioClip = GetComponent<AudioSource>();
        }

        public abstract void PlayTTSAudio(string text, Action callack);
    }
}