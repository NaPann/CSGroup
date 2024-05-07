using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Services
{
    public class GlobalService
    {
        public bool RequireTextbox(TextBox sender, string senderName)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text.Trim()))
            {
                MessageBox.Show("กรุณากรอกข้อมูล: " + senderName + " !!", "คำเตือน !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                sender.Select();
                sender.SelectAll();
                return false;
            }
            return true;
        }
        public bool RequireColorTextbox(TextBox sender)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text.Trim()))
            {
                sender.BackColor = Color.LightCoral;
                sender.Select();
                sender.SelectAll();
                return false;
            }
            else
            {
                sender.BackColor = Color.White;
            }
            return true;
        }
        public bool RequireColorTextbox(NumericUpDown sender)
        {
            if ((sender as NumericUpDown).Value == 0)
            {
                sender.BackColor = Color.LightCoral;
                sender.Select();
                return false;
            }
            else
            {
                sender.BackColor = Color.White;
            }
            return true;
        }
        public bool RequireColorTextbox(NumericUpDown sender, decimal atLeast)
        {
            if ((sender as NumericUpDown).Value <= atLeast)
            {
                sender.BackColor = Color.LightCoral;
                sender.Select();
                return false;
            }
            else
            {
                sender.BackColor = Color.White;
            }
            return true;
        }
        public bool RequireColorControl(DateTimePicker sender)
        {
            if (!(sender as DateTimePicker).Checked)
            {
                sender.BackColor = Color.LightCoral;
                sender.Select();
                return false;
            }
            else
            {
                sender.BackColor = Color.White;
            }
            return true;
        }
        public void Announce(string announceText, AnnounceType type)
        {
            switch (type)
            {
                case AnnounceType.Infomation:
                    XtraMessageBox.Show(announceText, "แสดงข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case AnnounceType.Warning:
                    XtraMessageBox.Show(announceText, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case AnnounceType.Error:
                    XtraMessageBox.Show(announceText, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
        public DialogResult Sure(string questionText)
        {
            return XtraMessageBox.Show(questionText, "คำถาม ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public string AutoGenerate(GenerateType sType)
        {
            string result = "unknown"; DateTime _now = DateTime.Now; System.Globalization.CultureInfo cul = new System.Globalization.CultureInfo("en-us");
            using (var db = new Entity.CSBNPEntities())
            {
                switch (sType)
                {
                    case GenerateType.Product:
                        var genProduct = db.mas_Product
                            .Where(w => w.CreatedDate.Day == _now.Day && w.CreatedDate.Month == _now.Month && w.CreatedDate.Year == _now.Year)
                            .OrderByDescending(o => o.CreatedDate).FirstOrDefault();
                        if (genProduct == null)
                        {
                            //new
                            result = String.Format("PRD{0}001", _now.ToString("yyMMdd", cul));
                        }
                        else
                        {
                            string exCode = genProduct.ProductCode; int run = int.Parse(exCode.Substring(9).ToString());
                            result = String.Format("PRD{0}{1}", _now.ToString("yyMMdd", cul), (run + 1).ToString().PadLeft(3, '0'));
                        }
                        break;
                    case GenerateType.Debtor:
                        var genDebtor = db.mas_Debtor
                      .Where(w => w.CreatedDate.Day == _now.Day && w.CreatedDate.Month == _now.Month && w.CreatedDate.Year == _now.Year)
                      .OrderByDescending(o => o.CreatedDate).FirstOrDefault();
                        if (genDebtor == null)
                        {
                            //new
                            result = String.Format("DEB{0}001", _now.ToString("yyMMdd", cul));
                        }
                        else
                        {
                            string exCode = genDebtor.DebtorCode; int run = int.Parse(exCode.Substring(9).ToString());
                            result = String.Format("DEB{0}{1}", _now.ToString("yyMMdd", cul), (run + 1).ToString().PadLeft(3, '0'));
                        }
                        break;
                    case GenerateType.Creditor:
                        var genCreditor = db.mas_Creditor
                   .Where(w => w.CreatedDate.Day == _now.Day && w.CreatedDate.Month == _now.Month && w.CreatedDate.Year == _now.Year)
                   .OrderByDescending(o => o.CreatedDate).FirstOrDefault();
                        if (genCreditor == null)
                        {
                            //new
                            result = String.Format("CRE{0}001", _now.ToString("yyMMdd", cul));
                        }
                        else
                        {
                            string exCode = genCreditor.CreditorCode; int run = int.Parse(exCode.Substring(9).ToString());
                            result = String.Format("CRE{0}{1}", _now.ToString("yyMMdd", cul), (run + 1).ToString().PadLeft(3, '0'));
                        }
                        break;
                    case GenerateType.Job:
                        var genJob = db.mas_Job
                         .Where(w => w.CreatedDate.Day == _now.Day && w.CreatedDate.Month == _now.Month && w.CreatedDate.Year == _now.Year)
                         .OrderByDescending(o => o.CreatedDate).FirstOrDefault();
                        if (genJob == null)
                        {
                            //new
                            result = String.Format("JOB{0}001", _now.ToString("yyMMdd", cul));
                        }
                        else
                        {
                            string exCode = genJob.JobCode; int run = int.Parse(exCode.Substring(9).ToString());
                            result = String.Format("JOB{0}{1}", _now.ToString("yyMMdd", cul), (run + 1).ToString().PadLeft(3, '0'));
                        }
                        break;
                    case GenerateType.TransactionCreditor:
                        var genTC = db.tran_Creditor
                         .Where(w => w.CreatedDate.Day == _now.Day && w.CreatedDate.Month == _now.Month && w.CreatedDate.Year == _now.Year)
                         .OrderByDescending(o => o.CreatedDate).FirstOrDefault();
                        if (genTC == null)
                        {
                            //new
                            result = String.Format("TRC{0}001", _now.ToString("yyMMdd", cul));
                        }
                        else
                        {
                            string exCode = genTC.TransactionCreditorCode; int run = int.Parse(exCode.Substring(9).ToString());
                            result = String.Format("TRC{0}{1}", _now.ToString("yyMMdd", cul), (run + 1).ToString().PadLeft(3, '0'));
                        }
                        break;
                    case GenerateType.TransactionDebitor:
                        var genTD = db.tran_DebitorRec
                         .Where(w => w.CreatedDate.Day == _now.Day && w.CreatedDate.Month == _now.Month && w.CreatedDate.Year == _now.Year)
                         .OrderByDescending(o => o.CreatedDate).FirstOrDefault();
                        if (genTD == null)
                        {
                            //new
                            result = String.Format("TRD{0}001", _now.ToString("yyMMdd", cul));
                        }
                        else
                        {
                            string exCode = genTD.TransactionDebitorCode; int run = int.Parse(exCode.Substring(9).ToString());
                            result = String.Format("TRD{0}{1}", _now.ToString("yyMMdd", cul), (run + 1).ToString().PadLeft(3, '0'));
                        }
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
        public void LogHistoryService(LogHistory type, string name,  string desc, string user)
        {
            Entity.CSBNPEntities db = new Entity.CSBNPEntities();
            var obj = new Entity.log_History();
            obj.logDate = DateTime.Now;
            obj.logDescription = desc;
            obj.logName = name;
            obj.logType = type.ToString();
            obj.logUser = user;
            db.log_History.Add(obj);
            db.SaveChanges();
        }
    }
}
public enum AnnounceType
{
    Infomation,
    Warning,
    Error
}
public enum GenerateType
{
    Product, Debtor,Creditor, Job, TransactionCreditor, TransactionDebitor
}
public enum BillingPeriodStatus
{
    New = 1,
    Processed = 2
}
public enum DebitorPeriodStatus
{
    New = 1,
    Processed = 2
}
public enum LogHistory
{
    INSERT,
    UPDATE,
    DELETE
}
