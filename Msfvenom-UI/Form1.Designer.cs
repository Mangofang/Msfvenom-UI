namespace Msfvenom_UI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.windowBar1 = new AntdUI.WindowBar();
            this.input1 = new AntdUI.Input();
            this.label1 = new AntdUI.Label();
            this.dropdown1 = new AntdUI.Dropdown();
            this.label2 = new AntdUI.Label();
            this.input2 = new AntdUI.Input();
            this.input3 = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.dropdown2 = new AntdUI.Dropdown();
            this.label4 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.dropdown4 = new AntdUI.Dropdown();
            this.input4 = new AntdUI.Input();
            this.label8 = new AntdUI.Label();
            this.input5 = new AntdUI.Input();
            this.label9 = new AntdUI.Label();
            this.input6 = new AntdUI.Input();
            this.label10 = new AntdUI.Label();
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // windowBar1
            // 
            this.windowBar1.DividerShow = true;
            this.windowBar1.DividerThickness = 2F;
            this.windowBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar1.Location = new System.Drawing.Point(0, 0);
            this.windowBar1.MaximizeBox = false;
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Size = new System.Drawing.Size(900, 64);
            this.windowBar1.TabIndex = 0;
            this.windowBar1.Text = "Msfvenom-UI";
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(12, 591);
            this.input1.Multiline = true;
            this.input1.Name = "input1";
            this.input1.ReadOnly = true;
            this.input1.Size = new System.Drawing.Size(862, 186);
            this.input1.TabIndex = 1;
            this.input1.DoubleClick += new System.EventHandler(this.input1_DoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Prefix = "*";
            this.label1.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Size = new System.Drawing.Size(154, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payload:";
            // 
            // dropdown1
            // 
            this.dropdown1.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dropdown1.DropDownArrow = true;
            this.dropdown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dropdown1.IsLink = true;
            this.dropdown1.Items.AddRange(new object[] {
            "windows/adduser",
            "windows/dllinject/bind_hidden_ipknock_tcp",
            "windows/dllinject/bind_hidden_tcp",
            "windows/dllinject/bind_ipv6_tcp",
            "windows/dllinject/bind_ipv6_tcp_uuid",
            "windows/dllinject/bind_named_pipe",
            "windows/dllinject/bind_nonx_tcp",
            "windows/dllinject/bind_tcp",
            "windows/dllinject/bind_tcp_rc4",
            "windows/dllinject/bind_tcp_uuid",
            "windows/dllinject/find_tag",
            "windows/dllinject/reverse_hop_http",
            "windows/dllinject/reverse_http",
            "windows/dllinject/reverse_http_proxy_pstore",
            "windows/dllinject/reverse_ipv6_tcp",
            "windows/dllinject/reverse_nonx_tcp",
            "windows/dllinject/reverse_ord_tcp",
            "windows/dllinject/reverse_tcp",
            "windows/dllinject/reverse_tcp_allports",
            "windows/dllinject/reverse_tcp_dns",
            "windows/dllinject/reverse_tcp_rc4",
            "windows/dllinject/reverse_tcp_rc4_dns",
            "windows/dllinject/reverse_tcp_uuid",
            "windows/dllinject/reverse_udp",
            "windows/dllinject/reverse_winhttp",
            "windows/dns_txt_query_exec",
            "windows/download_exec",
            "windows/exec",
            "windows/format_all_drives",
            "windows/loadlibrary",
            "windows/messagebox",
            "windows/meterpreter/bind_hidden_ipknock_tcp",
            "windows/meterpreter/bind_hidden_tcp",
            "windows/meterpreter/bind_ipv6_tcp",
            "windows/meterpreter/bind_ipv6_tcp_uuid",
            "windows/meterpreter/bind_named_pipe",
            "windows/meterpreter/bind_nonx_tcp",
            "windows/meterpreter/bind_tcp",
            "windows/meterpreter/bind_tcp_rc4",
            "windows/meterpreter/bind_tcp_uuid",
            "windows/meterpreter/find_tag",
            "windows/meterpreter/reverse_hop_http",
            "windows/meterpreter/reverse_http",
            "windows/meterpreter/reverse_http_proxy_pstore",
            "windows/meterpreter/reverse_https",
            "windows/meterpreter/reverse_https_proxy",
            "windows/meterpreter/reverse_ipv6_tcp",
            "windows/meterpreter/reverse_named_pipe",
            "windows/meterpreter/reverse_nonx_tcp",
            "windows/meterpreter/reverse_ord_tcp",
            "windows/meterpreter/reverse_tcp",
            "windows/meterpreter/reverse_tcp_allports",
            "windows/meterpreter/reverse_tcp_dns",
            "windows/meterpreter/reverse_tcp_rc4",
            "windows/meterpreter/reverse_tcp_rc4_dns",
            "windows/meterpreter/reverse_tcp_uuid",
            "windows/meterpreter/reverse_udp",
            "windows/meterpreter/reverse_winhttp",
            "windows/meterpreter/reverse_winhttps",
            "windows/meterpreter_bind_named_pipe",
            "windows/meterpreter_bind_tcp",
            "windows/meterpreter_reverse_http",
            "windows/meterpreter_reverse_https",
            "windows/meterpreter_reverse_ipv6_tcp",
            "windows/meterpreter_reverse_tcp",
            "windows/metsvc_bind_tcp",
            "windows/metsvc_reverse_tcp",
            "windows/patchupdllinject/bind_hidden_ipknock_tcp",
            "windows/patchupdllinject/bind_hidden_tcp",
            "windows/patchupdllinject/bind_ipv6_tcp",
            "windows/patchupdllinject/bind_ipv6_tcp_uuid",
            "windows/patchupdllinject/bind_named_pipe",
            "windows/patchupdllinject/bind_nonx_tcp",
            "windows/patchupdllinject/bind_tcp",
            "windows/patchupdllinject/bind_tcp_rc4",
            "windows/patchupdllinject/bind_tcp_uuid",
            "windows/patchupdllinject/find_tag",
            "windows/patchupdllinject/reverse_ipv6_tcp",
            "windows/patchupdllinject/reverse_nonx_tcp",
            "windows/patchupdllinject/reverse_ord_tcp",
            "windows/patchupdllinject/reverse_tcp",
            "windows/patchupdllinject/reverse_tcp_allports",
            "windows/patchupdllinject/reverse_tcp_dns",
            "windows/patchupdllinject/reverse_tcp_rc4",
            "windows/patchupdllinject/reverse_tcp_rc4_dns",
            "windows/patchupdllinject/reverse_tcp_uuid",
            "windows/patchupdllinject/reverse_udp",
            "windows/patchupmeterpreter/bind_hidden_ipknock_tcp",
            "windows/patchupmeterpreter/bind_hidden_tcp",
            "windows/patchupmeterpreter/bind_ipv6_tcp",
            "windows/patchupmeterpreter/bind_ipv6_tcp_uuid",
            "windows/patchupmeterpreter/bind_named_pipe",
            "windows/patchupmeterpreter/bind_nonx_tcp",
            "windows/patchupmeterpreter/bind_tcp",
            "windows/patchupmeterpreter/bind_tcp_rc4",
            "windows/patchupmeterpreter/bind_tcp_uuid",
            "windows/patchupmeterpreter/find_tag",
            "windows/patchupmeterpreter/reverse_ipv6_tcp",
            "windows/patchupmeterpreter/reverse_nonx_tcp",
            "windows/patchupmeterpreter/reverse_ord_tcp",
            "windows/patchupmeterpreter/reverse_tcp",
            "windows/patchupmeterpreter/reverse_tcp_allports",
            "windows/patchupmeterpreter/reverse_tcp_dns",
            "windows/patchupmeterpreter/reverse_tcp_rc4",
            "windows/patchupmeterpreter/reverse_tcp_rc4_dns",
            "windows/patchupmeterpreter/reverse_tcp_uuid",
            "windows/patchupmeterpreter/reverse_udp",
            "windows/powershell_bind_tcp",
            "windows/powershell_reverse_tcp",
            "windows/shell/bind_hidden_ipknock_tcp",
            "windows/shell/bind_hidden_tcp",
            "windows/shell/bind_ipv6_tcp",
            "windows/shell/bind_ipv6_tcp_uuid",
            "windows/shell/bind_named_pipe",
            "windows/shell/bind_nonx_tcp",
            "windows/shell/bind_tcp",
            "windows/shell/bind_tcp_rc4",
            "windows/shell/bind_tcp_uuid",
            "windows/shell/find_tag",
            "windows/shell/reverse_ipv6_tcp",
            "windows/shell/reverse_nonx_tcp",
            "windows/shell/reverse_ord_tcp",
            "windows/shell/reverse_tcp",
            "windows/shell/reverse_tcp_allports",
            "windows/shell/reverse_tcp_dns",
            "windows/shell/reverse_tcp_rc4",
            "windows/shell/reverse_tcp_rc4_dns",
            "windows/shell/reverse_tcp_uuid",
            "windows/shell/reverse_udp",
            "windows/shell_bind_tcp",
            "windows/shell_bind_tcp_xpfw",
            "windows/shell_hidden_bind_tcp",
            "windows/shell_reverse_tcp",
            "windows/speak_pwned",
            "windows/upexec/bind_hidden_ipknock_tcp",
            "windows/upexec/bind_hidden_tcp",
            "windows/upexec/bind_ipv6_tcp",
            "windows/upexec/bind_ipv6_tcp_uuid",
            "windows/upexec/bind_named_pipe",
            "windows/upexec/bind_nonx_tcp",
            "windows/upexec/bind_tcp",
            "windows/upexec/bind_tcp_rc4",
            "windows/upexec/bind_tcp_uuid",
            "windows/upexec/find_tag",
            "windows/upexec/reverse_ipv6_tcp",
            "windows/upexec/reverse_nonx_tcp",
            "windows/upexec/reverse_ord_tcp",
            "windows/upexec/reverse_tcp",
            "windows/upexec/reverse_tcp_allports",
            "windows/upexec/reverse_tcp_dns",
            "windows/upexec/reverse_tcp_rc4",
            "windows/upexec/reverse_tcp_rc4_dns",
            "windows/upexec/reverse_tcp_uuid",
            "windows/upexec/reverse_udp",
            "windows/vncinject/bind_hidden_ipknock_tcp",
            "windows/vncinject/bind_hidden_tcp",
            "windows/vncinject/bind_ipv6_tcp",
            "windows/vncinject/bind_ipv6_tcp_uuid",
            "windows/vncinject/bind_named_pipe",
            "windows/vncinject/bind_nonx_tcp",
            "windows/vncinject/bind_tcp",
            "windows/vncinject/bind_tcp_rc4",
            "windows/vncinject/bind_tcp_uuid",
            "windows/vncinject/find_tag",
            "windows/vncinject/reverse_hop_http",
            "windows/vncinject/reverse_http",
            "windows/vncinject/reverse_http_proxy_pstore",
            "windows/vncinject/reverse_ipv6_tcp",
            "windows/vncinject/reverse_nonx_tcp",
            "windows/vncinject/reverse_ord_tcp",
            "windows/vncinject/reverse_tcp",
            "windows/vncinject/reverse_tcp_allports",
            "windows/vncinject/reverse_tcp_dns",
            "windows/vncinject/reverse_tcp_rc4",
            "windows/vncinject/reverse_tcp_rc4_dns",
            "windows/vncinject/reverse_tcp_uuid",
            "windows/vncinject/reverse_udp",
            "windows/vncinject/reverse_winhttp",
            "windows/x64/exec",
            "windows/x64/loadlibrary",
            "windows/x64/meterpreter/bind_ipv6_tcp",
            "windows/x64/meterpreter/bind_ipv6_tcp_uuid",
            "windows/x64/meterpreter/bind_named_pipe",
            "windows/x64/meterpreter/bind_tcp",
            "windows/x64/meterpreter/bind_tcp_uuid",
            "windows/x64/meterpreter/reverse_http",
            "windows/x64/meterpreter/reverse_https",
            "windows/x64/meterpreter/reverse_named_pipe",
            "windows/x64/meterpreter/reverse_tcp",
            "windows/x64/meterpreter/reverse_tcp_rc4",
            "windows/x64/meterpreter/reverse_tcp_uuid",
            "windows/x64/meterpreter/reverse_winhttp",
            "windows/x64/meterpreter/reverse_winhttps",
            "windows/x64/meterpreter_bind_named_pipe",
            "windows/x64/meterpreter_bind_tcp",
            "windows/x64/meterpreter_reverse_http",
            "windows/x64/meterpreter_reverse_https",
            "windows/x64/meterpreter_reverse_ipv6_tcp",
            "windows/x64/meterpreter_reverse_tcp",
            "windows/x64/powershell_bind_tcp",
            "windows/x64/powershell_reverse_tcp",
            "windows/x64/shell/bind_ipv6_tcp",
            "windows/x64/shell/bind_ipv6_tcp_uuid",
            "windows/x64/shell/bind_named_pipe",
            "windows/x64/shell/bind_tcp",
            "windows/x64/shell/bind_tcp_uuid",
            "windows/x64/shell/reverse_tcp",
            "windows/x64/shell/reverse_tcp_rc4",
            "windows/x64/shell/reverse_tcp_uuid",
            "windows/x64/shell_bind_tcp",
            "windows/x64/shell_reverse_tcp",
            "windows/x64/vncinject/bind_ipv6_tcp",
            "windows/x64/vncinject/bind_ipv6_tcp_uuid",
            "windows/x64/vncinject/bind_named_pipe",
            "windows/x64/vncinject/bind_tcp",
            "windows/x64/vncinject/bind_tcp_uuid",
            "windows/x64/vncinject/reverse_http",
            "windows/x64/vncinject/reverse_https",
            "windows/x64/vncinject/reverse_tcp",
            "windows/x64/vncinject/reverse_tcp_rc4",
            "windows/x64/vncinject/reverse_tcp_uuid",
            "windows/x64/vncinject/reverse_winhttp",
            "windows/x64/vncinject/reverse_winhttps",
            "aix/ppc/shell_bind_tcp",
            "aix/ppc/shell_find_port",
            "aix/ppc/shell_interact",
            "aix/ppc/shell_reverse_tcp",
            "android/meterpreter/reverse_http",
            "android/meterpreter/reverse_https",
            "android/meterpreter/reverse_tcp",
            "android/meterpreter_reverse_http",
            "android/meterpreter_reverse_https",
            "android/meterpreter_reverse_tcp",
            "android/shell/reverse_http",
            "android/shell/reverse_https",
            "android/shell/reverse_tcp",
            "apple_ios/aarch64/meterpreter_reverse_http",
            "apple_ios/aarch64/meterpreter_reverse_https",
            "apple_ios/aarch64/meterpreter_reverse_tcp",
            "apple_ios/aarch64/shell_reverse_tcp",
            "bsd/sparc/shell_bind_tcp",
            "bsd/sparc/shell_reverse_tcp",
            "bsd/x64/exec",
            "bsd/x64/shell_bind_ipv6_tcp",
            "bsd/x64/shell_bind_tcp",
            "bsd/x64/shell_bind_tcp_small",
            "bsd/x64/shell_reverse_ipv6_tcp",
            "bsd/x64/shell_reverse_tcp",
            "bsd/x64/shell_reverse_tcp_small",
            "bsd/x86/exec",
            "bsd/x86/metsvc_bind_tcp",
            "bsd/x86/metsvc_reverse_tcp",
            "bsd/x86/shell/bind_ipv6_tcp",
            "bsd/x86/shell/bind_tcp",
            "bsd/x86/shell/find_tag",
            "bsd/x86/shell/reverse_ipv6_tcp",
            "bsd/x86/shell/reverse_tcp",
            "bsd/x86/shell_bind_tcp",
            "bsd/x86/shell_bind_tcp_ipv6",
            "bsd/x86/shell_find_port",
            "bsd/x86/shell_find_tag",
            "bsd/x86/shell_reverse_tcp",
            "bsd/x86/shell_reverse_tcp_ipv6",
            "bsdi/x86/shell/bind_tcp",
            "bsdi/x86/shell/reverse_tcp",
            "bsdi/x86/shell_bind_tcp",
            "bsdi/x86/shell_find_port",
            "bsdi/x86/shell_reverse_tcp",
            "cmd/mainframe/apf_privesc_jcl",
            "cmd/mainframe/bind_shell_jcl",
            "cmd/mainframe/generic_jcl",
            "cmd/mainframe/reverse_shell_jcl",
            "cmd/unix/bind_awk",
            "cmd/unix/bind_inetd",
            "cmd/unix/bind_lua",
            "cmd/unix/bind_netcat",
            "cmd/unix/bind_netcat_gaping",
            "cmd/unix/bind_netcat_gaping_ipv6",
            "cmd/unix/bind_nodejs",
            "cmd/unix/bind_perl",
            "cmd/unix/bind_perl_ipv6",
            "cmd/unix/bind_r",
            "cmd/unix/bind_ruby",
            "cmd/unix/bind_ruby_ipv6",
            "cmd/unix/bind_socat_udp",
            "cmd/unix/bind_stub",
            "cmd/unix/bind_zsh",
            "cmd/unix/generic",
            "cmd/unix/interact",
            "cmd/unix/reverse",
            "cmd/unix/reverse_awk",
            "cmd/unix/reverse_bash",
            "cmd/unix/reverse_bash_telnet_ssl",
            "cmd/unix/reverse_ksh",
            "cmd/unix/reverse_lua",
            "cmd/unix/reverse_ncat_ssl",
            "cmd/unix/reverse_netcat",
            "cmd/unix/reverse_netcat_gaping",
            "cmd/unix/reverse_nodejs",
            "cmd/unix/reverse_openssl",
            "cmd/unix/reverse_perl",
            "cmd/unix/reverse_perl_ssl",
            "cmd/unix/reverse_php_ssl",
            "cmd/unix/reverse_python",
            "cmd/unix/reverse_python_ssl",
            "cmd/unix/reverse_r",
            "cmd/unix/reverse_ruby",
            "cmd/unix/reverse_ruby_ssl",
            "cmd/unix/reverse_socat_udp",
            "cmd/unix/reverse_ssl_double_telnet",
            "cmd/unix/reverse_stub",
            "cmd/unix/reverse_zsh",
            "cmd/windows/adduser",
            "cmd/windows/bind_lua",
            "cmd/windows/bind_perl",
            "cmd/windows/bind_perl_ipv6",
            "cmd/windows/bind_ruby",
            "cmd/windows/download_eval_vbs",
            "cmd/windows/download_exec_vbs",
            "cmd/windows/generic",
            "cmd/windows/powershell_bind_tcp",
            "cmd/windows/powershell_reverse_tcp",
            "cmd/windows/reverse_lua",
            "cmd/windows/reverse_perl",
            "cmd/windows/reverse_powershell",
            "cmd/windows/reverse_ruby",
            "firefox/exec",
            "firefox/shell_bind_tcp",
            "firefox/shell_reverse_tcp",
            "generic/custom",
            "generic/debug_trap",
            "generic/shell_bind_tcp",
            "generic/shell_reverse_tcp",
            "generic/tight_loop",
            "java/jsp_shell_bind_tcp",
            "java/jsp_shell_reverse_tcp",
            "java/meterpreter/bind_tcp",
            "java/meterpreter/reverse_http",
            "java/meterpreter/reverse_https",
            "java/meterpreter/reverse_tcp",
            "java/shell/bind_tcp",
            "java/shell/reverse_tcp",
            "java/shell_reverse_tcp",
            "linux/aarch64/meterpreter/reverse_tcp",
            "linux/aarch64/meterpreter_reverse_http",
            "linux/aarch64/meterpreter_reverse_https",
            "linux/aarch64/meterpreter_reverse_tcp",
            "linux/aarch64/shell/reverse_tcp",
            "linux/aarch64/shell_reverse_tcp",
            "linux/armbe/meterpreter_reverse_http",
            "linux/armbe/meterpreter_reverse_https",
            "linux/armbe/meterpreter_reverse_tcp",
            "linux/armbe/shell_bind_tcp",
            "linux/armle/adduser",
            "linux/armle/exec",
            "linux/armle/meterpreter/bind_tcp",
            "linux/armle/meterpreter/reverse_tcp",
            "linux/armle/meterpreter_reverse_http",
            "linux/armle/meterpreter_reverse_https",
            "linux/armle/meterpreter_reverse_tcp",
            "linux/armle/shell/bind_tcp",
            "linux/armle/shell/reverse_tcp",
            "linux/armle/shell_bind_tcp",
            "linux/armle/shell_reverse_tcp",
            "linux/mips64/meterpreter_reverse_http",
            "linux/mips64/meterpreter_reverse_https",
            "linux/mips64/meterpreter_reverse_tcp",
            "linux/mipsbe/exec",
            "linux/mipsbe/meterpreter/reverse_tcp",
            "linux/mipsbe/meterpreter_reverse_http",
            "linux/mipsbe/meterpreter_reverse_https",
            "linux/mipsbe/meterpreter_reverse_tcp",
            "linux/mipsbe/reboot",
            "linux/mipsbe/shell/reverse_tcp",
            "linux/mipsbe/shell_bind_tcp",
            "linux/mipsbe/shell_reverse_tcp",
            "linux/mipsle/exec",
            "linux/mipsle/meterpreter/reverse_tcp",
            "linux/mipsle/meterpreter_reverse_http",
            "linux/mipsle/meterpreter_reverse_https",
            "linux/mipsle/meterpreter_reverse_tcp",
            "linux/mipsle/reboot",
            "linux/mipsle/shell/reverse_tcp",
            "linux/mipsle/shell_bind_tcp",
            "linux/mipsle/shell_reverse_tcp",
            "linux/ppc/meterpreter_reverse_http",
            "linux/ppc/meterpreter_reverse_https",
            "linux/ppc/meterpreter_reverse_tcp",
            "linux/ppc/shell_bind_tcp",
            "linux/ppc/shell_find_port",
            "linux/ppc/shell_reverse_tcp",
            "linux/ppc64/shell_bind_tcp",
            "linux/ppc64/shell_find_port",
            "linux/ppc64/shell_reverse_tcp",
            "linux/ppc64le/meterpreter_reverse_http",
            "linux/ppc64le/meterpreter_reverse_https",
            "linux/ppc64le/meterpreter_reverse_tcp",
            "linux/ppce500v2/meterpreter_reverse_http",
            "linux/ppce500v2/meterpreter_reverse_https",
            "linux/ppce500v2/meterpreter_reverse_tcp",
            "linux/x64/exec",
            "linux/x64/meterpreter/bind_tcp",
            "linux/x64/meterpreter/reverse_tcp",
            "linux/x64/meterpreter_reverse_http",
            "linux/x64/meterpreter_reverse_https",
            "linux/x64/meterpreter_reverse_tcp",
            "linux/x64/shell/bind_tcp",
            "linux/x64/shell/reverse_tcp",
            "linux/x64/shell_bind_tcp",
            "linux/x64/shell_bind_tcp_random_port",
            "linux/x64/shell_find_port",
            "linux/x64/shell_reverse_tcp",
            "linux/x86/adduser",
            "linux/x86/chmod",
            "linux/x86/exec",
            "linux/x86/meterpreter/bind_ipv6_tcp",
            "linux/x86/meterpreter/bind_ipv6_tcp_uuid",
            "linux/x86/meterpreter/bind_nonx_tcp",
            "linux/x86/meterpreter/bind_tcp",
            "linux/x86/meterpreter/bind_tcp_uuid",
            "linux/x86/meterpreter/find_tag",
            "linux/x86/meterpreter/reverse_ipv6_tcp",
            "linux/x86/meterpreter/reverse_nonx_tcp",
            "linux/x86/meterpreter/reverse_tcp",
            "linux/x86/meterpreter/reverse_tcp_uuid",
            "linux/x86/meterpreter_reverse_http",
            "linux/x86/meterpreter_reverse_https",
            "linux/x86/meterpreter_reverse_tcp",
            "linux/x86/metsvc_bind_tcp",
            "linux/x86/metsvc_reverse_tcp",
            "linux/x86/read_file",
            "linux/x86/shell/bind_ipv6_tcp",
            "linux/x86/shell/bind_ipv6_tcp_uuid",
            "linux/x86/shell/bind_nonx_tcp",
            "linux/x86/shell/bind_tcp",
            "linux/x86/shell/bind_tcp_uuid",
            "linux/x86/shell/find_tag",
            "linux/x86/shell/reverse_ipv6_tcp",
            "linux/x86/shell/reverse_nonx_tcp",
            "linux/x86/shell/reverse_tcp",
            "linux/x86/shell/reverse_tcp_uuid",
            "linux/x86/shell_bind_ipv6_tcp",
            "linux/x86/shell_bind_tcp",
            "linux/x86/shell_bind_tcp_random_port",
            "linux/x86/shell_find_port",
            "linux/x86/shell_find_tag",
            "linux/x86/shell_reverse_tcp",
            "linux/x86/shell_reverse_tcp_ipv6",
            "linux/zarch/meterpreter_reverse_http",
            "linux/zarch/meterpreter_reverse_https",
            "linux/zarch/meterpreter_reverse_tcp",
            "mainframe/shell_reverse_tcp",
            "multi/meterpreter/reverse_http",
            "multi/meterpreter/reverse_https",
            "netware/shell/reverse_tcp",
            "nodejs/shell_bind_tcp",
            "nodejs/shell_reverse_tcp",
            "nodejs/shell_reverse_tcp_ssl",
            "osx/armle/execute/bind_tcp",
            "osx/armle/execute/reverse_tcp",
            "osx/armle/shell/bind_tcp",
            "osx/armle/shell/reverse_tcp",
            "osx/armle/shell_bind_tcp",
            "osx/armle/shell_reverse_tcp",
            "osx/armle/vibrate",
            "osx/ppc/shell/bind_tcp",
            "osx/ppc/shell/find_tag",
            "osx/ppc/shell/reverse_tcp",
            "osx/ppc/shell_bind_tcp",
            "osx/ppc/shell_reverse_tcp",
            "osx/x64/dupandexecve/bind_tcp",
            "osx/x64/dupandexecve/reverse_tcp",
            "osx/x64/exec",
            "osx/x64/meterpreter/bind_tcp",
            "osx/x64/meterpreter/reverse_tcp",
            "osx/x64/meterpreter_reverse_http",
            "osx/x64/meterpreter_reverse_https",
            "osx/x64/meterpreter_reverse_tcp",
            "osx/x64/say",
            "osx/x64/shell_bind_tcp",
            "osx/x64/shell_find_tag",
            "osx/x64/shell_reverse_tcp",
            "osx/x86/bundleinject/bind_tcp",
            "osx/x86/bundleinject/reverse_tcp",
            "osx/x86/exec",
            "osx/x86/isight/bind_tcp",
            "osx/x86/isight/reverse_tcp",
            "osx/x86/shell_bind_tcp",
            "osx/x86/shell_find_port",
            "osx/x86/shell_reverse_tcp",
            "osx/x86/vforkshell/bind_tcp",
            "osx/x86/vforkshell/reverse_tcp",
            "osx/x86/vforkshell_bind_tcp",
            "osx/x86/vforkshell_reverse_tcp",
            "php/bind_perl",
            "php/bind_perl_ipv6",
            "php/bind_php",
            "php/bind_php_ipv6",
            "php/download_exec",
            "php/exec",
            "php/meterpreter/bind_tcp",
            "php/meterpreter/bind_tcp_ipv6",
            "php/meterpreter/bind_tcp_ipv6_uuid",
            "php/meterpreter/bind_tcp_uuid",
            "php/meterpreter/reverse_tcp",
            "php/meterpreter/reverse_tcp_uuid",
            "php/meterpreter_reverse_tcp",
            "php/reverse_perl",
            "php/reverse_php",
            "php/shell_findsock",
            "python/meterpreter/bind_tcp",
            "python/meterpreter/bind_tcp_uuid",
            "python/meterpreter/reverse_http",
            "python/meterpreter/reverse_https",
            "python/meterpreter/reverse_tcp",
            "python/meterpreter/reverse_tcp_ssl",
            "python/meterpreter/reverse_tcp_uuid",
            "python/meterpreter_bind_tcp",
            "python/meterpreter_reverse_http",
            "python/meterpreter_reverse_https",
            "python/meterpreter_reverse_tcp",
            "python/shell_bind_tcp",
            "python/shell_reverse_tcp",
            "python/shell_reverse_tcp_ssl",
            "python/shell_reverse_udp",
            "r/shell_bind_tcp",
            "r/shell_reverse_tcp",
            "ruby/shell_bind_tcp",
            "ruby/shell_bind_tcp_ipv6",
            "ruby/shell_reverse_tcp",
            "ruby/shell_reverse_tcp_ssl",
            "solaris/sparc/shell_bind_tcp",
            "solaris/sparc/shell_find_port",
            "solaris/sparc/shell_reverse_tcp",
            "solaris/x86/shell_bind_tcp",
            "solaris/x86/shell_find_port",
            "solaris/x86/shell_reverse_tcp",
            "tty/unix/interact"});
            this.dropdown1.Location = new System.Drawing.Point(151, 82);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Placement = AntdUI.TAlignFrom.Bottom;
            this.dropdown1.ShowArrow = true;
            this.dropdown1.Size = new System.Drawing.Size(723, 74);
            this.dropdown1.TabIndex = 4;
            this.dropdown1.Text = "windows/meterpreter/bind_tcp";
            this.dropdown1.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.dropdown1_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Prefix = "*";
            this.label2.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Size = new System.Drawing.Size(154, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "LHOST:";
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(151, 162);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(278, 74);
            this.input2.TabIndex = 6;
            this.input2.Text = "127.0.0.1";
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            // 
            // input3
            // 
            this.input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input3.Location = new System.Drawing.Point(596, 162);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(278, 74);
            this.input3.TabIndex = 8;
            this.input3.Text = "8888";
            this.input3.TextChanged += new System.EventHandler(this.input3_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 173);
            this.label3.Name = "label3";
            this.label3.Prefix = "*";
            this.label3.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Size = new System.Drawing.Size(154, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "LPORT:";
            // 
            // dropdown2
            // 
            this.dropdown2.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dropdown2.DropDownArrow = true;
            this.dropdown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown2.IsLink = true;
            this.dropdown2.Items.AddRange(new object[] {
            "none",
            "cmd/echo",
            "cmd/generic_sh",
            "cmd/ifs",
            "cmd/perl",
            "cmd/powershell_base64",
            "cmd/printf_php_mq",
            "generic/eicar",
            "generic/none",
            "mipsbe/byte_xori",
            "mipsbe/longxor",
            "mipsle/byte_xori",
            "mipsle/longxor",
            "php/base64",
            "ppc/longxor",
            "ppc/longxor_tag",
            "ruby/base64",
            "sparc/longxor_tag",
            "x64/xor",
            "x64/zutto_dekiru",
            "x86/add_sub",
            "x86/alpha_mixed",
            "x86/alpha_upper",
            "x86/avoid_underscore_tolower",
            "x86/avoid_utf8_tolower",
            "x86/bloxor",
            "x86/bmp_polyglot",
            "x86/call4_dword_xor",
            "x86/context_cpuid",
            "x86/context_stat",
            "x86/context_time",
            "x86/countdown",
            "x86/fnstenv_mov",
            "x86/jmp_call_additive",
            "x86/nonalpha",
            "x86/nonupper",
            "x86/opt_sub",
            "x86/service",
            "x86/shikata_ga_nai",
            "x86/single_static_bit",
            "x86/unicode_mixed",
            "x86/unicode_upper"});
            this.dropdown2.Location = new System.Drawing.Point(151, 251);
            this.dropdown2.Name = "dropdown2";
            this.dropdown2.Placement = AntdUI.TAlignFrom.Bottom;
            this.dropdown2.ShowArrow = true;
            this.dropdown2.Size = new System.Drawing.Size(278, 74);
            this.dropdown2.TabIndex = 9;
            this.dropdown2.Text = "none";
            this.dropdown2.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.dropdown2_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 262);
            this.label4.Name = "label4";
            this.label4.Prefix = "";
            this.label4.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Size = new System.Drawing.Size(132, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "编码方式:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 262);
            this.label6.Name = "label6";
            this.label6.Prefix = "";
            this.label6.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Size = new System.Drawing.Size(132, 52);
            this.label6.TabIndex = 16;
            this.label6.Text = "文件格式:";
            // 
            // dropdown4
            // 
            this.dropdown4.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dropdown4.DropDownArrow = true;
            this.dropdown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown4.IsLink = true;
            this.dropdown4.Items.AddRange(new object[] {
            "asp",
            "aspx",
            "aspx-exe",
            "axis2",
            "bash",
            "c",
            "csharp",
            "dll",
            "dw",
            "dword",
            "elf",
            "elf-so",
            "exe",
            "exe-only",
            "exe-service",
            "exe-small",
            "hex",
            "hta-psh",
            "jar",
            "java",
            "js_be",
            "js_le",
            "jsp",
            "loop-vbs",
            "macho",
            "msi",
            "msi-nouac",
            "num",
            "osx-app",
            "perl",
            "pl",
            "powershell",
            "ps1",
            "psh",
            "psh-cmd",
            "psh-net",
            "psh-reflection",
            "py",
            "python",
            "raw",
            "rb",
            "ruby",
            "sh",
            "vba",
            "vba-exe",
            "vbapplication",
            "vba-psh",
            "vbs",
            "vbscript",
            "war"});
            this.dropdown4.Location = new System.Drawing.Point(596, 251);
            this.dropdown4.Name = "dropdown4";
            this.dropdown4.Placement = AntdUI.TAlignFrom.Bottom;
            this.dropdown4.ShowArrow = true;
            this.dropdown4.Size = new System.Drawing.Size(278, 74);
            this.dropdown4.TabIndex = 15;
            this.dropdown4.Text = "exe";
            this.dropdown4.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.dropdown4_SelectedValueChanged);
            // 
            // input4
            // 
            this.input4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input4.Location = new System.Drawing.Point(596, 350);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(278, 74);
            this.input4.TabIndex = 20;
            this.input4.TextChanged += new System.EventHandler(this.input4_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 361);
            this.label8.Name = "label8";
            this.label8.Prefix = "";
            this.label8.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Size = new System.Drawing.Size(154, 52);
            this.label8.TabIndex = 19;
            this.label8.Text = "去除字符:";
            // 
            // input5
            // 
            this.input5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input5.Location = new System.Drawing.Point(151, 350);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(278, 74);
            this.input5.TabIndex = 18;
            this.input5.Text = "1";
            this.input5.TextChanged += new System.EventHandler(this.input5_TextChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 361);
            this.label9.Name = "label9";
            this.label9.Prefix = "";
            this.label9.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Size = new System.Drawing.Size(154, 52);
            this.label9.TabIndex = 17;
            this.label9.Text = "编码次数:";
            // 
            // input6
            // 
            this.input6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input6.Location = new System.Drawing.Point(171, 444);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(574, 74);
            this.input6.TabIndex = 22;
            this.input6.TextChanged += new System.EventHandler(this.input6_TextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 455);
            this.label10.Name = "label10";
            this.label10.Prefix = "*";
            this.label10.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Size = new System.Drawing.Size(154, 52);
            this.label10.TabIndex = 21;
            this.label10.Text = "输出位置:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 73);
            this.button1.TabIndex = 23;
            this.button1.Text = "选择";
            this.button1.Type = AntdUI.TTypeMini.Primary;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(862, 61);
            this.button2.TabIndex = 24;
            this.button2.Text = "运行Msfvenom生成";
            this.button2.Type = AntdUI.TTypeMini.Primary;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 785);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dropdown4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropdown2);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.windowBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Input input1;
        private AntdUI.Label label1;
        private AntdUI.Dropdown dropdown1;
        private AntdUI.Label label2;
        private AntdUI.Input input2;
        private AntdUI.Input input3;
        private AntdUI.Label label3;
        private AntdUI.Dropdown dropdown2;
        private AntdUI.Label label4;
        private AntdUI.Label label6;
        private AntdUI.Dropdown dropdown4;
        private AntdUI.Input input4;
        private AntdUI.Label label8;
        private AntdUI.Input input5;
        private AntdUI.Label label9;
        private AntdUI.Input input6;
        private AntdUI.Label label10;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
    }
}

