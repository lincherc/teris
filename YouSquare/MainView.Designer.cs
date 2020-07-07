namespace YouSquare
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.mainContainer = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单人游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.双人游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreCanvas = new System.Windows.Forms.PictureBox();
            this.labelCurrentScore = new System.Windows.Forms.Label();
            this.labelCurrentLevel = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.nextPreviewContainer = new System.Windows.Forms.PictureBox();
            this.labelNext = new System.Windows.Forms.Label();
            this.subContainer = new System.Windows.Forms.PictureBox();
            this.subnextpreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subscoreCanvas = new System.Windows.Forms.PictureBox();
            this.sublabelLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Remove1 = new System.Windows.Forms.Label();
            this.Remove2 = new System.Windows.Forms.Label();
            this.Change1 = new System.Windows.Forms.Label();
            this.Change2 = new System.Windows.Forms.Label();
            this.Grow = new System.Windows.Forms.Label();
            this.Grow2 = new System.Windows.Forms.Label();
            this.RemoveC1 = new System.Windows.Forms.Label();
            this.ChangeC1 = new System.Windows.Forms.Label();
            this.GrowC1 = new System.Windows.Forms.Label();
            this.RemoveC2 = new System.Windows.Forms.Label();
            this.GrowC2 = new System.Windows.Forms.Label();
            this.ChangeC2 = new System.Windows.Forms.Label();
            this.GameStatu1 = new System.Windows.Forms.Label();
            this.GameStatu2 = new System.Windows.Forms.Label();
            this.GameStatu0 = new System.Windows.Forms.Label();
            this.Pause1 = new System.Windows.Forms.Label();
            this.Pause2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.mainContainer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.scoreCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nextPreviewContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.subContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.subnextpreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.subscoreCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainContainer.Image = ((System.Drawing.Image) (resources.GetObject("mainContainer.Image")));
            this.mainContainer.Location = new System.Drawing.Point(36, 54);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(400, 625);
            this.mainContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainContainer.TabIndex = 0;
            this.mainContainer.TabStop = false;
            this.mainContainer.Click += new System.EventHandler(this.mainContainer_Click);
            this.mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.开始游戏ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始游戏ToolStripMenuItem
            // 
            this.开始游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.单人游戏ToolStripMenuItem, this.双人游戏ToolStripMenuItem});
            this.开始游戏ToolStripMenuItem.Name = "开始游戏ToolStripMenuItem";
            this.开始游戏ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.开始游戏ToolStripMenuItem.Text = "开始新游戏";
            // 
            // 单人游戏ToolStripMenuItem
            // 
            this.单人游戏ToolStripMenuItem.Name = "单人游戏ToolStripMenuItem";
            this.单人游戏ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.单人游戏ToolStripMenuItem.Text = "单打";
            this.单人游戏ToolStripMenuItem.Click += new System.EventHandler(this.单人游戏ToolStripMenuItem_Click);
            // 
            // 双人游戏ToolStripMenuItem
            // 
            this.双人游戏ToolStripMenuItem.Name = "双人游戏ToolStripMenuItem";
            this.双人游戏ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.双人游戏ToolStripMenuItem.Text = "双打";
            this.双人游戏ToolStripMenuItem.Click += new System.EventHandler(this.双人游戏ToolStripMenuItem_Click);
            // 
            // scoreCanvas
            // 
            this.scoreCanvas.BackColor = System.Drawing.Color.Black;
            this.scoreCanvas.Location = new System.Drawing.Point(483, 285);
            this.scoreCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreCanvas.Name = "scoreCanvas";
            this.scoreCanvas.Size = new System.Drawing.Size(140, 90);
            this.scoreCanvas.TabIndex = 2;
            this.scoreCanvas.TabStop = false;
            // 
            // labelCurrentScore
            // 
            this.labelCurrentScore.AutoSize = true;
            this.labelCurrentScore.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelCurrentScore.Location = new System.Drawing.Point(497, 246);
            this.labelCurrentScore.Name = "labelCurrentScore";
            this.labelCurrentScore.Size = new System.Drawing.Size(85, 24);
            this.labelCurrentScore.TabIndex = 3;
            this.labelCurrentScore.Text = "得分：";
            // 
            // labelCurrentLevel
            // 
            this.labelCurrentLevel.AutoSize = true;
            this.labelCurrentLevel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelCurrentLevel.Location = new System.Drawing.Point(497, 389);
            this.labelCurrentLevel.Name = "labelCurrentLevel";
            this.labelCurrentLevel.Size = new System.Drawing.Size(85, 24);
            this.labelCurrentLevel.TabIndex = 4;
            this.labelCurrentLevel.Text = "等级：";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Black;
            this.labelLevel.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.labelLevel.ForeColor = System.Drawing.Color.Red;
            this.labelLevel.Location = new System.Drawing.Point(523, 432);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(38, 40);
            this.labelLevel.TabIndex = 5;
            this.labelLevel.Text = "0";
            this.labelLevel.Click += new System.EventHandler(this.labelLevel_Click);
            // 
            // nextPreviewContainer
            // 
            this.nextPreviewContainer.BackColor = System.Drawing.Color.Black;
            this.nextPreviewContainer.Location = new System.Drawing.Point(483, 108);
            this.nextPreviewContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextPreviewContainer.Name = "nextPreviewContainer";
            this.nextPreviewContainer.Size = new System.Drawing.Size(140, 135);
            this.nextPreviewContainer.TabIndex = 8;
            this.nextPreviewContainer.TabStop = false;
            this.nextPreviewContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.nextPreviewContainer_Paint);
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelNext.Location = new System.Drawing.Point(483, 69);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(110, 24);
            this.labelNext.TabIndex = 9;
            this.labelNext.Text = "预测方块";
            // 
            // subContainer
            // 
            this.subContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subContainer.Image = ((System.Drawing.Image) (resources.GetObject("subContainer.Image")));
            this.subContainer.Location = new System.Drawing.Point(837, 54);
            this.subContainer.Margin = new System.Windows.Forms.Padding(4);
            this.subContainer.Name = "subContainer";
            this.subContainer.Size = new System.Drawing.Size(400, 625);
            this.subContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.subContainer.TabIndex = 0;
            this.subContainer.TabStop = false;
            this.subContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.subContainer_Paint);
            // 
            // subnextpreview
            // 
            this.subnextpreview.BackColor = System.Drawing.Color.Black;
            this.subnextpreview.Location = new System.Drawing.Point(656, 108);
            this.subnextpreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subnextpreview.Name = "subnextpreview";
            this.subnextpreview.Size = new System.Drawing.Size(140, 135);
            this.subnextpreview.TabIndex = 8;
            this.subnextpreview.TabStop = false;
            this.subnextpreview.Paint += new System.Windows.Forms.PaintEventHandler(this.subnextpreview_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(656, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "预测方块";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(665, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "得分：";
            // 
            // subscoreCanvas
            // 
            this.subscoreCanvas.BackColor = System.Drawing.Color.Black;
            this.subscoreCanvas.Location = new System.Drawing.Point(656, 285);
            this.subscoreCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subscoreCanvas.Name = "subscoreCanvas";
            this.subscoreCanvas.Size = new System.Drawing.Size(140, 90);
            this.subscoreCanvas.TabIndex = 2;
            this.subscoreCanvas.TabStop = false;
            // 
            // sublabelLevel
            // 
            this.sublabelLevel.AutoSize = true;
            this.sublabelLevel.BackColor = System.Drawing.Color.Black;
            this.sublabelLevel.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.sublabelLevel.ForeColor = System.Drawing.Color.Red;
            this.sublabelLevel.Location = new System.Drawing.Point(707, 432);
            this.sublabelLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sublabelLevel.Name = "sublabelLevel";
            this.sublabelLevel.Size = new System.Drawing.Size(38, 40);
            this.sublabelLevel.TabIndex = 5;
            this.sublabelLevel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(665, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "等级：";
            // 
            // Remove1
            // 
            this.Remove1.AutoSize = true;
            this.Remove1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Remove1.Location = new System.Drawing.Point(497, 524);
            this.Remove1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Remove1.Name = "Remove1";
            this.Remove1.Size = new System.Drawing.Size(123, 24);
            this.Remove1.TabIndex = 10;
            this.Remove1.Text = "消除一行E";
            // 
            // Remove2
            // 
            this.Remove2.AutoSize = true;
            this.Remove2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Remove2.Location = new System.Drawing.Point(663, 524);
            this.Remove2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Remove2.Name = "Remove2";
            this.Remove2.Size = new System.Drawing.Size(123, 24);
            this.Remove2.TabIndex = 10;
            this.Remove2.Text = "消除一行M";
            // 
            // Change1
            // 
            this.Change1.AutoSize = true;
            this.Change1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Change1.Location = new System.Drawing.Point(497, 568);
            this.Change1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Change1.Name = "Change1";
            this.Change1.Size = new System.Drawing.Size(123, 24);
            this.Change1.TabIndex = 10;
            this.Change1.Text = "更改方块R";
            this.Change1.Click += new System.EventHandler(this.Change1_Click);
            // 
            // Change2
            // 
            this.Change2.AutoSize = true;
            this.Change2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Change2.Location = new System.Drawing.Point(663, 568);
            this.Change2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Change2.Name = "Change2";
            this.Change2.Size = new System.Drawing.Size(123, 24);
            this.Change2.TabIndex = 10;
            this.Change2.Text = "更改方块N";
            // 
            // Grow
            // 
            this.Grow.AutoSize = true;
            this.Grow.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Grow.Location = new System.Drawing.Point(497, 616);
            this.Grow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grow.Name = "Grow";
            this.Grow.Size = new System.Drawing.Size(123, 24);
            this.Grow.TabIndex = 10;
            this.Grow.Text = "暴击对手T";
            // 
            // Grow2
            // 
            this.Grow2.AutoSize = true;
            this.Grow2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Grow2.Location = new System.Drawing.Point(663, 616);
            this.Grow2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grow2.Name = "Grow2";
            this.Grow2.Size = new System.Drawing.Size(123, 24);
            this.Grow2.TabIndex = 10;
            this.Grow2.Text = "暴击对手B";
            // 
            // RemoveC1
            // 
            this.RemoveC1.AutoSize = true;
            this.RemoveC1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RemoveC1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.RemoveC1.Location = new System.Drawing.Point(444, 528);
            this.RemoveC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemoveC1.Name = "RemoveC1";
            this.RemoveC1.Size = new System.Drawing.Size(20, 20);
            this.RemoveC1.TabIndex = 11;
            this.RemoveC1.Text = "0";
            // 
            // ChangeC1
            // 
            this.ChangeC1.AutoSize = true;
            this.ChangeC1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ChangeC1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.ChangeC1.Location = new System.Drawing.Point(444, 568);
            this.ChangeC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeC1.Name = "ChangeC1";
            this.ChangeC1.Size = new System.Drawing.Size(20, 20);
            this.ChangeC1.TabIndex = 11;
            this.ChangeC1.Text = "0";
            // 
            // GrowC1
            // 
            this.GrowC1.AutoSize = true;
            this.GrowC1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.GrowC1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.GrowC1.Location = new System.Drawing.Point(444, 612);
            this.GrowC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrowC1.Name = "GrowC1";
            this.GrowC1.Size = new System.Drawing.Size(20, 20);
            this.GrowC1.TabIndex = 11;
            this.GrowC1.Text = "0";
            // 
            // RemoveC2
            // 
            this.RemoveC2.AutoSize = true;
            this.RemoveC2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RemoveC2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.RemoveC2.Location = new System.Drawing.Point(809, 528);
            this.RemoveC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemoveC2.Name = "RemoveC2";
            this.RemoveC2.Size = new System.Drawing.Size(20, 20);
            this.RemoveC2.TabIndex = 11;
            this.RemoveC2.Text = "0";
            // 
            // GrowC2
            // 
            this.GrowC2.AutoSize = true;
            this.GrowC2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.GrowC2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.GrowC2.Location = new System.Drawing.Point(809, 616);
            this.GrowC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrowC2.Name = "GrowC2";
            this.GrowC2.Size = new System.Drawing.Size(20, 20);
            this.GrowC2.TabIndex = 11;
            this.GrowC2.Text = "0";
            // 
            // ChangeC2
            // 
            this.ChangeC2.AutoSize = true;
            this.ChangeC2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ChangeC2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.ChangeC2.Location = new System.Drawing.Point(809, 572);
            this.ChangeC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeC2.Name = "ChangeC2";
            this.ChangeC2.Size = new System.Drawing.Size(20, 20);
            this.ChangeC2.TabIndex = 11;
            this.ChangeC2.Text = "0";
            // 
            // GameStatu1
            // 
            this.GameStatu1.AutoSize = true;
            this.GameStatu1.BackColor = System.Drawing.Color.Black;
            this.GameStatu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.GameStatu1.ForeColor = System.Drawing.Color.Red;
            this.GameStatu1.Location = new System.Drawing.Point(107, 108);
            this.GameStatu1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameStatu1.Name = "GameStatu1";
            this.GameStatu1.Size = new System.Drawing.Size(248, 52);
            this.GameStatu1.TabIndex = 12;
            this.GameStatu1.Text = "你胜利了！";
            this.GameStatu1.Click += new System.EventHandler(this.GameStatu1_Click);
            // 
            // GameStatu2
            // 
            this.GameStatu2.AutoSize = true;
            this.GameStatu2.BackColor = System.Drawing.Color.Black;
            this.GameStatu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.GameStatu2.ForeColor = System.Drawing.Color.Red;
            this.GameStatu2.Location = new System.Drawing.Point(930, 108);
            this.GameStatu2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameStatu2.Name = "GameStatu2";
            this.GameStatu2.Size = new System.Drawing.Size(248, 52);
            this.GameStatu2.TabIndex = 12;
            this.GameStatu2.Text = "你胜利了！";
            // 
            // GameStatu0
            // 
            this.GameStatu0.AutoSize = true;
            this.GameStatu0.BackColor = System.Drawing.Color.Black;
            this.GameStatu0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.GameStatu0.ForeColor = System.Drawing.Color.Red;
            this.GameStatu0.Location = new System.Drawing.Point(518, 9);
            this.GameStatu0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameStatu0.Name = "GameStatu0";
            this.GameStatu0.Size = new System.Drawing.Size(248, 52);
            this.GameStatu0.TabIndex = 12;
            this.GameStatu0.Text = "保护伞公司";
            this.GameStatu0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pause1
            // 
            this.Pause1.AutoSize = true;
            this.Pause1.BackColor = System.Drawing.Color.White;
            this.Pause1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Pause1.ForeColor = System.Drawing.Color.Red;
            this.Pause1.Location = new System.Drawing.Point(177, 351);
            this.Pause1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pause1.Name = "Pause1";
            this.Pause1.Size = new System.Drawing.Size(106, 24);
            this.Pause1.TabIndex = 13;
            this.Pause1.Text = "游戏暂停";
            // 
            // Pause2
            // 
            this.Pause2.AutoSize = true;
            this.Pause2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Pause2.ForeColor = System.Drawing.Color.Red;
            this.Pause2.Location = new System.Drawing.Point(979, 351);
            this.Pause2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pause2.Name = "Pause2";
            this.Pause2.Size = new System.Drawing.Size(106, 24);
            this.Pause2.TabIndex = 13;
            this.Pause2.Text = "游戏暂停";
            this.Pause2.Click += new System.EventHandler(this.Pause2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(467, 655);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "按空格暂停";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 694);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pause2);
            this.Controls.Add(this.Pause1);
            this.Controls.Add(this.GameStatu2);
            this.Controls.Add(this.GameStatu0);
            this.Controls.Add(this.GameStatu1);
            this.Controls.Add(this.GrowC1);
            this.Controls.Add(this.ChangeC1);
            this.Controls.Add(this.ChangeC2);
            this.Controls.Add(this.GrowC2);
            this.Controls.Add(this.RemoveC2);
            this.Controls.Add(this.RemoveC1);
            this.Controls.Add(this.Remove2);
            this.Controls.Add(this.Change2);
            this.Controls.Add(this.Grow2);
            this.Controls.Add(this.Grow);
            this.Controls.Add(this.Change1);
            this.Controls.Add(this.Remove1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.subnextpreview);
            this.Controls.Add(this.nextPreviewContainer);
            this.Controls.Add(this.sublabelLevel);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCurrentLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCurrentScore);
            this.Controls.Add(this.subscoreCanvas);
            this.Controls.Add(this.scoreCanvas);
            this.Controls.Add(this.subContainer);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.Text = "保护伞方块";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainView_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.mainContainer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.scoreCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nextPreviewContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.subContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.subnextpreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.subscoreCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label Change1;
        private System.Windows.Forms.Label Change2;
        private System.Windows.Forms.Label ChangeC1;
        private System.Windows.Forms.Label ChangeC2;
        private System.Windows.Forms.Label GameStatu0;
        private System.Windows.Forms.Label GameStatu1;
        private System.Windows.Forms.Label GameStatu2;
        private System.Windows.Forms.Label Grow;
        private System.Windows.Forms.Label Grow2;
        private System.Windows.Forms.Label GrowC1;
        private System.Windows.Forms.Label GrowC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentLevel;
        private System.Windows.Forms.Label labelCurrentScore;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.PictureBox mainContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox nextPreviewContainer;
        private System.Windows.Forms.Label Pause1;
        private System.Windows.Forms.Label Pause2;
        private System.Windows.Forms.Label Remove1;
        private System.Windows.Forms.Label Remove2;
        private System.Windows.Forms.Label RemoveC1;
        private System.Windows.Forms.Label RemoveC2;
        private System.Windows.Forms.PictureBox scoreCanvas;
        private System.Windows.Forms.PictureBox subContainer;
        private System.Windows.Forms.Label sublabelLevel;
        private System.Windows.Forms.PictureBox subnextpreview;
        private System.Windows.Forms.PictureBox subscoreCanvas;
        private System.Windows.Forms.ToolStripMenuItem 单人游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 双人游戏ToolStripMenuItem;

        #endregion
    }
}