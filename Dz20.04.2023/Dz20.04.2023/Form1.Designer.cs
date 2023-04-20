namespace Dz20._04._2023
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
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.procList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("KardinalPro ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(12, 536);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(206, 42);
            this.update.TabIndex = 1;
            this.update.Text = "Обновить процессы";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KardinalPro ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя процесса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KardinalPro ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(547, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "PID:";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("KardinalPro ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(553, 536);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(206, 42);
            this.close.TabIndex = 5;
            this.close.Text = "Закрыть процесс";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // procList
            // 
            this.procList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.procList.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.procList.HideSelection = false;
            this.procList.Location = new System.Drawing.Point(24, 42);
            this.procList.Name = "procList";
            this.procList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.procList.Size = new System.Drawing.Size(735, 488);
            this.procList.TabIndex = 6;
            this.procList.UseCompatibleStateImageBehavior = false;
            this.procList.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 590);
            this.Controls.Add(this.procList);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Name = "Form1";
            this.Text = "Диспетчер задач";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListView procList;
    }
}

