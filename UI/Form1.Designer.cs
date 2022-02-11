namespace WinFormsAppSQLITE
{
    partial class FrmTodo
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTAF = new System.Windows.Forms.Label();
            this.TodoDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Echeance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxTask = new System.Windows.Forms.TextBox();
            this.dateTimePickerEcheance = new System.Windows.Forms.DateTimePicker();
            this.lblEcheance = new System.Windows.Forms.Label();
            this.lblTache = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodoDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblTAF);
            this.panel1.Controls.Add(this.TodoDataGridView);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 668);
            this.panel1.TabIndex = 0;
            // 
            // lblTAF
            // 
            this.lblTAF.AutoSize = true;
            this.lblTAF.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTAF.Location = new System.Drawing.Point(12, 275);
            this.lblTAF.Name = "lblTAF";
            this.lblTAF.Size = new System.Drawing.Size(121, 24);
            this.lblTAF.TabIndex = 3;
            this.lblTAF.Text = "Todo à faire :";
            // 
            // TodoDataGridView
            // 
            this.TodoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TodoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Task,
            this.Echeance,
            this.Desc});
            this.TodoDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.TodoDataGridView.Location = new System.Drawing.Point(16, 309);
            this.TodoDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TodoDataGridView.Name = "TodoDataGridView";
            this.TodoDataGridView.RowHeadersWidth = 51;
            this.TodoDataGridView.RowTemplate.Height = 24;
            this.TodoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TodoDataGridView.Size = new System.Drawing.Size(1157, 329);
            this.TodoDataGridView.TabIndex = 2;
            this.TodoDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TodoDataGridView_RowHeaderMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Task
            // 
            this.Task.HeaderText = "Tâche";
            this.Task.MinimumWidth = 6;
            this.Task.Name = "Task";
            // 
            // Echeance
            // 
            this.Echeance.HeaderText = "Echéance";
            this.Echeance.MinimumWidth = 6;
            this.Echeance.Name = "Echeance";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.18328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.08039F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.80386F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxTask, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerEcheance, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEcheance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTache, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDesc, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDesc, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 271);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(494, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ma Todolist";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(925, 79);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxTask
            // 
            this.txtBoxTask.Location = new System.Drawing.Point(303, 79);
            this.txtBoxTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTask.Name = "txtBoxTask";
            this.txtBoxTask.Size = new System.Drawing.Size(583, 27);
            this.txtBoxTask.TabIndex = 2;
            // 
            // dateTimePickerEcheance
            // 
            this.dateTimePickerEcheance.Location = new System.Drawing.Point(303, 123);
            this.dateTimePickerEcheance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerEcheance.Name = "dateTimePickerEcheance";
            this.dateTimePickerEcheance.Size = new System.Drawing.Size(229, 27);
            this.dateTimePickerEcheance.TabIndex = 4;
            // 
            // lblEcheance
            // 
            this.lblEcheance.AutoSize = true;
            this.lblEcheance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEcheance.Location = new System.Drawing.Point(140, 124);
            this.lblEcheance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblEcheance.Name = "lblEcheance";
            this.lblEcheance.Size = new System.Drawing.Size(96, 24);
            this.lblEcheance.TabIndex = 3;
            this.lblEcheance.Text = "Échéance :";
            // 
            // lblTache
            // 
            this.lblTache.AutoSize = true;
            this.lblTache.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTache.Location = new System.Drawing.Point(140, 80);
            this.lblTache.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTache.Name = "lblTache";
            this.lblTache.Size = new System.Drawing.Size(69, 24);
            this.lblTache.TabIndex = 1;
            this.lblTache.Text = "Tâche :";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(303, 167);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(583, 100);
            this.textBoxDesc.TabIndex = 6;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(140, 168);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(114, 24);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Description :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // FrmTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 698);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.FrmTodo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodoDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTache;
        private System.Windows.Forms.TextBox txtBoxTask;
        private System.Windows.Forms.Label lblEcheance;
        private System.Windows.Forms.DateTimePicker dateTimePickerEcheance;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label lblTAF;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Echeance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        public System.Windows.Forms.DataGridView TodoDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;

        //#endregion
    }
}
