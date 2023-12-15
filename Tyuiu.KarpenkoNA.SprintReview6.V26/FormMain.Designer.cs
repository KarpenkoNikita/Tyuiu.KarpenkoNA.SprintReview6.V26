
namespace Tyuiu.KarpenkoNA.SprintReview6.V26
{
    partial class FormMain
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
            this.panelLeft_KNA = new System.Windows.Forms.Panel();
            this.panelRight_KNA = new System.Windows.Forms.Panel();
            this.splitterTask_KNA = new System.Windows.Forms.Splitter();
            this.groupBoxSize_KNA = new System.Windows.Forms.GroupBox();
            this.groupBoxDiap_KNA = new System.Windows.Forms.GroupBox();
            this.groupBoxDannye_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxRows_KNA = new System.Windows.Forms.TextBox();
            this.textBoxColumns_KNA = new System.Windows.Forms.TextBox();
            this.textBoxN1_KNA = new System.Windows.Forms.TextBox();
            this.textBoxN2_KNA = new System.Windows.Forms.TextBox();
            this.textBoxK_KNA = new System.Windows.Forms.TextBox();
            this.textBoxL_KNA = new System.Windows.Forms.TextBox();
            this.textBoxR_KNA = new System.Windows.Forms.TextBox();
            this.labelRows_KNA = new System.Windows.Forms.Label();
            this.labelColumns_KNA = new System.Windows.Forms.Label();
            this.labelN1_KNA = new System.Windows.Forms.Label();
            this.labelN2_KNA = new System.Windows.Forms.Label();
            this.labelK_KNA = new System.Windows.Forms.Label();
            this.labelL_KNA = new System.Windows.Forms.Label();
            this.labelRowR_KNA = new System.Windows.Forms.Label();
            this.dataGridViewMas_KNA = new System.Windows.Forms.DataGridView();
            this.groupBoxMult_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KNA = new System.Windows.Forms.TextBox();
            this.buttonResult_KNA = new System.Windows.Forms.Button();
            this.panelLeft_KNA.SuspendLayout();
            this.panelRight_KNA.SuspendLayout();
            this.groupBoxSize_KNA.SuspendLayout();
            this.groupBoxDiap_KNA.SuspendLayout();
            this.groupBoxDannye_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas_KNA)).BeginInit();
            this.groupBoxMult_KNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft_KNA
            // 
            this.panelLeft_KNA.Controls.Add(this.groupBoxDannye_KNA);
            this.panelLeft_KNA.Controls.Add(this.groupBoxDiap_KNA);
            this.panelLeft_KNA.Controls.Add(this.groupBoxSize_KNA);
            this.panelLeft_KNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KNA.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_KNA.Name = "panelLeft_KNA";
            this.panelLeft_KNA.Size = new System.Drawing.Size(359, 450);
            this.panelLeft_KNA.TabIndex = 0;
            // 
            // panelRight_KNA
            // 
            this.panelRight_KNA.Controls.Add(this.buttonResult_KNA);
            this.panelRight_KNA.Controls.Add(this.groupBoxMult_KNA);
            this.panelRight_KNA.Controls.Add(this.dataGridViewMas_KNA);
            this.panelRight_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_KNA.Location = new System.Drawing.Point(359, 0);
            this.panelRight_KNA.Name = "panelRight_KNA";
            this.panelRight_KNA.Size = new System.Drawing.Size(441, 450);
            this.panelRight_KNA.TabIndex = 1;
            // 
            // splitterTask_KNA
            // 
            this.splitterTask_KNA.Location = new System.Drawing.Point(359, 0);
            this.splitterTask_KNA.Name = "splitterTask_KNA";
            this.splitterTask_KNA.Size = new System.Drawing.Size(3, 450);
            this.splitterTask_KNA.TabIndex = 2;
            this.splitterTask_KNA.TabStop = false;
            // 
            // groupBoxSize_KNA
            // 
            this.groupBoxSize_KNA.Controls.Add(this.labelColumns_KNA);
            this.groupBoxSize_KNA.Controls.Add(this.labelRows_KNA);
            this.groupBoxSize_KNA.Controls.Add(this.textBoxColumns_KNA);
            this.groupBoxSize_KNA.Controls.Add(this.textBoxRows_KNA);
            this.groupBoxSize_KNA.Location = new System.Drawing.Point(19, 12);
            this.groupBoxSize_KNA.Name = "groupBoxSize_KNA";
            this.groupBoxSize_KNA.Size = new System.Drawing.Size(290, 111);
            this.groupBoxSize_KNA.TabIndex = 0;
            this.groupBoxSize_KNA.TabStop = false;
            this.groupBoxSize_KNA.Text = "Укажите размерность массива:";
            // 
            // groupBoxDiap_KNA
            // 
            this.groupBoxDiap_KNA.Controls.Add(this.labelN2_KNA);
            this.groupBoxDiap_KNA.Controls.Add(this.labelN1_KNA);
            this.groupBoxDiap_KNA.Controls.Add(this.textBoxN2_KNA);
            this.groupBoxDiap_KNA.Controls.Add(this.textBoxN1_KNA);
            this.groupBoxDiap_KNA.Location = new System.Drawing.Point(19, 141);
            this.groupBoxDiap_KNA.Name = "groupBoxDiap_KNA";
            this.groupBoxDiap_KNA.Size = new System.Drawing.Size(290, 112);
            this.groupBoxDiap_KNA.TabIndex = 1;
            this.groupBoxDiap_KNA.TabStop = false;
            this.groupBoxDiap_KNA.Text = "Укажите диапозон значений:";
            // 
            // groupBoxDannye_KNA
            // 
            this.groupBoxDannye_KNA.Controls.Add(this.labelRowR_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.labelL_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.labelK_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.textBoxR_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.textBoxL_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.textBoxK_KNA);
            this.groupBoxDannye_KNA.Location = new System.Drawing.Point(18, 271);
            this.groupBoxDannye_KNA.Name = "groupBoxDannye_KNA";
            this.groupBoxDannye_KNA.Size = new System.Drawing.Size(320, 165);
            this.groupBoxDannye_KNA.TabIndex = 2;
            this.groupBoxDannye_KNA.TabStop = false;
            this.groupBoxDannye_KNA.Text = "Укажите диапозон произведения значений массива:";
            // 
            // textBoxRows_KNA
            // 
            this.textBoxRows_KNA.Location = new System.Drawing.Point(12, 38);
            this.textBoxRows_KNA.Name = "textBoxRows_KNA";
            this.textBoxRows_KNA.Size = new System.Drawing.Size(208, 20);
            this.textBoxRows_KNA.TabIndex = 0;
            // 
            // textBoxColumns_KNA
            // 
            this.textBoxColumns_KNA.Location = new System.Drawing.Point(15, 81);
            this.textBoxColumns_KNA.Name = "textBoxColumns_KNA";
            this.textBoxColumns_KNA.Size = new System.Drawing.Size(204, 20);
            this.textBoxColumns_KNA.TabIndex = 1;
            // 
            // textBoxN1_KNA
            // 
            this.textBoxN1_KNA.Location = new System.Drawing.Point(10, 35);
            this.textBoxN1_KNA.Name = "textBoxN1_KNA";
            this.textBoxN1_KNA.Size = new System.Drawing.Size(133, 20);
            this.textBoxN1_KNA.TabIndex = 0;
            // 
            // textBoxN2_KNA
            // 
            this.textBoxN2_KNA.Location = new System.Drawing.Point(10, 75);
            this.textBoxN2_KNA.Name = "textBoxN2_KNA";
            this.textBoxN2_KNA.Size = new System.Drawing.Size(133, 20);
            this.textBoxN2_KNA.TabIndex = 1;
            // 
            // textBoxK_KNA
            // 
            this.textBoxK_KNA.Location = new System.Drawing.Point(11, 48);
            this.textBoxK_KNA.Name = "textBoxK_KNA";
            this.textBoxK_KNA.Size = new System.Drawing.Size(125, 20);
            this.textBoxK_KNA.TabIndex = 0;
            // 
            // textBoxL_KNA
            // 
            this.textBoxL_KNA.Location = new System.Drawing.Point(11, 96);
            this.textBoxL_KNA.Name = "textBoxL_KNA";
            this.textBoxL_KNA.Size = new System.Drawing.Size(122, 20);
            this.textBoxL_KNA.TabIndex = 1;
            // 
            // textBoxR_KNA
            // 
            this.textBoxR_KNA.Location = new System.Drawing.Point(166, 48);
            this.textBoxR_KNA.Name = "textBoxR_KNA";
            this.textBoxR_KNA.Size = new System.Drawing.Size(125, 20);
            this.textBoxR_KNA.TabIndex = 2;
            // 
            // labelRows_KNA
            // 
            this.labelRows_KNA.AutoSize = true;
            this.labelRows_KNA.Location = new System.Drawing.Point(14, 23);
            this.labelRows_KNA.Name = "labelRows_KNA";
            this.labelRows_KNA.Size = new System.Drawing.Size(141, 13);
            this.labelRows_KNA.TabIndex = 2;
            this.labelRows_KNA.Text = "Количество строк N (N>1):";
            // 
            // labelColumns_KNA
            // 
            this.labelColumns_KNA.AutoSize = true;
            this.labelColumns_KNA.Location = new System.Drawing.Point(16, 66);
            this.labelColumns_KNA.Name = "labelColumns_KNA";
            this.labelColumns_KNA.Size = new System.Drawing.Size(161, 13);
            this.labelColumns_KNA.TabIndex = 3;
            this.labelColumns_KNA.Text = "Количество столбцов M (M>1):";
            // 
            // labelN1_KNA
            // 
            this.labelN1_KNA.AutoSize = true;
            this.labelN1_KNA.Location = new System.Drawing.Point(13, 20);
            this.labelN1_KNA.Name = "labelN1_KNA";
            this.labelN1_KNA.Size = new System.Drawing.Size(38, 13);
            this.labelN1_KNA.TabIndex = 2;
            this.labelN1_KNA.Text = "От n1:";
            // 
            // labelN2_KNA
            // 
            this.labelN2_KNA.AutoSize = true;
            this.labelN2_KNA.Location = new System.Drawing.Point(13, 61);
            this.labelN2_KNA.Name = "labelN2_KNA";
            this.labelN2_KNA.Size = new System.Drawing.Size(40, 13);
            this.labelN2_KNA.TabIndex = 3;
            this.labelN2_KNA.Text = "До n2:";
            // 
            // labelK_KNA
            // 
            this.labelK_KNA.AutoSize = true;
            this.labelK_KNA.Location = new System.Drawing.Point(13, 32);
            this.labelK_KNA.Name = "labelK_KNA";
            this.labelK_KNA.Size = new System.Drawing.Size(32, 13);
            this.labelK_KNA.TabIndex = 3;
            this.labelK_KNA.Text = "От k:";
            // 
            // labelL_KNA
            // 
            this.labelL_KNA.AutoSize = true;
            this.labelL_KNA.Location = new System.Drawing.Point(10, 80);
            this.labelL_KNA.Name = "labelL_KNA";
            this.labelL_KNA.Size = new System.Drawing.Size(30, 13);
            this.labelL_KNA.TabIndex = 4;
            this.labelL_KNA.Text = "До l:";
            // 
            // labelRowR_KNA
            // 
            this.labelRowR_KNA.AutoSize = true;
            this.labelRowR_KNA.Location = new System.Drawing.Point(163, 32);
            this.labelRowR_KNA.Name = "labelRowR_KNA";
            this.labelRowR_KNA.Size = new System.Drawing.Size(98, 13);
            this.labelRowR_KNA.TabIndex = 5;
            this.labelRowR_KNA.Text = "Укажите строку r:";
            // 
            // dataGridViewMas_KNA
            // 
            this.dataGridViewMas_KNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMas_KNA.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewMas_KNA.Name = "dataGridViewMas_KNA";
            this.dataGridViewMas_KNA.Size = new System.Drawing.Size(438, 303);
            this.dataGridViewMas_KNA.TabIndex = 0;
            // 
            // groupBoxMult_KNA
            // 
            this.groupBoxMult_KNA.Controls.Add(this.textBoxResult_KNA);
            this.groupBoxMult_KNA.Location = new System.Drawing.Point(9, 309);
            this.groupBoxMult_KNA.Name = "groupBoxMult_KNA";
            this.groupBoxMult_KNA.Size = new System.Drawing.Size(420, 67);
            this.groupBoxMult_KNA.TabIndex = 1;
            this.groupBoxMult_KNA.TabStop = false;
            this.groupBoxMult_KNA.Text = "Произведение:";
            // 
            // textBoxResult_KNA
            // 
            this.textBoxResult_KNA.Location = new System.Drawing.Point(12, 28);
            this.textBoxResult_KNA.Name = "textBoxResult_KNA";
            this.textBoxResult_KNA.Size = new System.Drawing.Size(179, 20);
            this.textBoxResult_KNA.TabIndex = 0;
            // 
            // buttonResult_KNA
            // 
            this.buttonResult_KNA.BackColor = System.Drawing.Color.Green;
            this.buttonResult_KNA.Location = new System.Drawing.Point(17, 382);
            this.buttonResult_KNA.Name = "buttonResult_KNA";
            this.buttonResult_KNA.Size = new System.Drawing.Size(411, 53);
            this.buttonResult_KNA.TabIndex = 2;
            this.buttonResult_KNA.Text = "Выполнить";
            this.buttonResult_KNA.UseVisualStyleBackColor = false;
            this.buttonResult_KNA.Click += new System.EventHandler(this.buttonResult_KNA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitterTask_KNA);
            this.Controls.Add(this.panelRight_KNA);
            this.Controls.Add(this.panelLeft_KNA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelLeft_KNA.ResumeLayout(false);
            this.panelRight_KNA.ResumeLayout(false);
            this.groupBoxSize_KNA.ResumeLayout(false);
            this.groupBoxSize_KNA.PerformLayout();
            this.groupBoxDiap_KNA.ResumeLayout(false);
            this.groupBoxDiap_KNA.PerformLayout();
            this.groupBoxDannye_KNA.ResumeLayout(false);
            this.groupBoxDannye_KNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas_KNA)).EndInit();
            this.groupBoxMult_KNA.ResumeLayout(false);
            this.groupBoxMult_KNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_KNA;
        private System.Windows.Forms.GroupBox groupBoxDannye_KNA;
        private System.Windows.Forms.Label labelRowR_KNA;
        private System.Windows.Forms.Label labelL_KNA;
        private System.Windows.Forms.Label labelK_KNA;
        private System.Windows.Forms.TextBox textBoxR_KNA;
        private System.Windows.Forms.TextBox textBoxL_KNA;
        private System.Windows.Forms.TextBox textBoxK_KNA;
        private System.Windows.Forms.GroupBox groupBoxDiap_KNA;
        private System.Windows.Forms.Label labelN2_KNA;
        private System.Windows.Forms.Label labelN1_KNA;
        private System.Windows.Forms.TextBox textBoxN2_KNA;
        private System.Windows.Forms.TextBox textBoxN1_KNA;
        private System.Windows.Forms.GroupBox groupBoxSize_KNA;
        private System.Windows.Forms.Label labelColumns_KNA;
        private System.Windows.Forms.Label labelRows_KNA;
        private System.Windows.Forms.TextBox textBoxColumns_KNA;
        private System.Windows.Forms.TextBox textBoxRows_KNA;
        private System.Windows.Forms.Panel panelRight_KNA;
        private System.Windows.Forms.Button buttonResult_KNA;
        private System.Windows.Forms.GroupBox groupBoxMult_KNA;
        private System.Windows.Forms.TextBox textBoxResult_KNA;
        private System.Windows.Forms.DataGridView dataGridViewMas_KNA;
        private System.Windows.Forms.Splitter splitterTask_KNA;
    }
}

