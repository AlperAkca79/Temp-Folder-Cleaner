using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Temp_Folder_Cleaner
{
    public partial class Main : Form
    {
        // Form
        string TempFolderCleaner = "Temp Folder Cleaner";
        public Main()
        {
            InitializeComponent();
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue(TempFolderCleaner).ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    loadOnSystemStartupToolStripMenuItem.Checked = true;
                }
            }
            catch
            {

            }
        }

        // Form Load
        private void Main_Load(object sender, EventArgs e)
        {

        }

        // Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                // Temp
                var tempPath = new DirectoryInfo(@"C:\Windows\Temp");
                tempPath.Attributes = tempPath.Attributes & ~FileAttributes.ReadOnly;
                tempPath.Delete(true);

                // Prefetch
                var prefetchPath = new DirectoryInfo(@"C:\Windows\Prefetch");
                prefetchPath.Attributes = prefetchPath.Attributes & ~FileAttributes.ReadOnly;
                prefetchPath.Delete(true);

                MessageBox.Show("Both Folders Cleaned!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton2.Checked)
            {
                var prefetchPath = new DirectoryInfo(@"C:\Windows\Prefetch");
                prefetchPath.Attributes = prefetchPath.Attributes & ~FileAttributes.ReadOnly;
                prefetchPath.Delete(true);

                MessageBox.Show("The Prefetch Folder is Cleared!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton1.Checked)
            {
                var tempPath = new DirectoryInfo(@"C:\Windows\Temp");
                tempPath.Attributes = tempPath.Attributes & ~FileAttributes.ReadOnly;
                tempPath.Delete(true);

                MessageBox.Show("The Temp Folder is Cleared!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Link Label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult option = MessageBox.Show("The Version History Will Open in the Web Browser. Do you want to open it?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (option == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/AlperAkca79/Temp-Folder-Cleaner/releases");
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult option = MessageBox.Show("The Source Code Will Open in the Web Browser. Do you want to open it?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (option == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/AlperAkca79/Temp-Folder-Cleaner");
            }
        }

        // Menu Strip
        // File
        // File - Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Preferences
        // Preferences - Theme - Light
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Main User Interface
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkGray;
            menuStrip1.ForeColor = Color.Black;

            // Group Box
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;

            // Button
            button1.ForeColor = Color.Black;

            // Link Label
            linkLabel1.LinkColor = Color.Green;
            linkLabel2.LinkColor = Color.Green;
        }

        // Preferences - Theme - Dark
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Main User Interface
            this.BackColor = Color.FromArgb(37, 37, 38);
            this.ForeColor = Color.White;

            // Menu Strip
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.ForeColor = Color.White;

            // Button
            button1.ForeColor = Color.Black;

            // Group Box
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;

            // Link Label
            linkLabel1.LinkColor = Color.Green;
            linkLabel2.LinkColor = Color.Green;
        }

        // Preferences - Theme - Hight Constrast
        private void hightConstrastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Preferences - Language - English
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Folder";
            groupBox2.Text = "Clear Selected Folders";
            button1.Text = "Clear";
            fileToolStripMenuItem.Text = "File";
            exitToolStripMenuItem.Text = "Exit";
            settingsToolStripMenuItem.Text = "Preferences";
            themeToolStripMenuItem.Text = "Theme";
            lightToolStripMenuItem.Text = "Light";
            darkToolStripMenuItem.Text = "Dark";
            hightConstrastToolStripMenuItem.Text = "High Contrast";
            languageToolStripMenuItem.Text = "Language";
            englishToolStripMenuItem.Text = "English";
            turkishToolStripMenuItem.Text = "Turkish";
            frenchToolStripMenuItem.Text = "French";
            germanToolStripMenuItem.Text = "German";
            russianToolStripMenuItem.Text = "Russian";
            chineseToolStripMenuItem.Text = "Chinese";
            aboutToolStripMenuItem.Text = "About";
            versionToolStripMenuItem.Text = "Program Version";
            nETVersionToolStripMenuItem.Text = ".NET Version";
            whoCreateThisProgramToolStripMenuItem.Text = "Creator";
            helpToolStripMenuItem.Text = "Help";
            webSiteToolStripMenuItem.Text = "Web Site";
            gitHubToolStripMenuItem.Text = "GitHub";
            sourceCodeToolStripMenuItem.Text = "Source Code";
            reportIssueToolStripMenuItem.Text = "Report Issue";
            linkLabel2.Text = "Source Code";
            linkLabel1.Text = "v1.0.0";
            radioButton3.Text = "Both";
            submitARequestToolStripMenuItem.Text = "Submit a Request";
            loadOnSystemStartupToolStripMenuItem.Text = "Load on System Startup";
            cancelToolStripMenuItem.Text = "Cancel";
        }

        // Preferences - Language - Turkish
        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Klasör";
            groupBox2.Text = "Seçili Dosyaları Temizle";
            button1.Text = "Temizle";
            fileToolStripMenuItem.Text = "Dosya";
            exitToolStripMenuItem.Text = "Çık";
            settingsToolStripMenuItem.Text = "Tercihler";
            themeToolStripMenuItem.Text = "Tema";
            lightToolStripMenuItem.Text = "Açık";
            darkToolStripMenuItem.Text = "Koyu";
            hightConstrastToolStripMenuItem.Text = "Yüksek Kontrast";
            languageToolStripMenuItem.Text = "Dil";
            englishToolStripMenuItem.Text = "İngilizce";
            turkishToolStripMenuItem.Text = "Türkçe";
            frenchToolStripMenuItem.Text = "Fransızca";
            germanToolStripMenuItem.Text = "Almanca";
            russianToolStripMenuItem.Text = "Rusça";
            chineseToolStripMenuItem.Text = "Çince";
            aboutToolStripMenuItem.Text = "Hakkında";
            versionToolStripMenuItem.Text = "Program Versiyonu";
            nETVersionToolStripMenuItem.Text = ".NET Versiyonu";
            whoCreateThisProgramToolStripMenuItem.Text = "Oluşturucu";
            helpToolStripMenuItem.Text = "Yardım";
            webSiteToolStripMenuItem.Text = "Web Sitesi";
            gitHubToolStripMenuItem.Text = "GitHub";
            sourceCodeToolStripMenuItem.Text = "Kaynak Kodu";
            reportIssueToolStripMenuItem.Text = "Sorun Bildir";
            linkLabel2.Text = "Kaynak Kod";
            linkLabel1.Text = "v1.0.0";
            radioButton3.Text = "Her İkisi";
            submitARequestToolStripMenuItem.Text = "İstek Bildir";
            loadOnSystemStartupToolStripMenuItem.Text = "Sistem Başlangıcında Çalıştır";
            cancelToolStripMenuItem.Text = "İptal";
        }

        // Preferences - Language - French
        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Dossier";
            groupBox2.Text = "Effacer Les Dossiers Sélectionnés";
            button1.Text = "Dégager";
            fileToolStripMenuItem.Text = "Dossier";
            exitToolStripMenuItem.Text = "Sortir";
            settingsToolStripMenuItem.Text = "Préférences";
            themeToolStripMenuItem.Text = "Théme";
            lightToolStripMenuItem.Text = "Lumiére";
            darkToolStripMenuItem.Text = "Foncé";
            hightConstrastToolStripMenuItem.Text = "Contraste éleve";
            languageToolStripMenuItem.Text = "Langue";
            englishToolStripMenuItem.Text = "Anglais";
            turkishToolStripMenuItem.Text = "Turc";
            frenchToolStripMenuItem.Text = "Français";
            germanToolStripMenuItem.Text = "Allemand";
            russianToolStripMenuItem.Text = "Russe";
            chineseToolStripMenuItem.Text = "Chinois";
            aboutToolStripMenuItem.Text = "Sur";
            versionToolStripMenuItem.Text = "Version Du Programme";
            nETVersionToolStripMenuItem.Text = "Version .NET";
            whoCreateThisProgramToolStripMenuItem.Text = "Créateur";
            helpToolStripMenuItem.Text = "Aider";
            webSiteToolStripMenuItem.Text = "Site Internet";
            gitHubToolStripMenuItem.Text = "GitHub";
            sourceCodeToolStripMenuItem.Text = "Code Source";
            reportIssueToolStripMenuItem.Text = "Signaler Un Probléme";
            linkLabel2.Text = "La Source";
            linkLabel1.Text = "v1.0.0";
            radioButton3.Text = "Tous Les Deux";
            submitARequestToolStripMenuItem.Text = "Soumettre Une Demade";
            loadOnSystemStartupToolStripMenuItem.Text = "Charger Au Démarrage Du Systéme";
            cancelToolStripMenuItem.Text = "Annuler";
        }

        // Preferences - Language - German
        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Mappe";
            groupBox2.Text = "Ausgewählte Ordner löschen";
            button1.Text = "Klar";
            fileToolStripMenuItem.Text = "Datei";
            exitToolStripMenuItem.Text = "Ausgang";
            settingsToolStripMenuItem.Text = "Einstellungen";
            themeToolStripMenuItem.Text = "Thema";
            lightToolStripMenuItem.Text = "Licht";
            darkToolStripMenuItem.Text = "Dunkel";
            hightConstrastToolStripMenuItem.Text = "Hoher Kontrast";
            languageToolStripMenuItem.Text = "Sprache";
            englishToolStripMenuItem.Text = "Englisch";
            turkishToolStripMenuItem.Text = "Türkisch";
            frenchToolStripMenuItem.Text = "Französisch";
            germanToolStripMenuItem.Text = "Deutsch";
            russianToolStripMenuItem.Text = "Russisch";
            chineseToolStripMenuItem.Text = "Chinesisch";
            aboutToolStripMenuItem.Text = "Über";
            versionToolStripMenuItem.Text = "Programmversion";
            nETVersionToolStripMenuItem.Text = "..NET-Version";
            whoCreateThisProgramToolStripMenuItem.Text = "Schöpfer";
            helpToolStripMenuItem.Text = "Hilfe";
            webSiteToolStripMenuItem.Text = "Website";
            gitHubToolStripMenuItem.Text = "GitHub";
            sourceCodeToolStripMenuItem.Text = "Quellcode";
            reportIssueToolStripMenuItem.Text = "Problem melden";
            linkLabel2.Text = "Quelle";
            linkLabel1.Text = "v1.0.0";
            radioButton3.Text = "Beide";
            submitARequestToolStripMenuItem.Text = "Senden Sie eine Anfrage";
            loadOnSystemStartupToolStripMenuItem.Text = "Laden beim Systemstart";
            cancelToolStripMenuItem.Text = "Abbrechen";
        }

        // Preferences - Languages - Russian
        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Папка";
            groupBox2.Text = "Очистка выбранных папок";
            button1.Text = "Ясный";
            fileToolStripMenuItem.Text = "Файл";
            exitToolStripMenuItem.Text = "Выход";
            settingsToolStripMenuItem.Text = "Предпочтения";
            themeToolStripMenuItem.Text = "Тема";
            lightToolStripMenuItem.Text = "Свет ";
            darkToolStripMenuItem.Text = "Темный";
            hightConstrastToolStripMenuItem.Text = "Высокая контрастность";
            languageToolStripMenuItem.Text = "Язык";
            englishToolStripMenuItem.Text = "Английский";
            turkishToolStripMenuItem.Text = "Турецкий";
            frenchToolStripMenuItem.Text = "Французский";
            germanToolStripMenuItem.Text = "Немецкий";
            russianToolStripMenuItem.Text = "Русский";
            chineseToolStripMenuItem.Text = "Китайский";
            aboutToolStripMenuItem.Text = "Около";
            versionToolStripMenuItem.Text = "Версия программы";
            nETVersionToolStripMenuItem.Text = "Версия .NET";
            whoCreateThisProgramToolStripMenuItem.Text = "Создатель";
            helpToolStripMenuItem.Text = "Справка";
            webSiteToolStripMenuItem.Text = "Веб-сайт";
            gitHubToolStripMenuItem.Text = "GitHub";
            sourceCodeToolStripMenuItem.Text = "Исходный код";
            reportIssueToolStripMenuItem.Text = "Сообщить о проблеме";
            linkLabel2.Text = "Исходный код";
            linkLabel1.Text = "v1.0.0";
            radioButton3.Text = "Оба";
            submitARequestToolStripMenuItem.Text = "Отправить запрос";
            loadOnSystemStartupToolStripMenuItem.Text = "Загрузка при запуске системы";
            cancelToolStripMenuItem.Text = "Отмена";
        }

        // Preferences - Load on System Startup
        private void loadOnSystemStartupToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (loadOnSystemStartupToolStripMenuItem.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(TempFolderCleaner, "\"" + Application.ExecutablePath + "\"");
            }

            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(TempFolderCleaner);
            }
        }


        // About
        // About - Program Version
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Version: 1.0.2", "Version Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // About - .NET Version
        private void nETVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".NET Version: 4.7.2.0", ".NET Version Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // About - Creator
        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program Coded By AlperAkca79", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // About - Programming Language
        private void programmingLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program coded with C# programming language.", "Programming Language", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Help
        // Help - Web Site
        private void webSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("The Web Site Will Open in the Web Browser. Do you want to open it?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (option == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://temp-folder-cleaner.github.io/");
            }
        }

        // Help - GitHub
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult option = MessageBox.Show("The GitHub Will Open in the Web Browser. Do you want to open it?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (option == DialogResult.OK)
            {

                System.Diagnostics.Process.Start("https://github.com/AlperAkca79");
            }
        }

        // Help - Source Code
        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("The Source Code Will Open in the Web Browser. Do you want to open it?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (option == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/AlperAkca79/Temp-Folder-Cleaner");
            }
        }

        // Help - Report Issues
        private void reportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("The Report Issue Page Will Open in the Web Browser. Do you want to open it?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (option == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/AlperAkca79/Temp-Folder-Cleaner/issues");
            }
        }
    }
}