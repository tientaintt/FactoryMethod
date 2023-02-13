using System;
using System.Windows.Forms;
namespace refactoring_guru.factory_method.example.buttons
{
    public class WindowsButton : Button
    {
        private Panel panel;
        private Form frame;
        private Button button;

        public WindowsButton()
        {
            panel = new Panel();
            frame = new Form();
            button = new Button();
        }

        public void Render()
        {
            frame.FormBorderStyle = FormBorderStyle.FixedSingle;
            frame.StartPosition = FormStartPosition.CenterScreen;
            frame.MaximizeBox = false;
            frame.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Hello World!";
            label.BackColor = Color.FromArgb(235, 233, 126);
            label.Font = new Font("Dialog", Font.Bold, 44);
            label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Dock = DockStyle.Fill;
            frame.Controls.Add(panel);
            panel.Controls.Add(label);

            OnClick();
            panel.Controls.Add(button);

            frame.ClientSize = new Size(320, 200);
            frame.Show();
        }

        public void OnClick()
        {
            button.Text = "Exit";
            button.Click += new EventHandler((sender, e) =>
            {
                frame.Close();
                Application.Exit();
            });
        }
    }
}