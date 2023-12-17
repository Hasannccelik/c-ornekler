namespace WinFormsApp1

{

    public partial class Form1 : Form
    {
        // open file dialog tanýmlamasý
        OpenFileDialog file = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        string yazi = "zorlama_yeniden";

        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox1.Text)) // eðer ayný adda dosya yok ise programý baþlat
            {
                File.Create(textBox1.Text + ".txt").Close(); // textboxtaki dosya ismi ile txt formatýnda dosya oluþtur.
                using (StreamWriter sw = File.AppendText(textBox1.Text + ".txt"))// burda stream writer metodunu kullanýyoruz
                {
                    sw.WriteLine(textBox1.Text); // textbox2 deki text ti yapmýþ olduðumuz txt dosyasýnýn içine yazdýrdýk.


                    save.Filter = "Text Files|*.txt";
                    save.OverwritePrompt = true;
                    //messagebox ile böyle bir dosya oluþturmak istermisin diye soracak
                    save.CreatePrompt = true;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter Kayit = new StreamWriter(save.FileName);
                        Kayit.WriteLine(yazi);
                        Kayit.Close();
                    }
                }
            }
            else // eðer ayný adda dosya varsa programý durdur.
            {
                MessageBox.Show("This File is already existed!!!");
            }








        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bu komut default olarak open file dialog u masaüstünde açar.
            /*file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);*/

            //open file dialog un varsayýlan olarak hangi klasörde çalýþacaðýný belirleyen kod
            //file.InitialDirectory = "C:\\";
            //sadece fotograf olan dosyalarý getir ancak show dialog un üstünde tanýmlanacak
            //burada tek çizgi ile istediðimiz kadar uzantý ekleyebiliriz.

             //file.Filter = "Photos|*.jpg| Videos|*.mp4";

            //filter index ile ilk sýrada hangi uzantýnýn çýkacaðýný belirliyoruz.
            file.FilterIndex = 1;
            //kaldýðýn dosya yolundan open file dialog u açmaya devam et
            file.RestoreDirectory = true;
            //dosya konumunda eðer yazdýðýmýz dosya yok ise uyarý çýkar bu mesajý iptal etme komutu
            file.CheckFileExists = false;
            //open file dialog un baþlýk kýsmý ismi
            file.Title = "Select File";
            //open file dialogta çoklu dosya seçme özelliðini aktif etme kodu
            file.Multiselect = false;

            //dosyanýn adýný ve konumunu string deðiþkene aktardýk.
            //açýlma penceresini gösteriyoruz.
            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                
                System.IO.FileInfo ff = new System.IO.FileInfo(file.FileName);
                string DosyaUzantisi = ff.Extension;
                
                if (DosyaUzantisi==".png")
                {
                    
                    MessageBox.Show("jpg deðil");
                }
                label1.Text = DosyaUzantisi;



            }
            else
            {

                file.Reset();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
