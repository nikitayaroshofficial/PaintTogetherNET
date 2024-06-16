using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace PaintTogetherNET
{
    public class CatnipRequest
    {
        public CatnipRequest(string type, string meta1 = null, string meta2 = null, string meta3 = null, string meta4=null, string meta5 = null, string meta6 = null) {
            this.type = type;
            this.meta1 = meta1;
            this.meta2 = meta2;
            this.meta3 = meta3;
            this.meta4 = meta4;
            this.meta5 = meta5;
            this.meta6 = meta6;
        }
        public string type { get; set; }
        public string meta1 { get; set; }
        public string meta2 { get; set; }
        public string meta3 { get; set; }
        public string meta4 { get; set; }
        public string meta5 { get; set; }
        public string meta6 { get; set; }
    }
    public class PaintTogetherServer : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            // TODO: make catnip logger
            try
            {
                CatnipRequest urd = JsonSerializer.Deserialize<CatnipRequest>(Convert.ToString(e.Data));
                if (urd.type == "pen" && CatnipDatabase.drawEnabled)
                {
                    CatnipDatabase.DEBUG_UPDATE_LOGS("User requested to:\nPEN at X: "+urd.meta1+" Y:" + urd.meta2+"\n"+"With color: rgb("+ urd.meta3+","+ urd.meta4 + "," + urd.meta5+")");
                    this.Sessions.Broadcast(e.Data);
                }
                else if (urd.type == "brush" && CatnipDatabase.drawEnabled)
                {
                    CatnipDatabase.DEBUG_UPDATE_LOGS("User requested to:\nBRUSH at X: " + urd.meta1 + " Y:" + urd.meta2 + "\n" + "With color: rgb(" + urd.meta3 + "," + urd.meta4 + "," + urd.meta5 + "), WIDTH: "+urd.meta6);
                    this.Sessions.Broadcast(e.Data);
                }
                else if (urd.type == "spray")
                {
                }
                else if (urd.type == "chat" && CatnipDatabase.chatEnabled)
                {
                    CatnipDatabase.DEBUG_UPDATE_LOGS("[ptCHAT] <" + urd.meta1 + "> " + urd.meta2);
                    this.Sessions.Broadcast(e.Data);
                }
            }
            catch
            {
                Send("{\"type\":\"error\",\"meta1\":\"invalid_catnip\"}");
            }
        }
        protected override void OnOpen()
        {
            if (!CatnipDatabase.connectionAllowed) {
                this.Send("kicked");
            }
        }
        protected void kickAll(string reason)
        {
            foreach(string ID in this.Sessions.IDs)
            {
                this.Sessions.CloseSession(ID,1000,reason);
            }
            
        }
    }
    internal class SockManager
    {
        public WebSocket receiver;
        public WebSocketServer server;
        public bool Connect(string addr)
        {
            bool WasSuccess = true;
            try
            {
                receiver = new WebSocket("ws://" + addr + ":7887/PaintTogether");
                receiver.Connect();
                WasSuccess = true;
            }
            catch
            {
                WasSuccess = false;
            }
            return WasSuccess;
        }
        public string ReceiveData()
        {
            return "";
        }
        public void PrepareForReconnection()
        {
            receiver = null;
        }
        public string getHTTP(string webaddr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webaddr);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return content;
        }
        public void BuildServer()
        {
            server = new WebSocketServer(IPAddress.Any, 7887);
            server.AddWebSocketService<PaintTogetherServer>("/PaintTogether");
        }
    }
}
