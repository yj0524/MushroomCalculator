namespace MyCalc
{
    partial class MyCalc
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCalc));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.bnt_Plus = new System.Windows.Forms.Button();
            this.bnt_Minus = new System.Windows.Forms.Button();
            this.bnt_Multiply = new System.Windows.Forms.Button();
            this.bnt_Divide = new System.Windows.Forms.Button();
            this.bnt_Equal = new System.Windows.Forms.Button();
            this.bnt_Point = new System.Windows.Forms.Button();
            this.bnt_0 = new System.Windows.Forms.Button();
            this.bnt_Negative = new System.Windows.Forms.Button();
            this.bnt_3 = new System.Windows.Forms.Button();
            this.bnt_2 = new System.Windows.Forms.Button();
            this.bnt_1 = new System.Windows.Forms.Button();
            this.bnt_6 = new System.Windows.Forms.Button();
            this.bnt_5 = new System.Windows.Forms.Button();
            this.bnt_4 = new System.Windows.Forms.Button();
            this.bnt_9 = new System.Windows.Forms.Button();
            this.bnt_8 = new System.Windows.Forms.Button();
            this.bnt_7 = new System.Windows.Forms.Button();
            this.bnt_Back = new System.Windows.Forms.Button();
            this.bnt_C = new System.Windows.Forms.Button();
            this.bnt_CE = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Result, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Plus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Minus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Multiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Divide, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Equal, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Point, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.bnt_0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Negative, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bnt_3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bnt_2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bnt_1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bnt_6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bnt_5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bnt_4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bnt_9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bnt_8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bnt_7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bnt_Back, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bnt_C, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bnt_CE, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Result, 4);
            this.txt_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Result.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Result.Location = new System.Drawing.Point(2, 2);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(689, 39);
            this.txt_Result.TabIndex = 0;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bnt_Plus
            // 
            this.bnt_Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Plus.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Plus.Location = new System.Drawing.Point(521, 45);
            this.bnt_Plus.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Plus.Name = "bnt_Plus";
            this.bnt_Plus.Size = new System.Drawing.Size(170, 81);
            this.bnt_Plus.TabIndex = 4;
            this.bnt_Plus.Text = "+";
            this.bnt_Plus.UseVisualStyleBackColor = true;
            this.bnt_Plus.Click += new System.EventHandler(this.bnt_Operation_Click);
            // 
            // bnt_Minus
            // 
            this.bnt_Minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Minus.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Minus.Location = new System.Drawing.Point(521, 130);
            this.bnt_Minus.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Minus.Name = "bnt_Minus";
            this.bnt_Minus.Size = new System.Drawing.Size(170, 81);
            this.bnt_Minus.TabIndex = 8;
            this.bnt_Minus.Text = "-";
            this.bnt_Minus.UseVisualStyleBackColor = true;
            this.bnt_Minus.Click += new System.EventHandler(this.bnt_Operation_Click);
            // 
            // bnt_Multiply
            // 
            this.bnt_Multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Multiply.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Multiply.Location = new System.Drawing.Point(521, 215);
            this.bnt_Multiply.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Multiply.Name = "bnt_Multiply";
            this.bnt_Multiply.Size = new System.Drawing.Size(170, 81);
            this.bnt_Multiply.TabIndex = 12;
            this.bnt_Multiply.Text = "*";
            this.bnt_Multiply.UseVisualStyleBackColor = true;
            this.bnt_Multiply.Click += new System.EventHandler(this.bnt_Operation_Click);
            // 
            // bnt_Divide
            // 
            this.bnt_Divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Divide.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Divide.Location = new System.Drawing.Point(521, 300);
            this.bnt_Divide.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Divide.Name = "bnt_Divide";
            this.bnt_Divide.Size = new System.Drawing.Size(170, 81);
            this.bnt_Divide.TabIndex = 13;
            this.bnt_Divide.Text = "/";
            this.bnt_Divide.UseVisualStyleBackColor = true;
            this.bnt_Divide.Click += new System.EventHandler(this.bnt_Operation_Click);
            // 
            // bnt_Equal
            // 
            this.bnt_Equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Equal.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Equal.Location = new System.Drawing.Point(521, 385);
            this.bnt_Equal.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Equal.Name = "bnt_Equal";
            this.bnt_Equal.Size = new System.Drawing.Size(170, 82);
            this.bnt_Equal.TabIndex = 17;
            this.bnt_Equal.Text = "=";
            this.bnt_Equal.UseVisualStyleBackColor = true;
            this.bnt_Equal.Click += new System.EventHandler(this.bnt_Equal_Click);
            // 
            // bnt_Point
            // 
            this.bnt_Point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Point.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Point.Location = new System.Drawing.Point(348, 385);
            this.bnt_Point.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Point.Name = "bnt_Point";
            this.bnt_Point.Size = new System.Drawing.Size(169, 82);
            this.bnt_Point.TabIndex = 15;
            this.bnt_Point.Text = ".";
            this.bnt_Point.UseVisualStyleBackColor = true;
            this.bnt_Point.Click += new System.EventHandler(this.bnt_Point_Click);
            // 
            // bnt_0
            // 
            this.bnt_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_0.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_0.Location = new System.Drawing.Point(175, 385);
            this.bnt_0.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_0.Name = "bnt_0";
            this.bnt_0.Size = new System.Drawing.Size(169, 82);
            this.bnt_0.TabIndex = 14;
            this.bnt_0.Text = "0";
            this.bnt_0.UseVisualStyleBackColor = true;
            this.bnt_0.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_Negative
            // 
            this.bnt_Negative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Negative.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Negative.Location = new System.Drawing.Point(2, 385);
            this.bnt_Negative.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Negative.Name = "bnt_Negative";
            this.bnt_Negative.Size = new System.Drawing.Size(169, 82);
            this.bnt_Negative.TabIndex = 16;
            this.bnt_Negative.Text = "±";
            this.bnt_Negative.UseVisualStyleBackColor = true;
            // 
            // bnt_3
            // 
            this.bnt_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_3.Location = new System.Drawing.Point(348, 300);
            this.bnt_3.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_3.Name = "bnt_3";
            this.bnt_3.Size = new System.Drawing.Size(169, 81);
            this.bnt_3.TabIndex = 11;
            this.bnt_3.Text = "3";
            this.bnt_3.UseVisualStyleBackColor = true;
            this.bnt_3.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_2
            // 
            this.bnt_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_2.Location = new System.Drawing.Point(175, 300);
            this.bnt_2.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_2.Name = "bnt_2";
            this.bnt_2.Size = new System.Drawing.Size(169, 81);
            this.bnt_2.TabIndex = 10;
            this.bnt_2.Text = "2";
            this.bnt_2.UseVisualStyleBackColor = true;
            this.bnt_2.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_1
            // 
            this.bnt_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_1.Location = new System.Drawing.Point(2, 300);
            this.bnt_1.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_1.Name = "bnt_1";
            this.bnt_1.Size = new System.Drawing.Size(169, 81);
            this.bnt_1.TabIndex = 9;
            this.bnt_1.Text = "1";
            this.bnt_1.UseVisualStyleBackColor = true;
            this.bnt_1.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_6
            // 
            this.bnt_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_6.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_6.Location = new System.Drawing.Point(348, 215);
            this.bnt_6.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_6.Name = "bnt_6";
            this.bnt_6.Size = new System.Drawing.Size(169, 81);
            this.bnt_6.TabIndex = 7;
            this.bnt_6.Text = "6";
            this.bnt_6.UseVisualStyleBackColor = true;
            this.bnt_6.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_5
            // 
            this.bnt_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_5.Location = new System.Drawing.Point(175, 215);
            this.bnt_5.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_5.Name = "bnt_5";
            this.bnt_5.Size = new System.Drawing.Size(169, 81);
            this.bnt_5.TabIndex = 6;
            this.bnt_5.Text = "5";
            this.bnt_5.UseVisualStyleBackColor = true;
            this.bnt_5.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_4
            // 
            this.bnt_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_4.Location = new System.Drawing.Point(2, 215);
            this.bnt_4.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_4.Name = "bnt_4";
            this.bnt_4.Size = new System.Drawing.Size(169, 81);
            this.bnt_4.TabIndex = 5;
            this.bnt_4.Text = "4";
            this.bnt_4.UseVisualStyleBackColor = true;
            this.bnt_4.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_9
            // 
            this.bnt_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_9.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_9.Location = new System.Drawing.Point(348, 130);
            this.bnt_9.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_9.Name = "bnt_9";
            this.bnt_9.Size = new System.Drawing.Size(169, 81);
            this.bnt_9.TabIndex = 3;
            this.bnt_9.Text = "9";
            this.bnt_9.UseVisualStyleBackColor = true;
            this.bnt_9.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_8
            // 
            this.bnt_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_8.Location = new System.Drawing.Point(175, 130);
            this.bnt_8.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_8.Name = "bnt_8";
            this.bnt_8.Size = new System.Drawing.Size(169, 81);
            this.bnt_8.TabIndex = 2;
            this.bnt_8.Text = "8";
            this.bnt_8.UseVisualStyleBackColor = true;
            this.bnt_8.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_7
            // 
            this.bnt_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_7.Location = new System.Drawing.Point(2, 130);
            this.bnt_7.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_7.Name = "bnt_7";
            this.bnt_7.Size = new System.Drawing.Size(169, 81);
            this.bnt_7.TabIndex = 1;
            this.bnt_7.Text = "7";
            this.bnt_7.UseVisualStyleBackColor = true;
            this.bnt_7.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // bnt_Back
            // 
            this.bnt_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_Back.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_Back.Location = new System.Drawing.Point(348, 45);
            this.bnt_Back.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Back.Name = "bnt_Back";
            this.bnt_Back.Size = new System.Drawing.Size(169, 81);
            this.bnt_Back.TabIndex = 18;
            this.bnt_Back.Text = "←";
            this.bnt_Back.UseVisualStyleBackColor = true;
            this.bnt_Back.Click += new System.EventHandler(this.bnt_Back_Click);
            // 
            // bnt_C
            // 
            this.bnt_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_C.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_C.Location = new System.Drawing.Point(175, 45);
            this.bnt_C.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_C.Name = "bnt_C";
            this.bnt_C.Size = new System.Drawing.Size(169, 81);
            this.bnt_C.TabIndex = 19;
            this.bnt_C.Text = "C";
            this.bnt_C.UseVisualStyleBackColor = true;
            this.bnt_C.Click += new System.EventHandler(this.bnt_C_Click);
            // 
            // bnt_CE
            // 
            this.bnt_CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnt_CE.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_CE.Location = new System.Drawing.Point(2, 45);
            this.bnt_CE.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_CE.Name = "bnt_CE";
            this.bnt_CE.Size = new System.Drawing.Size(169, 81);
            this.bnt_CE.TabIndex = 20;
            this.bnt_CE.Text = "CE";
            this.bnt_CE.UseVisualStyleBackColor = true;
            // 
            // MyCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyCalc";
            this.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Text = "Mushroom Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button bnt_7;
        private System.Windows.Forms.Button bnt_8;
        private System.Windows.Forms.Button bnt_9;
        private System.Windows.Forms.Button bnt_Plus;
        private System.Windows.Forms.Button bnt_4;
        private System.Windows.Forms.Button bnt_5;
        private System.Windows.Forms.Button bnt_6;
        private System.Windows.Forms.Button bnt_Minus;
        private System.Windows.Forms.Button bnt_1;
        private System.Windows.Forms.Button bnt_2;
        private System.Windows.Forms.Button bnt_3;
        private System.Windows.Forms.Button bnt_Multiply;
        private System.Windows.Forms.Button bnt_Divide;
        private System.Windows.Forms.Button bnt_Equal;
        private System.Windows.Forms.Button bnt_Point;
        private System.Windows.Forms.Button bnt_0;
        private System.Windows.Forms.Button bnt_Negative;
        private System.Windows.Forms.Button bnt_Back;
        private System.Windows.Forms.Button bnt_C;
        private System.Windows.Forms.Button bnt_CE;
    }
}

