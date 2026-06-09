namespace Lab;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(449, 68);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(210, 62);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(34, 306);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(285, 90);
        button1.TabIndex = 1;
        button1.Text = "Пуск";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Items.AddRange(new object[] { "парні", "непарні" });
        listBox1.Location = new System.Drawing.Point(34, 68);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(306, 84);
        listBox1.TabIndex = 2;
        listBox1.Click += listBox1_SelectedIndexChanged;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(listBox1);
        Controls.Add(button1);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBox1;

    #endregion
}
