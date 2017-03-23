using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
namespace Client
{
    public partial class MathClient : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        string sendToServer;//það sem er sent til serversins
        string[] fromServer = new string[2];//það sem kemur frá servernum er sett inn í þetta array

        public MathClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sendToTxt("Client byrjaður");
                clientSocket.Connect("127.0.0.1", 8888);//tengst servernum
                lblConnection.Text = "Tengdur við server";
                rad1.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ekki náðist samband við server."); //ef ekki hægt sé að tengjast servernum
                Application.Exit();
            }
            
            

        }
        int stig = 0;
        public string[] getFromServer()//function sem nær í það sem serverinn senti yfir í clientinn
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(sendToServer);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            fromServer = returndata.Split('=');
            return fromServer;
        }
        
        public void sendToTxt(string message)//skrifar í textaboxið
        {
            txtMath.Text = message;
            
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //sendir servernum að notandinn valdi plús dæmi
            if (rad1.Checked == true)
            {
               sendToServer = "plus$1"; 
            }
            if (rad2.Checked == true)
            {
                sendToServer = "plus$2";
            }
            if (rad3.Checked == true)
            {
                sendToServer = "plus$3";
            }
            btnPlus.BackColor = Color.Gray;
            btnByrja.BackColor = Color.Green;
            btnMinus.Enabled = false;
            btnMulti.Enabled = false;
            btnPlus.Enabled = false;
            btnByrja.Enabled = true;
            rad1.Enabled = false;
            rad2.Enabled = false;
            rad3.Enabled = false;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            //sendir servernum að notandinn valdi mínus dæmi
            if (rad1.Checked == true)
            {
                sendToServer = "minus$1";
            }
            if (rad2.Checked == true)
            {
                sendToServer = "minus$2";
            }
            if (rad3.Checked == true)
            {
                sendToServer = "minus$3";
            }
            btnMinus.BackColor = Color.Gray;
            btnByrja.BackColor = Color.Green;
            btnMinus.Enabled = false;
            btnMulti.Enabled = false;
            btnPlus.Enabled = false;
            btnByrja.Enabled = true;
            rad1.Enabled = false;
            rad2.Enabled = false;
            rad3.Enabled = false;
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            //sendir servernum að notandinn valdi margföldunardæmi dæmi
            if (rad1.Checked == true)
            {
                sendToServer = "multi$1";
            }
            if (rad2.Checked == true)
            {
                sendToServer = "multi$2";
            }
            if (rad3.Checked == true)
            {
                sendToServer = "multi$3";
            }
            btnMulti.BackColor = Color.Gray;
            btnByrja.BackColor = Color.Green;
            btnMinus.Enabled = false;
            btnMulti.Enabled = false;
            btnPlus.Enabled = false;
            btnByrja.Enabled = true;
            rad1.Enabled = false;
            rad2.Enabled = false;
            rad3.Enabled = false;
        }

        private void btnByrja_Click(object sender, EventArgs e)
        {
            txtSvar.Focus();
            btnByrja.BackColor = Color.Gray;
            try
            {

                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(sendToServer);//breytir því sem er sent til serverinn í bytes
                serverStream.Write(outStream, 0, outStream.Length);//sent til serversins
                serverStream.Flush();


                byte[] inStream = new byte[10025];//búið til byte sem tekur við skilaboðum frá servernum
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);//tekið á móti skilaboðum
                string returndata = System.Text.Encoding.ASCII.GetString(inStream); //skilaboð sett í streng
                fromServer = returndata.Split('=');//setur skilaboðin í array
                sendToTxt(fromServer[0]);//fromServer[0] er dæmið og fromServer[1] er svarið
                btnByrja.Enabled = false;
                btnSenda.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Ekki náðist samband við server.");
                Application.Exit();
            }
        }

        private void btnSenda_Click(object sender, EventArgs e)
        {
            if (txtSvar.Text != string.Empty)
            {
                try
                {
                    string answer;//það sem notandinn svarar
                    answer = txtSvar.Text;
                    txtSvar.Text = "";
                    txtSvar.Focus();
                    int rightAnswer;//rétta svarið
                    int clientAnswer;//svarið sem notandinn gefur
                    rightAnswer = Convert.ToInt32(fromServer[1]);
                    clientAnswer = Convert.ToInt32(answer);
                    if (clientAnswer == rightAnswer)//ef svarið er rétt
                    {
                        btnSenda.BackColor = Color.Green;//breyti takkanum í grænann
                        sendToServer = "right$";//þetta lætur serverinn vita að notandinn hafi svarað rétt
                    }
                    else
                    {
                        MessageBox.Show(" Rangt svar! \n Rétta svar er:" + fromServer[1]);//ef svarað er vitlaust birtist gluggi með rétta svarinu
                        btnSenda.BackColor = Color.LightBlue;//breyti takkanum í rauðann
                        sendToServer = "wrong$";//lætur serverinn vita að notandinn hafi svarað vitlaust
                    }
                    getFromServer();//nær í það sem serverinn senti
                    sendToTxt(fromServer[0]);//skrifar dæmið í textaboxið
                    stig = Convert.ToInt32(fromServer[2]);//nær í stigin frá servernum
                    lblPoints.Text = "Stig: " + stig.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ekki náðist samband við server.");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Vinsamlegast sláðu inn svar");
                txtSvar.Focus();
            }
        } 
    }
}
