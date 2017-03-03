using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace verych_regexp_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runRegexp()
        {
            if (comboBox1.Text.Length == 0)
            {
                statusL1.Text = "Regexp is empty";
                return;
            }

             RegexOptions options = RegexOptions.None;
                    if (checkBoxIgnorCase.Checked) { options |= RegexOptions.IgnoreCase; }
                    if (checkBoxSingleLine.Checked) { options |= RegexOptions.Singleline; }
                    if (checkBoxMLine.Checked) { options |= RegexOptions.Multiline; }

            try
            {
                String result = textBox1.Text;
                if (!checkBoxReplace.Checked)
                {
                    String regExp = comboBox1.Text;
                    String bracket1 = "";
                    String bracket2 = "";

                    if (checkBoxBracket.Checked)
                    {
                        bracket1 = "<span class='this_is_match' style='color: #ccccff;'>[</span>";
                        bracket2 = "<span style='color: #ccccff;'>]</span>";
                    }

                    String postMatch = bracket2 + "</span>[[this_is_match]]";

                    MatchCollection m = Regex.Matches(textBox1.Text, regExp, options);

                    for (int i = m.Count - 1; i >= 0; i--)
                    {
                        String GrInfo = "";
                        for (int j = 0; j < m[i].Groups.Count; j++)
                        {
                            GrInfo += "<div><span style='color: blue;'>" + j.ToString() + "</span>:&nbsp;<strong>" + CleanHtml(m[i].Groups[j].Value) + "</strong></div>";
                        }

                        String preMatch = "[[this_is_match]]<span onclick='var gi__n = document.getElementById(\"gi__n" + i.ToString() + "\"); if(gi__n.style.display==\"none\"){gi__n.style.display=\"\"} else {gi__n.style.display=\"none\"}' style='background: #ffffaa; cursor: pointer;'>" + bracket1;
                        preMatch += "<div id='gi__n" + i.ToString() + "' style='display: none; border: 1px solid #999999; background: #ffffee; padding: 2px; margin-top: 1.1em; position: absolute;'>" + GrInfo + "</div>";
                        result = result.Substring(0, m[i].Groups[0].Index) + preMatch + CleanHtml(m[i].Groups[0].Value) + postMatch + result.Substring(m[i].Groups[0].Index + m[i].Groups[0].Length);
                    }

                    String[] spl = { "[[this_is_match]]" };
                    String[] arr = result.Split(spl, StringSplitOptions.None);
                    result = "";
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            result += CleanHtml(arr[i]);
                        }
                        else 
                        {
                            result += arr[i];
                        }
                        
                    }

                    statusL1.Text = String.Format("Matches: {0}", m.Count);
                    statusL2.Text = String.Format(" ({0})", textBox1.Text.Length);
                }
                else
                {
                    result = Regex.Replace(textBox1.Text, comboBox1.Text, textBox2.Text, options);
                    webBrowser1.DocumentText = result;
                    statusL1.Text = "";
                    statusL2.Text = String.Format(" ({0}/{1})", textBox1.Text.Length, result.Length);
                    result = CleanHtml(result);
                }
                
                webBrowser1.DocumentText = "<pre style='font-size: 8.25pt; font-family: sans-serif; margin: 0px; padding: 0px;'>" + result + "<pre>";
            }
            catch (Exception exp)
            {
                statusL1.Text = exp.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            runRegexp();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            runRegexp();
        }

        private void checkBoxIgnorCase_Click(object sender, EventArgs e)
        {
            runRegexp();
        }

        public static string CleanHtml(string pHtml)
        {
            StringBuilder oSb = new StringBuilder();

            if (!string.IsNullOrEmpty(pHtml))
            {
                foreach (char c in pHtml)
                {
                    // Known Replacements
                    if (c == '&')
                        oSb.Append("&amp;");
                    else if (c == '<')
                        oSb.Append("&lt;");
                    else if (c == '>')
                        oSb.Append("&gt;");
                    else if (c == '`')
                        oSb.Append("'");
                    else if ((int)(c) > 127)
                    {
                        // Always Encode Extended Ascii Codes
                        oSb.AppendFormat("&#{0};", (int)c);
                    }
                    else
                    {
                        // If nothing was added, add the original char
                        oSb.Append(c);
                    }
                }
            }
            return oSb.ToString();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ToolTipText.Length > 0)
            {
                textBoxRegBody.Text = e.Node.Text;
                richTextBoxRegDescription.Text = e.Node.ToolTipText;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            comboBox1.Text = textBoxRegBody.Text;
            tabControl1.SelectedIndex = 0;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            runRegexp();
        }
     }
}
