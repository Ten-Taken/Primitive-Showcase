namespace Program_8
{
  partial class Prog8Form
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
      this.Requirement_1 = new System.Windows.Forms.Label();
      this.quantityPhones = new System.Windows.Forms.NumericUpDown();
      this.labelPhones = new System.Windows.Forms.Label();
      this.buttonPhones = new System.Windows.Forms.Button();
      this.flowPhoneBox = new System.Windows.Forms.FlowLayoutPanel();
      this.createPhonesButton = new System.Windows.Forms.Button();
      this.confirmPhones = new System.Windows.Forms.Label();
      this.AccountHeader = new System.Windows.Forms.Label();
      this.acctNameBox = new System.Windows.Forms.TextBox();
      this.acctAddrBox = new System.Windows.Forms.TextBox();
      this.acctCredBox = new System.Windows.Forms.TextBox();
      this.flowRadioPhones = new System.Windows.Forms.FlowLayoutPanel();
      this.buttAcctCreat = new System.Windows.Forms.Button();
      this.confirmAcctMade = new System.Windows.Forms.Label();
      this.acctGrid = new System.Windows.Forms.DataGridView();
      this.Name_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Address_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Phone_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.card_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Balance_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Minutes_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.minsUpDown = new System.Windows.Forms.NumericUpDown();
      this.minsLabel = new System.Windows.Forms.Label();
      this.req3Label = new System.Windows.Forms.Label();
      this.Req2Label = new System.Windows.Forms.Label();
      this.Req5label = new System.Windows.Forms.Label();
      this.Req4Label = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.quantityPhones)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.acctGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.minsUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // Requirement_1
      // 
      this.Requirement_1.AutoSize = true;
      this.Requirement_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.Requirement_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
      this.Requirement_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(22)))));
      this.Requirement_1.Location = new System.Drawing.Point(296, 26);
      this.Requirement_1.Name = "Requirement_1";
      this.Requirement_1.Size = new System.Drawing.Size(231, 33);
      this.Requirement_1.TabIndex = 0;
      this.Requirement_1.Text = "#1 This is Program-8";
      this.Requirement_1.UseCompatibleTextRendering = true;
      // 
      // quantityPhones
      // 
      this.quantityPhones.Location = new System.Drawing.Point(43, 82);
      this.quantityPhones.Name = "quantityPhones";
      this.quantityPhones.Size = new System.Drawing.Size(52, 22);
      this.quantityPhones.TabIndex = 1;
      // 
      // labelPhones
      // 
      this.labelPhones.AutoSize = true;
      this.labelPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.labelPhones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.labelPhones.Location = new System.Drawing.Point(117, 84);
      this.labelPhones.Name = "labelPhones";
      this.labelPhones.Size = new System.Drawing.Size(221, 20);
      this.labelPhones.TabIndex = 2;
      this.labelPhones.Text = "Number of phones to create.";
      // 
      // buttonPhones
      // 
      this.buttonPhones.Location = new System.Drawing.Point(344, 82);
      this.buttonPhones.Name = "buttonPhones";
      this.buttonPhones.Size = new System.Drawing.Size(87, 25);
      this.buttonPhones.TabIndex = 3;
      this.buttonPhones.Text = "Submit";
      this.buttonPhones.UseVisualStyleBackColor = true;
      this.buttonPhones.Click += new System.EventHandler(this.buttonPhones_Click);
      // 
      // flowPhoneBox
      // 
      this.flowPhoneBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowPhoneBox.Location = new System.Drawing.Point(43, 141);
      this.flowPhoneBox.Name = "flowPhoneBox";
      this.flowPhoneBox.Size = new System.Drawing.Size(790, 131);
      this.flowPhoneBox.TabIndex = 4;
      // 
      // createPhonesButton
      // 
      this.createPhonesButton.Location = new System.Drawing.Point(344, 279);
      this.createPhonesButton.Name = "createPhonesButton";
      this.createPhonesButton.Size = new System.Drawing.Size(115, 27);
      this.createPhonesButton.TabIndex = 5;
      this.createPhonesButton.Text = "Create Phones";
      this.createPhonesButton.UseVisualStyleBackColor = true;
      this.createPhonesButton.Visible = false;
      this.createPhonesButton.Click += new System.EventHandler(this.createPhonesButton_Click);
      // 
      // confirmPhones
      // 
      this.confirmPhones.AutoSize = true;
      this.confirmPhones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.confirmPhones.ForeColor = System.Drawing.Color.Lime;
      this.confirmPhones.Location = new System.Drawing.Point(43, 288);
      this.confirmPhones.Name = "confirmPhones";
      this.confirmPhones.Size = new System.Drawing.Size(0, 17);
      this.confirmPhones.TabIndex = 6;
      // 
      // AccountHeader
      // 
      this.AccountHeader.AutoSize = true;
      this.AccountHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
      this.AccountHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(22)))));
      this.AccountHeader.Location = new System.Drawing.Point(291, 332);
      this.AccountHeader.Name = "AccountHeader";
      this.AccountHeader.Size = new System.Drawing.Size(195, 29);
      this.AccountHeader.TabIndex = 7;
      this.AccountHeader.Text = "Account Creation";
      // 
      // acctNameBox
      // 
      this.acctNameBox.Location = new System.Drawing.Point(78, 384);
      this.acctNameBox.Name = "acctNameBox";
      this.acctNameBox.Size = new System.Drawing.Size(155, 22);
      this.acctNameBox.TabIndex = 8;
      this.acctNameBox.Text = "Your Name";
      // 
      // acctAddrBox
      // 
      this.acctAddrBox.Location = new System.Drawing.Point(255, 384);
      this.acctAddrBox.Name = "acctAddrBox";
      this.acctAddrBox.Size = new System.Drawing.Size(190, 22);
      this.acctAddrBox.TabIndex = 9;
      this.acctAddrBox.Text = "Your Address";
      // 
      // acctCredBox
      // 
      this.acctCredBox.Location = new System.Drawing.Point(465, 384);
      this.acctCredBox.Name = "acctCredBox";
      this.acctCredBox.Size = new System.Drawing.Size(168, 22);
      this.acctCredBox.TabIndex = 10;
      this.acctCredBox.Text = "Credit Card #";
      // 
      // flowRadioPhones
      // 
      this.flowRadioPhones.AutoSize = true;
      this.flowRadioPhones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowRadioPhones.Location = new System.Drawing.Point(43, 428);
      this.flowRadioPhones.Name = "flowRadioPhones";
      this.flowRadioPhones.Size = new System.Drawing.Size(443, 100);
      this.flowRadioPhones.TabIndex = 11;
      // 
      // buttAcctCreat
      // 
      this.buttAcctCreat.Location = new System.Drawing.Point(504, 459);
      this.buttAcctCreat.Name = "buttAcctCreat";
      this.buttAcctCreat.Size = new System.Drawing.Size(115, 32);
      this.buttAcctCreat.TabIndex = 12;
      this.buttAcctCreat.Text = "Create Account";
      this.buttAcctCreat.UseVisualStyleBackColor = true;
      this.buttAcctCreat.Visible = false;
      this.buttAcctCreat.Click += new System.EventHandler(this.buttAcctCreat_Click);
      // 
      // confirmAcctMade
      // 
      this.confirmAcctMade.AutoSize = true;
      this.confirmAcctMade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(201)))), ((int)(((byte)(52)))));
      this.confirmAcctMade.Location = new System.Drawing.Point(638, 473);
      this.confirmAcctMade.Name = "confirmAcctMade";
      this.confirmAcctMade.Size = new System.Drawing.Size(116, 17);
      this.confirmAcctMade.TabIndex = 13;
      this.confirmAcctMade.Text = "Account Created!";
      this.confirmAcctMade.Visible = false;
      // 
      // acctGrid
      // 
      this.acctGrid.AllowUserToDeleteRows = false;
      this.acctGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.acctGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_out,
            this.Address_out,
            this.Phone_out,
            this.card_out,
            this.Balance_out,
            this.Minutes_out});
      this.acctGrid.Location = new System.Drawing.Point(43, 551);
      this.acctGrid.Name = "acctGrid";
      this.acctGrid.ReadOnly = true;
      this.acctGrid.RowTemplate.Height = 24;
      this.acctGrid.Size = new System.Drawing.Size(646, 121);
      this.acctGrid.TabIndex = 14;
      // 
      // Name_out
      // 
      this.Name_out.HeaderText = "Name";
      this.Name_out.Name = "Name_out";
      this.Name_out.ReadOnly = true;
      // 
      // Address_out
      // 
      this.Address_out.HeaderText = "Adress";
      this.Address_out.Name = "Address_out";
      this.Address_out.ReadOnly = true;
      // 
      // Phone_out
      // 
      this.Phone_out.HeaderText = "Phone";
      this.Phone_out.Name = "Phone_out";
      this.Phone_out.ReadOnly = true;
      // 
      // card_out
      // 
      this.card_out.HeaderText = "Card #";
      this.card_out.Name = "card_out";
      this.card_out.ReadOnly = true;
      // 
      // Balance_out
      // 
      this.Balance_out.HeaderText = "Balance";
      this.Balance_out.Name = "Balance_out";
      this.Balance_out.ReadOnly = true;
      // 
      // Minutes_out
      // 
      this.Minutes_out.HeaderText = "Minutes";
      this.Minutes_out.Name = "Minutes_out";
      this.Minutes_out.ReadOnly = true;
      // 
      // minsUpDown
      // 
      this.minsUpDown.Location = new System.Drawing.Point(652, 384);
      this.minsUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.minsUpDown.Name = "minsUpDown";
      this.minsUpDown.Size = new System.Drawing.Size(120, 22);
      this.minsUpDown.TabIndex = 15;
      // 
      // minsLabel
      // 
      this.minsLabel.AutoSize = true;
      this.minsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.minsLabel.Location = new System.Drawing.Point(660, 364);
      this.minsLabel.Name = "minsLabel";
      this.minsLabel.Size = new System.Drawing.Size(94, 17);
      this.minsLabel.TabIndex = 16;
      this.minsLabel.Text = "Minutes Used";
      // 
      // req3Label
      // 
      this.req3Label.AutoSize = true;
      this.req3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
      this.req3Label.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.req3Label.Location = new System.Drawing.Point(78, 361);
      this.req3Label.Name = "req3Label";
      this.req3Label.Size = new System.Drawing.Size(95, 13);
      this.req3Label.TabIndex = 17;
      this.req3Label.Text = "Req #3 -User Input";
      // 
      // Req2Label
      // 
      this.Req2Label.AutoSize = true;
      this.Req2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
      this.Req2Label.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.Req2Label.Location = new System.Drawing.Point(786, 13);
      this.Req2Label.Name = "Req2Label";
      this.Req2Label.Size = new System.Drawing.Size(123, 13);
      this.Req2Label.TabIndex = 18;
      this.Req2Label.Text = "Req #2 - Recreate Prog6";
      // 
      // Req5label
      // 
      this.Req5label.AutoSize = true;
      this.Req5label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
      this.Req5label.ForeColor = System.Drawing.Color.Snow;
      this.Req5label.Location = new System.Drawing.Point(704, 413);
      this.Req5label.Name = "Req5label";
      this.Req5label.Size = new System.Drawing.Size(123, 13);
      this.Req5label.TabIndex = 19;
      this.Req5label.Text = "Req#5 - Invokes Method";
      // 
      // Req4Label
      // 
      this.Req4Label.AutoSize = true;
      this.Req4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
      this.Req4Label.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.Req4Label.Location = new System.Drawing.Point(696, 571);
      this.Req4Label.Name = "Req4Label";
      this.Req4Label.Size = new System.Drawing.Size(101, 13);
      this.Req4Label.TabIndex = 20;
      this.Req4Label.Text = "Req #4 - Object Info";
      // 
      // Prog8Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(930, 753);
      this.Controls.Add(this.Req4Label);
      this.Controls.Add(this.Req5label);
      this.Controls.Add(this.Req2Label);
      this.Controls.Add(this.req3Label);
      this.Controls.Add(this.minsLabel);
      this.Controls.Add(this.minsUpDown);
      this.Controls.Add(this.acctGrid);
      this.Controls.Add(this.confirmAcctMade);
      this.Controls.Add(this.buttAcctCreat);
      this.Controls.Add(this.flowRadioPhones);
      this.Controls.Add(this.acctCredBox);
      this.Controls.Add(this.acctAddrBox);
      this.Controls.Add(this.acctNameBox);
      this.Controls.Add(this.AccountHeader);
      this.Controls.Add(this.confirmPhones);
      this.Controls.Add(this.createPhonesButton);
      this.Controls.Add(this.flowPhoneBox);
      this.Controls.Add(this.buttonPhones);
      this.Controls.Add(this.labelPhones);
      this.Controls.Add(this.quantityPhones);
      this.Controls.Add(this.Requirement_1);
      this.Name = "Prog8Form";
      this.Text = "Program_8";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prog8Form_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.quantityPhones)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.acctGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.minsUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Requirement_1;
    private System.Windows.Forms.NumericUpDown quantityPhones;
    private System.Windows.Forms.Label labelPhones;
    private System.Windows.Forms.Button buttonPhones;
    private System.Windows.Forms.FlowLayoutPanel flowPhoneBox;
    private System.Windows.Forms.Button createPhonesButton;
    private System.Windows.Forms.Label confirmPhones;
    private System.Windows.Forms.Label AccountHeader;
    private System.Windows.Forms.TextBox acctNameBox;
    private System.Windows.Forms.TextBox acctAddrBox;
    private System.Windows.Forms.TextBox acctCredBox;
    private System.Windows.Forms.FlowLayoutPanel flowRadioPhones;
    private System.Windows.Forms.Button buttAcctCreat;
    private System.Windows.Forms.Label confirmAcctMade;
    private System.Windows.Forms.DataGridView acctGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name_out;
    private System.Windows.Forms.DataGridViewTextBoxColumn Address_out;
    private System.Windows.Forms.DataGridViewTextBoxColumn Phone_out;
    private System.Windows.Forms.DataGridViewTextBoxColumn card_out;
    private System.Windows.Forms.DataGridViewTextBoxColumn Balance_out;
    private System.Windows.Forms.DataGridViewTextBoxColumn Minutes_out;
    private System.Windows.Forms.NumericUpDown minsUpDown;
    private System.Windows.Forms.Label minsLabel;
    private System.Windows.Forms.Label req3Label;
    private System.Windows.Forms.Label Req2Label;
    private System.Windows.Forms.Label Req5label;
    private System.Windows.Forms.Label Req4Label;
  }
}

