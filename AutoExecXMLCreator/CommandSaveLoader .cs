using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoExecXMLCreator
{
    class CommandSaveLoader
    {

        public void WriteCommandsToFile(Storage info, SaveFileDialog fileDialog)
        {
            Stream fileStream = fileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(fileStream);
            foreach(Storage.Command c in info.commands)
            {
                sw.WriteLine(c.command);
                sw.WriteLine(c.chatValue);
                sw.WriteLine(c.self.ToString());
                sw.WriteLine(c.type.ToString());
            }
            sw.Flush();
            sw.Close();
        }

        public void GetCommandsFromFile(Storage info, OpenFileDialog openDialog)
        {
            List<string> commandStrings = new List<string>();
            Stream fileStream = openDialog.OpenFile();
            StreamReader sr = new StreamReader(fileStream);
            while(!sr.EndOfStream)
            {
                commandStrings.Add(sr.ReadLine());
            }
            for(int i = 0; i < commandStrings.Count; i+=4)
            {
                Storage.Command newCommand = new Storage.Command();
                newCommand.command = commandStrings[i];
                newCommand.chatValue = commandStrings[i + 1];
                newCommand.self = Convert.ToBoolean(commandStrings[i + 2]);
                newCommand.type = (Storage.AbilityType)Enum.Parse(typeof(Storage.AbilityType), commandStrings[i + 3]);
                info.commands.Add(newCommand);
            }
        }

        //public void WriteBuffsToFile()
        //{
        //    if (!Directory.Exists(@"C:\AutoExec\data"))
        //    {
        //        //if it doesn't, create it
        //        Directory.CreateDirectory(@"C:\AutoExec\data");

        //    }
        //    string fileName = @"C:AutoExec\data\commands.txt";
        //    int count = 1;
        //    while (File.Exists(fileName))
        //    {
        //        fileName = @"C:\temp\newautoexec" + count.ToString() + ".xml";
        //        count++;
        //    }
        //    if (count > 1)
        //        count--;
        //    fileName = @"C:\temp\newautoexec" + count.ToString() + ".txt";
        //    using (StreamWriter
        //        file = new StreamWriter(@"c:"))
        //        foreach (Storage.Command c in info.buffCommands)
        //        {

        //        }
        //}
    }
}
