/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 07.07.2020
 * Time: 12:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text;
using System.Xml.XPath; // for Extensions.XPathSelectElement Method


namespace XMLParserTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BDownloadClick(object sender, EventArgs e)
		{
			string url = tbURL.Text;
			string xml;
			try
			{
				//source: https://stackoverflow.com/questions/3175790/how-can-i-download-an-xml-file-using-c
				//source: https://stackoverflow.com/questions/7137165/webclient-downloadstring-results-in-mangled-characters-due-to-encoding-issues-b
			    using (var webClient = new WebClient())
			    {
			    	webClient.Encoding = Encoding.UTF8;
			        xml = webClient.DownloadString(url);
			    }
			    
			    
			    //source: https://docs.microsoft.com/ru-ru/dotnet/api/system.xml.xmlreader?view=netcore-3.1
			    //source: 
			    lbParsed.Items.Clear();
			    using (var xmlStringReader = new StringReader(xml))
			    {
			    	using (XmlReader reader = XmlReader.Create(xmlStringReader))
			    	{
			    		while (reader.Read())
			    		{
			    			switch (reader.NodeType)
				            {
				                case XmlNodeType.Element:
			    					lbParsed.Items.Add(String.Format("Start Element {0}", reader.Name));
				                    break;
				                case XmlNodeType.Text:
				                    lbParsed.Items.Add(String.Format("Text Node: {0}", reader.Value));
				                    break;
				                case XmlNodeType.EndElement:
				                    lbParsed.Items.Add(String.Format("End Element {0}", reader.Name));
				                    break;
				                default:
				                    lbParsed.Items.Add(String.Format("Other node {0} with value {1}",
				                                                     reader.NodeType, reader.Value));
				                    break;
				            }
			    		}
			    	}
			    }
			    
			    // source: https://stackoverflow.com/questions/3175790/how-can-i-download-an-xml-file-using-c
			    XDocument doc = XDocument.Parse(xml);
			    
			    if (tbPath.Text.Trim()!="")
			    {
			    	string res = doc.XPathSelectElement(tbPath.Text).Value;
			    	tbResult.Text = res;
			    }
			    else 
			    {
			    	tbResult.Text = "";
			    }
			}
			catch (Exception ex)
			{
				lbParsed.Items.Clear();
				tbResult.Text = "";
				MessageBox.Show(ex.Message,"Error!");
			}
			

		    
		}
		
		void MainFormSizeChanged(object sender, EventArgs e)
		{
			
		}
	}
}
