using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace BaiduSpeechDemo
{
    public partial class SpeechFrm : Form
    {
        public SpeechFrm()
        {
            InitializeComponent();
            if (!Directory.Exists("temp"))
                Directory.CreateDirectory("temp");
        }

        private string _fileName;
        private WaveIn _recorder;
        private BufferedWaveProvider _bufferedWaveProvider;
        private SavingWaveProvider _savingWaveProvider;
        private WaveOut _player;


        private delegate void LogCallback(string str);
        private void Log(string log)
        {
            if (InvokeRequired)
            {
                //使用委托调用本方法
                var d = new LogCallback(Log);
                Invoke(d, log);
            }
            else
            {
                tbLog.AppendText(Environment.NewLine);
                tbLog.AppendText($"【{ DateTime.Now.ToString(CultureInfo.InvariantCulture)}】：{log}");
                tbLog.AppendText(Environment.NewLine);
            }
        }

        private void OnStartRecordingClick(object sender, EventArgs e)
        {
            // 设置记录器
            // 参数依次为 格式\采样率\声道\每秒平均码率\单位采样点的字节数\采样位数
            _recorder = new WaveIn { WaveFormat = WaveFormat.CreateCustomFormat(WaveFormatEncoding.Pcm, 8000, 1, 16000, 2, 16) };
            _recorder.DataAvailable += RecorderOnDataAvailable;

            // 建立我们的信号链
            _bufferedWaveProvider = new BufferedWaveProvider(_recorder.WaveFormat);

            _fileName = Path.Combine("temp", Guid.NewGuid() + ".pcm");
            _savingWaveProvider = new SavingWaveProvider(_bufferedWaveProvider, _fileName);




            //设置播放
            _player = new WaveOut();
            _player.Init(_savingWaveProvider);

            // 开始播放和录制
            _player.Play();
            _recorder.StartRecording();

            Log("开始录制");

        }
        private void OnStopRecordingClick(object sender, EventArgs e)
        {
            // 停止录制
            _recorder.StopRecording();
            // 停止播放
            _player.Stop();
            // 最终完成 WAV 文件
            _savingWaveProvider.Dispose();
            Log("停止录制");

            Log("请求百度ASR接口");
            var a = SpeechHelper.AsrData(_fileName);


            Log($"请求结果:{a.Result.Serialize()}");
        }
        private void RecorderOnDataAvailable(object sender, WaveInEventArgs waveInEventArgs)
        {
            _bufferedWaveProvider.AddSamples(waveInEventArgs.Buffer, 0, waveInEventArgs.BytesRecorded);
        }

        private void btnAsr_Click(object sender, EventArgs e)
        {
            if (string.Equals(btnAsr.Text, "开始录音", StringComparison.Ordinal))
            {
                btnAsr.Text = "语音转文字";
                OnStartRecordingClick(sender, e);
            }
            else
            {
                btnAsr.Text = "开始录音";
                OnStopRecordingClick(sender, e);
            }
        }

        private void btnTts_Click(object sender, EventArgs e)
        {
            // 临时保存路径
            var musicPath = Path.Combine("temp", Guid.NewGuid() + ".mp3");

            // 发言人
            var per = cbPer.SelectedIndex >= 2 ? cbPer.SelectedIndex + 1 : cbPer.SelectedIndex;

            //调用Baidu TTS Api
            if (!SpeechHelper.Tts(tbContext.Text, musicPath, (int)nudSpd.Value, (int)nudPit.Value, (int)nudVol.Value, per)) return;

            //播放请求得到的结果
            IWavePlayer waveOutDevice = new WaveOut();
            var audioFileReader = new AudioFileReader(musicPath);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            //播放结束后销毁播放对象
            waveOutDevice.PlaybackStopped += delegate
            {
                waveOutDevice?.Stop();
                waveOutDevice?.Dispose();
                waveOutDevice = null;
            };
        }

        private void SpeechFrm_Load(object sender, EventArgs e) => cbPer.SelectedIndex = 0;

        private void SpeechFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Directory.Exists("temp")) return;
            var files = Directory.GetFiles("temp");
            foreach (var file in files)
                File.Delete(file);
            Directory.Delete("temp");
        }
    }
}
