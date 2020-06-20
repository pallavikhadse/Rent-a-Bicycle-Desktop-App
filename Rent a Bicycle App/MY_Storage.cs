using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Rent_a_Bicycle_App
{
    public class MY_Storage
    {
        public static void WriteXml<T>(T data, string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                FileStream stream;
                stream = new FileStream(filename, FileMode.Create);

                serializer.Serialize(stream, data);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                throw;
            }
        }

        public static T ReadXml<T>(string file)
            {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                return default(T);
            }
            }
    }
}
