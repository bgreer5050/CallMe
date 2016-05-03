using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;

namespace PrintManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCallCell_Click(object sender, EventArgs e)
        {
            MakeCall("18154120866");
        }

        private void btnCallOffice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MakeCall("17089101012").ToString());
        }

        private bool MakeCall(string strPhone)
        {
            string strCallTo = strPhone;

            throw new NotImplementedException("PUT IN ACCOUNTSID AND AUTH TOKEN INFO");
            string AccountSid = "";
            string AuthToken = "";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            // Build the parameters 
            var options = new CallOptions();
            options.To = strCallTo;
            options.From = "+17086757020";
            options.Url = "http://ositospartyrentals.com/Home/CallMindyWork";
            options.Method = "GET";
            options.FallbackMethod = "GET";
            options.StatusCallbackMethod = "GET";
            options.Record = false;

            var call = twilio.InitiateOutboundCall(options);
            if(call.Sid != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
