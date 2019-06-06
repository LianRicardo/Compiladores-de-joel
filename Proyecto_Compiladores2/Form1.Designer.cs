namespace Proyecto_Compiladores2
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.compiññToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.compileProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveTokensAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveSymbolsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aiuuuudaaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.simbols = new System.Windows.Forms.DataGridView();
      this.output = new System.Windows.Forms.TextBox();
      this.datatoken = new System.Windows.Forms.DataGridView();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txt = new System.Windows.Forms.TextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ventana2 = new System.Windows.Forms.OpenFileDialog();
      this.ventana = new System.Windows.Forms.SaveFileDialog();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.simbols)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.datatoken)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.compiññToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1341, 24);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.saveAsToolStripMenuItem.Text = "Save as";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // compiññToolStripMenuItem
      // 
      this.compiññToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileProgramToolStripMenuItem,
            this.saveTokensAsToolStripMenuItem,
            this.saveSymbolsAsToolStripMenuItem});
      this.compiññToolStripMenuItem.Name = "compiññToolStripMenuItem";
      this.compiññToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
      this.compiññToolStripMenuItem.Text = "Compile";
      // 
      // compileProgramToolStripMenuItem
      // 
      this.compileProgramToolStripMenuItem.Name = "compileProgramToolStripMenuItem";
      this.compileProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.compileProgramToolStripMenuItem.Text = "Compile Program";
      this.compileProgramToolStripMenuItem.Click += new System.EventHandler(this.CompileProgramToolStripMenuItem_Click);
      // 
      // saveTokensAsToolStripMenuItem
      // 
      this.saveTokensAsToolStripMenuItem.Name = "saveTokensAsToolStripMenuItem";
      this.saveTokensAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.saveTokensAsToolStripMenuItem.Text = "Save Tokens as";
      this.saveTokensAsToolStripMenuItem.Click += new System.EventHandler(this.SaveTokensAsToolStripMenuItem_Click);
      // 
      // saveSymbolsAsToolStripMenuItem
      // 
      this.saveSymbolsAsToolStripMenuItem.Name = "saveSymbolsAsToolStripMenuItem";
      this.saveSymbolsAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.saveSymbolsAsToolStripMenuItem.Text = "Save Symbols as";
      this.saveSymbolsAsToolStripMenuItem.Click += new System.EventHandler(this.SaveSymbolsAsToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aiuuuudaaaaToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aiuuuudaaaaToolStripMenuItem
      // 
      this.aiuuuudaaaaToolStripMenuItem.Name = "aiuuuudaaaaToolStripMenuItem";
      this.aiuuuudaaaaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.aiuuuudaaaaToolStripMenuItem.Text = "aiuuuudaaaa";
      this.aiuuuudaaaaToolStripMenuItem.Click += new System.EventHandler(this.AiuuuudaaaaToolStripMenuItem_Click);
      // 
      // simbols
      // 
      this.simbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.simbols.Location = new System.Drawing.Point(14, 598);
      this.simbols.Name = "simbols";
      this.simbols.ReadOnly = true;
      this.simbols.Size = new System.Drawing.Size(1244, 152);
      this.simbols.TabIndex = 10;
      this.simbols.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Simbols_CellContentClick);
      // 
      // output
      // 
      this.output.Location = new System.Drawing.Point(14, 400);
      this.output.Multiline = true;
      this.output.Name = "output";
      this.output.ReadOnly = true;
      this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.output.Size = new System.Drawing.Size(1244, 183);
      this.output.TabIndex = 9;
      this.output.TextChanged += new System.EventHandler(this.Output_TextChanged);
      // 
      // datatoken
      // 
      this.datatoken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.datatoken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.t,
            this.Linea});
      this.datatoken.Location = new System.Drawing.Point(637, 29);
      this.datatoken.Name = "datatoken";
      this.datatoken.ReadOnly = true;
      this.datatoken.Size = new System.Drawing.Size(621, 354);
      this.datatoken.TabIndex = 8;
      this.datatoken.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datatoken_CellContentClick);
      // 
      // Nombre
      // 
      this.Nombre.HeaderText = "Linea";
      this.Nombre.Name = "Nombre";
      this.Nombre.ReadOnly = true;
      // 
      // t
      // 
      this.t.HeaderText = "Nombre";
      this.t.Name = "t";
      this.t.ReadOnly = true;
      this.t.Width = 250;
      // 
      // Linea
      // 
      this.Linea.HeaderText = "Tipo";
      this.Linea.Name = "Linea";
      this.Linea.ReadOnly = true;
      this.Linea.Width = 250;
      // 
      // txt
      // 
      this.txt.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt.Location = new System.Drawing.Point(13, 27);
      this.txt.Multiline = true;
      this.txt.Name = "txt";
      this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txt.Size = new System.Drawing.Size(618, 356);
      this.txt.TabIndex = 7;
      this.txt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // ventana2
      // 
      this.ventana2.FileName = "Text1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1341, 765);
      this.Controls.Add(this.simbols);
      this.Controls.Add(this.output);
      this.Controls.Add(this.datatoken);
      this.Controls.Add(this.txt);
      this.Controls.Add(this.menuStrip1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.simbols)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.datatoken)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem compiññToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem compileProgramToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveTokensAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveSymbolsAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aiuuuudaaaaToolStripMenuItem;
    private System.Windows.Forms.DataGridView simbols;
    private System.Windows.Forms.TextBox output;
    private System.Windows.Forms.DataGridView datatoken;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn t;
    private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
    private System.Windows.Forms.TextBox txt;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.OpenFileDialog ventana2;
    private System.Windows.Forms.SaveFileDialog ventana;
  }
}

