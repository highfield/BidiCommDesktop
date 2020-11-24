using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidiCommDesktop
{
    //vedi: https://docs.microsoft.com/en-us/aspnet/core/signalr/dotnet-client?view=aspnetcore-5.0&tabs=visual-studio
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.labResult.Text = "";
            this.grpMaster.Enabled = false;

            this.btnConn.Click += BtnConn_Click;
            this.btnExec.Click += BtnExec_Click;
            this.FormClosing += Form1_FormClosing;
        }

        private HubConnection _connection;
        private readonly IProdottoService _prodottoService = new ProdottoService();


        private async void BtnConn_Click(object sender, EventArgs e)
        {
            this.txtServerURL.Enabled = false;
            this.txtMitt.Enabled = false;
            this.btnConn.Enabled = false;

            this._connection = new HubConnectionBuilder()
                .WithUrl(this.txtServerURL.Text + "myhub")
                .Build();

            this._connection.Closed += _connection_Closed;

            this._connection.On<string>("ReceiveLog", this.HandleLog);
            this._connection.On<Guid, Message>("RequestReply", this.HandleRequestReply);

            try
            {
                await this._connection.StartAsync();
                await this._connection.InvokeAsync("Hello", this.txtMitt.Text);
                this.grpMaster.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task _connection_Closed(Exception arg)
        {
            //riconnessione
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await _connection.StartAsync();
            await this._connection.InvokeAsync("Hello", this.txtMitt.Text);
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._connection?.State == HubConnectionState.Connected)
            {
                await this._connection.InvokeAsync("Bye", this.txtMitt.Text);
            }
        }


        private async Task HandleRequestReply(Guid uid, Message message)
        {
            string response = string.Empty;
            try
            {
                if (message.Destinatario == this.txtMitt.Text)
                {
                    switch (message.NomeServizio)
                    {
                        case "prodotto":
                            response = await this._prodottoService.Calcola(message.Payload);
                            break;

                        default: throw new NotSupportedException();
                    };
                }
                else
                {
                    //
                }
            }
            finally
            {
                await this._connection.InvokeAsync("ServeResponse", uid, response);
            }
        }

        private void HandleLog(string rawText)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.lstLog.Items.Add(rawText);
            }));
        }

        private async void BtnExec_Click(object sender, EventArgs e)
        {
            var jobj = new JObject()
            {
                ["a"] = double.Parse(this.txtA.Text),
                ["b"] = double.Parse(this.txtB.Text),
            };
            var message = new Message()
            {
                Mittente=this.txtMitt.Text,
                Destinatario=this.txtDest.Text,
                NomeServizio=this.txtServ.Text,
                Payload = jobj.ToString(),
            };

            string response = await this._connection.InvokeAsync<string>(
                "RequestReply",
                message
                );

            var jresp = JObject.Parse(response);
            this.labResult.Text = jresp["result"].ToString();
        }

    }

    public class Message
    {
        public string Mittente { get; set; }
        public string Destinatario { get; set; }
        public string NomeServizio { get; set; }
        public string Payload { get; set; }
    }
}
