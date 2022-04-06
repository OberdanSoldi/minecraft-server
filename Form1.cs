using System.ComponentModel;
using System.Diagnostics;

namespace RunMinecraftSv; 

public partial class Frm : Form {
    private string folderPath = "";
    private bool isRunning;
    private readonly Process serverProcess = new();

    public Frm() {
        InitializeComponent();
    }


    public void runServer() {
        var path = textBox1.Text;
        var JarName = textBox2.Text;
        var Args = txtArgs.Text;
        serverProcess.StartInfo.UseShellExecute = false;
        serverProcess.StartInfo.RedirectStandardOutput = true;
        serverProcess.StartInfo.FileName = "java.exe";
        serverProcess.StartInfo.WorkingDirectory = path;
        serverProcess.StartInfo.Arguments = "-jar " + Args + " " + JarName + " nogui";
        serverProcess.StartInfo.CreateNoWindow = true;
        serverProcess.OutputDataReceived += outputHandler;

        using (var writer = new StreamWriter(path + "\\eula.txt", false)) {
            writer.Write("eula=true");
            writer.Close();
        }

        serverProcess.Start();
        serverProcess.BeginOutputReadLine();
        isRunning = true;
    }

    private void outputHandler(object sendingProcess, DataReceivedEventArgs outLine) {
        var received = outLine.Data;
        if (!string.IsNullOrEmpty(received)) setTextToTextBox(textBox4, received);
    }

    private void setTextToTextBox(TextBox tb, string texto) {
        try {
            if (tb.InvokeRequired) {
                CallBackTextbox ctb = setTextToTextBox;
                Invoke(ctb, tb, texto);
            } else {
                tb.AppendText(texto + Environment.NewLine);
            }
        } catch (Exception ex) {
            MessageBox.Show(ex.Message);
        }
    }

    private void button1_Click(object sender, EventArgs e) {
        if (textBox1.Text == "" || textBox2.Text == "") {
            MessageBox.Show("Coloque o Path e o Jar File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } else {
            runServer();
            textBox3.Text = "Running";
        }
    }

    private void btnKill_Click(object sender, EventArgs e) {
        if (isRunning)
            try {
                var localByName = Process.GetProcessesByName("java");
                localByName[localByName.Length - 1].Kill();
                isRunning = false;
                textBox3.Text = "Stopped";
                textBox4.Clear();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
    }

    private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) {
    }

    private void btnPath_Click(object sender, EventArgs e) {
        folderBrowserDialog1 = new FolderBrowserDialog();
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            btnSvFolder.Enabled = true;
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
    }

    private void button2_Click(object sender, EventArgs e) {
        openFileDialog1 = new OpenFileDialog();
        if (openFileDialog1.ShowDialog() == DialogResult.OK) textBox2.Text = openFileDialog1.FileName;
    }

    private void textBox2_TextChanged(object sender, EventArgs e) {
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
    }

    private void label1_Click(object sender, EventArgs e) {
    }

    private void label2_Click(object sender, EventArgs e) {
    }

    private void textBox3_TextChanged(object sender, EventArgs e) {
    }

    private void useCustomArgs_CheckedChanged(object sender, EventArgs e) {
        if (useCustomArgs.Checked) txtArgs.Enabled = true;
        if (useCustomArgs.Checked == false) txtArgs.Enabled = false;
    }

    private void txtArgs_TextChanged(object sender, EventArgs e) {
    }

    private void btnSvFolder_Click(object sender, EventArgs e) {
        if (textBox1.Text == "") btnSvFolder.Enabled = false;
        Process.Start("explorer.exe", textBox1.Text);
    }

    private void textBox4_TextChanged(object sender, EventArgs e) {
    }

    private delegate void CallBackTextbox(TextBox tb, string texto);
}