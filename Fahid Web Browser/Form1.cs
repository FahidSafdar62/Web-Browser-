using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


  

namespace Fahid_Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("www.google.com"); 
            
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.WebBrowserShortcutsEnabled = false;
          
           
           
{
     // this code sets the height and the width of the WebBrowser element.
    
}

        }




        // Click a button ------------------------------

        private void ClickButton(string tag, string attribute, string attName)
        {
            HtmlElementCollection col = webBrowser1.Document.GetElementsByTagName(tag);

            foreach (HtmlElement element in col)
            {

                if (element.GetAttribute(attribute).Equals(attName))
                {

                    element.InvokeMember("click");
                }
            }
        }

        // Fill up a input ---------------------------------

        private void SetText(string tag, string attribute, string attName, string value)
        {

            // Get a collection of all the tags with name "input";

            HtmlElementCollection tagsCollection = webBrowser1.Document.GetElementsByTagName(tag);

            foreach (HtmlElement currentTag in tagsCollection)
            {

                // If the attribute of the current tag has the name attName

                if (currentTag.GetAttribute(attribute).Equals(attName))

                    // Then set its attribute "value".

                    currentTag.SetAttribute("value", value);
            }
        }
      

           

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x08000000;
                return parms;
            }
        }

      
        

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           if (webBrowser1.CanGoForward)
        webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
          
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            webBrowser1.Navigate("https://www.google.com/");
           
          
            
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            ProgressBar1.Maximum = (int)e.MaximumProgress;
           ProgressBar1.Value = ((int)e.CurrentProgress < 0 ||
            (int)e.MaximumProgress < (int)e.CurrentProgress) ? (int)e.MaximumProgress : (int)e.CurrentProgress;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.CanGoBack) toolStripButton1.Enabled = true;
            else toolStripButton1.Enabled = false;

            if (webBrowser1.CanGoForward) toolStripButton2.Enabled = true;
            else toolStripButton2.Enabled = false;
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
          
        }
    
public  bool ScriptErrorsSuppressed { get; set; }

private void ProgressBar1_Click(object sender, EventArgs e)
{

}

private void Form1_Load(object sender, EventArgs e)
{
    toolStripButton1.Enabled = false;
    toolStripButton2.Enabled = false;
}

private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{

}
    }


}


 
                
