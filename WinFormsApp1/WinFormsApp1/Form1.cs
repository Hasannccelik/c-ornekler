namespace WinFormsApp1

{

    public partial class Form1 : Form
    {
        // open file dialog tan�mlamas�
        OpenFileDialog file = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        string yazi = "zorlama_yeniden";

        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox1.Text)) // e�er ayn� adda dosya yok ise program� ba�lat
            {
                File.Create(textBox1.Text + ".txt").Close(); // textboxtaki dosya ismi ile txt format�nda dosya olu�tur.
                using (StreamWriter sw = File.AppendText(textBox1.Text + ".txt"))// burda stream writer metodunu kullan�yoruz
                {
                    sw.WriteLine(textBox1.Text); // textbox2 deki text ti yapm�� oldu�umuz txt dosyas�n�n i�ine yazd�rd�k.


                    save.Filter = "Text Files|*.txt";
                    save.OverwritePrompt = true;
                    //messagebox ile b�yle bir dosya olu�turmak istermisin diye soracak
                    save.CreatePrompt = true;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter Kayit = new StreamWriter(save.FileName);
                        Kayit.WriteLine(yazi);
                        Kayit.Close();
                    }
                }
            }
            else // e�er ayn� adda dosya varsa program� durdur.
            {
                MessageBox.Show("This File is already existed!!!");
            }








        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bu komut default olarak open file dialog u masa�st�nde a�ar.
            /*file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);*/

            //open file dialog un varsay�lan olarak hangi klas�rde �al��aca��n� belirleyen kod
            //file.InitialDirectory = "C:\\";
            //sadece fotograf olan dosyalar� getir ancak show dialog un �st�nde tan�mlanacak
            //burada tek �izgi ile istedi�imiz kadar uzant� ekleyebiliriz.

             //file.Filter = "Photos|*.jpg| Videos|*.mp4";

            //filter index ile ilk s�rada hangi uzant�n�n ��kaca��n� belirliyoruz.
            file.FilterIndex = 1;
            //kald���n dosya yolundan open file dialog u a�maya devam et
            file.RestoreDirectory = true;
            //dosya konumunda e�er yazd���m�z dosya yok ise uyar� ��kar bu mesaj� iptal etme komutu
            file.CheckFileExists = false;
            //open file dialog un ba�l�k k�sm� ismi
            file.Title = "Select File";
            //open file dialogta �oklu dosya se�me �zelli�ini aktif etme kodu
            file.Multiselect = false;

            //dosyan�n ad�n� ve konumunu string de�i�kene aktard�k.
            //a��lma penceresini g�steriyoruz.
            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                
                System.IO.FileInfo ff = new System.IO.FileInfo(file.FileName);
                string DosyaUzantisi = ff.Extension;
                
                if (DosyaUzantisi==".png")
                {
                    
                    MessageBox.Show("jpg de�il");
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
