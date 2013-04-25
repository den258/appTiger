namespace appTiger
{
    partial class frmTest
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
            this.btnExecTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecTest
            // 
            this.btnExecTest.Location = new System.Drawing.Point(69, 12);
            this.btnExecTest.Name = "btnExecTest";
            this.btnExecTest.Size = new System.Drawing.Size(154, 42);
            this.btnExecTest.TabIndex = 0;
            this.btnExecTest.Text = "ExecTest";
            this.btnExecTest.UseVisualStyleBackColor = true;
            this.btnExecTest.Click += new System.EventHandler(this.btnExecTest_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 68);
            this.Controls.Add(this.btnExecTest);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecTest;
    }
}