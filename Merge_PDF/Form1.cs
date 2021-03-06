﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merge_PDF
{
    public partial class Merge_Form : Form
    {
        public Merge_Form()
        {
            InitializeComponent();
        }

        private List<string> filelist_A = new List<string>();
        private List<string> filelist_B = new List<string>();
        private string filepath_A;
        private string filepath_B;
        private string filepath_save;

        private bool MergeFile(string filepath_A, string filepath_B, string filepath_save)
        {
            PdfReader reader;
            Document document = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filepath_save, FileMode.Create));
            document.Open();
            PdfContentByte cb = writer.DirectContent;
            PdfImportedPage newPage;
            List<string> filelist = new List<string>
            {
                filepath_A,
                filepath_B
            };
            for (int i = 0; i < filelist.Count; i++)
            {
                reader = new PdfReader(filelist[i]);
                int iPageNum = reader.NumberOfPages;
                for (int j = 1; j <= iPageNum; j++)
                {
                    iTextSharp.text.Rectangle r = reader.GetPageSize(j);
                    var pageRotation = reader.GetPageRotation(j);
                    var pageWidth = reader.GetPageSizeWithRotation(j).Width;
                    var pageHeight = reader.GetPageSizeWithRotation(j).Height;
                    
                    Console.WriteLine(pageRotation);
                    document.SetPageSize(PageSize.A4);
                    document.NewPage();
                    newPage = writer.GetImportedPage(reader, j);
                    switch (pageRotation)
                    {
                        case 0:
                            cb.AddTemplate(newPage, 1f, 0, 0, 1f, 0, 0);
                            break;
                        case 90:
                            cb.AddTemplate(newPage, 0, 0);
                            //cb.AddTemplate(newPage, 0, -1f, 1f, 0, 0, pageHeight);
                            break;
                        case 180:
                            cb.AddTemplate(newPage, -1f, 0, 0, -1f, pageWidth, pageHeight);
                            break;
                        case 270:
                            cb.AddTemplate(newPage, 0, 0);
                            //cb.AddTemplate(newPage, 0, 1f, -1f, 0, pageWidth, 0);
                            break;
                        default:
                            throw new InvalidOperationException(string.Format("Unexpected page rotation: [{0}].", pageRotation));
                    }
                    //cb.AddTemplate(newPage, 0, 0);
                }
            }
            document.Close();



            


            return true;
        }

        private void Merge_btn_Click(object sender, EventArgs e)
        {
            filepath_A = this.fileload_A.Text;
            filepath_B = this.fileload_B.Text;
            filepath_save = this.fileload_save.Text;
            if (Directory.Exists(filepath_A) && Directory.Exists(filepath_B) && Directory.Exists(filepath_save))
            {
                DirectoryInfo root_A = new DirectoryInfo(filepath_A);
                DirectoryInfo root_B = new DirectoryInfo(filepath_B);
                foreach (FileInfo file_B in root_B.GetFiles())
                {
                    string dire_B = filepath_save + "\\" + file_B.Name;
                    if (!Directory.Exists(dire_B))
                    {
                        Directory.CreateDirectory(dire_B);
                    }
                    foreach (FileInfo file_A in root_A.GetFiles())
                    {

                        MergeFile(file_A.FullName, file_B.FullName, dire_B + "\\" + file_A.Name + '.' + file_B.Name);
                    }
                }
                MessageBox.Show("已完成");
            }
            else
            {
                MessageBox.Show("路径不存在，请再次核对");
            }
        }
    }
}
