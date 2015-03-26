using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CoolpyImageTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_post_Click(object sender, EventArgs e)
        {
            if(tb_key.Text != string.Empty && tb_url.Text != string.Empty)
            {
                byte[] array;
                string filename;

                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    if (openFileDialog1.ShowDialog() != DialogResult.OK)
                        return;
                    filename = openFileDialog1.FileName;
                    array = File.ReadAllBytes(filename);
                }
                post(array);
            }
        }

        void post(byte[] byteArray)
        {
            try
            {
                // Create a request using a URL that can receive a post. 
                WebRequest request = WebRequest.Create(tb_url.Text);
                // Set the Method property of the request to POST.
                request.Method = "POST";
                //request.ContentType = "multipart/form-data";
                request.Headers.Add("U-ApiKey", tb_key.Text);
                // Create POST data and convert it to a byte array.
                //string postData = "This is a test that posts this string to a Web server.";
                //byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/octet-stream";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;
                // Get the request stream.
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                lb_msg.Items.Insert(0, ((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                lb_msg.Items.Insert(0, responseFromServer);
                //Console.WriteLine(responseFromServer);
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                lb_msg.Items.Insert(0, ex.Message);
            }
            
        }
    }
}
