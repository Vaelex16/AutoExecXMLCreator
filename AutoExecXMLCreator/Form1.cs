using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AutoExecXMLCreator
{
    public partial class d : Form
    {
        Storage info = new Storage();
        CommandSaveLoader saveLoader = new CommandSaveLoader();

        public d()
        {
            InitializeComponent();
            InitializeListview();
            UpdateCharacterListBox();
            UpdateCommandsListBox();
        }
        
        void InitializeListview()
        {
            
        }

        void UpdateCharacterListBox()
        {
            Characters_LB.Items.Clear();
            foreach (string s in info.characters)
            {
                Characters_LB.Items.Add(s);
            }
        }

        void UpdateCommandsListBox()
        {
            Commands_LV.Clear();
            Commands_LV.View = View.Details;
            Commands_LV.GridLines = true;
            Commands_LV.FullRowSelect = true;
            Commands_LV.Columns.Add("Ability", -2, HorizontalAlignment.Left);
            Commands_LV.Columns.Add("Chat Command", -2, HorizontalAlignment.Left);
            Commands_LV.Columns.Add("Type", -2, HorizontalAlignment.Left);
            Commands_LV.Columns.Add("Self-Target", -2, HorizontalAlignment.Left);
            foreach (Storage.Command cmd in info.commands)
            {
                string selfTarget="";
                if (cmd.self)
                    selfTarget = "Yes";
                else
                    selfTarget = "No";
                var item = new ListViewItem(new[] { cmd.command, cmd.chatValue, cmd.type.ToString(), selfTarget });
                Commands_LV.Items.Add(item);
            }
            ResizeListViewColumns(Commands_LV);

        }
        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = (column.Text.Length < column.Name.Length ? -1 : -2);
            }
        }

        private void GenerateXML_BTN_Click(object sender, EventArgs e)
        {
            UpdateCBs();
            if (info.characters.Count < 1 || info.commands.Count < 1)
            {
                MessageBox.Show("You need at least one character and one command to generate the XML document.", "Setup Error");
                return;
            }
            saveFileDialog1.FileName = "newbot";
            saveFileDialog1.Filter = "XML File | *.xml";
            saveFileDialog1.ShowDialog();
            GenerateXMLDocument();
        }

        void GenerateXMLDocument()
        {
            //if (!Directory.Exists(@"C:\temp"))
            //{
            //    //if it doesn't, create it
            //    Directory.CreateDirectory(@"C:\temp");

            //}
            //string fileName = @"C:\temp\newautoexec1.xml";
            //int count = 1;
            //while (File.Exists(fileName))
            //{
            //    fileName = @"C:\temp\newautoexec" + count.ToString() + ".xml";
            //    count++;
            //}
            //if(count > 1)
            //    count--;
            //fileName = @"C:\temp\newautoexec" + count.ToString() + ".txt";
            string fileName = saveFileDialog1.FileName;
            List<string> outputCommands = new List<string>();
            outputCommands.Add("<?xml version=\"1.2\" ?>");
            outputCommands.Add("<autoexec>");

            foreach (string character in info.characters)
            {
                outputCommands.Add("");
                if(info.party)
                {
                    //follow
                    string writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_follow\">";
                    writeString += "input /follow " + character + "</register>";
                    outputCommands.Add(writeString);
                    //rest
                    writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_rest\">";
                    writeString += "input /rest </register>";
                    outputCommands.Add(writeString);
                    //assist
                    writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_assist\">";
                    writeString += "input /assist " + character + "</register>";
                    outputCommands.Add(writeString);
                    //attack
                    writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_atk\">";
                    writeString += "input /attack </register>";
                    outputCommands.Add(writeString);
                }
                if (info.tell)
                {
                    //follow
                    string writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_follow\">";
                    writeString += "input /follow " + character + "</register>";
                    outputCommands.Add(writeString);
                    //rest
                    writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_rest\">";
                    writeString += "input /rest </register>";
                    outputCommands.Add(writeString);
                    //assist
                    writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_assist\">";
                    writeString += "input /assist " + character + "</register>";
                    outputCommands.Add(writeString);
                    //attack
                    writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_atk\">";
                    writeString += "input /attack </register>";
                    outputCommands.Add(writeString);
                }
                if (info.ls)
                {
                    //follow
                    string writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_follow\">";
                    writeString += "input /follow " + character + "</register>";
                    outputCommands.Add(writeString);
                    //rest
                    writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_rest\">";
                    writeString += "input /rest </register>";
                    outputCommands.Add(writeString);
                    //assist
                    writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_assist\">";
                    writeString += "input /assist " + character + "</register>";
                    outputCommands.Add(writeString);
                    //attack
                    writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_atk\">";
                    writeString += "input /attack </register>";
                    outputCommands.Add(writeString);
                }
                if (info.ls2)
                {
                    //follow
                    string writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_follow\">";
                    writeString += "input /follow " + character + "</register>";
                    outputCommands.Add(writeString);
                    //rest
                    writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_rest\">";
                    writeString += "input /rest </register>";
                    outputCommands.Add(writeString);
                    //assist
                    writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_assist\">";
                    writeString += "input /assist " + character + "</register>";
                    outputCommands.Add(writeString);
                    //attack
                    writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_atk\">";
                    writeString += "input /attack </register>";
                    outputCommands.Add(writeString);
                }

                outputCommands.Add("");
                foreach (Storage.Command command in info.commands)
                {
                    // Party
                    if (info.party)
                    {
                        if (command.type == Storage.AbilityType.Buff)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            if (!command.self)
                                writeString += "input /ma \"" + command.command + "\" " + character + "</register>";
                            else
                                writeString += "input /ma \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.MagicAttack)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ma \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.JobAbility)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ja \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.WeaponSkill)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_party_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ws \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                    }                    
                    // Tell
                    if (info.tell)
                    {
                        if (command.type == Storage.AbilityType.Buff)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            if (!command.self)
                                writeString += "input /ma \"" + command.command + "\" " + character + "</register>";
                            else
                                writeString += "input /ma \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.MagicAttack)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ma \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.JobAbility)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ja \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.WeaponSkill)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_tell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ws \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                    }
                    //LS
                    if (info.ls)
                    {
                        if (command.type == Storage.AbilityType.Buff)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            if (!command.self)
                                writeString += "input /ma \"" + command.command + "\" " + character + "</register>";
                            else
                                writeString += "input /ma \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.MagicAttack)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ma \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.JobAbility)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ja \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.WeaponSkill)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ws \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                    }
                    // LS2
                    if (info.ls2)
                    {
                        if (command.type == Storage.AbilityType.Buff)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            if (!command.self)
                                writeString += "input /ma \"" + command.command + "\" " + character + "</register>";
                            else
                                writeString += "input /ma \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.MagicAttack)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ma \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.JobAbility)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ja \"" + command.command + "\" &lt;me&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                        else if (command.type == Storage.AbilityType.WeaponSkill)
                        {
                            // Create the parse
                            string writeString = " <register silent=\"true\" event=\"chat_linkshell2_" + character + "_" + command.chatValue + "\">";
                            // Add the input
                            writeString += "input /ws \"" + command.command + "\" &lt;bt&gt;</register>";
                            outputCommands.Add(writeString);
                        }
                    }
                }
            }

            outputCommands.Add("</autoexec>");

            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(fileName))
            {
                foreach (string line in outputCommands)
                {
                        file.WriteLine(line);
                }
            }

            FileInfo f = new FileInfo(fileName);
            f.MoveTo(Path.ChangeExtension(fileName, ".xml"));
        }

        private void RemoveChar_BTN_Click(object sender, EventArgs e)
        {
            if (Characters_LB.SelectedIndex < 0)
            {
                MessageBox.Show("You do not have a character selected!", "Error");
                return;
            }
            info.characters.RemoveAt(Characters_LB.SelectedIndex);
            UpdateCharacterListBox();
        }

        private void AddChar_BTN_Click(object sender, EventArgs e)
        {
            if(NewChar_TB.Text.Length < 1)
            {
                MessageBox.Show("You need a valid character name!", "Error");
                return;
            }
            info.characters.Add(NewChar_TB.Text);
            NewChar_TB.Text = "";
            UpdateCharacterListBox();
        }

        private void RemoveCmd_BTN_Click(object sender, EventArgs e)
        {
            if (Commands_LV.SelectedIndices.Count == 0)
            {
                MessageBox.Show("You do not have a command selected!", "Error");
                return;
            }
            info.commands.RemoveAt(Commands_LV.SelectedIndices[0]);
            Commands_LV.Items.Clear();
            UpdateCommandsListBox();
        }

        private void AddCommands_BTN_Click(object sender, EventArgs e)
        {
            if( ChatValue_TB.Text.Length == 0 || NewCommand_TB.Text.Length == 0 || Type_CB.SelectedItem == null)
            {
                MessageBox.Show("You are missing a command field, make sure everything has been entered!", "Error");
                return;
            }
            Storage.Command newCommand = new Storage.Command();
            newCommand.chatValue = ChatValue_TB.Text;
            newCommand.command = NewCommand_TB.Text;
            newCommand.self = SelfTarget_CKB.Checked;
            if (Type_CB.SelectedItem.ToString().Equals("Buff"))
                newCommand.type = Storage.AbilityType.Buff;
            else if (Type_CB.SelectedItem.ToString().Equals("Magic Attack"))
                newCommand.type = Storage.AbilityType.MagicAttack;
            else if (Type_CB.SelectedItem.ToString().Equals("Job Ability"))
                newCommand.type = Storage.AbilityType.JobAbility;
            else if (Type_CB.SelectedItem.ToString().Equals("Weapon Skill"))
                newCommand.type = Storage.AbilityType.WeaponSkill;
            foreach(Storage.Command c in info.commands)
            {
                if(c.chatValue.Equals(newCommand.chatValue))
                {
                    MessageBox.Show("Another command already has this chat value! Please use a different value.", "Error");
                    return;
                }
            }

            var item = new ListViewItem(new[] { newCommand.command, newCommand.chatValue, newCommand.type.ToString(), newCommand.self.ToString() });

            info.commands.Add(newCommand);
            Commands_LV.Items.Add(item);
            Commands_LV.Items.Clear();
            UpdateCommandsListBox();
        }        

        void UpdateCBs()
        {
            info.party = Party_CB.Checked;
            info.tell = Tell_CB.Checked;
            info.ls = LS_CB.Checked;
            info.ls2 = LS2_CB.Checked;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase + "/basebots");
            openFileDialog1.Filter = "Command Text File | *.cmdtxt";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            saveLoader.GetCommandsFromFile(info, openFileDialog1);
            UpdateCommandsListBox();
            openFileDialog1.Reset();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "commands";
            saveFileDialog1.Filter = "Command Text File | *.cmdtxt";
            saveFileDialog1.ShowDialog();
            saveLoader.WriteCommandsToFile(info, saveFileDialog1);
            saveFileDialog1.Reset();
        }

        private void d_Load(object sender, EventArgs e)
        {

        }

        private void RemoveAll_BTN_Click(object sender, EventArgs e)
        {
            Commands_LV.Items.Clear();
            info.commands.Clear();
            UpdateCommandsListBox();
        }
        
    }
}
