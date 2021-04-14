//#define TESTFLG1
//#define TESTFLG2
//#define TESTFLG3
//#define TESTFLG4
//#define TESTFLG5
//#define TESTFLG6
//#define TESTFLG7
//#define TESTFLG8
//#define TESTFLG9
//#define TESTFLG10
//#define TESTFLG11
//#define TESTFLG12
//#define TESTFLG13
//#define TESTFLG14
//#define TESTFLG15
//#define TESTFLG16
//#define TESTFLG17
#define en_ver
//#define ch_ver

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace WordGame
{
    public partial class WordGame : Form
    {
#if (TESTFLG1)
        Excel.Application TestApp;
#endif
        int player_ans_num;
        //
        //string ComputerAnsInput;
        string lookup_res_en;
        string lookup_res_ch;
        string[] word_record_en = new string[500];
        //
        int timeout_cnt = 0;
        int word_record_en_index = 0;
        uint record_num = 0;
        //
        bool player_first_flg = true;               //true : player
                                                    //false: computer
        bool game_mode_flg = true;                  //true : player - player
                                                    //false: player - computer
        bool playerans_first_check_flg = true;      //true : first check
                                                    //false: twice or more check
        //bool game_end_flg = true;
        //bool new_commit_flg = false;
        //bool timeout_flg = false;
        //
        bool waiting_computer_ans_flg = false;
        bool waiting_player_ans_flg = false;
        //
        Excel.Application app;
        Excel.Workbook wbook;
        Excel.Worksheet wsheet;
        //
        public WordGame()
        {
            InitializeComponent();
        }
        //
        // Test Block
        private void button1_Click(object sender, EventArgs e)
        {
#if (TESTFLG1)
            // define a range var
            Excel.Range rg;
                                   
            // set a range
            rg = TestApp.Range["B2:C9"];

            // show the UserName of the active excel file
            MessageBox.Show(TestApp.UserName);

            // define a selected zone
            rg.Select();

            // set the background selected red 
            rg.Interior.Color = Color.Red;
#endif
#if (TESTFLG2)
            // This debug is used to print all the active excel files

            foreach (Excel.Workbook wbk in TestApp.Workbooks)
            {
                MessageBox.Show(wbk.Name);
            }
#endif
#if (TESTFLG3)
            // This debug is used to open a new excel window

            var ExcelApp = new Excel.Application();
            ExcelApp.Visible = true;
#endif

#if (TESTFLG4)
            // This debug is used to call check and show the return

            MessageBox.Show(IsExcelRunning().ToString());
#endif

#if (TESTFLG5)
            // This debug is used to read and show a cell in an active excel

            var ExcelApp = Marshal.GetActiveObject("Excel.Application") as Excel.Application;
            var ExcelSht = ExcelApp.ActiveSheet as Excel.Worksheet;
            MessageBox.Show(ExcelSht.Range["A17"].Value.ToString());

            // only after the MessageBox is confirmed, 
            // the prg is run continuously

            ExcelApp.Quit();
            ExcelApp = null;
#endif

#if (TESTFLG6)
            // This debug is used to read and show a cell in an active excel

            Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE");
#endif

#if (TESTFLG7)
            // This debug is used to test game result

            PlayerWin();
            PlayerLose();
#endif

#if (TESTFLG8)
            // This debug is used to obtain the current running dir

            //MessageBox.Show(Environment.CurrentDirectory);
            MessageBox.Show(Application.StartupPath);
#endif

#if (TESTFLG9)
            // This debug is used to read a existed excel file

            Excel.Application app = new Excel.Application();
            Excel.Workbook wbook, newbook;
            Excel.Worksheet wsheet, newsheet;
            int RowNum = 2;
            int ColNum = 1;
            int index = 1;
            string temp;
            try
            {
                wbook = app.Workbooks.Open("C:\\Users\\Administrator\\Desktop\\wordslib\\WordGame\\WordGame\\bin\\x64\\Debug\\originalwordslib.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                wsheet = (Excel.Worksheet)wbook.Worksheets[1];
                newbook = app.Workbooks.Add(Type.Missing);
                newsheet = (Excel.Worksheet)newbook.Worksheets[1];
                for (; ; RowNum++)
                {
                    temp = (wsheet.Cells[RowNum, 2]).Text;

                    // if the second character is bigger than c
                    if ((temp.Length > 2) && (String.Equals(temp.Substring(0, 2), "ad")))
                    {
                        break;
                    }

                    // write the word into a new excel whose second character is b
                    if ((temp.Length > 2) && (String.Equals(temp.Substring(0, 2), "ac")))
                    {
                        newsheet.Cells[index++, 1] = temp;
                    }
                    //MessageBox.Show(temp);
                }
                index = 0;
                newsheet.SaveAs("C:\\Users\\Administrator\\Desktop\\wordslib\\WordGame\\WordGame\\bin\\x64\\Debug\\ac_test.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                RowNum = 1;
#if no_use_1
                for (; ColNum < 4; ColNum++)
                {
                    temp = (wsheet.Cells[8, ColNum]).Text;
                    MessageBox.Show(temp);
                }
#endif

                // close excel
                wbook.Close();
                newbook.Close();
                app.Quit();
                app = null;
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Excel Process Failed." + Environment.NewLine + ex.Message );
            }

#endif

#if (TESTFLG10)
            // This debug is used to format the cells in a sepcified range.

            Excel.Range rtemp = worksheet.get_Range("A1","C9");
            rtemp.Font.Name="宋体";
            rtemp.Font.FontStyle = "加粗";
            rtemp.Font.Size=5;
#endif

#if (TESTFLG11)
            // This debug is used to test the ascii of a char

            char i = 'a';
            int ii = (int)i;
            char j = 'A';
            int ij = (int)j;
            MessageBox.Show(i.ToString());
            MessageBox.Show(ii.ToString());    // print 97
            MessageBox.Show(j.ToString());
            MessageBox.Show(ij.ToString());     // print 65
#endif

#if (TESTFLG12)
            // This debug is used to abstract/divide the wordlib in the way of first char
            //
            // Excel.Application app = new Excel.Application();
            // Excel.Workbook wbook, newbook;
            // // Excel.Workbook[] newbook = new Excel.Workbook[26];
            // Excel.Worksheet wsheet, newsheet;
            //Excel.Worksheet[] newsheet = new Excel.Worksheet[26];
            //
            int dec_a = 97;
            int dec_A = 65;
            //
            byte[] btnumUpper;
            byte[] btnumLower;
            //
            System.Text.ASCIIEncoding encodeing = new System.Text.ASCIIEncoding();
            //
            // this block used to test the decimal to its ASCII
            // btnum = new byte[] {(byte)dec_a};
            // MessageBox.Show(EncodeC.GetString(btnum));
            // btnum = new byte[] {(byte)dec_A};
            // MessageBox.Show(EncodeC.GetString(btnum));
            //
            //#if (no_use_2)
            // set Excel Name to write
            string startpath = Application.StartupPath;
            string[] relative_path = {
                @"\data\a\",
                @"\data\b\",
                @"\data\c\",
                @"\data\d\",
                @"\data\e\",
                @"\data\f\",
                @"\data\g\",
                @"\data\h\",
                @"\data\i\",
                @"\data\j\",
                @"\data\k\",
                @"\data\l\",
                @"\data\m\",
                @"\data\n\",
                @"\data\o\",
                @"\data\p\",
                @"\data\q\",
                @"\data\r\",
                @"\data\s\",
                @"\data\t\",
                @"\data\u\",
                @"\data\v\",
                @"\data\w\",
                @"\data\x\",
                @"\data\y\",
                @"\data\z\"
            };
            string[] excelname = {
                "a.xlsx",
                "b.xlsx",
                "c.xlsx",
                "d.xlsx",
                "e.xlsx",
                "f.xlsx",
                "g.xlsx",
                "h.xlsx",
                "i.xlsx",
                "j.xlsx",
                "k.xlsx",
                "l.xlsx",
                "m.xlsx",
                "n.xlsx",
                "o.xlsx",
                "p.xlsx",
                "q.xlsx",
                "r.xlsx",
                "s.xlsx",
                "t.xlsx",
                "u.xlsx",
                "v.xlsx",
                "w.xlsx",
                "x.xlsx",
                "y.xlsx",
                "z.xlsx"
            };
            string abspath;
            string absexcel;
            string entemp = "start";
            string chtemp = "start";
            //
            // index used for 'for-cycle'
            uint index;
            // index2 used for initialize string[] 
            uint index2;
            UInt32 rownumlib = 2;
            UInt32 rownumsublib = 0;
            // a more efficient excel writing method
            string[,] enRangetemp = new String[15000, 1];
            string[,] chRangetemp = new String[15000, 1];
            // initialize void
            for (index2 = 0; index2 < 15000; index2++)
            {
                enRangetemp[index2, 0] = "";
                chRangetemp[index2, 0] = "";
            }
            // 
            // for (index = 2; index < 26; index++)
            // {
            //     abspath = (startpath + relative_path[index]);
            //     //
            //     // judege if exist abspath already
            //     if ((System.IO.Directory.Exists(abspath)))
            //     {
            //         // MessageBox.Show("Exist" + Environment.NewLine + abspath);
            //     }
            //     else
            //     {
            //         // MessageBox.Show("Do not Exist" + Environment.NewLine + abspath);
            //         System.IO.Directory.CreateDirectory(abspath);
            //         // MessageBox.Show("Create Dir Already" + Environment.NewLine + abspath);
            //     }
            //     //
            //     // MessageBox.Show(abspath);
            //     // if (System.IO.File.Exists(absexcel))
            //     // {
            //     //     MessageBox.Show("Exist" + Environment.NewLine + absexcel);
            //     //     System.IO.File.Delete(absexcel);
            //     // }
            //     // else
            //     // {
            //     //     MessageBox.Show("Do not Exist" + Environment.NewLine + absexcel);
            //     // }
            // }
            //
            // clear all excel process
            Process[] procs = Process.GetProcessesByName("EXCEL");
            foreach (Process pro in procs)
            {
                pro.Kill();
            }
            //
            try
            {
                Excel.Application app;
                Excel.Range enrange, chrange;
                Excel.Workbook wbook, newbook;
                Excel.Worksheet wsheet, newsheet;
                //
                app = new Excel.Application();
                wbook = app.Workbooks.Open(startpath + @"\data\" + "originalwordslib.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // read out the sheet1
                wsheet = (Excel.Worksheet)wbook.Worksheets[1];
                // from a to z cycle
                for ( index = 0; index < 11; index++ )
                {
                    // if the string read out is null,
                    if (entemp == "")
                    {
                        break;
                    }
                    // show alpha
                    Console.WriteLine(index.ToString() + " saving start");
                    //  
                    newbook = app.Workbooks.Add(Type.Missing);
                    newsheet = (Excel.Worksheet)newbook.Worksheets[1];
                    // Thread.Sleep(50);
                    // from 1 to 103976
                    for (; ; rownumlib++)
                    {
                        // read out English word
                        entemp = (wsheet.Cells[rownumlib, 2]).Text;
                        // chtemp = (wsheet.Cells[rownumlib, 3]).Text;
                        // Console.WriteLine(entemp);
                        // Console.WriteLine(chtemp);
                        //
                        // if the string read out is null,
                        if (entemp == "")
                        {
                            break;
                        }
                        //
                        //
                        // prepare to convert decimal to ASCII
                        // 'a' --------> 97
                        // 'A' --------> 65
                        btnumLower = new byte[] { (byte)(dec_a + index) };
                        btnumUpper = new byte[] { (byte)(dec_A + index) };
                        //
                        // judge the first character of the word read out
                        // according to the alpha-table sequence
                        if ( String.Equals((entemp.Substring(0, 1)), encodeing.GetString(btnumLower)) || String.Equals((entemp.Substring(0, 1)), encodeing.GetString(btnumUpper)) )
                        {
                            // newsheet[index].Cells[rownumsublib, 1] = entemp;
                            // newsheet.Cells[rownumsublib, 1] = entemp;
                            // Thread.Sleep(50);
                            // read out Chinese meanings
                            chtemp = (wsheet.Cells[rownumlib, 3]).Text;
                            // Thread.Sleep(50);
                            // newsheet[index].Cells[rownumsublib++, 2] = chtemp;
                            // newsheet.Cells[rownumsublib++, 2] = chtemp;
                            // Thread.Sleep(50);
                            enRangetemp[rownumsublib, 0] = entemp;
                            chRangetemp[rownumsublib++, 0] = chtemp;
                            // Console.WriteLine(enRangetemp[rownumsublib, 0]);
                            // Console.WriteLine(chRangetemp[rownumsublib, 0]);
                            // rownumsublib++;
                        }
                        else
                        // if the first character changes, then save
                        {
                            //Console.WriteLine("Excel Saving " + encodeing.GetString(btnumLower) + " Starts");
                            rownumsublib = 0;
                            absexcel = (startpath + relative_path[index] + excelname[index]);
                            // debug
                            Console.WriteLine(absexcel);
                            // before SaveAs, check whether exist already
                            // delete if exist
                            if (System.IO.File.Exists(absexcel))
                            {
                                System.IO.File.Delete(absexcel);
                            }
                            // Thread.Sleep(50);
                            // make bonus between string[] and excel cell range
                            enrange = newsheet.Range[newsheet.Cells[1, 1], newsheet.Cells[15000, 1]];
                            chrange = newsheet.Range[newsheet.Cells[1, 2], newsheet.Cells[15000, 2]];
                            // write the string[] data into range
                            enrange.Value = enRangetemp;
                            chrange.Value = chRangetemp;
                            // saving 
                            newsheet.SaveAs(absexcel, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                            // reinitialize string[]
                            for (index2 = 0; index2 < 15000; index2++)
                            {
                                if (enRangetemp[index2, 0] == "")
                                {
                                    break;
                                }
                                else
                                {
                                    enRangetemp[index2, 0] = "";
                                    chRangetemp[index2, 0] = "";
                                }
                            }
                            //
                            newbook.Close();
                            newbook = null;
                            // newsheet.Delete();
                            newsheet = null;
                            // jump out and ,
                            // start next process alpha
                            Console.WriteLine(index.ToString() + " saving over");
                            break;
                        }
                    }
                }
                // close excel
                wbook.Close();
                wbook = null;
                app.Quit();
                app = null;
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Excel Process Failed." + Environment.NewLine + ex.Message );
            }
            //#endif
#endif

#if (TESTFLG13)
            // this debug used to test string[] index out of bonuds
            //
            uint index = 0;
            uint alphaa = 65;
            byte[] alphaUpper;
            string[,] strange = new String[10, 1];
            //
            System.Text.ASCIIEncoding encodeing = new System.Text.ASCIIEncoding();
            for(; index < 10; index++)
            {
                Console.WriteLine(index.ToString());
                alphaUpper = new byte[] { (byte)(alphaa + index) };
                strange[index, 0] = encodeing.GetString(alphaUpper);
            }
            for(index = 0; index < 10; index++)
            {
                Console.WriteLine(strange[index, 0]);
            }
#endif

#if (TESTFLG14)
            // This debug is used to abstract/divide the wordlib in the way of first char
            //
            int dec_a = 97;
            int dec_A = 65;
            //
            byte[] btnumUpper;
            byte[] btnumLower;
            //
            System.Text.ASCIIEncoding encodeing = new System.Text.ASCIIEncoding();
            //
            // this block used to test the decimal to its ASCII
            // btnum = new byte[] {(byte)dec_a};
            // MessageBox.Show(EncodeC.GetString(btnum));
            // btnum = new byte[] {(byte)dec_A};
            // MessageBox.Show(EncodeC.GetString(btnum));
            //
            //#if (no_use_2)
            // set Excel Name to write6
            string startpath = Application.StartupPath;
            string[] relative_path = {
                @"\data\a\",
                @"\data\b\",
                @"\data\c\",
                @"\data\d\",
                @"\data\e\",
                @"\data\f\",
                @"\data\g\",
                @"\data\h\",
                @"\data\i\",
                @"\data\j\",
                @"\data\k\",
                @"\data\l\",
                @"\data\m\",
                @"\data\n\",
                @"\data\o\",
                @"\data\p\",
                @"\data\q\",
                @"\data\r\",
                @"\data\s\",
                @"\data\t\",
                @"\data\u\",
                @"\data\v\",
                @"\data\w\",
                @"\data\x\",
                @"\data\y\",
                @"\data\z\"
            };
            string[] excelname = {
                "a.xlsx",
                "b.xlsx",
                "c.xlsx",
                "d.xlsx",
                "e.xlsx",
                "f.xlsx",
                "g.xlsx",
                "h.xlsx",
                "i.xlsx",
                "j.xlsx",
                "k.xlsx",
                "l.xlsx",
                "m.xlsx",
                "n.xlsx",
                "o.xlsx",
                "p.xlsx",
                "q.xlsx",
                "r.xlsx",
                "s.xlsx",
                "t.xlsx",
                "u.xlsx",
                "v.xlsx",
                "w.xlsx",
                "x.xlsx",
                "y.xlsx",
                "z.xlsx"
            };
            //string abspath;
            string absexcel;
            string entemp = "start";
            string chtemp = "start";
            char[] entempch = new char[50];
            //
            // index used for 'for-cycle'
            uint index;
            // index2 used for initialize string[] 
            uint index2;
            uint index3;
            uint rownumlib = 1;
            uint rownumsublib = 0;
            // a more efficient excel writing method
            string[,] enRangetemp = new String[5000, 1];
            string[,] chRangetemp = new String[5000, 1];
            // initialize void
            for (index2 = 0; index2 < 5000; index2++)
            {
                enRangetemp[index2, 0] = "";
                chRangetemp[index2, 0] = "";
            }
            //
            Process[] procs;
            //
            try
            {
                Excel.Application app;
                Excel.Range enrange, chrange;
                Excel.Workbook wbook, newbook;
                Excel.Worksheet wsheet, newsheet;
                //
                index3 = 21;
                //
                do
                {
                    //
                    rownumlib = 1;
                    // clear all excel process
                    procs = Process.GetProcessesByName("EXCEL");
                    foreach (Process pro in procs)
                    {
                        pro.Kill();
                    }
                    //
                    app = new Excel.Application();
                    wbook = app.Workbooks.Open(startpath + relative_path[index3] + "lib.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // read out the sheet1
                    wsheet = (Excel.Worksheet)wbook.Worksheets[1];
                    entemp = "start";
                    // from a to z cycle
                    for (index = 0; index < 26; index++)
                    {
                        // if the string read out is null,
                        if (entemp == "")
                        {
                            break;
                        }
                        // show alpha
                        Console.WriteLine(index.ToString() + " saving start");
                        //  
                        newbook = app.Workbooks.Add(Type.Missing);
                        newsheet = (Excel.Worksheet)newbook.Worksheets[1];
                        // from 1 to 103976
                        for (; ; rownumlib++)
                        {
                            // read out English word
                            entemp = (wsheet.Cells[rownumlib, 1]).Text;
                            //
                            // prepare to convert decimal to ASCII
                            // 'a' --------> 97
                            // 'A' --------> 65
                            btnumLower = new byte[] { (byte)(dec_a + index) };
                            btnumUpper = new byte[] { (byte)(dec_A + index) };
                            //
                            // if the string read out is null,
                            if (entemp == "")
                            {
                                Console.WriteLine("Excel Saving " + encodeing.GetString(btnumLower) + " Starts");
                                rownumsublib = 0;
                                // make bonus between string[] and excel cell range
                                enrange = newsheet.Range[newsheet.Cells[1, 1], newsheet.Cells[5000, 1]];
                                chrange = newsheet.Range[newsheet.Cells[1, 2], newsheet.Cells[5000, 2]];
                                // write the string[] data into range
                                enrange.Value = enRangetemp;
                                chrange.Value = chRangetemp;
                                // saving 
                                absexcel = (startpath + relative_path[index3] + excelname[index]);
                                newsheet.SaveAs(absexcel, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                                // reinitialize string[]
                                for (index2 = 0; index2 < 5000; index2++)
                                {
                                    if (enRangetemp[index2, 0] == "")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        enRangetemp[index2, 0] = "";
                                        chRangetemp[index2, 0] = "";
                                    }
                                }
                                //
                                newbook.Close();
                                newbook = null;
                                // newsheet.Delete();
                                newsheet = null;
                                // jump out and ,
                                // start next process alpha
                                Console.WriteLine(index.ToString() + " saving over" + Environment.NewLine);
                                break;
                            }
                            //
                            if ( (entemp.Length == 1) )
                            {
                                Console.WriteLine("a single character found !");
                                continue;
                            }
                            //
                            entempch = entemp.ToCharArray();
                            //
                            if ( (entempch[1] > 47) && (entempch[1] < 58) )
                            {
                                Console.WriteLine("a decimal number contained is excluded !");
                                continue;
                            }
                            //
                            // judge the first character of the word read out
                            // according to the alpha-table sequence
                            if (String.Equals((entemp.Substring(1, 1)), encodeing.GetString(btnumLower)) || String.Equals((entemp.Substring(1, 1)), encodeing.GetString(btnumUpper)))
                                // 'a' < x < 'z'
                                // 'A' < x < 'Z'
                                // '0' < x < '9' 
                            {
                                // read out Chinese meanings
                                chtemp = (wsheet.Cells[rownumlib, 2]).Text;
                                enRangetemp[rownumsublib, 0] = entemp;
                                chRangetemp[rownumsublib++, 0] = chtemp;
                            }
                            else
                            // if the first character changes, then save
                            {
                                Console.WriteLine("Excel Saving " + encodeing.GetString(btnumLower) + " Starts");
                                rownumsublib = 0;
                                // make bonus between string[] and excel cell range
                                enrange = newsheet.Range[newsheet.Cells[1, 1], newsheet.Cells[5000, 1]];
                                chrange = newsheet.Range[newsheet.Cells[1, 2], newsheet.Cells[5000, 2]];
                                // write the string[] data into range
                                enrange.Value = enRangetemp;
                                chrange.Value = chRangetemp;
                                // saving 
                                absexcel = (startpath + relative_path[index3] + excelname[index]);
                                newsheet.SaveAs(absexcel, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                                // reinitialize string[]
                                for (index2 = 0; index2 < 5000; index2++)
                                {
                                    if (enRangetemp[index2, 0] == "")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        enRangetemp[index2, 0] = "";
                                        chRangetemp[index2, 0] = "";
                                    }
                                }
                                //
                                newbook.Close();
                                newbook = null;
                                // newsheet.Delete();
                                newsheet = null;
                                // jump out and ,
                                // start next process alpha
                                Console.WriteLine(index.ToString() + " saving over" + Environment.NewLine);
                                break;
                            }
                        }
                    }
                    // close excel
                    index3++;
                    wbook.Close();
                    wbook = null;
                    app.Quit();
                    app = null;
                } while (index3 < 26);
            }
            catch (Exception ex)
            {
                // clear all excel process
                procs = Process.GetProcessesByName("EXCEL");
                foreach (Process pro in procs)
                {
                    pro.Kill();
                }
                MessageBox.Show("Excel Process Failed." + Environment.NewLine + ex.Message);
            }
            //#endif
#endif

#if (TESTFLG15)
            // This debug is used to test abstracting a char from a string to compare with a decimal 
            //
            char[] ch = new char[20];
            string str = "Hello World.";
            int index;
            int ch_dec;
            for (index = 0; index < str.Length; index++)
            {
                ch = str.Substring(index, 1).ToCharArray();
                ch_dec = ch[0];
                if (99 < ch[0])
                {
                    Console.WriteLine(ch[0] + " is " + ch_dec.ToString() + ", and > 99");
                }
                else
                {
                    Console.WriteLine(ch[0] + " is " + ch_dec.ToString() + ", and < 99");
                }
            }
#endif

#if (TESTFLG16)
            int dec_a = 'a';
            int dec_A = 'A';
            int index = 0;
            //
            for (; index < 26; index++)
            {
                //
                Console.WriteLine((dec_a + index).ToString() + Environment.NewLine);
            }
            for (index = 0; index < 26; index++)
            {
                //
                Console.WriteLine((dec_A + index).ToString() + Environment.NewLine);
            }
#endif

#if (TESTFLG17)
            //
            string ans = "name";
            char[] ans_char = new char[20]; 
            string startpath = Application.StartupPath;
            ans_char = ans.ToCharArray();
            ans = startpath + @"\data\" + ans_char[0] + @"\" + ans_char[1] + ".xlsx";
            if (System.IO.File.Exists(ans))
            {
                MessageBox.Show("Exist" + Environment.NewLine + ans);
            }
#endif
        }
// the end of button1_Click() --> TEST
        
#if (TESTFLG4)
        // This fun is used to check if there is a progress named "EXCEL"
        // if so, return TURE
        // if not, return FALSE

        private bool IsExcelRunning()
        {
            var tempPro = Process.GetProcessesByName("EXCEL");
            return (tempPro.Length != 0);
        }
#endif
        //
        // program starts
        private void WordGame_Load(object sender, EventArgs e)
        {
            //
            int index;
            //get the running excel object now
            //TestApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            #if (ch_ver)
            Tips.Text = "我是英语单词接龙app！" + Environment.NewLine + "我接受的单词输入为原型单词，不支持复数变形、分词变形输入。" + Environment.NewLine +  "点击“开始游戏”吧！";
            #endif
            #if (en_ver)
            Tips.Text = "I am the Solitaire Game of English Word! " + Environment.NewLine + "The English Word I Accepted Only Include the Original Words." + Environment.NewLine +  "Click 'Start' to Game!";
            #endif
            Tips.Refresh();
            //
            record.Text = "";
            record.Refresh();
            //
            for (index = 0; index < 500; index++)
            {
                //
                word_record_en[index] = "";
            }
            //
            EndGame.Enabled = false;
            Commit.Enabled = false;
            //
            PlayerAns.Enabled = false;
            CompAns.Enabled = false;
            record.Enabled = false;
            Test.Enabled = false;
            //
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private double VocalbularyRate()
        {
            return (double)(player_ans_num * 1000 / 103976);
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Start");
            DialogResult dr_who_first;  // DialogResult.Yes: player first
                                        // DialogResult.No : computer first
            //
            DialogResult  dr_game_mode; // DialogResult.Yes: play with player-self
                                        // DialogResult.No : play with computer
            //
            StartGame.Enabled = false;
            EndGame.Enabled = true;
            Commit.Enabled = true;
            //
            PlayerAns.Enabled = true;
            CompAns.Enabled = true;
            record.Enabled = true;
            //
            record.Text = "";
            record.Refresh();
            //
            #if (ch_ver)
            dr_game_mode = MessageBox.Show(this, "点击“是”确认和玩家自己接龙；" + Environment.NewLine + "点击“否”确认和电脑接龙！", "游戏模式选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            #endif
            #if (en_ver)
            dr_game_mode = MessageBox.Show(this, "click 'Yes' to start playing with yourself." + Environment.NewLine + "click 'No' to start playing with computer.", "Game Mode Select", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            #endif
            //
            if (dr_game_mode == DialogResult.Yes)
            {
                game_mode_flg = true;    // player - player
                // leave enough time for player to commit its ans
                // update the tip
                waiting_player_ans_flg = true;
                #if (ch_ver)
                Tips.Text = "等待玩家提交单词！" + Environment.NewLine + "你有60s的时间来提交一个起始单词！";
                #endif
                #if (en_ver)
                Tips.Text = "Waiting player to commit word." + Environment.NewLine + "You have the time of 60s to commit a start word.";
                #endif
                Tips.Refresh();
                // start timer1
                timeout_cnt = 0;
                timer1.Start();
            }
            else if (dr_game_mode == DialogResult.No)
            {
                //
                game_mode_flg = false;    // player - computer
                //
                #if (ch_ver)
                dr_who_first = MessageBox.Show(this, "你要先手开局吗？", "先手方选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                #endif
                //
                #if (en_ver)
                dr_who_first = MessageBox.Show(this, "Do you want to start at first?", "Select who starts first", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                #endif
                if (dr_who_first == DialogResult.Yes)
                {
                    player_first_flg = true;  // player starts first
                                              // only get its value here, don't change anymore
                    // leave enough time for player to commit its ans
                    // update the tip
                    waiting_player_ans_flg = true;
                    #if (ch_ver)
                    Tips.Text = "等待玩家提交单词！" + Environment.NewLine + "你有60s的时间来提交一个起始单词！";
                    #endif
                    #if (en_ver)
                    Tips.Text = "Waiting player to commit word." + Environment.NewLine + "You have the time of 60s to commit a start word.";
                    #endif
                    Tips.Refresh();
                    // start timer1
                    timeout_cnt = 0;
                    timer1.Start();
                }
                else if (dr_who_first == DialogResult.No)
                {
                    player_first_flg = false;  // computer starts first
                                               // only get its value here, don't change anymore
                    ComputerAns();
                    waiting_player_ans_flg = true;
                    waiting_player_commit_start();
                }
                else
                {
                    //
                }
            }
            else
            {
                //
            }
            // //
            // // into endless cycle unless EndGame_Button is click
            // while(!game_end_flg)
            // {
            //     process_schedule();
            // }
        }

        private void waiting_player_commit_start()
        {
            //
            #if (ch_ver)
            Tips.Text = "轮到玩家接龙！" + Environment.NewLine + "你仍有60s的时间来提交一个单词！";
            #endif
            #if (en_ver)
            Tips.Text = "Your turn to play!" + Environment.NewLine + "You have the time of 60s to commit a start word, too!";
            #endif
            Tips.Refresh();
            TimeBar.Value = 0;
            timer1.Stop();
            timeout_cnt = 0;
            timer1.Start();
            return;
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            // set game_end_flg false, used to jump out and stop while() loop
            //game_end_flg = true;
            // MessageBox.Show("End");
            Process[] procs = Process.GetProcessesByName("EXCEL");
            foreach (Process pro in procs)
            {
                pro.Kill();
            }
            StartGame.Enabled = true;
            EndGame.Enabled = false;
            Commit.Enabled = false;
            //
            PlayerAns.Enabled = false;
            CompAns.Enabled = false;
            //record.Enabled = false;
            //
            if (timer1.Enabled)
            {
                TimeBar.Value = 0;
                timer1.Stop();
            }
            //
            #if (ch_ver)
            Tips.Text = "游戏已结束！" + Environment.NewLine + "你可以查看本局的历史记录！";
            #endif
            #if (en_ver)
            Tips.Text = "Game Over!" + Environment.NewLine + "You can review the history log of this play!";
            #endif
            Tips.Refresh();
            return;
        }

        private void EndGame_Timeout()
        {
            // 
            Process[] procs = Process.GetProcessesByName("EXCEL");
            foreach (Process pro in procs)
            {
                pro.Kill();
            }
            StartGame.Enabled = true;
            EndGame.Enabled = false;
            Commit.Enabled = false;
            //
            PlayerAns.Enabled = false;
            CompAns.Enabled = false;
            //
            if (timer1.Enabled)
            {
                TimeBar.Value = 0;
                timer1.Stop();
            }
            //
            #if (ch_ver)
            Tips.Text = "接龙超时！" + Environment.NewLine + "游戏已结束！" + Environment.NewLine + "你可以查看本局的历史记录！";
            #endif
            #if (en_ver)
            Tips.Text = "Salitaire Game Timeout!" + Environment.NewLine + "Game Over Already!" + Environment.NewLine + "You can review the history log of this play!";
            #endif
            Tips.Refresh();
            return;
        }

        private void commit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Commit");
            string playerans = PlayerAns.Text;
            //
            Commit.Enabled = false;
            // check the playerans
            if (!(player_ans_check(playerans)) || !(String.Equals(playerans, lookup_res_en)))
            {
                //
                player_ans_check_err();
                PlayerAns.Text = "";
                PlayerAns.Refresh();
                //
                Commit.Enabled = true;
                //
                return;
            }
            waiting_player_ans_flg = false;
            //ComputerAnsInput = playerans;
            // clear
            //playerans = "";
            // MessageBox.Show(playerans);
            WriteInRecord(lookup_res_en, lookup_res_ch);
            word_record_en[word_record_en_index++] = lookup_res_en;
            lookup_res_ch = "";
            //
            //record.AppendText(playerans + Environment.NewLine);
            PlayerAns.Text = "";
            PlayerAns.Refresh();
            //
            //new_commit_flg = true;
            player_ans_num++;
            //
            if (!game_mode_flg)
            {
                //
                ComputerAns();
                //
                Commit.Enabled = true;
            }
            else
            {
                //
                Commit.Enabled = true;
                waiting_player_commit_start();
            }
        }

        private bool player_ans_check(string ans)
        {
            //
            int dec_a = 'a';
            int dec_A = 'A';
            int index;
            int dec_char;
            //
            bool in_alpha_table_flg = false;
            bool in_wordlib_flg = false;
            //
            // used to convert int to its ASCII char
            //byte[] btnumUpper;
            //byte[] btnumLower;
            //
            char[] ans_char = new char[20];
            //string firstchar;
            //string secondchar;
            //
            //string target_sublib_dir = "";
            // store app start path
            string startpath = Application.StartupPath;
            //
            if (playerans_first_check_flg)
            {
                playerans_first_check_flg = false;
            }
            else
            {
                if ( !String.Equals((ans.Substring(0, 1)), (lookup_res_en.Substring(lookup_res_en.Length - 1, 1))) )
                {
                    // throw error
                    #if (ch_ver)
                    Tips.Text = "玩家提交的单词的首字母不是前一个单词的尾字母！";
                    #endif
                    #if (en_ver)
                    Tips.Text = "The first character in the word you committed is not the last character of the last word!";
                    #endif
                    Tips.Refresh();
                    WaitingView(1500);
                    return false;
                }
                //
                // Repeatability check
                for (index = 0; ; index++)
                {
                    // the condition for cycle to quit
                    if ( String.Equals( word_record_en[index], "" ) )
                    {
                        //
                        break;
                    }
                    // 
                    if ( index > 499 )
                    {
                        // throw error
                        #if (ch_ver)
                        Tips.Text = "单词记录已超过500条！请联系开发人员解决此问题！";
                        #endif
                        #if (en_ver)
                        Tips.Text = "The total word record number exceeds 500 in the history log!" + Environment.NewLine + "Please contact the developer to solve this problem!";
                        #endif
                        Tips.Refresh();
                        WaitingView(1500);
                        return false;
                    }
                    // 
                    if ( String.Equals( word_record_en[index], ans ) )
                    {
                        // throw error
                        #if (ch_ver)
                        Tips.Text = "玩家已经提交过该单词！";
                        #endif
                        #if (en_ver)
                        Tips.Text = "You have committed the word already!";
                        #endif
                        Tips.Refresh();
                        WaitingView(1500);
                        return false;
                    }
                }
            }
            //
            // abstract the last char of playerans
            if (ans.Length < 2)
            {
                // TODO
                // a, I, special process
                //  throw error 
                #if (ch_ver)
                Tips.Text = "单个字母类型的单词本程序目前不支持！";
                #endif
                #if (en_ver)
                Tips.Text = "In this version, the word with JUST ONE CHARACTER is not supported!";
                #endif
                Tips.Refresh();
                WaitingView(1500);
                return false;
            }
            //
            ans_char = ans.ToCharArray();
            //firstchar = ans.Substring(0, 1);
            //secondchar = ans.Substring(1, 1);
            // cycle to match a-z or A-Z with the last char
            in_alpha_table_flg = false;
            //
            // judge the first char
            dec_char = ans_char[0];
            if ( ((dec_char >= dec_a) && (dec_char <= (dec_a + 25))) || ((dec_char >= dec_A) && (dec_char <= (dec_A + 25))) )
            {
                // judge the second char
                dec_char = ans_char[1];
                if ( ((dec_char >= dec_a) && (dec_char <= (dec_a + 25))) || ((dec_char >= dec_A) && (dec_char <= (dec_A + 25))) )
                {
                    //
                    in_alpha_table_flg = true;
                }
                else
                {
                    // throw error
                    #if (ch_ver)
                    Tips.Text = "玩家提交的单词的第2个字符非英文字母！";
                    #endif
                    #if (en_ver)
                    Tips.Text = "The second character in the word you committed is not a right English character!";
                    #endif
                    Tips.Refresh();
                    WaitingView(1500);
                    return false;
                }
            }
            else
            {
                // throw error
                #if (ch_ver)
                Tips.Text = "玩家提交的单词的第1个字符非英文字母！";
                #endif
                #if (en_ver)
                Tips.Text = "The first character in the word you committed is not a right English character!";
                #endif
                Tips.Refresh();
                WaitingView(1500);
                return false;
            }
            // for ( index = 0; index < 26; index++ )
            // {
            //     // prepare to convert decimal to ASCII
            //     // 'a' --------> 97
            //     // 'A' --------> 65
            //     btnumLower = new byte[] { (byte)(dec_a + index) };
            //     btnumUpper = new byte[] { (byte)(dec_A + index) };
            //     if (String.Equals(firstchar, encodeing.GetString(btnumLower)) || String.Equals(firstchar, encodeing.GetString(btnumUpper)))
            //     {
            //         //
            //         in_alpha_table_flg = true;
            //         target_sublib_dir = encodeing.GetString(btnumLower);
            //         break;
            //     }
            // }
            //
            // clear all excel process
            Process[] procs = Process.GetProcessesByName("EXCEL");
            foreach (Process pro in procs)
            {
                pro.Kill();
            }
            //
            app = null;
            app = new Excel.Application();
            try
            {
                //
                // open the target excel sublib file
                wbook = app.Workbooks.Open(startpath + @"\data\" + ans_char[0] + @"\" + ans_char[1] + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // read out the sheet1
                wsheet = (Excel.Worksheet)wbook.Worksheets[1];
                // randly lookup a word
                for ( index = 1; ; index++ )
                {
                    //
                    if ( String.Equals((wsheet.Cells[index, 1]).Text, ans) )
                    {
                        //
                        lookup_res_en = (wsheet.Cells[index, 1]).Text;
                        lookup_res_ch = (wsheet.Cells[index, 2]).Text;
                        in_wordlib_flg = true;
                        break;
                    }
                    //
                    if ( String.Equals((wsheet.Cells[index, 1]).Text, "") )
                    {
                        //
                        #if (ch_ver)
                        Tips.Text = "玩家提交的单词不在词库中！";
                        #endif
                        #if (en_ver)
                        Tips.Text = "The word you committed is not in the Wordlib!";
                        #endif
                        Tips.Refresh();
                        WaitingView(1500);
                        break;
                    }
                }
                // close workbook
                wbook.Close();
                wbook = null;
                // close EXCEL.EXE
                app.Quit();
                app = null;
            }
            catch (Exception ex)
            {
                // close workbook
                wbook.Close();
                wbook = null;
                // close EXCEL.EXE
                app.Quit();
                app = null;
                MessageBox.Show("Excel Process Failed." + Environment.NewLine + ex.Message);
            }
            //
            return (in_alpha_table_flg && in_wordlib_flg);
        }

        private void ComputerAns()
        {
            // MessageBox.Show("Commit");
            int dec_a = 97;
            //int dec_A = 65;
            //
            string lastchar;
            //
            System.Text.ASCIIEncoding encodeing = new System.Text.ASCIIEncoding();
            //
            Random Rd = new Random();
            //
            // used to convert int to its ASCII char
            byte[] btnumLower;
            //
            waiting_player_ans_flg = true;
            //
            if (player_first_flg)
            // player starts
            {
                // operate according to 'lookup_res_en'
                lastchar = lookup_res_en.Substring(lookup_res_en.Length - 1, 1);
            }
            else
            // computer starts
            {
                // operate according to random()
                btnumLower = new byte[] { (byte)(dec_a + Rd.Next(0, 25)) };
                lastchar = encodeing.GetString(btnumLower);
            }
            //
            if (LookCompAnsInWordlib(lastchar))
            {
                // lookup ok
                CompAns.Text = lookup_res_en;
                word_record_en[word_record_en_index++] = lookup_res_en;
            }
            else
            {
                //lookup failed
                PlayerWin();
            }
            waiting_computer_ans_flg = false;
            //
            WaitingView(1500);
            WriteInRecord(lookup_res_en, lookup_res_ch);
            lookup_res_en = "";
            lookup_res_ch = "";
            // MessageBox.Show(playerans);
            // write CompAns and its chinese meanings
            //WriteInRecord();
            // clear CompAns Text
            CompAns.Text = "";
            CompAns.Refresh();
            waiting_player_commit_start();
        }

        private void player_ans_check_err()
        {
            //
            #if (ch_ver)
            Tips.Text = "玩家提交的单词有误！" + Environment.NewLine + "请重新输入！" + Environment.NewLine + "你仍有60s的时间来提交一个起始单词！";
            #endif
            #if (en_ver)
            Tips.Text = "The word you committed is incorrect!" + Environment.NewLine + "Please commit again!" + Environment.NewLine + "You have the time of 60s to commit a start word, too!";
            #endif
            Tips.Refresh();
            TimeBar.Value = 0;
            timer1.Stop();
            timeout_cnt = 0;
            timer1.Start();
            return;
        }

        private void WriteInRecord(String recd_en, String recd_ch)
        {
            //
            record_num++;
            record.AppendText("["+ record_num.ToString() + "] " + recd_en + Environment.NewLine);
            record.AppendText(recd_ch + Environment.NewLine);
            record.AppendText("-----------------------------" + Environment.NewLine);
            return;
        }

        private bool LookCompAnsInWordlib(string lastchar)
        {
            //
            //int dec_a = 97;
            //int dec_A = 65;
            int index = 0;
            int[] index_in_record = new int[50];
            int index_record = 0;
            int index_in_record_index = 0;
            //
            int random_index;
            int random_index_temp;
            int THE_MAX_ROW;
            //
            // store app start path
            string startpath = Application.StartupPath;
            string tempword;
            //
            bool is_lookup_ok = false;
            bool is_nonredundent_flg = false;
            //
            Random Rd = new Random();
            // clear all excel process
            Process[] procs = Process.GetProcessesByName("EXCEL");
            foreach (Process pro in procs)
            {
                pro.Kill();
            }
            //
            for (index = 0; index < 50; index++)
            {
                //
                index_in_record[index] = 0;
            }
            //
            try
            {
                //
                app = new Excel.Application();
                // open the target excel sublib file
                wbook = app.Workbooks.Open(startpath + @"\data\" + lastchar + @"\lib.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // read out the sheet1
                wsheet = (Excel.Worksheet)wbook.Worksheets[1];
                // 
                for (index = 1; ; index++)
                {
                    tempword = (wsheet.Cells[index, 1]).Text;
                    if (String.Equals(tempword, ""))
                    {
                        THE_MAX_ROW = index - 1;
                        break;
                    }
                    //
                    for (index_record = 0; ( word_record_en[index_record] != "" ) && (index_record < 50); index_record++)
                    {
                        //
                        if (String.Equals(word_record_en[index_record], tempword))
                        {
                            index_in_record[index_in_record_index] = index;
                            index_in_record_index++;
                        }
                    }
                }
                //
                while(true)
                {
                    random_index_temp = Rd.Next(1, THE_MAX_ROW);
                    for (index_in_record_index = 0; ( index_in_record[index_in_record_index] != 0 ) && (index_in_record_index < 50); index_in_record_index++)
                    {
                        //
                        if (index_in_record[index_in_record_index] == random_index_temp)
                        {
                            is_nonredundent_flg = false;
                            break;
                        }
                        is_nonredundent_flg = true;
                    }
                    if (is_nonredundent_flg)
                    {
                        //
                        random_index = random_index_temp;
                        break;
                    }
                }
                //
                lookup_res_en = (wsheet.Cells[random_index, 1]).Text;
                lookup_res_ch = (wsheet.Cells[random_index, 2]).Text;
                is_lookup_ok = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Excel Process Failed." + Environment.NewLine + ex.Message );
            }
            // close workbook
            wbook.Close();
            wbook = null;
            // close EXCEL.EXE
            app.Quit();
            app = null;
            //
            return is_lookup_ok;
        }

        // stop 2s for 
        private void WaitingView(int msec)
        {
            System.Threading.Thread.Sleep(msec);
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            // every 1000ms elapsed
            timeout_cnt++;
            TimeBar.PerformStep();
            if (timeout_cnt == 60)
            {
                //timeout_flg = true;
                TimeBar.Value = 0;
                timer1.Stop();
                timeout_gameover();
            }
        }

        private void timeout_gameover()
        {
            // 
            if (game_mode_flg)
            // player - player mode
            {
                //
                EndGame_Timeout();
            }
            else
            // player - computer mode
            {
                if (waiting_player_ans_flg)
                {
                    //
                    PlayerLose();
                    EndGame_Timeout();
                }
                if (waiting_computer_ans_flg)
                {
                    //
                    PlayerWin();
                    EndGame_Timeout();
                }
            }
        }

        // condition to call
        // 1. timeout and
        // 2. no new ans committed by computer
        private void PlayerWin()
        {
            // 
            Tips.Text = "Congratulation!" + Environment.NewLine + "你的实力碾压了电脑，你大获全胜！" + Environment.NewLine + "本次游戏过程体现了你的英语词汇量占词库比为千分之" + VocalbularyRate().ToString();
            Tips.Refresh();
        }

        // condition to call
        // 1. timeout and
        // 2. no new ans committed by player
        private void PlayerLose()
        {
            // 
            Tips.Text = "What a pity!" + Environment.NewLine + "你被电脑无情地击败了，电脑大获全胜！" + Environment.NewLine + "本次游戏过程体现了你的英语词汇量占词库比为千分之" + VocalbularyRate().ToString();
            Tips.Refresh();
        }

        private void Help_Click(object sender, CancelEventArgs e)
        {
            //
            MessageBox.Show(this, "[1]-本单词接龙软件包括两种游戏模式：玩家自对局，以及玩家和电脑对局!" + Environment.NewLine +
                                  "[2]-限于软件完善程度，本单词接龙软件不接受单个字母类型的单词！" + Environment.NewLine +
                                  "[3]-限于词库版本，本游戏支持输入的单词不包括（新生）缩略词！" + Environment.NewLine +
                                  "[4]-版本：2021040101" + Environment.NewLine +
                                  "[5]-Rev: 2021040101" + Environment.NewLine +
                                  "[6]-All Right Reserved By HaoyuSun",
                                  "游戏规则", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // private void process_schedule()
        // {
        //     // check whether EndGame is requested
        //     if (game_end_flg)
        //     {
        //         EndGame_Setting();
        //         return;
        //     }
        //     // if not, then,
        //     // this func used to process task shcdule
        //     //
        //     if (player_first_flg)
        //     {
        //         // player first
        //         if (new_commit_flg)
        //         {
        //             //
        //             new_commit_flg = false;
        //             ComputerAns();
        //         }
        //         else
        //         {
        //         }
        //     }
        //     else
        //     {
        //         // computer first
        //     }
        // }
    }
}
