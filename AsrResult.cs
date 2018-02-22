using Newtonsoft.Json;

namespace BaiduSpeechDemo
{
    class AsrResult
    {
        [JsonProperty(PropertyName = "corpus_no")]
        public string CorpusNo;
        [JsonProperty(PropertyName = "err_msg")]
        public string ErrMsg;
        [JsonProperty(PropertyName = "err_no")]
        public int ErrNo;
        [JsonProperty(PropertyName = "result")]
        public string[] Result;
        [JsonProperty(PropertyName = "sn")]
        public string Sn;

        public override string ToString() => this.Serialize();
    }
}
