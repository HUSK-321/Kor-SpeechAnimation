using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Networking;

namespace KorSpeech.TTSUtils
{
    public class GoogleTTS : TTS
    {
        private readonly string googleTTsPrefix = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=";
        private readonly string googleTTsSuffix = "&tl=Ko";
        public override void PlayTTSAudio(string text, Action<string> callback, string callbackParameter)
        {
            StartCoroutine(DownloadTTSFromGoogle(text, callback, callbackParameter));
        }

        IEnumerator DownloadTTSFromGoogle(string text, Action<string> callback, string callbackParameter)
        {
            string googleUrl = googleTTsPrefix + text + googleTTsSuffix;
            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(googleUrl, AudioType.MPEG))
            {
                yield return www.SendWebRequest();

                if (www.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    TTSAudioClip.clip = DownloadHandlerAudioClip.GetContent(www);
                }
            }
            TTSAudioClip.Play();
            callback(callbackParameter);
        }
    }
}