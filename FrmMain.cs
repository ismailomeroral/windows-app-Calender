using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ajanda.Properties;
using System.Xml.Linq;
using Button = System.Windows.Forms.Button;
using System.Reflection;

namespace Calendar
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
            DateTime now = DateTime.Now;
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            toDay = now.DayOfWeek.ToString();
            DateEventList();
            lblmytime.Text = (now.Hour.ToString("00") + ":" + now.Minute.ToString("00"));
            tmrmytime.Start();
            tmrAlarm.Start();
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
        
            for (int i = 0; i < 24; i++)
            {
                for (int a = 0; a <= 45; a += 15)
                {
                    cmboxStartTime.Items.Add(i.ToString("00")+":"+a.ToString("00"));
                    cmboxFinishTime.Items.Add(i.ToString("00") + ":" + a.ToString("00"));
                }
            }
          

        }

        private XElement xelement = XElement.Load(@"..\..\XMLFile1.xml");

        string toDay;
        int pzt, sal, car, per, cum, cmt, pzr;
        Panel[] pnlpzt = new Panel[1]
              , pnlsal = new Panel[1]
              , pnlcar = new Panel[1]
              , pnlper = new Panel[1]
              , pnlcum = new Panel[1]
              , pnlcmt = new Panel[1]
              , pnlpzr = new Panel[1];

        #region Functions

        public void ItemMouseHover(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb(21,21,21);
        }

        public void ItemMouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb(29, 29, 29);
        }

        public void ItemMouseClick(object sender, EventArgs e)
        {
            ChangeClear();
         
            if (n == false)
            {
                n = true;
                PanelAddMenu();
            }
            btnAdd.Visible = false;
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            SelectedDateEvent((sender as Panel).Name);

        }

        public void PanelAddMenu()
        {

            if (n)
            {
                this.MaximumSize = new Size(1267, 670);
                this.Size = new Size(1267, 670);
                this.Location = new Point(this.Location.X, this.Location.Y - 148);
                pctboxadd.Image = Resources.Up_Squared;

                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
            else
            {
                this.MaximumSize = new Size(1267, 432);
                this.Size = new Size(1267, 432);
                this.Location = new Point(this.Location.X, this.Location.Y + 148);
                pctboxadd.Image = Resources.Add_New;
            }
        }

        int DateId;

        public void NewDateEvent()
        {
            string day="";
            foreach (CheckBox item in  pnldays.Controls.OfType<CheckBox>())
            {
                if (item.Checked==true)
                {
                    day += "," + item.Text;
                }

            }
            if (day.Substring(0, 1).Equals(","))
            {
                day = day.Substring(1);
            }
            try
            {
                string Id = "0";
                var datelist = from x in xelement.Descendants("date")
                               select new
                               {
                                   xmlid = x.Element("date_id").Attribute("id").Value
                               };
                foreach (var item in datelist)
                { Id = item.xmlid; }
                    xelement.Add(new XElement("date",
                    new XElement("date_id", new XAttribute("id",(Convert.ToInt32(Id)+1  ).ToString())),
                    new XElement("date_name", new XAttribute("name", txtEventName.Text)),
                    new XElement("date_days", new XAttribute("days", day)),
                    new XElement("date_time", new XAttribute("time", cmboxStartTime.Text + " - " + cmboxFinishTime.Text)),
                    new XElement("date_explanation",new XAttribute("explanation",txtExplanation.Text)))

                    );
                xelement.Save(@"..\..\XMLFile1.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void DateEventList()
        {

            pnlPzt.Controls.Clear();
            pnlPzr.Controls.Clear();
            pnlSal.Controls.Clear();
            pnlCar.Controls.Clear();
            pnlPer.Controls.Clear();
            pnlCum.Controls.Clear();
            pnlCmt.Controls.Clear();
            pzt = 0; sal = 0; car = 0; per = 0; cum = 0; cmt = 0; pzr=0;

            var datelist = from x in xelement.Descendants("date")
                           select new {
                               xmlid = x.Element("date_id").Attribute("id").Value,
                               xmlname = x.Element("date_name").Attribute("name").Value,
                               xmldays = x.Element("date_days").Attribute("days").Value,
                               xmltime = x.Element("date_time").Attribute("time").Value,
                               xmlexplanation = x.Element("date_explanation").Attribute("explanation").Value
                           };


            foreach (var item in datelist)
            {
                char decetedchar = ',';

                string[] day = item.xmldays.Split(decetedchar);
                foreach (var xmdays in day)
                {
                    Label lble = new Label();
                    Label lblt = new Label();
                   
                    lble.BackColor = Color.Transparent;
                    lble.ForeColor = Color.Snow;
                    lble.Font = new Font("Noto Sans", 9, FontStyle.Regular, GraphicsUnit.Point);
                    lble.Name = "lblevent";
                    lble.Location = new Point(3, 3);
                    lble.Text = item.xmlname;
                  
                    lblt.BackColor = Color.Transparent;
                    lblt.ForeColor = Color.MistyRose;
                    lblt.Font = new Font("Noto Sans", 7, FontStyle.Regular, GraphicsUnit.Point);
                    lblt.Name = "lbltime";
                    lblt.Location = new Point(63, 23);
                    lblt.Text = item.xmltime;
                    if (xmdays.Equals("Pazartesi"))
                    {
                   
                        pnlpzt[pzt] = new Panel();
                        pnlpzt[pzt].Size = new Size(136, 40);
                        pnlpzt[pzt].BackColor = Color.FromArgb(30, 30, 30);
                        pnlpzt[pzt].BorderStyle = BorderStyle.None;
                        pnlpzt[pzt].Name = "pnlpzt" + pzt + "id:"+item.xmlid;
                        if (pzt == 0)
                        {
                            pnlpzt[pzt].Location = new Point(7, 11);
                        }
                        else
                        {
                            pnlpzt[pzt].Location = new Point(7, pnlpzt[pzt-1].Location.Y + 46);
                        }
                        pnlpzt[pzt].MouseEnter += new EventHandler(this.ItemMouseHover);
                        pnlpzt[pzt].MouseLeave += new EventHandler(this.ItemMouseLeave);
                        pnlpzt[pzt].Click += new EventHandler(this.ItemMouseClick);
                        pnlPzt.Controls.Add(pnlpzt[pzt]);
                        pnlpzt[pzt].Controls.Add(lble);
                        pnlpzt[pzt].Controls.Add(lblt);

                        pzt++;
                        Array.Resize(ref pnlpzt, pzt + 1);

                    }
                    else if (xmdays.Equals("Salı"))
                    {
                        pnlsal[sal] = new Panel();
                        pnlsal[sal].Size = new Size(136, 40);
                        pnlsal[sal].BackColor = Color.FromArgb(30, 30, 30);
                        pnlsal[sal].BorderStyle = BorderStyle.None;
                        pnlsal[sal].Name = "pnsal" + sal + "id:" + item.xmlid;
                        if (sal == 0)
                        {
                            pnlsal[sal].Location = new Point(7, 11);
                        }
                        else
                        {
                            pnlsal[sal].Location = new Point(7, pnlsal[sal-1].Location.Y + 46);
                        }
                        pnlsal[sal].MouseEnter += new EventHandler(this.ItemMouseHover);
                        pnlsal[sal].MouseLeave += new EventHandler(this.ItemMouseLeave);
                        pnlsal[sal].Click += new EventHandler(this.ItemMouseClick);
                        pnlSal.Controls.Add(pnlsal[sal]);
                        pnlsal[sal].Controls.Add(lble);
                        pnlsal[sal].Controls.Add(lblt);
                        sal++;
                        Array.Resize(ref pnlsal, sal + 1);
                    }
                    else if (xmdays.Equals("Çarşamba"))
                    {
                        pnlcar[car] = new Panel();
                        pnlcar[car].Size = new Size(136, 40);
                        pnlcar[car].BackColor = Color.FromArgb(30, 30, 30);
                        pnlcar[car].BorderStyle = BorderStyle.None;
                        pnlcar[car].Name = "pnlcar" + car + "id:" + item.xmlid;
                        if (car == 0)
                        {
                            pnlcar[car].Location = new Point(7, 11);
                        }
                        else
                        {
                            pnlcar[car].Location = new Point(7, pnlcar[car-1].Location.Y + 46);
                        }
                        pnlcar[car].MouseEnter += new EventHandler(this.ItemMouseHover);
                        pnlcar[car].MouseLeave += new EventHandler(this.ItemMouseLeave);
                        pnlcar[car].Click += new EventHandler(this.ItemMouseClick);
                        pnlCar.Controls.Add(pnlcar[car]);
                        pnlcar[car].Controls.Add(lble);
                        pnlcar[car].Controls.Add(lblt);
                        car++;
                        Array.Resize(ref pnlcar, car + 1);
                    }
                    else if (xmdays.Equals("Perşembe"))
                    {
                        pnlper[per] = new Panel();
                        pnlper[per].Size = new Size(136, 40);
                        pnlper[per].BackColor = Color.FromArgb(30, 30, 30);
                        pnlper[per].BorderStyle = BorderStyle.None;
                        pnlper[per].Name = "pnlper" + per + "id:" + item.xmlid;
                        if (per == 0)
                        {
                            pnlper[per].Location = new Point(7, 11);
                        }
                        else
                        {
                            pnlper[per].Location = new Point(7, pnlper[per-1].Location.Y + 46);
                        }
                        pnlper[per].MouseEnter += new EventHandler(this.ItemMouseHover);
                        pnlper[per].MouseLeave += new EventHandler(this.ItemMouseLeave);
                        pnlper[per].Click += new EventHandler(this.ItemMouseClick);
                        pnlPer.Controls.Add(pnlper[per]);
                        pnlper[per].Controls.Add(lble);
                        pnlper[per].Controls.Add(lblt);
                        per++;
                        Array.Resize(ref pnlper, per + 1);
                    }
                    else if (xmdays.Equals("Cuma"))
                    {
                        pnlcum[cum] = new Panel();
                        pnlcum[cum].Size = new Size(136, 40);
                        pnlcum[cum].BackColor = Color.FromArgb(30, 30, 30);
                        pnlcum[cum].BorderStyle = BorderStyle.None;
                        pnlcum[cum].Name = "pnlcum" + cum + "id:" + item.xmlid;
                        if (cum == 0)
                        {
                            pnlcum[cum].Location = new Point(7, 11);
                        }
                        else
                        {
                            pnlcum[cum].Location = new Point(7, pnlcum[cum-1].Location.Y + 46);
                        }
                        pnlcum[cum].MouseEnter += new EventHandler(this.ItemMouseHover);
                        pnlcum[cum].MouseLeave += new EventHandler(this.ItemMouseLeave);
                        pnlcum[cum].Click += new EventHandler(this.ItemMouseClick);
                        pnlCum.Controls.Add(pnlcum[cum]);
                        pnlcum[cum].Controls.Add(lble);
                        pnlcum[cum].Controls.Add(lblt);
                        cum++;
                        Array.Resize(ref pnlcum, cum + 1);
                    }
                    else if (xmdays.Equals("Cumartesi"))
                    {
                        pnlcmt[cmt] = new Panel();
                        pnlcmt[cmt].Size = new Size(136, 40);
                        pnlcmt[cmt].BackColor = Color.FromArgb(30, 30, 30);
                        pnlcmt[cmt].BorderStyle = BorderStyle.None;
                        pnlcmt[cmt].Name = "pnlcmt" + cmt + "id:" + item.xmlid;
                        if (cmt == 0)
                        {
                            pnlcmt[cmt].Location = new Point(7, 11);
                        }
                        else
                        {
                            pnlcmt[cmt].Location = new Point(7, pnlcmt[cmt-1].Location.Y + 46);
                        }
                        pnlcmt[cmt].MouseEnter += new EventHandler(this.ItemMouseHover);
                        pnlcmt[cmt].MouseLeave += new EventHandler(this.ItemMouseLeave);
                        pnlcmt[cmt].Click += new EventHandler(this.ItemMouseClick);

                        pnlCmt.Controls.Add(pnlcmt[cmt]);
                        pnlcmt[cmt].Controls.Add(lble);
                        pnlcmt[cmt].Controls.Add(lblt);
                        cmt++;
                        Array.Resize(ref pnlcmt, cmt + 1);
                    }
                    else if (xmdays.Equals("Pazar"))
                    {

                        pnlpzr[pzr] = new Panel();
                        pnlpzr[pzr].Size = new Size(136, 40);
                        pnlpzr[pzr].BackColor = Color.FromArgb(30, 30, 30);
                        pnlpzr[pzr].BorderStyle = BorderStyle.None;
                        pnlpzr[pzr].Name = "pnlpzr" + pzr + "id:" + item.xmlid;
                        if (pzr == 0)
                        {
                            pnlpzr[pzr].Location = new Point(7, 11);
                        }
                        else
                        {
                            pnlpzr[pzr].Location = new Point(7, pnlpzr[pzr-1].Location.Y + 46);
                        }
                        pnlpzr[pzr].MouseEnter += new EventHandler(this.ItemMouseHover);
                        pnlpzr[pzr].MouseLeave += new EventHandler(this.ItemMouseLeave);
                        pnlpzr[pzr].Click += new EventHandler(this.ItemMouseClick);
                        pnlPzr.Controls.Add(pnlpzr[pzr]);
                        pnlpzr[pzr].Controls.Add(lble);
                        pnlpzr[pzr].Controls.Add(lblt);
                        pzr++;
                        Array.Resize(ref pnlpzr, pzr + 1);
                    }
                }

            }

          

            if (pzt == 0)
            {
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Snow;
                lbl.Font = new Font("Noto Sans", 6.75f, FontStyle.Regular, GraphicsUnit.Point);
                lbl.Name = "lblnonevent";
                lbl.Location = new Point(33, 270);
                lbl.Text = "Etkinlik bulunamadı";
                pnlPzt.Controls.Add(lbl);
            }
            if (sal == 0)
            {
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Snow;
                lbl.Font = new Font("Noto Sans", 6.75f, FontStyle.Regular, GraphicsUnit.Point);
                lbl.Name = "lblnonevent";
                lbl.Location = new Point(33, 270);
                lbl.Text = "Etkinlik bulunamadı";
                pnlSal.Controls.Add(lbl);
            }
            if (car == 0)
            {
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Snow;
                lbl.Font = new Font("Noto Sans", 6.75f, FontStyle.Regular, GraphicsUnit.Point);
                lbl.Name = "lblnonevent";
                lbl.Location = new Point(33, 270);
                lbl.Text = "Etkinlik bulunamadı";
                pnlCar.Controls.Add(lbl);
            }
            if (per == 0)
            {
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Snow;
                lbl.Font = new Font("Noto Sans", 6.75f, FontStyle.Regular, GraphicsUnit.Point);
                lbl.Name = "lblnonevent";
                lbl.Location = new Point(33, 270);
                lbl.Text = "Etkinlik bulunamadı";
                pnlPer.Controls.Add(lbl);
            }
            if (cum == 0)
            {
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Snow;
                lbl.Font = new Font("Noto Sans", 6.75f, FontStyle.Regular, GraphicsUnit.Point);
                lbl.Name = "lblnonevent";
                lbl.Location = new Point(33, 270);
                lbl.Text = "Etkinlik bulunamadı";
                pnlCum.Controls.Add(lbl);
            }
            if (cmt == 0)
            {
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Snow;
                lbl.Font = new Font("Noto Sans", 6.75f, FontStyle.Regular, GraphicsUnit.Point);
                lbl.Name = "lblnonevent";
                lbl.Location = new Point(33, 270);
                lbl.Text = "Etkinlik bulunamadı";
                pnlCmt.Controls.Add(lbl);
            }
            if (pzr == 0)
            {
                Label lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Snow;
                lbl.Font = new Font("Noto Sans", 6.75f, FontStyle.Regular, GraphicsUnit.Point);
                lbl.Name = "lblnonevent";
                lbl.Location = new Point(33, 270);
                lbl.Text = "Etkinlik bulunamadı";
                pnlPzr.Controls.Add(lbl);
            }
        }
        public void SelectedDateEvent(string rawName)
        {
            string tid= "0";

            for (int f = 0; f < rawName.Length - 3; f++)
                if (rawName.Substring(f,3).Equals("id:"))
                    tid = rawName.Substring(f + 3);


            var datelist = from x in xelement.Descendants("date")
                           select new
                           {
                               xmlid = x.Element("date_id").Attribute("id").Value,
                               xmlname = x.Element("date_name").Attribute("name").Value,
                               xmldays = x.Element("date_days").Attribute("days").Value,
                               xmltime = x.Element("date_time").Attribute("time").Value,
                               xmlexplanation = x.Element("date_explanation").Attribute("explanation").Value
                           };
            foreach (var item in datelist)
            {
              
                if (item.xmlid==tid)
                {
                    txtEventName.Text = item.xmlname;
                    txtExplanation.Text = item.xmlexplanation;
                    cmboxStartTime.Text = item.xmltime.Substring(0, 5);
                    cmboxFinishTime.Text = item.xmltime.Substring(8, 5);
                    DateId = Convert.ToInt32(item.xmlid);
                    char decetedchar = ',';
                    string[] day = item.xmldays.Split(decetedchar);
                    foreach (var cboxday in day)
                    {
                        if (cboxday == cboxPzr.Text)
                        {
                            cboxPzr.Checked = true;
                        }
                        if (cboxday == cboxSal.Text)
                        {
                            cboxSal.Checked = true;
                        }
                        if (cboxday == cboxCar.Text)
                        {
                            cboxCar.Checked = true;
                        }
                        if (cboxday == cboxPer.Text)
                        {
                            cboxPer.Checked = true;
                        }
                        if (cboxday == cboxCum.Text)
                        {
                            cboxCum.Checked = true;
                        }
                        if (cboxday == cboxCmt.Text)
                        {
                            cboxCmt.Checked = true;
                        }
                        if (cboxday == cboxPzt.Text)
                        {
                            cboxPzt.Checked = true;
                        }

                    }
                }

            }

        }
        public void DeleteDateEvent()
        {
            try
            {
                foreach (var node in xelement.Descendants("date_id")
           .Where(status => status.Attribute("id").Value==DateId.ToString())
           .ToList())
                {
                    node.Parent.Remove();
                }
                xelement.Save(@"..\..\XMLFile1.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
         
        }
        public void EditDateEvent()
        {
            string day = "";
            foreach (CheckBox item in pnldays.Controls.OfType<CheckBox>())
                if (item.Checked == true)
                    day += "," + item.Text;

            if (day.Substring(0, 1).Equals(","))
                day = day.Substring(1);


            var datelist = xelement.Descendants("date").ToList();
            foreach (XElement item in datelist)
            {
                if (item.Element("date_id").Attribute("id").Value == DateId.ToString())
                {
                    item.Element("date_name").SetAttributeValue("name", txtEventName.Text);
                    item.Element("date_days").SetAttributeValue("days",day);
                    item.Element("date_time").SetAttributeValue("time", cmboxStartTime.Text + " - " + cmboxFinishTime.Text);
                    item.Element("date_explanation").SetAttributeValue("explanation", txtExplanation.Text);
                    
                    break;
                }
            }
            xelement.Save(@"..\..\XMLFile1.xml");

        }

        string[] days = { "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };
        string istToDay;
        public void LangueTranslate(string trday)
        {
            if ("Monday" == toDay)
                istToDay = "Pazartesi";
            if ("Tuesday" == toDay)
                istToDay = "Salı";
            if ("Wednesday" == toDay)
                istToDay = "Çarşamba";
            if ("Thursday" == toDay)
                istToDay = "Perşembe";
            if ("Friday" == toDay)
                istToDay = "Cuma";
            if ("Saturday" == toDay)
                istToDay = "Cumartesi";
            if ("Sunday" == toDay)
                istToDay = "Pazar";
        }
        int alarm = 0;
        Form frmMesagge;
        bool isAlarmAlert=true;
        public void AlarmAlert()
        {
            char decetedchar = ',';
               var datelist = from x in xelement.Descendants("date")
                           select new {
                               xmlid = x.Element("date_id").Attribute("id").Value,
                               xmlname = x.Element("date_name").Attribute("name").Value,
                               xmldays = x.Element("date_days").Attribute("days").Value,
                               xmltime = x.Element("date_time").Attribute("time").Value,
                               xmlexplanation = x.Element("date_explanation").Attribute("explanation").Value
                           };
            foreach (var item in datelist)
            {
                string[] day = item.xmldays.Split(decetedchar);

                foreach (var f in day)
                {
                    LangueTranslate(toDay);
                    if (f == istToDay)
                    {
                        DateTime userStartTime = Convert.ToDateTime(item.xmltime.Substring(0, 5));
                        DateTime userFinishTime = Convert.ToDateTime(item.xmltime.Substring(8, 5));
                       
                        if (userFinishTime.TimeOfDay >= now.TimeOfDay && now.TimeOfDay >= userStartTime.TimeOfDay )
                        {
                            alarm++;
                            if (alarm==100 && isAlarmAlert==true)
                            {
                                frmMesagge = new Form
                                {
                                    Size = new Size(400, 200),
                                    Location = new Point(950, 500),
                                    StartPosition = FormStartPosition.Manual,
                                    BackColor = Color.FromArgb(29, 29, 29),
                                    FormBorderStyle = FormBorderStyle.None,
                                    ForeColor = Color.WhiteSmoke,
                                    Name = "frmMessage" + item.xmlid
                                };
                                Label lblMessageTitle = new Label
                                {
                                    ForeColor = Color.Snow,
                                    BackColor = Color.Transparent,
                                    Text = "" + item.xmlname,
                                    Name = "lblMessageTitle",
                                    Location = new Point(40, 30),
                                    Font = new Font("Noto Sans", 16, FontStyle.Regular),
                                };
                                Label lblMessageTime = new Label
                                {
                                    ForeColor = Color.MistyRose,
                                    BackColor = Color.Transparent,
                                    Text = userStartTime.Hour+":"+userStartTime.Minute+" - "+ userFinishTime.Hour + ":" + userFinishTime.Minute,
                                    Name = "lblMessageTime",
                                    Location = new Point(40, 50),
                                    Font = new Font("Noto Sans", 12, FontStyle.Regular)
                                };
                                Label lblMessageExplanation = new Label
                                {
                                    ForeColor = Color.Snow,
                                    BackColor = Color.Transparent,
                                    Text = "" + item.xmlexplanation,
                                    Name = "lblMessageExplanation",
                                    Location = new Point(40, 100),
                                    Font = new Font("Noto Sans", 14, FontStyle.Regular)
                                };
                                Button btnMessageStop = new Button
                                {
                                    ForeColor = Color.Snow,
                                    BackColor = Color.Gray,
                                    Size = new Size(150, 70),
                                    Font = new Font("Noto Sans", 12, FontStyle.Regular),
                                    FlatStyle = FlatStyle.Flat,
                                    Location = new Point(225, 100),
                                    Text = "Durdur",
                                    Name = "lblMessageStop"

                                };
                                Label lblMessageExit = new Label
                                {
                                    ForeColor = Color.Firebrick,
                                    BackColor = Color.Transparent,
                                    Cursor = Cursors.Hand,
                                    Text = "X",
                                    Name = "lblMessageExit",
                                    Location = new Point(370, 0),
                                    Font = new Font("Noto Sans", 15, FontStyle.Regular)
                                };
                                btnMessageStop.Click += new EventHandler(MessageFormbtnStop_Click);
                                lblMessageExit.Click += new EventHandler(MessageFormExit_Click);
                                frmMesagge.Controls.Add(lblMessageExit);
                                frmMesagge.Controls.Add(lblMessageTitle);
                                frmMesagge.Controls.Add(lblMessageTime);
                                frmMesagge.Controls.Add(lblMessageExplanation);
                                frmMesagge.Controls.Add(btnMessageStop);
                                NotifyIcon(item.xmlname, item.xmltime, item.xmlexplanation);
                                frmMesagge.Show();
                            }
                            if (alarm >= 110 && userFinishTime.TimeOfDay >= now.TimeOfDay)
                            {
                                alarm = 0;
                            }
                            if (userFinishTime.TimeOfDay <= now.TimeOfDay)
                            {
                                isAlarmAlert = true;
                            }
                        }
              
                        
                    }
                }
            }

        }


        #endregion

        #region MessageFormTransactions
        NotifyIcon notify_iconMesage = new NotifyIcon();
        void NotifyIcon(string title, string time, string explanation)
        {
            notify_iconMesage.Visible = true;
            notify_iconMesage.Text = title;
            notify_iconMesage.BalloonTipText = title;
            notify_iconMesage.BalloonTipTitle = title + " Etkinliği başladı";
            notify_iconMesage.BalloonTipText = time;
            notify_iconMesage.Icon = Resources.Calendar;
            notify_iconMesage.BalloonTipIcon = ToolTipIcon.Info;
            notify_iconMesage.ShowBalloonTip(2000);
            notify_iconMesage.MouseDoubleClick += new MouseEventHandler(notify_Icon_MouseDoubleClick);
        }
        void notify_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notify_iconMesage.Visible = false;
        }
        public void MessageFormExit_Click(object sender,EventArgs e)
        {
            frmMesagge.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MessageFormbtnStop_Click(object sender, EventArgs e)
        {
            frmMesagge.Close();
            isAlarmAlert = false;
        }
        public NotifyIcon notify_icon = new NotifyIcon();
        public ContextMenu contextMenu1 = new ContextMenu();
        private void Min_Click(object sender, EventArgs e)
        {
            contextMenu1.MenuItems.Add("Göster").Click += ContentMenuShowEvent_Click; ;
            contextMenu1.MenuItems.Add("Kapat").Click+= Exit_Click;

            // Set properties of NotifyIcon component.  
            notify_icon.Icon = Resources.Calendar_dark;
            notify_icon.Text = "Calendar";
            notify_icon.Visible = true;
            notify_icon.ContextMenu = contextMenu1;
            notify_icon.DoubleClick += ContentMenuShowEvent_Click;
            this.Hide();
        }

     
        private void ContentMenuShowEvent_Click(object sender, EventArgs e)
        {
            this.Show();
            notify_icon.Visible = false;

        }


        #endregion


        #region MainFormEvents
        public void tmr_Tick(object sender, EventArgs e) 
        {
            if (now.TimeOfDay >= restartTime.TimeOfDay)
            {
                tmrAlarm.Start();
                (sender as Timer).Stop();
            }
        }
        DateTime restartTime = new DateTime();
        bool n = false;
        private void pctboxadd_Click(object sender, EventArgs e)
        {
            n = !n;
            PanelAddMenu();
           ChangeClear(); 

        }
        public void ChangeClear()
        {
            txtEventName.Text = "";
            txtExplanation.Text = "";
            cmboxStartTime.Text = "12:00";
            cmboxFinishTime.Text = "13:00";
            cboxPzt.Checked = true;
            cboxPzr.Checked = false;
            cboxSal.Checked = false;
            cboxCar.Checked = false;
            cboxPer.Checked = false;
            cboxCum.Checked = false;
            cboxCmt.Checked = false;
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            btnEdit.Visible = false;

        }
        private void cmboxStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        int mow=0, mowX, mowY;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mow =0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mow==1)
            {
                this.SetDesktopLocation(MousePosition.X - mowX, MousePosition.Y - mowY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }

        private void tmrmytime_Tick(object sender, EventArgs e)
        {
            lblmytime.Text = (now.Hour.ToString("00") + ":" + now.Minute.ToString("00"));
            toDay = now.DayOfWeek.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboxPzr.Checked==true|| cboxPzt.Checked == true || cboxSal.Checked == true || cboxCar.Checked == true || cboxPer.Checked == true || cboxCum.Checked == true || cboxCmt.Checked == true)
            {
                NewDateEvent();
                ChangeClear();
                n = false;
                PanelAddMenu();
                DateEventList();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDateEvent();
            DateEventList();
            n = false;
            PanelAddMenu();
            ChangeClear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cboxPzr.Checked == true || cboxPzt.Checked == true || cboxSal.Checked == true || cboxCar.Checked == true || cboxPer.Checked == true || cboxCum.Checked == true || cboxCmt.Checked == true)
            {
                EditDateEvent();
                DateEventList();
                n = false;
                PanelAddMenu();
                ChangeClear();
            }

           
        }
        private void tmrAlarm_Tick(object sender, EventArgs e)
        {
            AlarmAlert();
        }
        #endregion
    }
}
