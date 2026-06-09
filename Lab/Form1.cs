namespace Lab;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex == -1)
        {
            label1.Text = "Виберіть рядок!";
            return;
        }

        string s = listBox1.Items[listBox1.SelectedIndex].ToString();

        string even = ""; // парні позиції
        string odd = "";  // непарні позиції

        for (int i = 0; i < s.Length; i++)
        {
            if ((i + 1) % 2 == 0) // парна позиція
                even += s[i];
            else                  // непарна позиція
                odd += s[i];
        }

        label1.Text = "Парні: " + even +
                      "\nНепарні: " + odd;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}
