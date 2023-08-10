namespace pocketMoney
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pocketMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocketmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocketMoneyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.schoolNumDataGridViewTextBoxColumn,
            this.pocketmoneyDataGridViewTextBoxColumn,
            this.useMoneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pocketMoneyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(583, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "모두보기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "학번 순으로 보기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(601, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 99);
            this.button3.TabIndex = 3;
            this.button3.Text = "용돈이 많은 사람부터 보기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(601, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 99);
            this.button4.TabIndex = 4;
            this.button4.Text = "쓴 돈이 많은 사람부터 보기";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pocketMoneyBindingSource
            // 
            this.pocketMoneyBindingSource.DataSource = typeof(pocketMoney.pocketMoney);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // schoolNumDataGridViewTextBoxColumn
            // 
            this.schoolNumDataGridViewTextBoxColumn.DataPropertyName = "schoolNum";
            this.schoolNumDataGridViewTextBoxColumn.HeaderText = "schoolNum";
            this.schoolNumDataGridViewTextBoxColumn.Name = "schoolNumDataGridViewTextBoxColumn";
            // 
            // pocketmoneyDataGridViewTextBoxColumn
            // 
            this.pocketmoneyDataGridViewTextBoxColumn.DataPropertyName = "pocketmoney";
            this.pocketmoneyDataGridViewTextBoxColumn.HeaderText = "pocketmoney";
            this.pocketmoneyDataGridViewTextBoxColumn.Name = "pocketmoneyDataGridViewTextBoxColumn";
            // 
            // useMoneyDataGridViewTextBoxColumn
            // 
            this.useMoneyDataGridViewTextBoxColumn.DataPropertyName = "useMoney";
            this.useMoneyDataGridViewTextBoxColumn.HeaderText = "useMoney";
            this.useMoneyDataGridViewTextBoxColumn.Name = "useMoneyDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "3212 임채영";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocketMoneyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocketmoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pocketMoneyBindingSource;
    }
}

