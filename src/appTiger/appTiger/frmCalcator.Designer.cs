namespace appTiger
{
    partial class frmCalcator
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxExpression = new System.Windows.Forms.TextBox();
            this.labResult = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxExpression
            // 
            this.tbxExpression.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxExpression.Location = new System.Drawing.Point(13, 10);
            this.tbxExpression.Name = "tbxExpression";
            this.tbxExpression.Size = new System.Drawing.Size(215, 23);
            this.tbxExpression.TabIndex = 0;
            // 
            // labResult
            // 
            this.labResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labResult.Location = new System.Drawing.Point(71, 50);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(120, 21);
            this.labResult.TabIndex = 1;
            this.labResult.Text = "**********";
            this.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExec
            // 
            this.btnExec.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExec.Location = new System.Drawing.Point(143, 85);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(85, 28);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "計算";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // frmCalcator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.tbxExpression);
            this.Name = "frmCalcator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalcator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbxExpression;
        public System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label1;
    }
}

