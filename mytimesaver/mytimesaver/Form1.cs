using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using System.CodeDom.Compiler;
using System.CodeDom;

namespace Mytimesaver
{
    public partial class Form1 : Form
    {
        enum GradeType { Assignment, Final };

        string FileName
        {
            get
            {
                return txtFileName.Text;
            }
        }

        GradeType Type
        {
            get
            {
                return (GradeType)cmbGradeType.SelectedItem;
            }
        }

        int KennitalaCol
        {
            get
            {
                return Int32.Parse(txtKennitala.Text);
            }
        }

        int GradeCol
        {
            get
            {
                return Int32.Parse(txtGradeCol.Text);
            }
        }

        int? CommentCol
        {
            get
            {
                int a;
                if (Int32.TryParse(txtCommentCol.Text, out a))
                {
                    return a;
                }
                return null;
            }
        }

        int Skip
        {
            get
            {
                return Int32.Parse(txtSkip.Text);
            }
        }

        bool Header
        {
            get
            {
                return cbHeader.Checked;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGradeType.DataSource = Enum.GetValues(typeof(GradeType));
        }

        private bool KtCheck(string kt)
        {
            return kt.Length == 10 && kt.All(x => Char.IsDigit(x));
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (!SanityCheck())
            {
                return;
            }
            try
            {
                DoStuff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\n\n" + ex.ToString(), "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoStuff()
        {
            using (CsvReader reader = new CsvReader(new StreamReader(FileName, Encoding.Default), false, ';'))
            {
                for (int i = 0; i != Skip; i++)
                {
                    reader.ReadNextRecord();
                }
                string gradeHeader = null;
                if (Header)
                {
                    reader.ReadNextRecord();
                    gradeHeader = reader[GradeCol];
                }
                Dictionary<string, string> ktGrades = new Dictionary<string, string>();
                Dictionary<string, string> ktComments = new Dictionary<string, string>();
                while (reader.ReadNextRecord())
                {
                    string kt = reader[KennitalaCol].Trim('\'');
                    if (KtCheck(kt))
                    {
                        ktGrades.Add(kt, reader[GradeCol]);
                        if (CommentCol.HasValue)
                        {
                            ktComments.Add(kt, reader[CommentCol.Value]);
                        }
                    }
                }
                CreateJs(ktGrades, ktComments, gradeHeader);
            }
        }

        private void CreateJs(Dictionary<string, string> grades, Dictionary<string, string> comments, string gradeHeader)
        {
            string cont = "";
            if (!string.IsNullOrEmpty(gradeHeader))
            {
                cont = String.Format("// Assignment name: {0}\n\n", gradeHeader);
            }
            if (Type == GradeType.Final)
            {
                cont += global::Mytimesaver.Properties.Resources.FinalTemplate.Replace("/*grades*/", Stringify(Fix(grades)));
            }
            else
            {
                cont += global::Mytimesaver.Properties.Resources.AssignmentTemplate.Replace("/*grades*/", Stringify(grades));
                if(CommentCol.HasValue)
                {
                    cont = cont.Replace("/*comments*/", String.Format("var comments = {0};", Stringify(comments)));
                }
            }
            txtOutput.Text = cont;
            Clipboard.SetText(cont);
        }

        private Dictionary<string, string> Fix(Dictionary<string, string> grades)
        {
            List<string> noShow = grades.Where(x => String.IsNullOrEmpty(x.Value)).Select(x => x.Key).ToList();
            foreach (string key in noShow)
            {
                grades[key] = "-3";
            }
            return grades;
        }

        private string Stringify(Dictionary<string, string> dict)
        {
            return String.Format("{{ {0} }}", 
                String.Join(", ", dict.Select(x => String.Format("'{0}': '{1}'", x.Key, ToLiteral(x.Value) ))));
        }

        private static string ToLiteral(string input)
        {
            using (var writer = new StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString().Trim('"');
                }
            }
        }

        private bool SanityCheck()
        {
            string fail = "";
            bool epicFail = false;
            if (!File.Exists(FileName))
            {
                fail += String.Format("The file '{0}' does not exist\n\n", FileName);
                epicFail = true;
            }
            int tmp;
            if (!Int32.TryParse(txtKennitala.Text, out tmp) || tmp < 0)
            {
                fail += String.Format("Kennitala column must be an integer greater than 0\n\n", FileName);
                epicFail = true;
            }

            if (!Int32.TryParse(txtGradeCol.Text, out tmp) || tmp < 0)
            {
                fail += String.Format("Grade column must be an integer greater than 0\n\n", FileName);
                epicFail = true;
            }

            if (epicFail)
            {
                MessageBox.Show(fail, "Settings are not correct", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return !epicFail;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Comma separated value (*.csv)|*.csv|All files (*.*)|*.*";
                dlg.Multiselect = false;
                dlg.CheckFileExists = true;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFileName.Text = dlg.FileName;
                }
            }
        }
    }
}
