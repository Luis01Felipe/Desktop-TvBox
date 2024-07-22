using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows;

namespace Desktop_TvBox
{
    public partial class MainScreen : Form
    {
        // Declare buttons as a class-level field
        private List<Button> buttons;

        public MainScreen()
        {
            InitializeComponent();
        
            // Initialize the buttons list with button instances
            buttons = new List<Button> { button1, btnYoutube, button2 };

            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            // Example operation: Print the names of all buttons in the list
            foreach (var button in buttons)
            {
                Console.WriteLine(button.Name);
            }

            // If you want to find a specific button by name, ensure you have a valid name to search for
            // This is just an illustrative example, as this.Name refers to the form's name, not the button's
            var foundButton = buttons.FirstOrDefault(b => b.Name == "btnYoutube");
            if (foundButton != null)
            {
                // Perform an action with foundButton
                Console.WriteLine($"Found button: {foundButton.Name}");
            }
        }

        private void ResizeComponents(Control control, int width, int height, int x, int y)
        {
            control.Size = new Size(width, height);
            control.Location = new Point(x, y);
        }
        
        private void MainScreen_Resize(object sender, EventArgs e)
        {
            // Buttons
            int btnWidth = 300;
            int btnHeight = 500;
            int btnCenterX = (this.Width / 2) - (btnWidth / 2); 
            int btnCenterY = (this.Height / 2) - (btnHeight / 2);
            
            ResizeComponents(btnYoutube, btnWidth, btnHeight, btnCenterX, btnCenterY); // Centralizado
            ResizeComponents(button1, btnWidth, btnHeight, btnCenterX - (btnWidth+25), btnCenterY); // Esquerda do Centro
            ResizeComponents(button2, btnWidth, btnHeight, btnCenterX + (btnWidth+25), btnCenterY); // Direita do Centro
            
            // Labels
            ResizeComponents(lbClock, 200, 50, (this.Width/2)-(200/2), 0); // Top Center
            ResizeComponents(lbDate, 200, 50, (this.Width/2)-(200/2), lbClock.Height); // Top Center-Down
        }

        private void ButtonMovement(Button clickedButton, List<Button> buttons)
        {
            
        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("HH:mm");
            lbDate.Text = DateTime.Now.ToString("dddd, dd, MMM", new System.Globalization.CultureInfo("pt-BR")); // Tirar daqui depois
        }
    }
}