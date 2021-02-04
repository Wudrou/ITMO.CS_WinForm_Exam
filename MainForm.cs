using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace Calculator
{
		public class Calc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btn_sbros;
		private System.Windows.Forms.Button btnChangesign;
		private System.Windows.Forms.Button btnpoint;
		private System.Windows.Forms.Button btn_ravno;
		private System.Windows.Forms.Button btn_delenie;
		private System.Windows.Forms.Button btn_umnojenie;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
        private IContainer components;

        /// <summary>
        /// Объявляем и инициализируем переменные, которые будут
        ///  возникать на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string odin = "1";
		private const string dva = "2";
		private const string tri = "3";
		private const string chetire = "4";
		private const string pyat = "5";
		private const string shest = "6";
		private const string sem = "7";
		private const string vosem = "8";
		private const string devyat = "9";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem обычныйToolStripMenuItem;
        private ToolStripMenuItem инженерныйToolStripMenuItem;
        private ToolTip toolTip;
        private Button btn_vkvadrat;
        private Button btn_vstepen;
        private Button btn_koren;
        private Button btn_obratnoe;
        private Button btn_factorial;
        private Button btn_korenkyb;
        private Button btn_yravnenie;
        private TextBox txtFactorial;
        private BackgroundWorker backgroundWorkerFactorial;
        private ProgressBar progressBar1;
        private const string nul = "0";

		public Calc()
		{

			InitializeComponent();
			this.Size = new Size(320, 300);
            this.txtFactorial.Visible = false;
			// При запуске приложения на экране будет пусто
			txtOutput.Text = "";
		
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_vkvadrat = new System.Windows.Forms.Button();
            this.btn_vstepen = new System.Windows.Forms.Button();
            this.btn_koren = new System.Windows.Forms.Button();
            this.btn_obratnoe = new System.Windows.Forms.Button();
            this.btn_factorial = new System.Windows.Forms.Button();
            this.btn_korenkyb = new System.Windows.Forms.Button();
            this.btn_yravnenie = new System.Windows.Forms.Button();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.backgroundWorkerFactorial = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(29, 53);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(242, 26);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sbros.Location = new System.Drawing.Point(218, 85);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(40, 80);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.toolTip.SetToolTip(this.btn_sbros, "Сброс");
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangesign.Location = new System.Drawing.Point(82, 205);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(40, 40);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpoint.Location = new System.Drawing.Point(122, 205);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(40, 40);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ravno.Location = new System.Drawing.Point(218, 165);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(40, 80);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.toolTip.SetToolTip(this.btn_ravno, "Равно");
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delenie.Location = new System.Drawing.Point(178, 85);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(40, 40);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.toolTip.SetToolTip(this.btn_delenie, "Деление");
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_umnojenie.Location = new System.Drawing.Point(178, 125);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(40, 40);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.toolTip.SetToolTip(this.btn_umnojenie, "Умножение");
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.Location = new System.Drawing.Point(178, 205);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(40, 40);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.toolTip.SetToolTip(this.btn_plus, "Сложение");
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_minus.Location = new System.Drawing.Point(178, 165);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(40, 40);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.toolTip.SetToolTip(this.btn_minus, "Вычитание");
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(42, 205);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(122, 85);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(82, 85);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(42, 85);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(122, 125);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(82, 125);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(42, 125);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(122, 165);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(82, 165);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(42, 165);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 26);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.инженерныйToolStripMenuItem});
            this.видToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            this.инженерныйToolStripMenuItem.Click += new System.EventHandler(this.инженерныйToolStripMenuItem_Click);
            // 
            // btn_vkvadrat
            // 
            this.btn_vkvadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_vkvadrat.Location = new System.Drawing.Point(300, 85);
            this.btn_vkvadrat.Name = "btn_vkvadrat";
            this.btn_vkvadrat.Size = new System.Drawing.Size(40, 40);
            this.btn_vkvadrat.TabIndex = 62;
            this.btn_vkvadrat.Text = "x²";
            this.toolTip.SetToolTip(this.btn_vkvadrat, "Квадрат числа");
            this.btn_vkvadrat.UseVisualStyleBackColor = false;
            this.btn_vkvadrat.Visible = false;
            this.btn_vkvadrat.Click += new System.EventHandler(this.btn_vkvadrat_Click);
            // 
            // btn_vstepen
            // 
            this.btn_vstepen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_vstepen.Location = new System.Drawing.Point(340, 85);
            this.btn_vstepen.Name = "btn_vstepen";
            this.btn_vstepen.Size = new System.Drawing.Size(40, 40);
            this.btn_vstepen.TabIndex = 62;
            this.btn_vstepen.Text = "xʸ";
            this.toolTip.SetToolTip(this.btn_vstepen, "Возведение в степень");
            this.btn_vstepen.UseVisualStyleBackColor = false;
            this.btn_vstepen.Visible = false;
            this.btn_vstepen.Click += new System.EventHandler(this.btn_vstepen_Click);
            // 
            // btn_koren
            // 
            this.btn_koren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_koren.Location = new System.Drawing.Point(380, 85);
            this.btn_koren.Name = "btn_koren";
            this.btn_koren.Size = new System.Drawing.Size(40, 40);
            this.btn_koren.TabIndex = 62;
            this.btn_koren.Text = "√";
            this.toolTip.SetToolTip(this.btn_koren, "Корень квадратный");
            this.btn_koren.UseVisualStyleBackColor = false;
            this.btn_koren.Visible = false;
            this.btn_koren.Click += new System.EventHandler(this.btn_koren_Click);
            // 
            // btn_obratnoe
            // 
            this.btn_obratnoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_obratnoe.Location = new System.Drawing.Point(300, 125);
            this.btn_obratnoe.Name = "btn_obratnoe";
            this.btn_obratnoe.Size = new System.Drawing.Size(40, 40);
            this.btn_obratnoe.TabIndex = 62;
            this.btn_obratnoe.Text = "⅟ᵪ";
            this.toolTip.SetToolTip(this.btn_obratnoe, "Обратное значение");
            this.btn_obratnoe.UseVisualStyleBackColor = false;
            this.btn_obratnoe.Visible = false;
            this.btn_obratnoe.Click += new System.EventHandler(this.btn_obratnoe_Click);
            // 
            // btn_factorial
            // 
            this.btn_factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_factorial.Location = new System.Drawing.Point(340, 125);
            this.btn_factorial.Name = "btn_factorial";
            this.btn_factorial.Size = new System.Drawing.Size(40, 40);
            this.btn_factorial.TabIndex = 62;
            this.btn_factorial.Text = "x!";
            this.toolTip.SetToolTip(this.btn_factorial, "Факториал");
            this.btn_factorial.UseVisualStyleBackColor = false;
            this.btn_factorial.Visible = false;
            this.btn_factorial.Click += new System.EventHandler(this.btn_factorial_Click);
            // 
            // btn_korenkyb
            // 
            this.btn_korenkyb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_korenkyb.Location = new System.Drawing.Point(380, 125);
            this.btn_korenkyb.Name = "btn_korenkyb";
            this.btn_korenkyb.Size = new System.Drawing.Size(40, 40);
            this.btn_korenkyb.TabIndex = 62;
            this.btn_korenkyb.Text = "³√";
            this.toolTip.SetToolTip(this.btn_korenkyb, "Корень кубический");
            this.btn_korenkyb.UseVisualStyleBackColor = false;
            this.btn_korenkyb.Visible = false;
            this.btn_korenkyb.Click += new System.EventHandler(this.btn_korenkyb_Click);
            // 
            // btn_yravnenie
            // 
            this.btn_yravnenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_yravnenie.Location = new System.Drawing.Point(300, 165);
            this.btn_yravnenie.Name = "btn_yravnenie";
            this.btn_yravnenie.Size = new System.Drawing.Size(120, 40);
            this.btn_yravnenie.TabIndex = 62;
            this.btn_yravnenie.Text = "ax²+bx+c=0";
            this.toolTip.SetToolTip(this.btn_yravnenie, "Квадратное уравнение");
            this.btn_yravnenie.UseVisualStyleBackColor = false;
            this.btn_yravnenie.Visible = false;
            this.btn_yravnenie.Click += new System.EventHandler(this.btn_yravnenie_Click);
            // 
            // txtFactorial
            // 
            this.txtFactorial.Enabled = false;
            this.txtFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFactorial.Location = new System.Drawing.Point(300, 53);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(120, 26);
            this.txtFactorial.TabIndex = 63;
            this.txtFactorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backgroundWorkerFactorial
            // 
            this.backgroundWorkerFactorial.WorkerReportsProgress = true;
            this.backgroundWorkerFactorial.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFactorial_DoWork);
            this.backgroundWorkerFactorial.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerFactorial_ProgressChanged);
            this.backgroundWorkerFactorial.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFactorial_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(300, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 7);
            this.progressBar1.TabIndex = 64;
            this.progressBar1.Visible = false;
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(450, 257);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.btn_koren);
            this.Controls.Add(this.btn_vstepen);
            this.Controls.Add(this.btn_korenkyb);
            this.Controls.Add(this.btn_factorial);
            this.Controls.Add(this.btn_obratnoe);
            this.Controls.Add(this.btn_yravnenie);
            this.Controls.Add(this.btn_vkvadrat);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор 1.0";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Calc());
		}
		/// <summary>
		/// Обработчики для кнопок  обращаются к методу chislonaEkrane класса mehanizmcalkulyatora
		/// и передают ему одну из постоянных (odin, dva, tri  и т.д.). Результат, возвращаемый методом,
		/// присваивается  свойству Text текстового поля txtOutput.
		/// </summary>

			private void btn1_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (odin);
			}

			private void btn2_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (dva);
			}

			private void btn3_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (tri);
			}

			private void btn4_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (chetire);
			}

			private void btn5_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (pyat);
			}

			private void btn6_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (shest);
			}

			private void btn7_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (sem);
			}

			private void btn8_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (vosem);
			}

			private void btn9_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (devyat);
			}

			private void btn0_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (nul);
			}

			private void btnChangesign_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
			}

			private void btnpoint_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
			}
			/// <summary>
			/// Обработчики кнопок действия калькулятора передают 
			/// методу DeystvieCalculatora класса mehanizmcalkulyatora переменную перечисления Deystvie.
			/// </summary>
		
			private void btn_delenie_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Delenie);
			}

			private void btn_umnojenie_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Umnojenie);
			}

			private void btn_minus_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Vichitanie);
			}

			private void btn_plus_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Slojenie);
			}

			private void btn_ravno_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
				mehanizmcalkulyatora.Sbros();
			}

			private void btn_sbros_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.Sbros();
				txtOutput.Text = "";
			}
            private void btn_vkvadrat_Click(object sender, EventArgs e)
            {
                try
                {
                    mehanizmcalkulyatora.pervoeChislo = Convert.ToDouble(mehanizmcalkulyatora.resultatOutput);
                    txtOutput.Text = (Math.Pow(mehanizmcalkulyatora.pervoeChislo, 2)).ToString();
                    mehanizmcalkulyatora.resultatOutput = "";
                }
                catch
                {
                    mehanizmcalkulyatora.Sbros();
                    txtOutput.Text = "0";
                }
            }
            private void btn_vstepen_Click(object sender, EventArgs e)
            {
                mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Vstepen);
            }

            private void btn_koren_Click(object sender, EventArgs e)
            {
                try
                {
                    if (Convert.ToDouble(mehanizmcalkulyatora.resultatOutput) < 0)
                    {
                        txtOutput.Text = "Значение не может быть < 0";
                        mehanizmcalkulyatora.resultatOutput = "";
                    }
                    else
                    {
                        mehanizmcalkulyatora.pervoeChislo = Convert.ToDouble(mehanizmcalkulyatora.resultatOutput);
                        txtOutput.Text = (Math.Sqrt(mehanizmcalkulyatora.pervoeChislo)).ToString();
                        mehanizmcalkulyatora.resultatOutput = "";
                    }
                }
                catch
                {
                    mehanizmcalkulyatora.Sbros();
                    txtOutput.Text = "0";
                }
            }
            private void btn_obratnoe_Click(object sender, EventArgs e)
            {
                try
                {
                    if (mehanizmcalkulyatora.resultatOutput == "0")
                    {
                        txtOutput.Text = "Делить на ноль нельзя";
                        mehanizmcalkulyatora.resultatOutput = "";
                    }
                    else
                    {
                        mehanizmcalkulyatora.pervoeChislo = Convert.ToDouble(mehanizmcalkulyatora.resultatOutput);
                        txtOutput.Text = (1 / mehanizmcalkulyatora.pervoeChislo).ToString();
                        mehanizmcalkulyatora.resultatOutput = "";
                    }
                }
                catch
                {
                    mehanizmcalkulyatora.Sbros();
                    txtOutput.Text = "0";
                }
        }
            private void btn_korenkyb_Click(object sender, EventArgs e)
            {
                try
                    {
                        if (Convert.ToDouble(mehanizmcalkulyatora.resultatOutput) < 0)
                        {
                            mehanizmcalkulyatora.pervoeChislo = Convert.ToDouble(mehanizmcalkulyatora.resultatOutput);
                            txtOutput.Text = "-" + Math.Pow(mehanizmcalkulyatora.pervoeChislo * mehanizmcalkulyatora.peremennayaMinus, 1.0 / 3.0).ToString();
                            mehanizmcalkulyatora.resultatOutput = "";
                        }
                        else
                        {
                            mehanizmcalkulyatora.pervoeChislo = Convert.ToDouble(mehanizmcalkulyatora.resultatOutput);
                            txtOutput.Text = (Math.Pow(mehanizmcalkulyatora.pervoeChislo, 1.0 / 3.0)).ToString();
                            mehanizmcalkulyatora.resultatOutput = "";
                        }
                    }
                catch
                {
                    mehanizmcalkulyatora.Sbros();
                    txtOutput.Text = "0";
                }
            }
            private void btn_factorial_Click(object sender, EventArgs e)
            {
                try
                {
                    mehanizmcalkulyatora.pervoeChislo = Convert.ToDouble(mehanizmcalkulyatora.resultatOutput);
                    if (mehanizmcalkulyatora.pervoeChislo < 0)
                    {
                        txtOutput.Text = "Значение не может быть < 0";
                        mehanizmcalkulyatora.resultatOutput = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(mehanizmcalkulyatora.pervoeChislo) != mehanizmcalkulyatora.pervoeChislo)
                        {
                            txtOutput.Text = "Значение должно быть целым";
                            mehanizmcalkulyatora.resultatOutput = "";
                        }
                        else
                        {
                            if (backgroundWorkerFactorial.IsBusy != true)
                            {
                                this.txtFactorial.Visible = true;
                                this.progressBar1.Visible = true;
                                this.progressBar1.Value = 0;
                                int fact = Convert.ToInt32(mehanizmcalkulyatora.pervoeChislo);
                                backgroundWorkerFactorial.RunWorkerAsync(fact);
                                mehanizmcalkulyatora.Sbros();
                                txtOutput.Text = "";
                            }
                        }
                    }
                }
                catch
                {
                    mehanizmcalkulyatora.Sbros();
                    txtOutput.Text = "0";
                }
            }
            private void backgroundWorkerFactorial_DoWork(object sender, DoWorkEventArgs e)
            {
                int factorial = 1;
                for (int i = 1; i <= (int)e.Argument; i++)
                {
                    factorial *= i;
                }
                int j = 5;
                for (int i = 1; i <= j; i++)
                {
                    Thread.Sleep(1000);
                    backgroundWorkerFactorial.ReportProgress(i * 100 / j);
                }
                e.Result = factorial;
            }
            private void backgroundWorkerFactorial_ProgressChanged(object sender, ProgressChangedEventArgs e)
            {
                this.progressBar1.Value = e.ProgressPercentage;
            }
            private void backgroundWorkerFactorial_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
                txtFactorial.Text = e.Result.ToString();
                this.progressBar1.Visible = false;
            }
        private void btn_yravnenie_Click(object sender, EventArgs e)
            {
                QuadEq quadEq = new QuadEq();
                quadEq.ShowDialog();
            }
        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Size = new Size(320, 300);
            this.btn_vkvadrat.Visible = false;
            this.btn_vstepen.Visible = false;
            this.btn_koren.Visible = false;
            this.btn_obratnoe.Visible = false;
            this.btn_factorial.Visible = false;
            this.btn_korenkyb.Visible = false;
            this.btn_yravnenie.Visible = false;
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Size = new Size(470, 300);
            this.btn_vkvadrat.Visible = true;
            this.btn_vstepen.Visible = true;
            this.btn_koren.Visible = true;
            this.btn_obratnoe.Visible = true;
            this.btn_factorial.Visible = true;
            this.btn_korenkyb.Visible = true;
            this.btn_yravnenie.Visible = true;
        }
}
    class mehanizmcalkulyatora
	{
	/// <summary>
	///Создаем перечисление Deystvie, для определения одного из четырех действия калькулятора.
	/// </summary>
		public enum Deystvie:int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
            Vstepen = 5,
        }

	/// <summary>
	/// Объявляем и инициализируем переменную, 
	/// которая будет использоваться для смены знака при нажатии клавиши (+/-)
	/// </summary>

		public static double peremennayaMinus = -1;

		/// <summary>
		/// Объвляем переменные, для работы калькулятора:
		/// resultatVichisleniy - переменная для хранения
		///  промежуточного результата в механизме калькулятора
		///  resultatOutput - переменная, значение которой будет сниматься с экрана и  выводиться на него.
		///  tekusheeDeystvieCalculatora - хранение одного из действия калькулятора.
		///  pervoeChislo - переменная, в которую будет записываться число на экране
		///   до нажатия на одну из четырех кнопок с действием.
		///  vtoroeChislo - второе число на экране.
		///  dobavlenierazryada при добавлении следующего  разряда эта переменная примет значение true;
		///  ChislosTochkoy при добавлении десятичного разряда (знака точки) эта переменная примет значение true
		/// </summary>
	
		public static double resultatVichisleniy;
		public static string resultatOutput;
		private static Deystvie tekusheeDeystvieCalculatora;
		public static double pervoeChislo;
		private static double vtoroeChislo;
		private static bool dobavlenierazryada;
		private static bool ChislosTochkoy;
 
		/// <summary>
		/// В конструкторе класса mehanizmcalkulyatora инициализируем переменные 
		/// ChislosTochkoy и dobavlenierazryada - при запуске калькулятора на экране 
		/// нет ни разрядности, ни десятичной части.
		/// </summary>

		public mehanizmcalkulyatora ()
		{
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}

			
		/// <summary>
		/// В этом методе переменная resultatOutput изменяется - при вводе числа ее значение перезаписывается.
		/// </summary>
		

		public static string chislonaEkrane (string najatayaKlavisha)
		{
			resultatOutput = resultatOutput + najatayaKlavisha;
			return (resultatOutput);
		}
		/// <summary>
		/// Метод, в котором определяется peremenDeystviya - одно значение перечисления Deystvie,
		///в зависимости от выбора  клавиши +, -, *,  или /
		/// </summary>
	
		public static void DeystvieCalculatora (Deystvie peremenDeystviya)
		{
			try
			{
				if (resultatOutput != "" && !dobavlenierazryada)
				{
					pervoeChislo = System.Convert.ToDouble (resultatOutput);
					tekusheeDeystvieCalculatora = peremenDeystviya;
					resultatOutput = "";
					ChislosTochkoy = false;
				}			
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
			
			}
		}



	/// <summary>
	/// При нажатии  кнопки +/- число на экране - tekusheeChislo умножается на -1,
	///  а затем результат снова присваивается переменной resultatOutput.
	/// </summary>
	

		public static string ZnakChisla ()
		{
			double tekusheeChislo;

			if (resultatOutput != "")
			{
				tekusheeChislo = System.Convert.ToDouble (resultatOutput);
				resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
			}
		
			return (resultatOutput);
		}

		/// <summary>
		/// При нажатии кнопки ( , ) переменная resultatOutput приобретает дробную часть.
		/// </summary>
	

		public static string ZnakTochki ()
		{
			if (!ChislosTochkoy && !dobavlenierazryada)
			{
				if (resultatOutput != "")
					resultatOutput = resultatOutput + ",";
				else
					resultatOutput = "0,";

				ChislosTochkoy = true;
			}

			return (resultatOutput);
		}

	/// <summary>
	/// При нажатии кнопки ZnakRavno обрабатываются значения 
	/// переменнных pervoeChislo и vtoroeChislo, результат присваивается переменной resultatVichisleniy 
	/// которая  затем преобразуется в resultatOutput.
	/// </summary>


		public static string ZnakRavno ()
		{
			bool proverkaOshibok = false;

			if (resultatOutput != "")
			{
				vtoroeChislo = System.Convert.ToDouble (resultatOutput);
				dobavlenierazryada = true;

				switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
						resultatVichisleniy = pervoeChislo + vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						resultatVichisleniy = pervoeChislo - vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
						resultatVichisleniy = pervoeChislo * vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
						resultatVichisleniy = pervoeChislo / vtoroeChislo;
						proverkaOshibok = true;
						break;

                    case Deystvie.Vstepen:
                        resultatVichisleniy = Math.Pow (pervoeChislo, vtoroeChislo);
                        proverkaOshibok = true;
                        break;

                    default:
						proverkaOshibok = false;
						break;
				}

				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString (resultatVichisleniy);
			}
			
			return (resultatOutput);
		}

	/// <summary>
	/// При нажатии кнопки  С (сброс) значения переменных обнуляются.
	/// </summary>

		public static void Sbros ()
		{
            resultatVichisleniy = 0;
			pervoeChislo = 0;
			vtoroeChislo = 0;
			resultatOutput = "";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			ChislosTochkoy = false;
			dobavlenierazryada = false;			
		}
	}
}
