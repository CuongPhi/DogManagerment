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
            tbBirthDay.Text = s.Info.BirthDay.ToShortDateString();
            tbEmail.Text = s.Info.EMail;
            tbIDCardNum.Text = s.Info.IdCardNumber.ToString();
            tbName.Text = s.Info.Name;
            tbPhoneNum.Text = s.Info.PhoneNum.ToString();
            tbID.Text = s.Info.IdPerson.ToString();
            if (s.Info.Gender == false)
            {
                cbMale.Checked = true;
            }
            else
            {
                cbFeMale.Checked = true;
            }
            tbUserName.Text = s.Account.UserName;
            //tbPass.Text = s.Account.PassWord;
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

        public Image resizeImage(int newWidth, int newHeight, Image imgPhoto)        {
          

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
                    MessageBox.Show("Lưu ảnh đại diện thành công !!");
                else
                    MessageBox.Show("Lưu thất bại !");
            }
        }
    }
}
