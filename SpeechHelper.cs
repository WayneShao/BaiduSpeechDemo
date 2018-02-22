using System.Collections.Generic;
using System.IO;
using Baidu.Aip.Speech;

namespace BaiduSpeechDemo
{
    static class SpeechHelper
    {
        private static readonly Asr AsrClient;
        private static readonly Tts TtsClient;

        static SpeechHelper()
        {
            AsrClient = new Asr("BWf8AWrvS5h6Y45NAOP3zaGp", "490737eca7a6ff4d20375d1696c7e548");
            TtsClient = new Tts("BWf8AWrvS5h6Y45NAOP3zaGp", "490737eca7a6ff4d20375d1696c7e548");
        }

        // 识别本地文件
        public static AsrResult AsrData(string path)
        {
            var data = File.ReadAllBytes(path);
            var result = AsrClient.Recognize(data, "pcm", 8000);
            return result.ToObject<AsrResult>();
        }

        // 识别URL中的语音文件
        public static AsrResult AsrUrl(string url, string callback = "")
        {
            var result = AsrClient.Recoginze(
                url,
                callback,
                "pcm",
                16000);
            return result.ToObject<AsrResult>();
        }

        // 合成
        public static bool Tts(string input, string path, int spd = 5, int pit = 5, int vol = 6, int per = 4)
        {
            // 可选参数
            var option = new Dictionary<string, object>
            {
                {"spd", spd}, // 语速，取值0-9，默认为5中语速
                {"pit", pit}, // 音调，取值0-9，默认为5中语调
                {"vol", vol}, // 音量，取值0-15，默认为5中音量
                {"per", per}  // 发音人选择, 0为普通女声，1为普通男生，3为情感合成-度逍遥，4为情感合成-度丫丫，默认为普通女声
            };
            var result = TtsClient.Synthesis(input, option);

            if (result.Success) File.WriteAllBytes(path, result.Data);

            //Console.WriteLine(result.Serialize());

            return result.Success;
        }

    }
}