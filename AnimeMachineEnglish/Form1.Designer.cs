namespace AnimeMachineEnglish
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbx_HairFront = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpg_Basic = new System.Windows.Forms.TabPage();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_RemoveAccessory = new System.Windows.Forms.Button();
            this.btn_AddAccessory = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_HairBack = new System.Windows.Forms.ListBox();
            this.lbx_EquippedAccessories = new System.Windows.Forms.ListBox();
            this.lbx_Head = new System.Windows.Forms.ListBox();
            this.lbx_AccessList = new System.Windows.Forms.ListBox();
            this.lbx_Outfit = new System.Windows.Forms.ListBox();
            this.lbx_Face = new System.Windows.Forms.ListBox();
            this.lbx_Eyes = new System.Windows.Forms.ListBox();
            this.tpg_Color = new System.Windows.Forms.TabPage();
            this.tpg_Character = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.imbx_ImagePrimary = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd_SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpg_Basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbx_ImagePrimary)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_HairFront
            // 
            this.lbx_HairFront.FormattingEnabled = true;
            this.lbx_HairFront.Location = new System.Drawing.Point(19, 22);
            this.lbx_HairFront.Name = "lbx_HairFront";
            this.lbx_HairFront.Size = new System.Drawing.Size(120, 95);
            this.lbx_HairFront.TabIndex = 8;
            this.lbx_HairFront.SelectedIndexChanged += new System.EventHandler(this.lbx_HairFront_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpg_Basic);
            this.tabControl1.Controls.Add(this.tpg_Color);
            this.tabControl1.Controls.Add(this.tpg_Character);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 561);
            this.tabControl1.TabIndex = 16;
            // 
            // tpg_Basic
            // 
            this.tpg_Basic.Controls.Add(this.btn_Down);
            this.tpg_Basic.Controls.Add(this.btn_Up);
            this.tpg_Basic.Controls.Add(this.btn_RemoveAccessory);
            this.tpg_Basic.Controls.Add(this.btn_AddAccessory);
            this.tpg_Basic.Controls.Add(this.label9);
            this.tpg_Basic.Controls.Add(this.label8);
            this.tpg_Basic.Controls.Add(this.label7);
            this.tpg_Basic.Controls.Add(this.label6);
            this.tpg_Basic.Controls.Add(this.label5);
            this.tpg_Basic.Controls.Add(this.label4);
            this.tpg_Basic.Controls.Add(this.label3);
            this.tpg_Basic.Controls.Add(this.label2);
            this.tpg_Basic.Controls.Add(this.lbx_HairBack);
            this.tpg_Basic.Controls.Add(this.lbx_EquippedAccessories);
            this.tpg_Basic.Controls.Add(this.lbx_Head);
            this.tpg_Basic.Controls.Add(this.lbx_AccessList);
            this.tpg_Basic.Controls.Add(this.lbx_HairFront);
            this.tpg_Basic.Controls.Add(this.lbx_Outfit);
            this.tpg_Basic.Controls.Add(this.lbx_Face);
            this.tpg_Basic.Controls.Add(this.lbx_Eyes);
            this.tpg_Basic.Location = new System.Drawing.Point(4, 22);
            this.tpg_Basic.Name = "tpg_Basic";
            this.tpg_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_Basic.Size = new System.Drawing.Size(359, 535);
            this.tpg_Basic.TabIndex = 0;
            this.tpg_Basic.Text = "Basic Selection";
            this.tpg_Basic.UseVisualStyleBackColor = true;
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(311, 495);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(16, 23);
            this.btn_Down.TabIndex = 26;
            this.btn_Down.Text = "↓";
            this.btn_Down.UseVisualStyleBackColor = true;
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(289, 495);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(16, 23);
            this.btn_Up.TabIndex = 25;
            this.btn_Up.Text = "↑";
            this.btn_Up.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveAccessory
            // 
            this.btn_RemoveAccessory.Location = new System.Drawing.Point(164, 495);
            this.btn_RemoveAccessory.Name = "btn_RemoveAccessory";
            this.btn_RemoveAccessory.Size = new System.Drawing.Size(120, 23);
            this.btn_RemoveAccessory.TabIndex = 24;
            this.btn_RemoveAccessory.Text = "Remove Accessory";
            this.btn_RemoveAccessory.UseVisualStyleBackColor = true;
            // 
            // btn_AddAccessory
            // 
            this.btn_AddAccessory.Location = new System.Drawing.Point(19, 495);
            this.btn_AddAccessory.Name = "btn_AddAccessory";
            this.btn_AddAccessory.Size = new System.Drawing.Size(120, 23);
            this.btn_AddAccessory.TabIndex = 17;
            this.btn_AddAccessory.Text = "Add Accessory";
            this.btn_AddAccessory.UseVisualStyleBackColor = true;
            this.btn_AddAccessory.Click += new System.EventHandler(this.btn_AddAccessory_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Equipped Accessories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Accessory List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Outfit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Eyes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Face";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Head ( ͡° ͜ʖ ͡°)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hair Back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hair Front";
            // 
            // lbx_HairBack
            // 
            this.lbx_HairBack.FormattingEnabled = true;
            this.lbx_HairBack.Location = new System.Drawing.Point(164, 22);
            this.lbx_HairBack.Name = "lbx_HairBack";
            this.lbx_HairBack.Size = new System.Drawing.Size(120, 95);
            this.lbx_HairBack.TabIndex = 9;
            this.lbx_HairBack.SelectedIndexChanged += new System.EventHandler(this.lbx_HairBack_SelectedIndexChanged);
            // 
            // lbx_EquippedAccessories
            // 
            this.lbx_EquippedAccessories.FormattingEnabled = true;
            this.lbx_EquippedAccessories.Location = new System.Drawing.Point(164, 394);
            this.lbx_EquippedAccessories.Name = "lbx_EquippedAccessories";
            this.lbx_EquippedAccessories.Size = new System.Drawing.Size(120, 95);
            this.lbx_EquippedAccessories.TabIndex = 15;
            this.lbx_EquippedAccessories.SelectedIndexChanged += new System.EventHandler(this.lbx_EquippedAccessories_SelectedIndexChanged);
            // 
            // lbx_Head
            // 
            this.lbx_Head.FormattingEnabled = true;
            this.lbx_Head.Location = new System.Drawing.Point(19, 142);
            this.lbx_Head.Name = "lbx_Head";
            this.lbx_Head.Size = new System.Drawing.Size(120, 95);
            this.lbx_Head.TabIndex = 10;
            this.lbx_Head.SelectedIndexChanged += new System.EventHandler(this.lbx_Head_SelectedIndexChanged);
            // 
            // lbx_AccessList
            // 
            this.lbx_AccessList.FormattingEnabled = true;
            this.lbx_AccessList.Location = new System.Drawing.Point(19, 394);
            this.lbx_AccessList.Name = "lbx_AccessList";
            this.lbx_AccessList.Size = new System.Drawing.Size(120, 95);
            this.lbx_AccessList.TabIndex = 14;
            this.lbx_AccessList.SelectedIndexChanged += new System.EventHandler(this.lbx_AccessList_SelectedIndexChanged);
            // 
            // lbx_Outfit
            // 
            this.lbx_Outfit.FormattingEnabled = true;
            this.lbx_Outfit.Location = new System.Drawing.Point(164, 266);
            this.lbx_Outfit.Name = "lbx_Outfit";
            this.lbx_Outfit.Size = new System.Drawing.Size(120, 95);
            this.lbx_Outfit.TabIndex = 13;
            this.lbx_Outfit.SelectedIndexChanged += new System.EventHandler(this.lbx_Outfit_SelectedIndexChanged);
            // 
            // lbx_Face
            // 
            this.lbx_Face.FormattingEnabled = true;
            this.lbx_Face.Location = new System.Drawing.Point(164, 142);
            this.lbx_Face.Name = "lbx_Face";
            this.lbx_Face.Size = new System.Drawing.Size(120, 95);
            this.lbx_Face.TabIndex = 11;
            this.lbx_Face.SelectedIndexChanged += new System.EventHandler(this.lbx_Face_SelectedIndexChanged);
            // 
            // lbx_Eyes
            // 
            this.lbx_Eyes.FormattingEnabled = true;
            this.lbx_Eyes.Location = new System.Drawing.Point(19, 266);
            this.lbx_Eyes.Name = "lbx_Eyes";
            this.lbx_Eyes.Size = new System.Drawing.Size(120, 95);
            this.lbx_Eyes.TabIndex = 12;
            this.lbx_Eyes.SelectedIndexChanged += new System.EventHandler(this.lbx_Eyes_SelectedIndexChanged);
            // 
            // tpg_Color
            // 
            this.tpg_Color.Location = new System.Drawing.Point(4, 22);
            this.tpg_Color.Name = "tpg_Color";
            this.tpg_Color.Size = new System.Drawing.Size(359, 535);
            this.tpg_Color.TabIndex = 1;
            this.tpg_Color.Text = "Color Selection";
            this.tpg_Color.UseVisualStyleBackColor = true;
            // 
            // tpg_Character
            // 
            this.tpg_Character.Location = new System.Drawing.Point(4, 22);
            this.tpg_Character.Name = "tpg_Character";
            this.tpg_Character.Size = new System.Drawing.Size(359, 535);
            this.tpg_Character.TabIndex = 2;
            this.tpg_Character.Text = "Character Selection";
            this.tpg_Character.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(557, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Image";
            // 
            // imbx_ImagePrimary
            // 
            this.imbx_ImagePrimary.Location = new System.Drawing.Point(446, 91);
            this.imbx_ImagePrimary.Name = "imbx_ImagePrimary";
            this.imbx_ImagePrimary.Size = new System.Drawing.Size(303, 428);
            this.imbx_ImagePrimary.TabIndex = 2;
            this.imbx_ImagePrimary.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // sfd_SaveFile
            // 
            this.sfd_SaveFile.Filter = "Portable Network Graphics|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(789, 626);
            this.Controls.Add(this.imbx_ImagePrimary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Anime Engine Eks Dee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpg_Basic.ResumeLayout(false);
            this.tpg_Basic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbx_ImagePrimary)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbx_HairFront;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpg_Basic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx_HairBack;
        private System.Windows.Forms.ListBox lbx_EquippedAccessories;
        private System.Windows.Forms.ListBox lbx_Head;
        private System.Windows.Forms.ListBox lbx_AccessList;
        private System.Windows.Forms.ListBox lbx_Outfit;
        private System.Windows.Forms.ListBox lbx_Face;
        private System.Windows.Forms.ListBox lbx_Eyes;
        private System.Windows.Forms.TabPage tpg_Color;
        private System.Windows.Forms.TabPage tpg_Character;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_RemoveAccessory;
        private System.Windows.Forms.Button btn_AddAccessory;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Label label10;
        private Emgu.CV.UI.ImageBox imbx_ImagePrimary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd_SaveFile;
    }
}

