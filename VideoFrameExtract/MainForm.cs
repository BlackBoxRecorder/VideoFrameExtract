using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace VideoFrameExtract
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CmbImageFormat.Items.Add("Jpg");
            CmbImageFormat.Items.Add("Png");
            CmbImageFormat.Items.Add("Bmp");
            CmbImageFormat.Items.Add("TIFF");

            CmbImageFormat.SelectedIndex = 0;
        }

        private CancellationTokenSource cts;
        private CancellationToken stopToken;

        private void MainForm_Load(object sender, EventArgs e)
        {
            TextTotalFrame.Enabled = false;
            TextSkipFrame.Enabled = false;
            TextStopAfterSecond.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null && !stopToken.IsCancellationRequested)
            {
                MessageBox.Show("请先停止后再退出");
                e.Cancel = true;
            }
        }

        private async void BtnExtract_Click(object sender, EventArgs e)
        {
            TextFrameCount.Text = $"已提取：0 帧";

            var videoSrc = TextVideoFile.Text;
            var imgDir = TextImageDir.Text;

            if (!Directory.Exists(imgDir))
            {
                MessageBox.Show("您选择的图片目录不存在");
                return;
            }

            if (Directory.GetFiles(imgDir).Length > 0)
            {
                MessageBox.Show("您选择的图片目录不为空");
                return;
            }

            var imgFormat = CmbImageFormat.Text.ToLower();

            var success = int.TryParse(TextTotalFrame.Text, out var totalFrame);
            if (!success && CkbTotalFrame.Checked)
            {
                MessageBox.Show("总抽取帧数填写错误");
                return;
            }

            success = int.TryParse(TextSkipFrame.Text, out var skipFrame);
            if (!success && CkbSkipFrame.Checked)
            {
                MessageBox.Show("间隔帧数填写错误");
                return;
            }

            success = int.TryParse(TextStopAfterSecond.Text, out var stopTime);
            if (!success && CkbStopAfterSecond.Checked)
            {
                MessageBox.Show("秒数填写错误，请填写整数");
                return;
            }

            VideoCapture cap = new VideoCapture();
            BtnExtract.Enabled = false;

            bool opened;
            if (int.TryParse(videoSrc, out int camIndex))
            {
                opened = cap.Open(camIndex);
            }
            else if (
                videoSrc.ToLower().Contains("rtsp://")
                || videoSrc.ToLower().Contains("rtmp://")
                || videoSrc.ToLower().Contains("http://")
            )
            {
                //网络流
                opened = cap.Open(videoSrc);
            }
            else
            {
                //视频文件
                if (!File.Exists(videoSrc))
                {
                    MessageBox.Show("您选择的视频文件不存在");
                    BtnExtract.Enabled = true;
                    return;
                }

                opened = cap.Open(videoSrc);
            }

            if (!opened)
            {
                MessageBox.Show("视频源打开失败");
                BtnExtract.Enabled = true;
                return;
            }

            if (cts == null)
            {
                cts = new CancellationTokenSource();
                stopToken = cts.Token;
            }

            int index = 0;
            int extractCount = 0;
            var sw = new Stopwatch();
            sw.Start();

            while (!stopToken.IsCancellationRequested)
            {
                await Task.Delay(1);
                if (CkbStopAfterSecond.Checked && sw.ElapsedMilliseconds / 1000 > stopTime)
                {
                    break;
                }

                if (!cap.IsOpened())
                {
                    MessageBox.Show("视频源已关闭");
                    break;
                }

                var frame = new Mat();
                bool readSuccess = cap.Read(frame);

                if (!readSuccess)
                {
                    MessageBox.Show("视频源已关闭");
                    break;
                }

                var imgfile = Path.Combine(imgDir, $"{extractCount}.{imgFormat}");

                if (CkbSkipFrame.Checked)
                {
                    if (index % skipFrame == 0)
                    {
                        extractCount++;
                        Cv2.ImWrite(imgfile, frame);
                        TextFrameCount.Text = $"已提取：{extractCount} 帧";
                    }
                }
                else
                {
                    Cv2.ImWrite(imgfile, frame);
                    extractCount++;
                    TextFrameCount.Text = $"已提取：{extractCount} 帧";
                }
                index++;

                if (CkbTotalFrame.Checked && extractCount >= totalFrame)
                {
                    break;
                }
            }

            BtnExtract.Enabled = true;
            CancelExtract();

            cap.Release();
            cap.Dispose();
        }

        private void CkbSkipFrame_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSkipFrame.Checked)
            {
                TextSkipFrame.Enabled = true;
            }
            else
            {
                TextSkipFrame.Text = string.Empty;
                TextSkipFrame.Enabled = false;
            }
        }

        private void CkbTotalFrame_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTotalFrame.Checked)
            {
                TextTotalFrame.Enabled = true;
            }
            else
            {
                TextTotalFrame.Text = string.Empty;
                TextTotalFrame.Enabled = false;
            }
        }

        private void CkbStopAfterMinute_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbStopAfterSecond.Checked)
            {
                TextStopAfterSecond.Enabled = true;
            }
            else
            {
                TextStopAfterSecond.Text = string.Empty;
                TextStopAfterSecond.Enabled = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelExtract();
        }

        private void CancelExtract()
        {
            if (cts != null)
            {
                cts.Cancel();
                cts.Dispose();
                cts = null;
            }
        }
    }
}
