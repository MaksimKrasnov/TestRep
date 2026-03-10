namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        OpenFileDialog dialog;

        byte[] data1;
        byte[] data2;

        string sourcePath1;
        string sourcePath2;

        string destPath1;
        string destPath2;

        int step1;
        int step2;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath1 = dialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath2 = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destPath1 = dialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destPath2 = dialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sourcePath1 == null || sourcePath2 == null)
            {
                MessageBox.Show("Выберите исходные файлы");
                return;
            }
            using (FileStream reader1 = File.OpenRead(sourcePath1))
            using (FileStream reader2 = File.OpenRead(sourcePath2))
            {
                data1 = new byte[reader1.Length];
                data2 = new byte[reader2.Length];

                step1 = (int)(reader1.Length / 100);
                step2 = (int)(reader2.Length / 100);


                step1 = step1 == 0 ? 1 : step1;
                step2 = step2 == 0 ? 1 : step2;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;

                int count1 = 0;
                int count2 = 0;

                int progress = 0;

                while (count1 < data1.Length || count2 < data2.Length)
                {
                    if (count1 < data1.Length)
                    {
                        count1 += reader1.Read(
                            data1,
                            count1,
                            Math.Min(step1, data1.Length - count1));
                    }
                    if (count2 < data2.Length)
                    {
                        count2 += reader2.Read(
                            data2,
                            count2,
                            Math.Min(step2, data2.Length - count2));
                    }
                    progress++;
                    if (progress <= 100)
                    {
                        progressBar1.Value = progress;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(data1 == null || data2== null)
            {
                MessageBox.Show("Сначала загрузите файлы");
                return;
            }
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Value = 0;
            progressBar1.Step = 1;

            Thread thread1 = new Thread(WriteFile1);
            Thread thread2 = new Thread(WriteFile2);

            thread1.Start();
            thread2.Start();
        }

        private void StepProgress()
        {
            progressBar2.PerformStep();
        }

        delegate void ProgressDelegate();


        private void WriteFile1()
        {
            using (FileStream writer = new FileStream(destPath1, FileMode.Create))
            {
                for (int i = 0; i < data1.Length; i++)
                {
                    writer.WriteByte(data1[i]);

                    if(i%step1 == 0)
                    {
                        if (InvokeRequired)
                        {
                            Invoke(new ProgressDelegate(StepProgress));
                        }
                        else
                        {
                            StepProgress();
                        }

                    }
                }
            }
        }
        private void WriteFile2()
        {
            using (FileStream writer = new FileStream(destPath2, FileMode.Create))
            {
                for (int i = 0; i < data2.Length; i++)
                {
                    writer.WriteByte(data2[i]);
                }
            }
        }
    }
}
