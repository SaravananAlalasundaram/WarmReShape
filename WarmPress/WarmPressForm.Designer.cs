using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarmPress
{
    partial class WarmPressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private readonly static string BandSerialLen = ConfigurationManager.AppSettings["BandSerialLen"] ?? string.Empty;
        private readonly static string BandSerialStChars = ConfigurationManager.AppSettings["BandSerialStChars"] ?? string.Empty;
        private readonly static string BandSerialEndChars = ConfigurationManager.AppSettings["BandSerialEndChars"] ?? string.Empty;
        private readonly static string Url = ConfigurationManager.AppSettings["Url"] ?? string.Empty;
        private readonly static string UrlPre = ConfigurationManager.AppSettings["UrlPre"] ?? string.Empty;
        private readonly static string UrlPostZ = ConfigurationManager.AppSettings["UrlPostZ"] ?? string.Empty;
        private readonly static string UrlPostW = ConfigurationManager.AppSettings["UrlPostW"] ?? string.Empty;


        /// <summary>
        /// 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScanCode = new System.Windows.Forms.TextBox();
            this.lblScanCode = new System.Windows.Forms.Label();
            this.btnTraceCall = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWarmPress = new System.Windows.Forms.Button();
            this.btnUploadTrace = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScanCode
            // 
            this.txtScanCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanCode.Location = new System.Drawing.Point(736, 116);
            this.txtScanCode.Name = "txtScanCode";
            this.txtScanCode.Size = new System.Drawing.Size(513, 38);
            this.txtScanCode.TabIndex = 0;
            this.txtScanCode.TextChanged += new System.EventHandler(this.txtScanCode_TextChanged);
            // 
            // lblScanCode
            // 
            this.lblScanCode.AutoSize = true;
            this.lblScanCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanCode.Location = new System.Drawing.Point(230, 122);
            this.lblScanCode.Name = "lblScanCode";
            this.lblScanCode.Size = new System.Drawing.Size(287, 32);
            this.lblScanCode.TabIndex = 1;
            this.lblScanCode.Text = "Scan the MCH Band";
            this.lblScanCode.Click += new System.EventHandler(this.lblScanCode_Click);
            // 
            // btnTraceCall
            // 
            this.btnTraceCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraceCall.Enabled = false;
            this.btnTraceCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraceCall.Location = new System.Drawing.Point(911, 249);
            this.btnTraceCall.Name = "btnTraceCall";
            this.btnTraceCall.Size = new System.Drawing.Size(338, 47);
            this.btnTraceCall.TabIndex = 2;
            this.btnTraceCall.Text = "Check If NG in Z-Height";
            this.btnTraceCall.UseVisualStyleBackColor = false;
            this.btnTraceCall.Click += new System.EventHandler(this.btnTraceCall_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(46, 18);
            this.lblMsg.MinimumSize = new System.Drawing.Size(200, 25);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(1088, 29);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "This is Warm Re Shape Machine with Trace Interfcae Application , please Scan Band" +
    " to Start";
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 63);
            this.panel1.TabIndex = 4;
            // 
            // btnWarmPress
            // 
            this.btnWarmPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnWarmPress.Enabled = false;
            this.btnWarmPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarmPress.Location = new System.Drawing.Point(911, 337);
            this.btnWarmPress.Name = "btnWarmPress";
            this.btnWarmPress.Size = new System.Drawing.Size(338, 60);
            this.btnWarmPress.TabIndex = 5;
            this.btnWarmPress.Text = "Click to get Warm Press Data";
            this.btnWarmPress.UseVisualStyleBackColor = false;
            this.btnWarmPress.Click += new System.EventHandler(this.btnWarmPress_Click);
            // 
            // btnUploadTrace
            // 
            this.btnUploadTrace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUploadTrace.Enabled = false;
            this.btnUploadTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadTrace.Location = new System.Drawing.Point(911, 433);
            this.btnUploadTrace.Name = "btnUploadTrace";
            this.btnUploadTrace.Size = new System.Drawing.Size(338, 60);
            this.btnUploadTrace.TabIndex = 6;
            this.btnUploadTrace.Text = "Upload Trace";
            this.btnUploadTrace.UseVisualStyleBackColor = false;
            this.btnUploadTrace.Click += new System.EventHandler(this.btnUploadTrace_Click);
            // 
            // WarmPressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1373, 569);
            this.Controls.Add(this.btnUploadTrace);
            this.Controls.Add(this.btnWarmPress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTraceCall);
            this.Controls.Add(this.lblScanCode);
            this.Controls.Add(this.txtScanCode);
            this.Name = "WarmPressForm";
            this.Text = "WarmPressTraceApplication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUploadTrace_Click(object sender, EventArgs e)
        {

            TraceUploadPostWarmReShape();

        }

        private void btnWarmPress_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtScanCode_TextChanged(object sender, EventArgs e)
        {
            if (ValidateBandSerial(txtScanCode.Text.ToString().Trim()))
            {
                lblMsg.Text = "The Scanned Band MCH is Valid One , Please proceed to process further";

                btnTraceCall.Enabled = true;

            }
            else
            {
                lblMsg.Text = "The Scanned Band MCH is not valid one, please check";
            };
        }

        private void btnTraceCall_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            ZHeightCheck();
            
        }
        public void TraceUploadPostWarmReShape()
        {
            string passScrap = string.Empty;
            using (var context = new warmPressEntities())
            {

                var bandCheck = context.WarmReshapeParams.Where(s => s.BandSerial == txtScanCode.Text.ToString().Trim()).Any();
                if (bandCheck)
                {
                    var getBand = (from bandser in context.WarmReshapeParams
                                  where bandser.BandSerial == txtScanCode.Text.ToString().Trim()
                                  select new
                                  {
                                      UnloadTime = bandser.UnLoadStopTime,
                                      StartTime = bandser.LoadStartTime,
                                      ProcessStart = bandser.PressStartTime,
                                      ProcessEnd = bandser.PressStopTime,
                                      TopFixTemp = bandser.TopFixtureTemp,
                                      BottomFixTemp = bandser.BottomFixtureTemp,


                                  }).First();
                    TimeSpan HoldCT = (DateTime)getBand.UnloadTime - (DateTime)getBand.StartTime;
                    TimeSpan PressCT = (DateTime)getBand.ProcessEnd - (DateTime)getBand.ProcessStart;
                    if (HoldCT.TotalSeconds <= 60 && PressCT.TotalSeconds <= 6)
                    {
                        passScrap = "pass";


                    }
                    else if(HoldCT.TotalSeconds > 60 || PressCT.TotalSeconds > 6)
                    {
                        passScrap = "scrap";
                    }
                    UutAttributes uutAtribs = new UutAttributes();
                    uutAtribs.press_start_time = getBand.ProcessStart.ToString();
                    uutAtribs.press_stop_time = getBand.ProcessEnd.ToString();
                    uutAtribs.top_fixture_temp = getBand.TopFixTemp.ToString();
                    uutAtribs.bottom_fixture_temp = getBand.BottomFixTemp.ToString();
                    uutAtribs.load_start_time = getBand.StartTime.ToString();
                    uutAtribs.unload_stop_time = getBand.UnloadTime.ToString();

                    TestAttributes testAttributes = new TestAttributes();
                    testAttributes.test_result = passScrap;

                    Item iteml = new Item();
                    iteml.test = "load_ct";
                    iteml.result = passScrap;
                    iteml.units = "s";
                    iteml.value = HoldCT.TotalSeconds.ToString();

                    Item itemh = new Item();
                    itemh.test = "press_ct";
                    itemh.result = passScrap;
                    itemh.units = "s";
                    itemh.value = PressCT.TotalSeconds.ToString();

                    Results results = new Results();
                    results.items.Add(iteml);
                    results.items.Add(itemh);


                    Insight insight = new Insight();
                    insight.uut_attributes = uutAtribs;
                    insight.test_attributes = testAttributes;
                    insight.results = results;

                    Data data = new Data();
                    data.insight = insight;

                    Root root = new Root();
                    var serialsLs = new List<string>();
                    serialsLs.Add(txtScanCode.Text.ToString().Trim());
                    root.serial_type = "band";
                    root.serials = serialsLs;
                    root.data = data;

                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = System.Text.Json.JsonSerializer.Serialize(root, options);
                    string URL = ConfigurationManager.AppSettings["Url"];
                    Uri u = new Uri(URL);
                    HttpContent c = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    try
                    {


                        var t = Task.Run(() => PostURI(u, c));
                        t.Wait();
                       
                        //T Console.WriteLine("The Data Upload result " + t.Result);
                    }
                    catch (Exception ex)
                    {
                       
                        WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Exception thrown at Calling POST Method for   " + txtScanCode.Text.ToString() + "   " + ex.StackTrace.ToString()+ "   ", DateTime.Now + "  " + ex.Message));
                    };

                }
            }
        
        }
            public  void ZHeightCheck ()
        { 
            string Url = string.Empty;
            string getResultCode  = string.Empty;
            string getResultDesc  = string.Empty;
            Url += UrlPre.ToString().Trim() ;
            Url += txtScanCode.Text.ToString().Trim();
            Url += UrlPostZ.ToString().Trim();
            Uri u = new Uri(Url);
            try
            {


                var t = Task.Run(() => GetURIZHeight(u));
                t.Wait();
                getResultCode = t.Result;
                getResultDesc = t.ToString();
                //T Console.WriteLine("The Data Upload result " + t.Result);
            }
            catch (Exception ex)
            {
                WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Z Height Trace Call is failed at the Call   " + getResultCode + "   Desc: " + ex.StackTrace.ToString() + "   ", DateTime.Now));


            };





        }

        private async Task<string> GetURIZHeight(Uri u)
        {
            var response = string.Empty;
            string status = string.Empty;
            string desc = string.Empty;
            bool NGinZheight = false;
            using (var client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage result = await client.GetAsync(u);
                    result.EnsureSuccessStatusCode();
                    response = await result.Content.ReadAsStringAsync();
                    zheightCheck prop = JsonConvert.DeserializeObject<zheightCheck>(response);


                    foreach (var property in prop.history)
                    {
                        if (property.Event == "fail")
                        {
                            btnWarmPress.Enabled = true;
                            lblMsg.Text = "This Band is NG in Z height, Please load the Band in Warm Press m/c and click the button to get parameters";
                            NGinZheight = true;
                        }

                        else
                        {
                            btnWarmPress.Enabled = false;
                            lblMsg.Text = "This Band is not NG in Z height, Please do not prosess this in WarmPress ";


                        }
                    }
                


                    status = result.StatusCode.ToString();
                    desc = result.Content.ToString();
                    
                    try {

                        using (var context = new warmPressEntities())
                        {
                            var bandCheck = context.WarmReshapeParams.Where(s => s.BandSerial == txtScanCode.Text.ToString().Trim()).Any();
                            if (bandCheck)
                            {

                                if (NGinZheight)
                                {
                                    var bandfound = context.WarmReshapeParams.Where(s => s.BandSerial == txtScanCode.Text.ToString().Trim()).First();
                                    bandfound.WarmPressCheck = true;
                                    bandfound.ProcessedOn = DateTime.Now;
                                    context.SaveChanges();


                                }
                                else
                                {
                                    var bandfound = context.WarmReshapeParams.Where(s => s.BandSerial == txtScanCode.Text.ToString().Trim()).First();
                                    bandfound.WarmPressCheck = false;
                                    bandfound.ProcessedOn = DateTime.Now;
                                    context.SaveChanges();



                                }


                            }
                            else {

                                if (NGinZheight)
                                {
                                    var newBand = context.WarmReshapeParams.Add(new WarmReshapeParam() { BandSerial = txtScanCode.Text.ToString().Trim(), ProcessedOn = DateTime.Now , WarmPressCheck = true });
                                    context.SaveChanges();
                                }
                                else {
                                    var newBand = context.WarmReshapeParams.Add(new WarmReshapeParam() { BandSerial = txtScanCode.Text.ToString().Trim(), ProcessedOn = DateTime.Now, WarmPressCheck = false });
                                    context.SaveChanges();


                                }

                            }


                        }

                        } catch (Exception ex) {
                        WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Z Height Trace Call is failed    " + status.ToString() + "   Desc: " + ex.StackTrace.ToString() + "   ", DateTime.Now));


                    }

                }
                catch (Exception ex)
                {
                    WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Z Height Trace Call is failed    " +  status.ToString() + "   Desc: " + ex.StackTrace.ToString() + "   ", DateTime.Now));

                }
                return response;
            }
        }
        static async Task<string> PostURI(Uri u, HttpContent c )
        {
            var response = string.Empty;

            using (var client = new HttpClient())
            {
                try
                {
                    //T Console.WriteLine("Content display    "    + c);
                    HttpResponseMessage result = await client.PostAsync(u, c);
                    //T Console.WriteLine("After the call     ");
                    if (result.IsSuccessStatusCode)
                    {
                        response = result.StatusCode.ToString();
                        
                        WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Trace Upload Sucess    " + result.StatusCode.ToString() + "   ", DateTime.Now));
                    }
                    else
                    {
                       
                        response = result.StatusCode.ToString();
                        WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Trace Upload failed    " + result.StatusCode.ToString() + "   Desc: " + result.Content.ToString() + "   ", DateTime.Now));
                    }
                }
                catch (Exception ex)
                {
                    
                    WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Exception thrown at POST method Call  ", DateTime.Now + "  " + ex.Message));



                }


            }


                return response;
        }
            private void CheckNG_in_Zheight(Uri u, HttpContent c) { 
           
        
        
        }
        #endregion
        private bool ValidateBandSerial(string bandSerial )
        {
            bool validBand = true ;
            if (!(bandSerial.ToString().Trim().Length == (int)Int64.Parse(BandSerialLen.ToString().Trim())))
            {

                validBand = false;
            }
            else
            {

                if (!(bandSerial.ToString().Trim().Substring(0, BandSerialStChars.ToString().Trim().Length ) == BandSerialStChars.ToString().Trim()))
                {

                    validBand = false;
                }

                if (!(bandSerial.ToString().Trim().Substring(bandSerial.ToString().Trim().Length - BandSerialEndChars.ToString().Trim().Length) == BandSerialEndChars.ToString().Trim()))
                {

                    validBand = false;
                }
            }
            return validBand;
            
        }

        private System.Windows.Forms.TextBox txtScanCode;
        private System.Windows.Forms.Label lblScanCode;
        private System.Windows.Forms.Button btnTraceCall;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWarmPress;
        private System.Windows.Forms.Button btnUploadTrace;
    }
}

