using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace PaintTogetherNET
{
    public class CatnipServerUser
    {
        public bool PERM_DRAW;
        public bool PERM_FILL;
        public bool PERM_LOAD;
        public bool PERM_BAN;
        public bool PERM_KICK;

        public bool IS_BANNED;

    }
    public class ConnectedToServer
    {
        public ConnectedToServer() { }
        public string addr { get; set; }
        public string desc { get; set; }
        public int port { get; set; }
        public string un { get; set; }
        public string up { get; set; }
    }
    public class CatnipServerData
    {
        public bool serverPublic = false;
        public bool requireServerAuthorization = false;
        public string serverTitle = "";
        public string serverDescription = "";
        public string[] banips;
        public CatnipServerUser[] serverAccounts;
        public void TestFunc()
        {
            banips.Append("256.256.256.256");
        }
    }
    static internal class CatnipDatabase
    {
        static public bool appClosing = false;
        public const string CURRENT_VERSION = "ver_a035_a";
        static public bool loadMainMenu = false;
        static public bool shouldUpdateLogMon = false;
        static public string currentLogMonString = "";
        static public bool shouldUpdateChat = false;
        static public string currentChatString = "";
        static public bool shouldVerboseEverything = true;

        static public bool chatEnabled = true;
        static public bool drawEnabled = true;
        static public bool connectionAllowed = true;

        static public bool hasServer = false;
        static public bool hasClient = false;

        static public bool init = false;
        static public bool isLoggedIn;
        static public string username;
        static public string passwordHash;

        public static CatnipServerData _serverData;
        public static ConnectedToServer connection;
        public static SockManager wsman = new SockManager();

        static bool loadFromCatnipFile(string filepath)
        {
            bool WasSuccess = true;
            string savedataraw = "";
            try
            {
                StreamReader reader = new StreamReader(filepath);
                savedataraw = reader.ReadToEnd();
                reader.Close();
            }
            catch
            {
                WasSuccess = false;
            }
            if (savedataraw.Substring(0, 6) == "CATNIP")
            {
                string role = savedataraw.Substring(6, 2); 
                savedataraw = savedataraw.Substring(8);
                savedataraw = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(savedataraw));
                decodeCatnipNotation(savedataraw, role);
            }
            else
            {
                WasSuccess = false;
            }
            return WasSuccess;
        }
        static public void DEBUG_UPDATE_LOGS(string logmsg)
        {
            currentLogMonString = logmsg;
            shouldUpdateLogMon = true;
        }
        static public void CHAT_LOG(string logmsg)
        {
            currentChatString = logmsg;
            shouldUpdateChat = true;
        }

        static bool decodeCatnipNotation(string catnip, string role)
        {
            bool WasSuccess = true;
            try
            {
                if (role == "SD")
                {
                    _serverData = JsonSerializer.Deserialize<CatnipServerData>(catnip);
                }
                else if (role == "SL")
                {
                    MessageBox.Show("Внимание! Обнаружен файл устаревшей CATNIP-нотации", "Paint Together .NET Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch{
                WasSuccess=false;
            }
            return WasSuccess;
        }
    }
}
