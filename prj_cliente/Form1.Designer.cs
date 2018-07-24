namespace prj_cliente
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnUlt = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumCod = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInc = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesq = new System.Windows.Forms.Label();
            this.btnLimparInf = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txbRg = new System.Windows.Forms.MaskedTextBox();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.cmbEstCivil = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrim
            // 
            this.btnPrim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrim.Image = ((System.Drawing.Image)(resources.GetObject("btnPrim.Image")));
            this.btnPrim.Location = new System.Drawing.Point(545, 189);
            this.btnPrim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(36, 33);
            this.btnPrim.TabIndex = 120;
            this.btnPrim.UseVisualStyleBackColor = false;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnt.Image = ((System.Drawing.Image)(resources.GetObject("btnAnt.Image")));
            this.btnAnt.Location = new System.Drawing.Point(580, 189);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(36, 33);
            this.btnAnt.TabIndex = 121;
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnProx
            // 
            this.btnProx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProx.Image = ((System.Drawing.Image)(resources.GetObject("btnProx.Image")));
            this.btnProx.Location = new System.Drawing.Point(615, 189);
            this.btnProx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(36, 33);
            this.btnProx.TabIndex = 122;
            this.btnProx.UseVisualStyleBackColor = false;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnUlt
            // 
            this.btnUlt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlt.Image = ((System.Drawing.Image)(resources.GetObject("btnUlt.Image")));
            this.btnUlt.Location = new System.Drawing.Point(650, 189);
            this.btnUlt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUlt.Name = "btnUlt";
            this.btnUlt.Size = new System.Drawing.Size(36, 33);
            this.btnUlt.TabIndex = 123;
            this.btnUlt.UseVisualStyleBackColor = false;
            this.btnUlt.Click += new System.EventHandler(this.btnUlt_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(321, 79);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 19);
            this.lblSexo.TabIndex = 118;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblEstCivil
            // 
            this.lblEstCivil.AutoSize = true;
            this.lblEstCivil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCivil.Location = new System.Drawing.Point(7, 115);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(100, 19);
            this.lblEstCivil.TabIndex = 115;
            this.lblEstCivil.Text = "Estado Civil:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(63, 79);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(252, 22);
            this.txbEmail.TabIndex = 114;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 19);
            this.lblEmail.TabIndex = 113;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblNumCod
            // 
            this.lblNumCod.AutoSize = true;
            this.lblNumCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCod.Location = new System.Drawing.Point(84, 6);
            this.lblNumCod.Name = "lblNumCod";
            this.lblNumCod.Size = new System.Drawing.Size(0, 21);
            this.lblNumCod.TabIndex = 112;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(637, 422);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 28);
            this.btnLimpar.TabIndex = 111;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInc);
            this.groupBox2.Controls.Add(this.btnExc);
            this.groupBox2.Controls.Add(this.btnAlt);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(523, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(180, 174);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // btnInc
            // 
            this.btnInc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInc.Image = ((System.Drawing.Image)(resources.GetObject("btnInc.Image")));
            this.btnInc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInc.Location = new System.Drawing.Point(7, 27);
            this.btnInc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(166, 28);
            this.btnInc.TabIndex = 12;
            this.btnInc.Text = "Incluir";
            this.btnInc.UseVisualStyleBackColor = false;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // btnExc
            // 
            this.btnExc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExc.Image = ((System.Drawing.Image)(resources.GetObject("btnExc.Image")));
            this.btnExc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExc.Location = new System.Drawing.Point(7, 83);
            this.btnExc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(166, 28);
            this.btnExc.TabIndex = 13;
            this.btnExc.Text = "Excluir";
            this.btnExc.UseVisualStyleBackColor = false;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlt.Location = new System.Drawing.Point(7, 138);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(166, 28);
            this.btnAlt.TabIndex = 14;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(170, 425);
            this.txbPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(459, 21);
            this.txbPesquisa.TabIndex = 109;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // lblPesq
            // 
            this.lblPesq.AutoSize = true;
            this.lblPesq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesq.Location = new System.Drawing.Point(9, 425);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(153, 18);
            this.lblPesq.TabIndex = 108;
            this.lblPesq.Text = "Pesquisa por Nome:";
            // 
            // btnLimparInf
            // 
            this.btnLimparInf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparInf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparInf.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparInf.Image")));
            this.btnLimparInf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparInf.Location = new System.Drawing.Point(278, 189);
            this.btnLimparInf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimparInf.Name = "btnLimparInf";
            this.btnLimparInf.Size = new System.Drawing.Size(241, 36);
            this.btnLimparInf.TabIndex = 107;
            this.btnLimparInf.Text = "Limpar Informações";
            this.btnLimparInf.UseVisualStyleBackColor = false;
            this.btnLimparInf.Click += new System.EventHandler(this.btnLimparInf_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(12, 189);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(259, 36);
            this.btnNovo.TabIndex = 106;
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(162, 7);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(354, 22);
            this.txbNome.TabIndex = 105;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 233);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(694, 185);
            this.dgv_clientes.TabIndex = 104;
            this.dgv_clientes.Click += new System.EventHandler(this.dgv_clientes_Click);
            this.dgv_clientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_clientes_KeyUp);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(144, 152);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(35, 19);
            this.lblRg.TabIndex = 103;
            this.lblRg.Text = "RG:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(104, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 19);
            this.lblNome.TabIndex = 101;
            this.lblNome.Text = "Nome:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(7, 7);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(71, 19);
            this.lblCod.TabIndex = 100;
            this.lblCod.Text = "Código:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(403, 45);
            this.txbTelefone.Mask = "(00) 0000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(113, 22);
            this.txbTelefone.TabIndex = 128;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(176, 45);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(105, 22);
            this.dtpDataNasc.TabIndex = 127;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(321, 45);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(78, 19);
            this.lblTelefone.TabIndex = 126;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(7, 45);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(172, 19);
            this.lblDataNasc.TabIndex = 125;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // txbRg
            // 
            this.txbRg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRg.Location = new System.Drawing.Point(176, 151);
            this.txbRg.Mask = "00.000.000-0";
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(100, 22);
            this.txbRg.TabIndex = 129;
            // 
            // txbCpf
            // 
            this.txbCpf.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(45, 151);
            this.txbCpf.Mask = "000.000.000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(100, 22);
            this.txbCpf.TabIndex = 130;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(7, 149);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 19);
            this.lblCpf.TabIndex = 131;
            this.lblCpf.Text = "CPF:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(240, 115);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(87, 19);
            this.lblEndereco.TabIndex = 132;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(325, 115);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(192, 22);
            this.txbEndereco.TabIndex = 133;
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(419, 149);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(97, 22);
            this.dtpDataCad.TabIndex = 135;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCad.Location = new System.Drawing.Point(273, 150);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(149, 19);
            this.lblDataCad.TabIndex = 134;
            this.lblDataCad.Text = "Data de Cadastro:";
            // 
            // cmbEstCivil
            // 
            this.cmbEstCivil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstCivil.FormattingEnabled = true;
            this.cmbEstCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viúvo"});
            this.cmbEstCivil.Location = new System.Drawing.Point(108, 117);
            this.cmbEstCivil.Name = "cmbEstCivil";
            this.cmbEstCivil.Size = new System.Drawing.Size(126, 25);
            this.cmbEstCivil.TabIndex = 136;
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(367, 79);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(149, 25);
            this.cmbSexo.TabIndex = 137;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 457);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbEstCivil);
            this.Controls.Add(this.dtpDataCad);
            this.Controls.Add(this.lblDataCad);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnUlt);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstCivil);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNumCod);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.lblPesq);
            this.Controls.Add(this.btnLimparInf);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCod);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnUlt;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumCod;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label lblPesq;
        private System.Windows.Forms.Button btnLimparInf;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox txbRg;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.ComboBox cmbEstCivil;
        private System.Windows.Forms.ComboBox cmbSexo;
    }
}

