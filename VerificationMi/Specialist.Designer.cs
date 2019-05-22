namespace VerificationMi
{
    partial class Specialist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Specialist));
            this.verificationmiDataSet = new VerificationMi.verificationmiDataSet();
            this.specialstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialstTableAdapter = new VerificationMi.verificationmiDataSetTableAdapters.specialstTableAdapter();
            this.tableAdapterManager = new VerificationMi.verificationmiDataSetTableAdapters.TableAdapterManager();
            this.specialstBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specialstBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.specialstDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.статусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаПроверкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыСИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.verificationmiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialstBindingNavigator)).BeginInit();
            this.specialstBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialstDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // verificationmiDataSet
            // 
            this.verificationmiDataSet.DataSetName = "verificationmiDataSet";
            this.verificationmiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialstBindingSource
            // 
            this.specialstBindingSource.DataMember = "specialst";
            this.specialstBindingSource.DataSource = this.verificationmiDataSet;
            // 
            // specialstTableAdapter
            // 
            this.specialstTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.measuringinstrumentTableAdapter = null;
            this.tableAdapterManager.placeTableAdapter = null;
            this.tableAdapterManager.specialstTableAdapter = this.specialstTableAdapter;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.typeofmiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VerificationMi.verificationmiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // specialstBindingNavigator
            // 
            this.specialstBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specialstBindingNavigator.BindingSource = this.specialstBindingSource;
            this.specialstBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specialstBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specialstBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.specialstBindingNavigatorSaveItem});
            this.specialstBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.specialstBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specialstBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specialstBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specialstBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specialstBindingNavigator.Name = "specialstBindingNavigator";
            this.specialstBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specialstBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.specialstBindingNavigator.TabIndex = 4;
            this.specialstBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // specialstBindingNavigatorSaveItem
            // 
            this.specialstBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specialstBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specialstBindingNavigatorSaveItem.Image")));
            this.specialstBindingNavigatorSaveItem.Name = "specialstBindingNavigatorSaveItem";
            this.specialstBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.specialstBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.specialstBindingNavigatorSaveItem.Click += new System.EventHandler(this.specialstBindingNavigatorSaveItem_Click);
            // 
            // specialstDataGridView
            // 
            this.specialstDataGridView.AutoGenerateColumns = false;
            this.specialstDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.specialstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialstDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.specialstDataGridView.DataSource = this.specialstBindingSource;
            this.specialstDataGridView.Location = new System.Drawing.Point(0, 52);
            this.specialstDataGridView.Name = "specialstDataGridView";
            this.specialstDataGridView.Size = new System.Drawing.Size(800, 405);
            this.specialstDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "addres";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // хToolStripMenuItem
            // 
            this.хToolStripMenuItem.Name = "хToolStripMenuItem";
            this.хToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.хToolStripMenuItem.Text = "Выход";
            this.хToolStripMenuItem.Click += new System.EventHandler(this.хToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.хToolStripMenuItem,
            this.статусыToolStripMenuItem,
            this.местаПроверкиToolStripMenuItem,
            this.типыСИToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // статусыToolStripMenuItem
            // 
            this.статусыToolStripMenuItem.Name = "статусыToolStripMenuItem";
            this.статусыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.статусыToolStripMenuItem.Text = "Статусы СИ";
            this.статусыToolStripMenuItem.Click += new System.EventHandler(this.статусыToolStripMenuItem_Click);
            // 
            // местаПроверкиToolStripMenuItem
            // 
            this.местаПроверкиToolStripMenuItem.Name = "местаПроверкиToolStripMenuItem";
            this.местаПроверкиToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.местаПроверкиToolStripMenuItem.Text = "Места проверки СИ";
            this.местаПроверкиToolStripMenuItem.Click += new System.EventHandler(this.местаПроверкиToolStripMenuItem_Click);
            // 
            // типыСИToolStripMenuItem
            // 
            this.типыСИToolStripMenuItem.Name = "типыСИToolStripMenuItem";
            this.типыСИToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.типыСИToolStripMenuItem.Text = "Типы СИ";
            this.типыСИToolStripMenuItem.Click += new System.EventHandler(this.типыСИToolStripMenuItem_Click);
            // 
            // Specialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.specialstDataGridView);
            this.Controls.Add(this.specialstBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Specialist";
            this.Text = "Специалисты";
            this.Load += new System.EventHandler(this.Specialist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verificationmiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialstBindingNavigator)).EndInit();
            this.specialstBindingNavigator.ResumeLayout(false);
            this.specialstBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialstDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private verificationmiDataSet verificationmiDataSet;
        private System.Windows.Forms.BindingSource specialstBindingSource;
        private verificationmiDataSetTableAdapters.specialstTableAdapter specialstTableAdapter;
        private verificationmiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specialstBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton specialstBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView specialstDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem статусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаПроверкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыСИToolStripMenuItem;
    }
}