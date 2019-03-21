using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Text.RegularExpressions;
using System.Linq;
[assembly: AssemblyTitle("JailPriority Plugin")]
[assembly: AssemblyVersion("1.0.0.3")]

namespace ACT_Plugin
{
    public class JailPriority : UserControl, IActPluginV1
    {
        #region Designer Created Code (Avoid editing)
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1RadioButton = new System.Windows.Forms.RadioButton();
            this.player2RadioButton = new System.Windows.Forms.RadioButton();
            this.player3RadioButton = new System.Windows.Forms.RadioButton();
            this.player4RadioButton = new System.Windows.Forms.RadioButton();
            this.player5RadioButton = new System.Windows.Forms.RadioButton();
            this.player6RadioButton = new System.Windows.Forms.RadioButton();
            this.player7RadioButton = new System.Windows.Forms.RadioButton();
            this.player8RadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.player3TextBox = new System.Windows.Forms.TextBox();
            this.player4TextBox = new System.Windows.Forms.TextBox();
            this.player5TextBox = new System.Windows.Forms.TextBox();
            this.player6TextBox = new System.Windows.Forms.TextBox();
            this.player7TextBox = new System.Windows.Forms.TextBox();
            this.player8TextBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tts1TextBox = new System.Windows.Forms.TextBox();
            this.tts2TextBox = new System.Windows.Forms.TextBox();
            this.tts3TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.logsTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1RadioButton
            // 
            this.player1RadioButton.AutoSize = true;
            this.player1RadioButton.Checked = true;
            this.player1RadioButton.Location = new System.Drawing.Point(3, 14);
            this.player1RadioButton.Name = "player1RadioButton";
            this.player1RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player1RadioButton.TabIndex = 0;
            this.player1RadioButton.TabStop = true;
            this.player1RadioButton.UseVisualStyleBackColor = true;
            this.player1RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // player2RadioButton
            // 
            this.player2RadioButton.AutoSize = true;
            this.player2RadioButton.Location = new System.Drawing.Point(3, 37);
            this.player2RadioButton.Name = "player2RadioButton";
            this.player2RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player2RadioButton.TabIndex = 1;
            this.player2RadioButton.TabStop = true;
            this.player2RadioButton.UseVisualStyleBackColor = true;
            this.player2RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // player3RadioButton
            // 
            this.player3RadioButton.AutoSize = true;
            this.player3RadioButton.Location = new System.Drawing.Point(3, 60);
            this.player3RadioButton.Name = "player3RadioButton";
            this.player3RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player3RadioButton.TabIndex = 2;
            this.player3RadioButton.TabStop = true;
            this.player3RadioButton.UseVisualStyleBackColor = true;
            this.player3RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // player4RadioButton
            // 
            this.player4RadioButton.AutoSize = true;
            this.player4RadioButton.Location = new System.Drawing.Point(3, 83);
            this.player4RadioButton.Name = "player4RadioButton";
            this.player4RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player4RadioButton.TabIndex = 3;
            this.player4RadioButton.TabStop = true;
            this.player4RadioButton.UseVisualStyleBackColor = true;
            this.player4RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // player5RadioButton
            // 
            this.player5RadioButton.AutoSize = true;
            this.player5RadioButton.Location = new System.Drawing.Point(3, 106);
            this.player5RadioButton.Name = "player5RadioButton";
            this.player5RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player5RadioButton.TabIndex = 4;
            this.player5RadioButton.TabStop = true;
            this.player5RadioButton.UseVisualStyleBackColor = true;
            this.player5RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // player6RadioButton
            // 
            this.player6RadioButton.AutoSize = true;
            this.player6RadioButton.Location = new System.Drawing.Point(3, 129);
            this.player6RadioButton.Name = "player6RadioButton";
            this.player6RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player6RadioButton.TabIndex = 5;
            this.player6RadioButton.TabStop = true;
            this.player6RadioButton.UseVisualStyleBackColor = true;
            this.player6RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // player7RadioButton
            // 
            this.player7RadioButton.AutoSize = true;
            this.player7RadioButton.Location = new System.Drawing.Point(3, 152);
            this.player7RadioButton.Name = "player7RadioButton";
            this.player7RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player7RadioButton.TabIndex = 6;
            this.player7RadioButton.TabStop = true;
            this.player7RadioButton.UseVisualStyleBackColor = true;
            this.player7RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // player8RadioButton
            // 
            this.player8RadioButton.AutoSize = true;
            this.player8RadioButton.Location = new System.Drawing.Point(3, 175);
            this.player8RadioButton.Name = "player8RadioButton";
            this.player8RadioButton.Size = new System.Drawing.Size(14, 13);
            this.player8RadioButton.TabIndex = 7;
            this.player8RadioButton.TabStop = true;
            this.player8RadioButton.UseVisualStyleBackColor = true;
            this.player8RadioButton.CheckedChanged += new System.EventHandler(this.updatePlayerIndex);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.player1TextBox);
            this.panel1.Controls.Add(this.player2TextBox);
            this.panel1.Controls.Add(this.player3TextBox);
            this.panel1.Controls.Add(this.player4TextBox);
            this.panel1.Controls.Add(this.player5TextBox);
            this.panel1.Controls.Add(this.player6TextBox);
            this.panel1.Controls.Add(this.player7TextBox);
            this.panel1.Controls.Add(this.player8TextBox);
            this.panel1.Controls.Add(this.player1RadioButton);
            this.panel1.Controls.Add(this.player2RadioButton);
            this.panel1.Controls.Add(this.player3RadioButton);
            this.panel1.Controls.Add(this.player4RadioButton);
            this.panel1.Controls.Add(this.player5RadioButton);
            this.panel1.Controls.Add(this.player6RadioButton);
            this.panel1.Controls.Add(this.player7RadioButton);
            this.panel1.Controls.Add(this.player8RadioButton);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 211);
            this.panel1.TabIndex = 8;
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(23, 11);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(164, 20);
            this.player1TextBox.TabIndex = 8;
            this.player1TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(23, 34);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(164, 20);
            this.player2TextBox.TabIndex = 9;
            this.player2TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player3TextBox
            // 
            this.player3TextBox.Location = new System.Drawing.Point(23, 57);
            this.player3TextBox.Name = "player3TextBox";
            this.player3TextBox.Size = new System.Drawing.Size(164, 20);
            this.player3TextBox.TabIndex = 10;
            this.player3TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player4TextBox
            // 
            this.player4TextBox.Location = new System.Drawing.Point(23, 80);
            this.player4TextBox.Name = "player4TextBox";
            this.player4TextBox.Size = new System.Drawing.Size(164, 20);
            this.player4TextBox.TabIndex = 11;
            this.player4TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player5TextBox
            // 
            this.player5TextBox.Location = new System.Drawing.Point(23, 103);
            this.player5TextBox.Name = "player5TextBox";
            this.player5TextBox.Size = new System.Drawing.Size(164, 20);
            this.player5TextBox.TabIndex = 12;
            this.player5TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player6TextBox
            // 
            this.player6TextBox.Location = new System.Drawing.Point(23, 126);
            this.player6TextBox.Name = "player6TextBox";
            this.player6TextBox.Size = new System.Drawing.Size(164, 20);
            this.player6TextBox.TabIndex = 13;
            this.player6TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player7TextBox
            // 
            this.player7TextBox.Location = new System.Drawing.Point(23, 148);
            this.player7TextBox.Name = "player7TextBox";
            this.player7TextBox.Size = new System.Drawing.Size(164, 20);
            this.player7TextBox.TabIndex = 14;
            this.player7TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // player8TextBox
            // 
            this.player8TextBox.Location = new System.Drawing.Point(23, 171);
            this.player8TextBox.Name = "player8TextBox";
            this.player8TextBox.Size = new System.Drawing.Size(164, 20);
            this.player8TextBox.TabIndex = 15;
            this.player8TextBox.TextChanged += new System.EventHandler(this.updatePlayers);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(130, 244);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportPriorityList);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(3, 244);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 10;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importPriorityList);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(437, 33);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(201, 80);
            this.instructionLabel.TabIndex = 11;
            this.instructionLabel.Text = "1. Write priority list.\r\n2. Select your name.\r\n3. Set up your TSS triggers.\r\n\r\nyo" +
    "u can export/import priority list.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tts1TextBox);
            this.panel2.Controls.Add(this.tts2TextBox);
            this.panel2.Controls.Add(this.tts3TextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(211, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 86);
            this.panel2.TabIndex = 13;
            // 
            // tts1TextBox
            // 
            this.tts1TextBox.Location = new System.Drawing.Point(54, 8);
            this.tts1TextBox.Name = "tts1TextBox";
            this.tts1TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts1TextBox.TabIndex = 3;
            this.tts1TextBox.Text = "First";
            this.tts1TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // tts2TextBox
            // 
            this.tts2TextBox.Location = new System.Drawing.Point(54, 34);
            this.tts2TextBox.Name = "tts2TextBox";
            this.tts2TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts2TextBox.TabIndex = 4;
            this.tts2TextBox.Text = "Second";
            this.tts2TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // tts3TextBox
            // 
            this.tts3TextBox.Location = new System.Drawing.Point(54, 60);
            this.tts3TextBox.Name = "tts3TextBox";
            this.tts3TextBox.Size = new System.Drawing.Size(163, 20);
            this.tts3TextBox.TabIndex = 5;
            this.tts3TextBox.Text = "Third";
            this.tts3TextBox.TextChanged += new System.EventHandler(this.updateTSS);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "3rd TTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "2nd TTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "1st TTS";
            // 
            // logsTextBox
            // 
            this.logsTextBox.Location = new System.Drawing.Point(211, 119);
            this.logsTextBox.MaxLength = 1000000;
            this.logsTextBox.Multiline = true;
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ReadOnly = true;
            this.logsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logsTextBox.Size = new System.Drawing.Size(427, 148);
            this.logsTextBox.TabIndex = 14;
            this.logsTextBox.Text = "Started..";
            this.logsTextBox.WordWrap = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(506, 270);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(132, 13);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Discord: @Tarutella#3846";
            // 
            // JailPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.logsTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.panel1);
            this.Name = "JailPriority";
            this.Size = new System.Drawing.Size(969, 493);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void updatePlayerIndex(object sender, EventArgs e)
        {

            RadioButton[] radios = panel1.Controls.OfType<RadioButton>().ToArray();
            for (int i = 0; i < radios.Length; i++)
            {
                if (radios[i].Checked)
                {
                    yourIndex = i;
                    break;
                }
            }
        }

        #endregion

        #endregion
        public JailPriority()
        {
            InitializeComponent();
        }
        Label lblStatus;    // The status label that appears in ACT's Plugin tab
        string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\TitanJail.config.xml");
        private RadioButton player5RadioButton;
        private RadioButton player4RadioButton;
        private RadioButton player6RadioButton;
        private RadioButton player2RadioButton;
        private RadioButton player7RadioButton;
        private RadioButton player3RadioButton;
        private RadioButton player8RadioButton;
        private RadioButton player1RadioButton;
        private Panel panel1;
        private TextBox player8TextBox;
        private TextBox player7TextBox;
        private TextBox player6TextBox;
        private TextBox player5TextBox;
        private TextBox player4TextBox;
        private TextBox player3TextBox;
        private TextBox player2TextBox;
        private TextBox player1TextBox;
        private Button exportButton;
        private Button importButton;
        private Label instructionLabel;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tts3TextBox;
        private TextBox tts2TextBox;
        private TextBox tts1TextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox logsTextBox;
        private Label infoLabel;
        SettingsSerializer xmlSettings;

        #region IActPluginV1 Members
        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
            pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
            this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
            xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
            LoadSettings();
            ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
            lblStatus.Text = "Plugin Started";
        }
        List<String> orderPlayers = new List<string>();// list of players matched in logLine
        List<String> order = new List<String>(); // List of TTS Callouts
        List<String> players = new List<String>(); // All players in priority list
        String regex = ":(.*)?:2B6(B|C):.*?:.*?:"; // regex for jails
        int countMatches = 0;// number of matchups to the regex
        int yourIndex = 0;// player's index in the priority list
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            var match = Regex.Match(logInfo.logLine, regex, RegexOptions.IgnoreCase);
            if (!match.Success)
                return;
            if (stopwatch.ElapsedMilliseconds > 1000)//if elapsed time since 1st matchup > 1 second. reset stopwatch
            {
                logsTextBox.Text += "\r\n\r\n" + "=======[RESET]=======";
                stopwatch.Reset();
                countMatches = 0;
                orderPlayers.Clear();
            }
            logsTextBox.Text += "\r\n" + logInfo.logLine;
            stopwatch.Start();
            for (int i = 0; i < players.Count; i++)
            {
                if (logInfo.logLine.Contains(players[i]))
                    orderPlayers.Add(players[i]);
            }
            countMatches++;
            int y = 0;
            if (countMatches != 3)
                return;
            if (countMatches != orderPlayers.Count)
            {
                logsTextBox.Text += "\r\n" + "-[Incorrect name/s in priority list!]-";
                return;
            }
            for (int i = 0; i < players.Count; i++)
            {
                if (orderPlayers.Contains(players[i]))
                {
                    if (players[i] == players[yourIndex])
                    {
                        ActGlobals.oFormActMain.TTS(order[y]);
                        logsTextBox.Text += "\r\n" + "---[" + (i + 1) + "]---[" + players[i] + "]------>-----" + order[y] + "---<--[YOU]";
                    }
                    else
                    {
                        logsTextBox.Text += "\r\n" + "---[" + (i + 1) + "]---[" + players[i] + "]------>-----" + order[y] + "-------------";
                    }
                    y++;
                }
            }
        }
        
    public void DeInitPlugin()
        {
            // Unsubscribe from any events you listen to when exiting!
            ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;
            SaveSettings();
            lblStatus.Text = "Plugin Exited";
        }
        #endregion


        void LoadSettings()
        {

            if (File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlTextReader xReader = new XmlTextReader(fs);
                TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
                TextBox[] Order = panel2.Controls.OfType<TextBox>().ToArray();
                try
                {
                    int i = 0;
                    int j = 0;
                    while (xReader.Read())
                    {
                        if (xReader.NodeType == XmlNodeType.Element)
                        {
                            if (xReader.LocalName == "You")
                            {
                                yourIndex = xReader.ReadElementContentAsInt();
                                panel1.Controls.OfType<RadioButton>().ToArray()[yourIndex].Checked = true;
                            }
                            if (xReader.Name == "Player")
                            {
                                String line = xReader.ReadElementContentAsString();
                                players.Add(line);
                                Players[i].Text = line;
                                i++;
                            }
                            if (xReader.Name == "Order")
                            {
                                String line = xReader.ReadElementContentAsString();
                                order.Add(line);
                                Order[j].Text = line;
                                j++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error loading settings: " + ex.Message;
                }
                xReader.Close();
            }
            else
            {
                updateTSS();
            }
        }
        void SaveSettings()
        {
            FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
            TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
            TextBox[] Order = panel2.Controls.OfType<TextBox>().ToArray();
            xWriter.Formatting = Formatting.Indented;
            xWriter.Indentation = 1;
            xWriter.IndentChar = '\t';
            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("Config");    // <Config>
            xWriter.WriteStartElement("You");
            xWriter.WriteValue(yourIndex);
            xWriter.WriteEndElement();
            for (int i = 0; i < Players.Length; i++)
            {
                xWriter.WriteStartElement("Player");
                xWriter.WriteValue(Players[i].Text);
                xWriter.WriteEndElement();
            }
            for (int i = 0; i < Order.Length; i++)
            {
                xWriter.WriteStartElement("Order");
                xWriter.WriteValue(Order[i].Text);
                xWriter.WriteEndElement();
            }
            xWriter.WriteEndElement();  // </Config>
            xWriter.WriteEndDocument(); // Tie up loose ends (shouldn't be any)
            xWriter.Flush();    // Flush the file buffer to disk
            xWriter.Close();
        }

        private void exportPriorityList(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "Priority.xml";
            // set filters - this can be done in properties as well
            savefile.Filter = "XML file (*.xml)|*.xml|All files (*.*)|*.*";
            savefile.RestoreDirectory = true;
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(savefile.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                    {
                        XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
                        TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
                        xWriter.Formatting = Formatting.Indented;
                        xWriter.Indentation = 1;
                        xWriter.IndentChar = '\t';
                        xWriter.WriteStartDocument(true);
                        xWriter.WriteStartElement("Priority");
                        for (int i = 0; i < Players.Length; i++)
                        {
                            xWriter.WriteStartElement("Player");
                            xWriter.WriteValue(Players[i].Text);
                            xWriter.WriteEndElement();
                        }
                        xWriter.WriteEndElement();
                        xWriter.WriteEndDocument();
                        xWriter.Flush();
                        xWriter.Close();
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error Exporting File: " + ex.Message;
                }
            }
        }
        private void importPriorityList(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "XML file (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    try
                    {
                        FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
                        XmlTextReader xReader = new XmlTextReader(fs);
                        int i = 0;
                        while (xReader.Read())
                        {
                            if (xReader.NodeType == XmlNodeType.Element)
                            {
                                if (xReader.Name == "Player")
                                {
                                    Players[i].Text = xReader.ReadElementContentAsString();
                                    i++;
                                }
                            }
                        }
                        xReader.Close();
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = "Error Importing File: " + ex.Message;
                    }

                }
            }
        }

        private void updatePlayers(object sender, EventArgs e)
        {
            players.Clear();
            TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
            for (int i = 0; i < Players.Length; i++)
            {
                players.Add(Players[i].Text);
            }
        }

        private void updateTSS(object sender, EventArgs e)
        {
            updateTSS();
        }
        private void updateTSS()
        {
            order.Clear();
            TextBox[] Order = panel2.Controls.OfType<TextBox>().ToArray();
            for (int i = 0; i < Order.Length; i++)
            {
                order.Add(Order[i].Text);
            }
        }

    }
}
