namespace Weather_test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputNameCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImgSun = new DevExpress.XtraEditors.SvgImageBox();
            this.imgSunCloud = new DevExpress.XtraEditors.SvgImageBox();
            this.ImgSmallRain = new DevExpress.XtraEditors.SvgImageBox();
            this.ImgSnow = new DevExpress.XtraEditors.SvgImageBox();
            this.btnMurmansk = new System.Windows.Forms.Button();
            this.btn_Tiraspol = new System.Windows.Forms.Button();
            this.btnStambul = new System.Windows.Forms.Button();
            this.btnlondon = new System.Windows.Forms.Button();
            this.svgReset = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSunCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSmallRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgReset)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNameCity
            // 
            this.inputNameCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNameCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameCity.Location = new System.Drawing.Point(279, 13);
            this.inputNameCity.Multiline = true;
            this.inputNameCity.Name = "inputNameCity";
            this.inputNameCity.Size = new System.Drawing.Size(202, 29);
            this.inputNameCity.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Узнать погоду";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите название города:";
            // 
            // ImgSun
            // 
            this.ImgSun.Location = new System.Drawing.Point(342, 117);
            this.ImgSun.Name = "ImgSun";
            this.ImgSun.Size = new System.Drawing.Size(170, 145);
            this.ImgSun.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.ImgSun.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImgSun.SvgImage")));
            this.ImgSun.TabIndex = 5;
            this.ImgSun.Text = "svgImageBox1";
            // 
            // imgSunCloud
            // 
            this.imgSunCloud.Location = new System.Drawing.Point(342, 117);
            this.imgSunCloud.Name = "imgSunCloud";
            this.imgSunCloud.Size = new System.Drawing.Size(170, 145);
            this.imgSunCloud.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.imgSunCloud.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("imgSunCloud.SvgImage")));
            this.imgSunCloud.TabIndex = 6;
            this.imgSunCloud.Text = "svgImageBox2";
            this.imgSunCloud.Visible = false;
            // 
            // ImgSmallRain
            // 
            this.ImgSmallRain.Location = new System.Drawing.Point(342, 117);
            this.ImgSmallRain.Name = "ImgSmallRain";
            this.ImgSmallRain.Size = new System.Drawing.Size(170, 145);
            this.ImgSmallRain.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.ImgSmallRain.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImgSmallRain.SvgImage")));
            this.ImgSmallRain.TabIndex = 7;
            this.ImgSmallRain.Text = "svgImageBox1";
            this.ImgSmallRain.Visible = false;
            // 
            // ImgSnow
            // 
            this.ImgSnow.Location = new System.Drawing.Point(342, 117);
            this.ImgSnow.Name = "ImgSnow";
            this.ImgSnow.Size = new System.Drawing.Size(170, 145);
            this.ImgSnow.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.ImgSnow.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImgSnow.SvgImage")));
            this.ImgSnow.TabIndex = 8;
            this.ImgSnow.Text = "svgImageBox1";
            this.ImgSnow.Visible = false;
            // 
            // btnMurmansk
            // 
            this.btnMurmansk.Location = new System.Drawing.Point(16, 57);
            this.btnMurmansk.Name = "btnMurmansk";
            this.btnMurmansk.Size = new System.Drawing.Size(75, 23);
            this.btnMurmansk.TabIndex = 9;
            this.btnMurmansk.Text = "Мурманск";
            this.btnMurmansk.UseVisualStyleBackColor = true;
            this.btnMurmansk.Click += new System.EventHandler(this.btnMurmansk_Click);
            // 
            // btn_Tiraspol
            // 
            this.btn_Tiraspol.Location = new System.Drawing.Point(97, 57);
            this.btn_Tiraspol.Name = "btn_Tiraspol";
            this.btn_Tiraspol.Size = new System.Drawing.Size(75, 23);
            this.btn_Tiraspol.TabIndex = 10;
            this.btn_Tiraspol.Text = "Тирасполь";
            this.btn_Tiraspol.UseVisualStyleBackColor = true;
            this.btn_Tiraspol.Click += new System.EventHandler(this.btn_Tiraspol_Click);
            // 
            // btnStambul
            // 
            this.btnStambul.Location = new System.Drawing.Point(178, 57);
            this.btnStambul.Name = "btnStambul";
            this.btnStambul.Size = new System.Drawing.Size(75, 23);
            this.btnStambul.TabIndex = 11;
            this.btnStambul.Text = "Стамбул";
            this.btnStambul.UseVisualStyleBackColor = true;
            this.btnStambul.Click += new System.EventHandler(this.btnStambul_Click);
            // 
            // btnlondon
            // 
            this.btnlondon.Location = new System.Drawing.Point(259, 57);
            this.btnlondon.Name = "btnlondon";
            this.btnlondon.Size = new System.Drawing.Size(75, 23);
            this.btnlondon.TabIndex = 12;
            this.btnlondon.Text = "Лондон";
            this.btnlondon.UseVisualStyleBackColor = true;
            this.btnlondon.Click += new System.EventHandler(this.btnlondon_Click);
            // 
            // svgReset
            // 
            this.svgReset.Location = new System.Drawing.Point(487, 13);
            this.svgReset.Name = "svgReset";
            this.svgReset.Size = new System.Drawing.Size(25, 29);
            this.svgReset.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgReset.SvgImage")));
            this.svgReset.TabIndex = 14;
            this.svgReset.Text = "svgImageBox1";
            this.svgReset.Click += new System.EventHandler(this.svgImageBox1_Click);
            this.svgReset.MouseEnter += new System.EventHandler(this.svgReset_MouseEnter);
            this.svgReset.MouseLeave += new System.EventHandler(this.svgReset_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(530, 279);
            this.Controls.Add(this.svgReset);
            this.Controls.Add(this.btnlondon);
            this.Controls.Add(this.btnStambul);
            this.Controls.Add(this.btn_Tiraspol);
            this.Controls.Add(this.btnMurmansk);
            this.Controls.Add(this.ImgSnow);
            this.Controls.Add(this.ImgSmallRain);
            this.Controls.Add(this.imgSunCloud);
            this.Controls.Add(this.ImgSun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputNameCity);
            this.Name = "Form1";
            this.Text = "Погода";
            ((System.ComponentModel.ISupportInitialize)(this.ImgSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSunCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSmallRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNameCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SvgImageBox ImgSun;
        private DevExpress.XtraEditors.SvgImageBox imgSunCloud;
        private DevExpress.XtraEditors.SvgImageBox ImgSmallRain;
        private DevExpress.XtraEditors.SvgImageBox ImgSnow;
        private System.Windows.Forms.Button btnMurmansk;
        private System.Windows.Forms.Button btn_Tiraspol;
        private System.Windows.Forms.Button btnStambul;
        private System.Windows.Forms.Button btnlondon;
        private DevExpress.XtraEditors.SvgImageBox svgReset;
    }
}

