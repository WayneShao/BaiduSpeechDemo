using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BaiduSpeechDemo
{
    /// <summary>
    ///     JSON操作助手类
    /// </summary>
    /// <remarks>
    ///     2013-11-18 18:56 Created By iceStone
    /// </remarks>
    public static class JsonHelper
    {
        private static readonly JsonSerializer JsonSerializer = new JsonSerializer();

        /// <summary>
        ///     将一个对象序列化JSON字符串
        /// </summary>
        /// <remarks>
        ///     2013-11-18 18:56 Created By iceStone
        /// </remarks>
        /// <param name="obj">待序列化的对象</param>
        /// <returns>JSON字符串</returns>
        public static string Serialize(object obj)
        {
            var sw = new StringWriter();
            JsonSerializer.Serialize(new JsonTextWriter(sw), obj);
            return sw.GetStringBuilder().ToString();
        }
        public static string SerializeIndented(object obj) => ConvertJsonStringIndented(Serialize(obj));

        /// <summary>
        ///     将JSON字符串反序列化为一个Object对象
        /// </summary>
        /// <remarks>
        ///     2013-11-18 18:56 Created By iceStone
        /// </remarks>
        /// <param name="json">JSON字符串</param>
        /// <returns>Object对象</returns>
        public static object Deserialize(string json)
        {
            var sr = new StringReader(json);
            return JsonSerializer.Deserialize(new JsonTextReader(sr));
        }

        /// <summary>
        ///     将JSON字符串反序列化为一个指定类型对象
        /// </summary>
        /// <remarks>
        ///     2013-11-18 18:56 Created By iceStone
        /// </remarks>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">JSON字符串</param>
        /// <returns>指定类型对象</returns>
        public static T Deserialize<T>(string json) where T : class
        {
            var sr = new StringReader(json);
            return JsonSerializer.Deserialize(new JsonTextReader(sr), typeof(T)) as T;
        }

        /// <summary>
        ///     将JSON字符串反序列化为一个JObject对象
        /// </summary>
        /// <remarks>
        ///     2013-11-18 18:56 Created By iceStone
        /// </remarks>
        /// <param name="json">JSON字符串</param>
        /// <returns>JObject对象</returns>
        public static JObject DeserializeObject(string json)
        {
            return JsonConvert.DeserializeObject(json) as JObject;
        }

        /// <summary>
        ///     将JSON字符串反序列化为一个JArray数组
        /// </summary>
        /// <remarks>
        ///     2013-11-18 18:56 Created By iceStone
        /// </remarks>
        /// <param name="json">JSON字符串</param>
        /// <returns>JArray对象</returns>
        public static JArray DeserializeArray(string json)
        {
            return JsonConvert.DeserializeObject(json) as JArray;
        }
        private static string ConvertJsonStringIndented(string str)
        {
            TextReader tr = new StringReader(str);
            var jtr = new JsonTextReader(tr);

            var obj = JsonSerializer.Deserialize(jtr);
            if (obj == null) return str;
            var textWriter = new StringWriter();
            var jsonWriter = new JsonTextWriter(textWriter)
            {
                Formatting = Formatting.Indented,
                Indentation = 4,
                IndentChar = ' '
            };
            JsonSerializer.Serialize(jsonWriter, obj);
            return textWriter.ToString();

        }

    }

    static class JsonMethods
    {
        public static string Serialize(this object obj) => JsonHelper.Serialize(obj);

        public static string SerializeIndented(this object obj) => JsonHelper.SerializeIndented(obj);

        public static bool TrySerialize(this object obj, out string str)
        {
            try
            {
                str = JsonHelper.Serialize(obj);
                return true;
            }
            catch (Exception e)
            {
                str = string.Empty;
                return false;
            }
        }

        public static T Deserialize<T>(this string json) where T : class => JsonHelper.Deserialize<T>(json);

        public static bool TryDeserialize<T>(this string json, out T value) where T : class
        {
            try
            {
                value = JsonHelper.Deserialize<T>(json);
                return true;
            }
            catch (Exception e)
            {
                value = null;
                return false;
            }
        }
    }
}