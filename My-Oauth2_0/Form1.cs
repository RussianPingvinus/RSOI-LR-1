using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.IO;

namespace RSOI_lab1
{
    public partial class Form1 : Form
    {
        enum InitState { None, Code, Token };
        InitState selfstate = InitState.None;

        void SetState(InitState newstate)
        {
            switch (selfstate = newstate)
            {
                case InitState.None:
                    SendAuthRequest();
                    break;
                case InitState.Code:
                    SendTokenRequest();
                    break;
                case InitState.Token:
                    DoSomethingWithToken();
                    break;                    
            }
        }

        string client_id = "";
        string client_secret = "";
        string state_param = "123";
        string redirectUrl = "http://localhost";

        string sessionID;
        Random r = new Random();
        StreamWriter SW = new StreamWriter("out.txt");

        string code;
        string token;
        string access_token;
        string expires_in;

        private void SendAuthRequest()
        {

            webControl1.Source = new Uri("https://www.superjob.ru/authorize/"
                                            + "?client_id=" + client_id
                                            + "&redirect_uri=" + redirectUrl
                                            + "&state=" + state_param
            );
        }

        private void SendTokenRequest()
        {

            var rc = new RestClient("https://api.superjob.ru/2.0/oauth2/access_token/");
            var rq = new RestRequest(Method.POST);
            rq.AddParameter("code", code);
            rq.AddParameter("redirect_uri", redirectUrl);
            rq.AddParameter("client_id", client_id);
            rq.AddParameter("client_secret", client_secret);

            var response_all = rc.Execute(rq);
            var response_raw = response_all.Content;

            rtb_RecieveToken.Text = response_raw.ToString();

            var response = response_raw
                .Replace("\"", "")
                .Split(new char[] { ',', '{', '}', ':' },
                StringSplitOptions.RemoveEmptyEntries);
            if (response.Length > 0)
            {
                if (response[0] == "error")
                {
                    MessageBox.Show("Не получен access-токен");
                }
                else
                {
                    token = response_raw;
                    access_token = response[1].Trim();
                    expires_in = response[7];
                    SW.WriteLine("access_token: " + access_token);
                    SW.WriteLine("expires_in: " + expires_in);
                }
            }
        }

        private void DoSomethingWithToken()
        {
            var rc = new RestClient("https://api.superjob.ru/2.0/user/current/");
            var rq = new RestRequest(Method.GET);
/*
            rq.AddParameter("Host", "api.superjob.ru");
            rq.AddParameter("X-Api-App-Id", client_secret);
            rq.AddParameter("Authorization", ("Bearer " + access_token).ToString()); 
*/  
            rq.AddHeader("Authorization", "Bearer " + access_token); 
            
            var res = rc.Execute(rq);

            rtb_RecieveToken.Text = res.Content;

            SW.WriteLine("Login info:");
            SW.WriteLine(res.Content);
            SW.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Awesomium_Windows_Forms_WebControl_TargetURLChanged(object sender, Awesomium.Core.UrlEventArgs e)
        {
            if (webControl1.Source.AbsoluteUri.StartsWith(redirectUrl) && selfstate == InitState.None)
            {

                string s = webControl1.Source.AbsoluteUri.Split(new string[] { "localhost" }, StringSplitOptions.None).ToArray()[1];
                var parvals = s.Split(new char[] { '/', '?', '=', '&' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                try
                {
                    if (state_param != parvals[3])
                    {
                        MessageBox.Show("Не совпадают отправленный и полученный state!");
                        return;
                    }
                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message);
                    throw;
                }

                if (parvals[0] == "code")
                {
                    MessageBox.Show("Авторизация прошла успешно");
                    code = parvals[1];
                    SW.WriteLine("code: " + code);
                    SetState(InitState.Code);
                }
                else
                    if (parvals[0] == "error")
                    {
                        MessageBox.Show("Ошибка авторизации: \r\n" + parvals[3]);
                        SetState(InitState.None);
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так: \r\n" + webControl1.Source.AbsoluteUri);
                        SetState(InitState.None);
                    }
  
            }
        }

        private void Awesomium_Windows_Forms_WebControl_CertificateError(object sender, Awesomium.Core.CertificateErrorEventArgs e)
        {
            if (e.Url.OriginalString.StartsWith("http://superjob.ru"))
            {
                e.Handled = Awesomium.Core.EventHandling.Modal;
                e.Ignore = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sessionID = r.Next().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client_id = tb_ClientID.Text;
            client_secret = tb_ClientSecret.Text;

            SetState(InitState.None);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var rc = new RestClient("https://api.superjob.ru/2.0/vacancies/");
            var rq = new RestRequest(Method.GET);

//            rq.AddParameter("X-Api-App-Id", client_secret);

            rq.AddHeader("X-Api-App-Id", client_secret); 

            var res = rc.Execute(rq);

            rtb_RecieveToken.Text = res.Content;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoSomethingWithToken();
        }
    }
}
