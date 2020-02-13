using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace shitty_app_for_saving_time
{
    public class Pair<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }
        public Pair() { }
    }
    public partial class MainWindow : Form
    {
        [DllImport("Shlwapi.dll")]
        public static extern bool PathIsDirectoryA(string path);


        private         String m_preferenceRegPath = null;
        private const   String m_keyName           = "UserMapDir";

        private bool IsWow64()
        {
            return Environment.Is64BitOperatingSystem;
        }
        private readonly String[] m_regPaths =
        {
            "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\BlueByte\\Settlers4\\S4Editor",
            "HKEY_LOCAL_MACHINE\\SOFTWARE\\BlueByte\\Settlers4\\S4Editor"
        };

        public String GetPreferenceRegPath()
        {
            if (IsWow64())
                return m_regPaths[0];
            else
                return m_regPaths[1];
        }
        /*
         * Returns: Pair<RegPath,RegPathKeyValue>
         * */
        public Pair<String,String> FindEditorExportPath()
        {
            Pair<String, String> pair = new Pair<String,String>();
            pair.First = GetPreferenceRegPath();
            pair.Second = (String)Registry.GetValue(GetPreferenceRegPath(), m_keyName, null);
            if(pair.Second == null)
            {
                foreach (String regPath in m_regPaths)
                {
                    pair.First = regPath;
                    pair.Second = (String)Registry.GetValue(regPath, m_keyName, null);
                    if (pair.Second != null) break;
                }
            }
            return pair;
        }

        public void SetEditorExportPath(String path)
        {
            // \\ for S4Editor separation as folder folder\\file.map
            if (!path.EndsWith("\\"))
                path += "\\";
            Registry.SetValue(m_preferenceRegPath, m_keyName, path);
        }

        public MainWindow()
        {
            InitializeComponent();
            //Find registry value 
            Pair<String,String> currentPair = FindEditorExportPath();
            if(currentPair.Second == null)
            {
                MessageBox.Show("Ich konnte keinen Exportierpfad finden. Hast du den Editor schonmal gestartet gehabt?","Nichts gefunden!");
                System.Environment.Exit(0x100);
            }
            else
            {
                m_preferenceRegPath = currentPair.First;
            }
            textBox1.Text = currentPair.Second;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by MuffinMario on a boring no-internet day. \nActually I got homework to do, but I dont want to do them.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //search for folder
            var folderBrowserDialog = new FolderBrowserDialog();
            String path = textBox1.Text;
            if (PathIsDirectoryA(path))
            {
                folderBrowserDialog.SelectedPath = path;
            }
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //set value 
            String path = textBox1.Text;
            if (PathIsDirectoryA(path))
            {
                if(!Directory.Exists(path))
                {
                    /* Doubting that this will happen. PathIsDirectory only returns true on existing paths */
                    DialogResult yesnoresult = MessageBox.Show("Achtung!", "Der ausgewählte Ordner existiert nicht. Das Exportieren wird auch funktionieren. Möchten Sie Fortfahren?", MessageBoxButtons.YesNo);
                    if(yesnoresult != DialogResult.Yes)
                    {
                        infoLabel.ForeColor = Color.Orange;
                        infoLabel.Text = "Operation abgebrochen";
                        infoLabel.Visible = true;
                        return;
                    }
                }
                SetEditorExportPath(path);
                infoLabel.ForeColor = Color.DarkGreen;
                infoLabel.Text = "Ordner erfolgreich geändert!";
                infoLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Du musst einen korrekten Ordner angeben");
            }
        }
    }
}
