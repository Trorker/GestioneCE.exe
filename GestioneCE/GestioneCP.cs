using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneCE
{
    public partial class GeneralWindow : Form
    {
        RecognitionSound recognitionSound;

        private Regex regexCE = new Regex(@"\d{2}[A-Z]\d[A-Z](\d|[A-Z]){4}\d{8}");
        Regex regexCP_Enel = new Regex(@"CASARS\d{12}");
        Regex regexCP_Sielte = new Regex(@"SIELTE\d{0,12}");

        public GeneralWindow()
        {
            InitializeComponent();
        }
        private void bt_NewCP_Click(object sender, EventArgs e)
        {
            AutoSave = string.Empty;

            NameCP nameCP = new NameCP();
            if (nameCP.ShowDialog() == DialogResult.OK)
            {
                lb_SerialNumberCE.Items.Clear();
                txb_edit.Clear();
                txb_serialCE.Clear();
                txb_serialCE.Focus();

                lbl_SerialNumberCP.Text = nameCP.Passvalue;
                if (lbl_SerialNumberCP.Text != String.Empty)
                {
                    try
                    {
                        lbl_SerialNumberCE.Text = lbl_SerialNumberCP.Text;
                        pb_barCode.Image = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum.Draw(lbl_SerialNumberCP.Text, 70, 1);
                    }
                    catch (Exception) { }
                }

                SaveFileDialog saveFD = new SaveFileDialog();

                saveFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFD.FileName = lbl_SerialNumberCP.Text;
                saveFD.FilterIndex = 1;
                saveFD.RestoreDirectory = true;

                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    string save = lbl_SerialNumberCP.Text;
                    foreach (string serialNumberOnItems in lb_SerialNumberCE.Items)
                    {
                        save += Environment.NewLine + serialNumberOnItems.ToString().Substring(5);
                    }
                    string filename = saveFD.FileName;
                    AutoSave = filename;
                    File.WriteAllText(filename, save);
                }
            }
        }

        private void InsertCE()
        {
            if (txb_serialCE.Text != String.Empty)
            {
                Match match = regexCE.Match(txb_serialCE.Text);
                if (match.Success)
                {
                    bool exists = false;
                    foreach (string serialNumberOnItems in lb_SerialNumberCE.Items)
                    {
                        if (regexCE.Match(serialNumberOnItems.ToString()).Value == match.Value)
                            exists = true;
                    }

                    //foreach (string serialNumberOnCEConsulivare in CEConsulivare)
                    //{
                    //    if (serialNumberOnCEConsulivare.ToString() == match.Value)
                    //    {


                    //        Console.Beep(8000, 500);
                    //        Console.Beep(8000, 500);
                    //        Console.Beep(4000, 500);

                    //        //Post a message to the message queue.
                    //        // On arrival remove the focus of any focused window. 
                    //        //In our case it will be default button.
                    //        this.BeginInvoke(new MethodInvoker(() =>
                    //        { SetFocus(IntPtr.Zero); }));

                    //        MessageBox.Show("Contatore è da Consultivare", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //        Console.Beep();

                    //        txb_serialCE.Clear();
                    //        return;
                    //    }
                    //}

                    if (exists == false)
                    {


                        if (lb_SerialNumberCE.Items.Count < 175 || regexCP_Sielte.Match(lbl_SerialNumberCP.Text).Success)
                        {
                            if (regexCP_Sielte.Match(lbl_SerialNumberCP.Text).Success)
                            {
                                lb_SerialNumberCE.Items.Add((lb_SerialNumberCE.Items.Count + 1).ToString("000") + ": " + match.Value + " Scat. N: " + ((lb_SerialNumberCE.Items.Count / 5) + 1));

                                if ((lb_SerialNumberCE.Items.Count % 5) == 0)
                                {
                                    MessageBox.Show("Cambio scatola.\nScatola successiva porta il numero: " + ((lb_SerialNumberCE.Items.Count / 5) + 1).ToString(), "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else if (regexCP_Enel.Match(lbl_SerialNumberCP.Text).Success)
                            {
                                lb_SerialNumberCE.Items.Add((lb_SerialNumberCE.Items.Count + 1).ToString("000") + ": " + match.Value);

                            }

                            lb_SerialNumberCE.SelectedIndex = lb_SerialNumberCE.Items.Count - 1;
                            txb_serialCE.Clear();

                            if ((AutoSave != String.Empty) && ((lb_SerialNumberCE.Items.Count + 1) % 25) == 1)
                            {
                                string save = lbl_SerialNumberCP.Text;
                                foreach (string serialNumberOnItems in lb_SerialNumberCE.Items)
                                {
                                    save += Environment.NewLine + serialNumberOnItems.ToString().Substring(5);
                                }
                                File.WriteAllText(AutoSave, save);
                            }
                        }
                        else
                        {
                            //Post a message to the message queue.
                            // On arrival remove the focus of any focused window. 
                            //In our case it will be default button.
                            this.BeginInvoke(new MethodInvoker(() =>
                            { SetFocus(IntPtr.Zero); }));

                            MessageBox.Show("CP Pieno", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txb_serialCE.Clear();
                            txb_serialCE.Focus();
                        }
                    }
                    else
                    {
                        //Post a message to the message queue.
                        // On arrival remove the focus of any focused window. 
                        //In our case it will be default button.
                        this.BeginInvoke(new MethodInvoker(() =>
                        { SetFocus(IntPtr.Zero); }));

                        MessageBox.Show("Già Iserito", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txb_serialCE.Clear();
                        txb_serialCE.Focus();
                    }
                }
                else
                {
                    //Post a message to the message queue.
                    // On arrival remove the focus of any focused window. 
                    //In our case it will be default button.
                    this.BeginInvoke(new MethodInvoker(() =>
                    { SetFocus(IntPtr.Zero); }));

                    MessageBox.Show("Serial Number Errato", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txb_serialCE.Clear();
                    txb_serialCE.Focus();
                }
            }
            else
            {
                //Post a message to the message queue.
                // On arrival remove the focus of any focused window. 
                //In our case it will be default button.
                this.BeginInvoke(new MethodInvoker(() =>
                { SetFocus(IntPtr.Zero); }));

                MessageBox.Show("Inserire Serial Number", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txb_serialCE.Clear();
                txb_serialCE.Focus();
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetFocus(IntPtr hWnd);

        private void bt_insert_Click(object sender, EventArgs e)
        {
            InsertCE();
        }

        private void lb_SerialNumberCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Match match = regexCE.Match(lb_SerialNumberCE.SelectedItem.ToString());
                if (match.Success)
                {
                    string textCode = match.Value;
                    txb_edit.Text = textCode;
                    lbl_SerialNumberCE.Text = textCode;
                    pb_barCode.Image = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum.Draw(textCode, 70, 1);
                }
            }
            catch (Exception) { }
        }

        private void txb_serialCE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertCE();
            }
        }

        private void lbl_SerialNumberCP_Click(object sender, EventArgs e)
        {
            txb_edit.Clear();
            lb_SerialNumberCE.ClearSelected();
            Regex regex = new Regex(@"CASARS\d{12}");
            Match match = regex.Match(lbl_SerialNumberCP.Text);
            if (match.Success)
            {
                try
                {
                    lbl_SerialNumberCE.Text = match.Value;
                    pb_barCode.Image = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum.Draw(match.Value, 70, 1);
                }
                catch (Exception) { }
            }
        }

        string AutoSave = String.Empty;
        private void bt_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();

            saveFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFD.FileName = lbl_SerialNumberCP.Text;
            saveFD.FilterIndex = 1;
            saveFD.RestoreDirectory = true;

            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string save = lbl_SerialNumberCP.Text;
                foreach (string serialNumberOnItems in lb_SerialNumberCE.Items)
                {
                    save += Environment.NewLine + serialNumberOnItems.ToString().Substring(5);
                }
                string filename = saveFD.FileName;
                AutoSave = filename;
                File.WriteAllText(filename, save);
            }

            //savoInExcel();
        }

        private void savoInExcel()
        {
            FileInfo excelFile = new FileInfo(@"GestioneCP.xlsx");

            if (!File.Exists(excelFile.FullName))
            {
                using (ExcelPackage excel = new ExcelPackage(excelFile))
                {
                    excel.Workbook.Worksheets.Add("Management");
                    excel.Workbook.Worksheets.Add("Carton Pallet");

                    //Start Style\\
                    // Target a worksheet
                    var worksheet = excel.Workbook.Worksheets["Carton Pallet"];

                    worksheet.Cells[1, 1, worksheet.Cells.Rows, worksheet.Cells.Columns].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.View.FreezePanes(2, 1);

                    //End Style\\

                    excel.SaveAs(excelFile);
                }

            }

            using (ExcelPackage excel = new ExcelPackage(excelFile))
            {
                // Target a worksheet
                var worksheet = excel.Workbook.Worksheets["Carton Pallet"];

                int firstNullColumns = 1;
                for (int i = 1; i <= worksheet.Cells.Columns; i++)
                {
                    if (worksheet.Cells[1, i].Value == null)
                    {
                        firstNullColumns = i;
                        break;
                    }
                }

                worksheet.Cells[1, firstNullColumns].Value = lbl_SerialNumberCP.Text;
                worksheet.Cells[1, firstNullColumns].AutoFitColumns();

                for (int i = 0; i < lb_SerialNumberCE.Items.Count; i++)
                {
                    Match match = regexCE.Match(lb_SerialNumberCE.Items[i].ToString());
                    worksheet.Cells[i + 2, firstNullColumns].Value = match.Value;
                }

                excel.Save();
            }
        }

        Timer timerRecognitionSound = new Timer();
        Timer timerNotRecognition = new Timer();
        Timer timerDelayRecognition = new Timer();
        private void bt_Slide_Click(object sender, EventArgs e)
        {
            if (bt_SlideShow.Text == "Start" && lb_SerialNumberCE.Items.Count > 0)
            {
                bt_SlideShow.Text = "Stop";

                recognitionSound = new RecognitionSound();

                timerRecognitionSound.Interval = 10;
                timerRecognitionSound.Tick += new EventHandler(timerRecognitionSound_Tick);
                timerRecognitionSound.Start();

                timerNotRecognition.Interval = 5000;
                timerNotRecognition.Tick += new EventHandler(timerNotRecognition_Tick);

                delayTimer.Enabled = false;

                if (delayTimer.Value > 0)
                {
                    timerDelayRecognition.Interval = ((int)delayTimer.Value * 1000);
                    timerDelayRecognition.Tick += new EventHandler(timerDelayRecognition_Tick);

                    timerNotRecognition.Interval = 5000 + ((int)delayTimer.Value * 1000);
                }
            }
            else if (bt_SlideShow.Text == "Stop" && lb_SerialNumberCE.Items.Count > 0)
            {
                StopRecognition();
            }
            else if (lb_SerialNumberCE.Items.Count <= 0)
            {
                CaricaCP();
            }
        }


        private void timerRecognitionSound_Tick(object sender, EventArgs e)
        {
            RecognitionSound.ResultRecognition result = recognitionSound.Recognition();

            if (result != RecognitionSound.ResultRecognition.Null)
            {
                if (delayTimer.Value > 0)
                {
                    timerRecognitionSound.Stop();
                    timerDelayRecognition.Start();
                }

                recognitionSound.Stop();
                recognitionSound = new RecognitionSound();

                ResultBarCode(result);
            }
        }

        private void timerDelayRecognition_Tick(object sender, EventArgs e)
        {
            linearErrorCE = 0;
            NextCE();

            timerDelayRecognition.Stop();
            timerRecognitionSound.Start();
        }

        private void timerNotRecognition_Tick(object sender, EventArgs e)
        {
            timerNotRecognition.Stop();
            if (pb_barCode.Visible == true)
            {
                errorCE++;

                pb_barCode.Visible = false;
                timerNotRecognition.Interval = 2000;
            }
            else if (pb_barCode.Visible == false)
            {
                timerNotRecognition.Interval = 5000 + ((int)delayTimer.Value * 1000);
                pb_barCode.Visible = true;

                if (errorCE > 3)
                {
                    linearErrorCE++;
                    errorCE = 0;
                    allErrorCE += Environment.NewLine + lbl_SerialNumberCE.Text.ToString();

                    if (linearErrorCE >= 5)
                    {
                        StopRecognition();
                        MessageBox.Show("Errore nella battitura del CE\nUltimi 5 CE non sono stati battuti", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        errorCE = 0;
                        linearErrorCE = 0;
                        allErrorCE = string.Empty;
                    }
                    else
                        NextCE();
                }
            }
            timerNotRecognition.Start();
        }

        int errorCE = 0;
        int linearErrorCE = 0;
        string allErrorCE = string.Empty;
        private void ResultBarCode(RecognitionSound.ResultRecognition result)
        {
            if (pb_barCode.Visible == false)
                pb_barCode.Visible = true;

            switch (result)
            {
                case RecognitionSound.ResultRecognition.Accept:
                    if (delayTimer.Value == 0)
                    {
                        linearErrorCE = 0;
                        NextCE();
                    }
                    break;
                case RecognitionSound.ResultRecognition.Error:
                    ErrorCE();
                    break;
                case RecognitionSound.ResultRecognition.Exist:
                    if (delayTimer.Value == 0)
                    {
                        linearErrorCE = 0;
                        NextCE();
                    }
                    break;
                default:
                    //Code.....
                    break;
            }
        }

        private void ErrorCE()
        {
            timerNotRecognition.Stop();
            timerNotRecognition.Start();

            if (pb_barCode.Visible == true)
            {
                errorCE++;

                pb_barCode.Visible = false;
                timerNotRecognition.Interval = 2000;
            }
        }

        private void NextCE()
        {
            errorCE = 0;

            timerNotRecognition.Interval = 5000 + ((int)delayTimer.Value * 1000);
            pb_barCode.Visible = true;

            timerNotRecognition.Stop();
            timerNotRecognition.Start();

            if (lb_SerialNumberCE.SelectedIndex < (lb_SerialNumberCE.Items.Count - 1))
            {
                lb_SerialNumberCE.SelectedIndex++;
            }
            else
            {
                StopRecognition();

                if (allErrorCE != string.Empty)
                {
                    MessageBox.Show("Finito il CP.\n" + allErrorCE.Split('\n').Skip(1).ToArray().Length + " Contatore/(i) non battuto/(i).\nPremendo OK saranno visualizzati tutti i errori.", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lb_SerialNumberCE.Items.Clear();
                    //lbl_SerialNumberCE.Text = "Serial Number CE";
                    //lbl_SerialNumberCP.Text = "Serial Number CP";
                    txb_edit.Clear();

                    foreach (string CE in allErrorCE.Split('\n').Skip(1).ToArray())
                    {
                        lb_SerialNumberCE.Items.Add(CE);
                    }

                    lb_SerialNumberCE.SelectedIndex = 0;

                    errorCE = 0;
                    linearErrorCE = 0;
                    allErrorCE = string.Empty;
                }
                else
                {
                    MessageBox.Show("Finito il CP", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    errorCE = 0;
                    linearErrorCE = 0;
                    allErrorCE = string.Empty;

                    lb_SerialNumberCE.Items.Clear();
                    lbl_SerialNumberCE.Text = "Serial Number CE";
                    lbl_SerialNumberCP.Text = "Serial Number CP";
                    txb_edit.Clear();
                }
            }
        }

        private void StopRecognition()
        {

            if (pb_barCode.Visible == false)
                pb_barCode.Visible = true;


            bt_SlideShow.Text = "Start";

            recognitionSound.Stop();
            recognitionSound = null;

            timerRecognitionSound.Tick -= new EventHandler(timerRecognitionSound_Tick);
            timerRecognitionSound.Stop();

            timerNotRecognition.Tick -= new EventHandler(timerNotRecognition_Tick);
            timerNotRecognition.Stop();

            delayTimer.Enabled = true;

            if (delayTimer.Value > 0)
            {
                timerDelayRecognition.Tick -= new EventHandler(timerDelayRecognition_Tick);
                timerDelayRecognition.Stop();
            }
        }

        private void EditCE()
        {
            if (MessageBox.Show("Sei sicuro di volere modificare Serial Number?", "Gestione CP", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txb_edit.Text != String.Empty)
                {
                    Match match = regexCE.Match(txb_edit.Text);
                    if (match.Success)
                    {
                        bool exists = false;
                        foreach (string serialNumberOnItems in lb_SerialNumberCE.Items)
                        {
                            if (serialNumberOnItems.ToString().Substring(5) == match.Value)
                                exists = true;
                        }

                        if (exists == false)
                        {
                            lb_SerialNumberCE.Items[lb_SerialNumberCE.SelectedIndex] = (lb_SerialNumberCE.SelectedIndex + 1).ToString("000") + ": " + txb_edit.Text;
                            lb_SerialNumberCE.SelectedIndex = lb_SerialNumberCE.Items.Count - 1;
                        }
                        else
                        {
                            //Post a message to the message queue.
                            // On arrival remove the focus of any focused window. 
                            //In our case it will be default button.
                            this.BeginInvoke(new MethodInvoker(() =>
                            { SetFocus(IntPtr.Zero); }));

                            MessageBox.Show("Già Iserito", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txb_edit.Clear();
                            txb_edit.Focus();
                        }
                    }
                    else
                    {
                        //Post a message to the message queue.
                        // On arrival remove the focus of any focused window. 
                        //In our case it will be default button.
                        this.BeginInvoke(new MethodInvoker(() =>
                        { SetFocus(IntPtr.Zero); }));

                        MessageBox.Show("Serial Number Errato", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txb_edit.Clear();
                        txb_edit.Focus();
                    }
                }
                else
                {
                    //Post a message to the message queue.
                    // On arrival remove the focus of any focused window. 
                    //In our case it will be default button.
                    this.BeginInvoke(new MethodInvoker(() =>
                    { SetFocus(IntPtr.Zero); }));

                    MessageBox.Show("Inserire Serial Number", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txb_edit.Clear();
                    txb_edit.Focus();
                }
            }
        }


        private void txb_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditCE();
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            EditCE();
        }

        private void btn_removeLastCE_Click(object sender, EventArgs e)
        {
            //Post a message to the message queue.
            // On arrival remove the focus of any focused window. 
            //In our case it will be default button.
            this.BeginInvoke(new MethodInvoker(() =>
            { SetFocus(IntPtr.Zero); }));

            if (lb_SerialNumberCE.Items.Count != 0)
            {
                if (MessageBox.Show("Sei sicuro di volere eliminare ultimo CE?", "Gestione CP", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    lb_SerialNumberCE.Items.RemoveAt(lb_SerialNumberCE.Items.Count - 1);
                    lb_SerialNumberCE.SelectedIndex = lb_SerialNumberCE.Items.Count - 1;
                }
            }
        }

        private void bt_LoadCP_Click(object sender, EventArgs e)
        {
            CaricaCP();
        }

        private void CaricaCP()
        {
            OpenFileDialog openFD = new OpenFileDialog();

            openFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                lb_SerialNumberCE.Items.Clear();
                txb_edit.Clear();
                txb_serialCE.Clear();

                string filename = openFD.FileName;
                string[] fileText = File.ReadAllText(filename).Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                //
                if (regexCP_Enel.Match(fileText[0]).Success)
                {
                    btn_removeLastLine.Enabled = true;
                    MessageBox.Show("Carico il file del'Enel", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (regexCP_Sielte.Match(fileText[0]).Success)
                {
                    btn_removeLastLine.Enabled = false;
                    MessageBox.Show("Carico il file della Sielte", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Errore nel caricare il file", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //

                lbl_SerialNumberCP.Text = fileText[0];//Path.GetFileNameWithoutExtension(openFD.FileName);

                for (int i = 1; i < fileText.Length; i++)
                {
                    Match match = regexCE.Match(fileText[i]);
                    if (match.Success)
                    {
                        bool exists = false;
                        foreach (string serialNumberOnItems in lb_SerialNumberCE.Items)
                        {
                            if (serialNumberOnItems.ToString().Substring(5) == match.Value)
                                exists = true;
                        }

                        if (exists == false)
                        {
                            if (lb_SerialNumberCE.Items.Count < 175 || regexCP_Sielte.Match(lbl_SerialNumberCP.Text).Success)
                            {
                                if (regexCP_Sielte.Match(lbl_SerialNumberCP.Text).Success)
                                {
                                    lb_SerialNumberCE.Items.Add((lb_SerialNumberCE.Items.Count + 1).ToString("000") + ": " + match.Value + " Scat. N: " + ((lb_SerialNumberCE.Items.Count / 5) + 1));
                                }
                                else if (regexCP_Enel.Match(lbl_SerialNumberCP.Text).Success)
                                {
                                    lb_SerialNumberCE.Items.Add((lb_SerialNumberCE.Items.Count + 1).ToString("000") + ": " + match.Value);

                                }
                            }
                            else
                                MessageBox.Show("CP Pieno", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(i.ToString("000") + ": " + fileText[i] + " Già Iserito", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lb_SerialNumberCE.Items.Add((lb_SerialNumberCE.Items.Count + 1).ToString("000") + ": " + fileText[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show(i.ToString("000") + ": " + fileText[i] + " Serial Number Errato", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lb_SerialNumberCE.Items.Add((lb_SerialNumberCE.Items.Count + 1).ToString("000") + ": " + fileText[i]);
                    }
                    //lb_SerialNumberCE.SelectedIndex = lb_SerialNumberCE.Items.Count - 1;
                }

                try
                {
                    lbl_SerialNumberCE.Text = lbl_SerialNumberCP.Text;
                    pb_barCode.Image = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum.Draw(lbl_SerialNumberCP.Text, 70, 1);
                }
                catch (Exception) { }

                AutoSave = openFD.FileName;
            }
        }

        private void GeneralWindow_Load(object sender, EventArgs e)
        {
            try
            {
                pb_barCode.Image = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum.Draw("By Dzyuba Ruslan", 70, 1);
            }
            catch (Exception) { }

            //Consultivare();
        }

        //string[] CEConsulivare;
        //private void Consultivare()
        //{
        //    if (Properties.Settings.Default.PathConsultivare != string.Empty)
        //    {
        //        string data = File.ReadAllText(Properties.Settings.Default.PathConsultivare);
        //        CEConsulivare = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Non è presente il database con i CE da consultivare", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        private void GeneralWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di volere uscire?", "Gestione CP", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_removeLastLine_Click(object sender, EventArgs e)
        {
            //Post a message to the message queue.
            // On arrival remove the focus of any focused window. 
            //In our case it will be default button.
            this.BeginInvoke(new MethodInvoker(() =>
            { SetFocus(IntPtr.Zero); }));

            if (lb_SerialNumberCE.Items.Count > 0)
            {
                if (MessageBox.Show("Sei sicuro di volere eliminare ultimo piano?", "Gestione CP", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int level;
                    if (((lb_SerialNumberCE.Items.Count + 1) % 25) == 1)
                        level = (lb_SerialNumberCE.Items.Count) / 25;
                    else
                        level = ((lb_SerialNumberCE.Items.Count) / 25) + 1;

                    while (lb_SerialNumberCE.Items.Count > (level - 1) * 25)
                    {
                        lb_SerialNumberCE.Items.RemoveAt(lb_SerialNumberCE.Items.Count - 1);
                    }

                    lb_SerialNumberCE.SelectedIndex = lb_SerialNumberCE.Items.Count - 1;
                }
            }
        }
        private void txb_edit_Click(object sender, EventArgs e)
        {
            if (txb_edit.ReadOnly == true && txb_edit.TextLength == 17)
            {
                txb_edit.SelectAll();
                txb_edit.ReadOnly = false;
            }
        }

        private void txb_edit_Leave(object sender, EventArgs e)
        {
            txb_edit.ReadOnly = true;
        }

        private void TopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topMost.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFD = new OpenFileDialog();

            //openFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //if (openFD.ShowDialog() == DialogResult.OK)
            //{
            //    Properties.Settings.Default.PathConsultivare = openFD.FileName;
            //    Properties.Settings.Default.Save();
            //}

            ////Consultivare();
        }
    }
}

