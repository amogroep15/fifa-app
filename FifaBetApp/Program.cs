using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FifaBetApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            User bowser = new User("bowser");

            Stream stream = File.Open("UserData.dat",
                FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, bowser);
            stream.Close();

            bowser = null;

            stream = File.Open("UserData.dat", FileMode.Open);

            bf = new BinaryFormatter();

            bowser = (User)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine(bowser.ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new checkForm());
        }
    }
}
