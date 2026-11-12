namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] stu = new string[] { "A001", "A002", "A003", "A004","A005","A006" };  //存放學生學號
            string[] sub = new string[] { "計概", "程設", "專題","語文" };  //存放科目名稱
            int[,] score = new int[,] { { 82, 84, 90 , 98}, { 85, 92, 87 , 77}, { 80, 73, 82 ,67}, { 62, 68, 84 ,85}, { 62, 6, 80, 85 } , { 62, 68, 84, 65 } };
            int[] sum = new int[6] { 0, 0, 0, 0 ,0 ,0};
            for (int y = 0; y <= score.GetUpperBound(0); y++)
            {
                for (int x = 0; x <= score.GetUpperBound(1); x++)
                    sum[y] += score[y, x];
            }
            string msg = "學號\t";
            foreach (string s in sub)
                msg += s + "\t";
            msg += "總分\t";
            msg += "平均\n";
            
            for (int y = 0; y <= stu.GetUpperBound(0); y++)
            {
                float total = 0;
                msg += stu[y] + "\t";
                for (int x = 0; x <= sub.GetUpperBound(0); x++)
                    msg += $"{score[y, x]}\t";
                total += sum[y];
                msg += $"{sum[y]}\t";
                msg += $"{(total / 4).ToString("F1")}\n";
            }
            
            MessageBox.Show(msg, "成績表");
            Application.Exit();
        }
    }
}
