
namespace Lab04_Bessonova483_DB
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.pictureBoxScal = new System.Windows.Forms.PictureBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.comboBoxElement = new System.Windows.Forms.ComboBox();
            this.labelElem = new System.Windows.Forms.Label();
            this.textBoxNameEl = new System.Windows.Forms.TextBox();
            this.labelDataElem = new System.Windows.Forms.Label();
            this.textBoxnumEl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxWave = new System.Windows.Forms.ListBox();
            this.listBoxIntes = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Элементы:";
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow.Location = new System.Drawing.Point(316, 28);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(222, 34);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // pictureBoxScal
            // 
            this.pictureBoxScal.Location = new System.Drawing.Point(18, 92);
            this.pictureBoxScal.Name = "pictureBoxScal";
            this.pictureBoxScal.Size = new System.Drawing.Size(906, 63);
            this.pictureBoxScal.TabIndex = 7;
            this.pictureBoxScal.TabStop = false;
            this.pictureBoxScal.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxScal_Paint);
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImport.Location = new System.Drawing.Point(750, 12);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(183, 34);
            this.buttonImport.TabIndex = 10;
            this.buttonImport.Text = "Импорт данных";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // comboBoxElement
            // 
            this.comboBoxElement.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxElement.FormattingEnabled = true;
            this.comboBoxElement.Location = new System.Drawing.Point(127, 32);
            this.comboBoxElement.Name = "comboBoxElement";
            this.comboBoxElement.Size = new System.Drawing.Size(183, 29);
            this.comboBoxElement.TabIndex = 11;
            // 
            // labelElem
            // 
            this.labelElem.AutoSize = true;
            this.labelElem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelElem.Location = new System.Drawing.Point(18, 180);
            this.labelElem.Name = "labelElem";
            this.labelElem.Size = new System.Drawing.Size(160, 21);
            this.labelElem.TabIndex = 12;
            this.labelElem.Text = "Название элемента";
            // 
            // textBoxNameEl
            // 
            this.textBoxNameEl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameEl.Location = new System.Drawing.Point(185, 180);
            this.textBoxNameEl.Name = "textBoxNameEl";
            this.textBoxNameEl.ReadOnly = true;
            this.textBoxNameEl.Size = new System.Drawing.Size(163, 29);
            this.textBoxNameEl.TabIndex = 13;
            // 
            // labelDataElem
            // 
            this.labelDataElem.AutoSize = true;
            this.labelDataElem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataElem.Location = new System.Drawing.Point(457, 183);
            this.labelDataElem.Name = "labelDataElem";
            this.labelDataElem.Size = new System.Drawing.Size(163, 21);
            this.labelDataElem.TabIndex = 14;
            this.labelDataElem.Text = "Данные о элементе";
            // 
            // textBoxnumEl
            // 
            this.textBoxnumEl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxnumEl.Location = new System.Drawing.Point(185, 233);
            this.textBoxnumEl.Name = "textBoxnumEl";
            this.textBoxnumEl.ReadOnly = true;
            this.textBoxnumEl.Size = new System.Drawing.Size(163, 29);
            this.textBoxnumEl.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Номер элемента";
            // 
            // listBoxWave
            // 
            this.listBoxWave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWave.FormattingEnabled = true;
            this.listBoxWave.ItemHeight = 21;
            this.listBoxWave.Location = new System.Drawing.Point(626, 183);
            this.listBoxWave.Name = "listBoxWave";
            this.listBoxWave.Size = new System.Drawing.Size(133, 256);
            this.listBoxWave.TabIndex = 19;
            // 
            // listBoxIntes
            // 
            this.listBoxIntes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxIntes.FormattingEnabled = true;
            this.listBoxIntes.ItemHeight = 21;
            this.listBoxIntes.Location = new System.Drawing.Point(765, 183);
            this.listBoxIntes.Name = "listBoxIntes";
            this.listBoxIntes.Size = new System.Drawing.Size(133, 256);
            this.listBoxIntes.TabIndex = 20;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(17, 420);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(140, 34);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 466);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxIntes);
            this.Controls.Add(this.listBoxWave);
            this.Controls.Add(this.textBoxnumEl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDataElem);
            this.Controls.Add(this.textBoxNameEl);
            this.Controls.Add(this.labelElem);
            this.Controls.Add(this.comboBoxElement);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.pictureBoxScal);
            this.Name = "FormMain";
            this.Text = "Bessonova 483 - Database";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.PictureBox pictureBoxScal;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ComboBox comboBoxElement;
        private System.Windows.Forms.Label labelElem;
        private System.Windows.Forms.TextBox textBoxNameEl;
        private System.Windows.Forms.Label labelDataElem;
        private System.Windows.Forms.TextBox textBoxnumEl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxWave;
        private System.Windows.Forms.ListBox listBoxIntes;
        private System.Windows.Forms.Button buttonClear;
    }
}

