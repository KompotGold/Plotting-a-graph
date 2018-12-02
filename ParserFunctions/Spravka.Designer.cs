namespace ParserFunctions
{
    partial class Spravka
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Сложение");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Вычитание");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Произведение");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Деление");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Простые математические операции", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("cos");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("sin");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("tn");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ctn");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Тригонометрия", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Логарифмы с основанием");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Натуральный логарифм");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Логарифмы", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Корень");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Экспонента");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Число Pi");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Другие операции", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Сложение";
            treeNode2.Name = "Узел9";
            treeNode2.Text = "Вычитание";
            treeNode3.Name = "Узел10";
            treeNode3.Text = "Произведение";
            treeNode4.Name = "Узел11";
            treeNode4.Text = "Деление";
            treeNode5.Name = "Узел0";
            treeNode5.Text = "Простые математические операции";
            treeNode6.Name = "Узел14";
            treeNode6.Text = "cos";
            treeNode7.Name = "Узел15";
            treeNode7.Text = "sin";
            treeNode8.Name = "Узел16";
            treeNode8.Text = "tn";
            treeNode9.Name = "Узел17";
            treeNode9.Text = "ctn";
            treeNode10.Name = "Узел1";
            treeNode10.Text = "Тригонометрия";
            treeNode11.Name = "Узел18";
            treeNode11.Text = "Логарифмы с основанием";
            treeNode12.Name = "Узел19";
            treeNode12.Text = "Натуральный логарифм";
            treeNode13.Name = "Узел2";
            treeNode13.Text = "Логарифмы";
            treeNode14.Name = "Узел13";
            treeNode14.Text = "Корень";
            treeNode15.Name = "Узел0";
            treeNode15.Text = "Экспонента";
            treeNode16.Name = "Узел1";
            treeNode16.Text = "Число Pi";
            treeNode17.Name = "Узел12";
            treeNode17.Text = "Другие операции";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode13,
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(284, 367);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Spravka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Spravka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spravka";
            this.Load += new System.EventHandler(this.Spravka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}