namespace KeyLogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblKeyPressedLabel.Text = "";
            lblKeyInformation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblKeyPressedLabel.Text = $"Key Pressed: {e.KeyChar}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Text.StringBuilder data = new();

            data.Append($"Alt Pressed? {(e.Alt ? "Yes" : "No")}\n");
            data.Append($"Control Pressed? {(e.Control ? "Yes" : "No")}\n");
            data.Append($"Shift Pressed? {(e.Shift ? "Yes" : "No")}\n");
            data.Append($"Key Code: {e.KeyCode}\n");
            data.Append($"Key Data: {e.KeyData}\n");
            data.Append($"Key Value: {e.KeyValue}\n");

            lblKeyInformation.Text = data.ToString();


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            lblKeyPressedLabel.Text = "";
            lblKeyInformation.Text = "";
        }
    }
}