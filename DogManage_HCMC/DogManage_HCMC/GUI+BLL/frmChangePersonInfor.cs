using DogManage_HCMC.DAL;
using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogManage_HCMC.GUI_BLL
{
    public partial class frmChangePersonInfor : Form
    {
        //Form này có thuộc tính account để lưu tài khoản đang đăng nhập
        Account _acc = new Account();
        SoftWareUser user = null;
        bool isSave = false;
        public frmChangePersonInfor(Account acc)
        {
            _acc = acc;
            InitializeComponent();
        }
        //
        // Load tất cả thông tin của tài khoản đang đăng nhập
        public void loadAllInfoAccount()
        {

            user = SoftWareUserConnection.Inst.getUserByUserName(_acc.UserName);
            if (user == null)
            {
                MessageBox.Show("Tải thông tin thất bại, vui lòng thử lại sau !");
                this.Close();
            }
            else
            {
                user.Account = _acc;
                loadUser(user);
            }
        }
        // Thay đổi text của các control hiện thị ở UI theo tài khoản đang đăng nhập
        public void loadUser(SoftWareUser s)
        {
            tbAddress.Text = s.Info.Address;

            dateTimePicker1.Text = s.Info.BirthDay.ToShortDateString();
            tbEmail.Text = s.Info.EMail;
            tbIDCardNum.Text = s.Info.IdCardNumber.ToString();
            tbName.Text = s.Info.Name;
            tbPhoneNum.Text = s.Info.PhoneNum.ToString();
            tbID.Text = s.Info.IdPerson.ToString();

            cbFeMale.Checked = s.Info.Gender;

            tbUserName.Text = s.Account.UserName;

            tbTypeAcc.Text = s.Account.Type.ToString();

            tbMedicalCode.Text = s.MedicalCode.ToString();
            tbFringeBenefit.Text = s.FringeBenegit.ToString();
            tbDateJoin.Text = s.DateJoin.ToShortDateString();

            tbBasicSalary.Text = s.Salary.ToString();
            TbBankNumber.Text = s.BankAccountNum.ToString();

            pictureBox1.Image = byteArrToImage(s.Image);


        }

        Image byteArrToImage(byte[] b)
        {
            if (b == null) return null;
            MemoryStream str = new MemoryStream(b);
            Image img = Image.FromStream(str);
            return img;
        }
        private void gbPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void cbMale_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFeMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmChangePersonInfor_Load(object sender, EventArgs e)
        {

            loadAllInfoAccount();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string fileName = op.FileName;
            if (string.IsNullOrEmpty(fileName))
                return;
            pictureBox1.Image = Image.FromFile(fileName);
        }

        public Image resizeImage(int newWidth, int newHeight, Image imgPhoto)
        {


            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            //Consider vertical pics
            if (sourceWidth < sourceHeight)
            {
                int buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)newHeight / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth -
                          (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight -
                          (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);


            Bitmap bmPhoto = new Bitmap(newWidth, newHeight,
                          PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                         imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode =
                System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            imgPhoto.Dispose();
            return bmPhoto;
        }
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (user != null)
            {

                MemoryStream str = new MemoryStream();
                pictureBox1.Image.Save(str, ImageFormat.Jpeg);

                user.Image = str.ToArray();
                if (SoftWareUserConnection.Inst.saveImage(user.Image, user.Info.IdPerson))
                {
                    MessageBox.Show("Lưu ảnh đại diện thành công !!");
                    isSave = true;
                }

                else
                {
                    MessageBox.Show("Lưu ảnh thất bại, vui lòng thử lại sau !");
                }
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {

            if (PersonInfoConnection.Inst.updateName(StandardString(tbName.Text), tbID.Text))
            {
                MessageBox.Show("Lưu tên thành công !");
                isSave = true;
            }
            else
            {
                MessageBox.Show("Lưu thất bại, vui lòng thử lại sau !");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            if (SoftWareUserConnection.Inst.updateMedicalCode(tbMedicalCode.Text, tbID.Text))
            {
                MessageBox.Show("Lưu mã số BHYT thành công !");
                isSave = true;
            }
            else
            {
                MessageBox.Show("Lưu thất bại, vui lòng thử lại sau !");
            }
        }

        private void btnSave4_Click(object sender, EventArgs e)
        {
            string birthday = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            int gender = cbFeMale.Checked ? 1 : 0;

            if (PersonInfoConnection.Inst.updatePSI(tbID.Text, tbPhoneNum.Text, tbIDCardNum.Text, StandardString(tbAddress.Text), tbEmail.Text, birthday, gender))
            {
                MessageBox.Show("Lưu thông tin cá nhân thành công !");
                isSave = true;
            }
            else
            {
                MessageBox.Show("Lưu thất bại, vui lòng thử lại sau !");
            }

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (tbAddress.Text.Length >= 22)
            {
                tbAddress.Multiline = true;
            }
            else
            {
                tbAddress.Multiline = false;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbMedicalCode.Text = "";
            tbEmail.Text = "";
            tbPhoneNum.Text = "";
            tbAddress.Text = "";
            tbIDCardNum.Text = "";
            cbFeMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadAllInfoAccount();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            btnSave1_Click(sender, e);
            btnSaveImage_Click(sender, e);
            btnSave3_Click(sender, e);
            btnSave4_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

           

        }
        public string StandardString(string strInput)
        {
            string tmp = strInput;
            try
            {
                strInput = strInput.Trim().ToLower();
                while (strInput.Contains("  "))
                    strInput = strInput.Replace("  ", " ");
                string strResult = "";
                string[] arrResult = strInput.Split(' ');
                foreach (string item in arrResult)
                    strResult += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
                return strResult.TrimEnd();
            }
            catch { return tmp; }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                if (MessageBox.Show("Bạn chưa lưu lại thông tin, có muốn thoát ngay bây giờ không ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {

                }
            }
        }
    }
}
