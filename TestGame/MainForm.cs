using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int fixedI;
        private int fixedJ;
        private Graphics graph;
        private Graphics graphState;
        private PlayingField pf;
        private bool GameStarted = false;
        private string NameOfElement;

        private void StartBTN_Click(object sender, EventArgs e)
        {
            graphState.FillRectangle(Brushes.White, 0, 0, 40, 40);
            graph.FillRectangle(Brushes.White, 0, 0, 601, 601);
            pf = new PlayingField();
            Pen p = new Pen(Brushes.Black, 5);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    graph.DrawRectangle(p, PlayingField.quadrates[i, j].X, PlayingField.quadrates[i, j].Y, 200, 200);
            p = new Pen(Brushes.Red, 4);
            graphState.DrawLine(p, 5, 5, 33, 33);
            graphState.DrawLine(p, 33, 5, 5, 33);
            StartBTN.Text = "Рестарт";
            NameOfElement = "хрестики";
            fixedI = -1;
            fixedJ = -1;
            GameStarted = true;
        }


        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((fixedI != e.X / 200 || fixedJ != e.Y / 200) && GameStarted == true)
            {
                if (fixedI != -1 && fixedJ != -1)
                    DrawElement(PlayingField.elements[fixedI, fixedJ].NameOfElement, fixedI, fixedJ);
                fixedI = e.X / 200;
                fixedJ = e.Y / 200;
                if (PlayingField.elements[e.X / 200, e.Y / 200].NameOfElement == "")
                    DrawElement(NameOfElement, e.X / 200, e.Y / 200);
            }

        }

        private void DrawElement(string ElementName, int I, int J)
        {
            Pen p = new Pen(Brushes.Red, 7);
            switch (ElementName)
            {
                case "хрестики":
                    graph.DrawLine(p, I * 200 + 20, J * 200 + 20, I * 200 + 180, J * 200 + 180);
                    graph.DrawLine(p, I * 200 + 180, J * 200 + 20, I * 200 + 20, J * 200 + 180);
                    break;
                case "нулики":
                    graph.DrawEllipse(p, I * 200 + 25, J * 200 + 25, 155, 155);
                    break;
                default:
                    graph.FillRectangle(Brushes.White, I * 200 + 18, J * 200 + 18, 170, 170);
                    break;
            }
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (GameStarted == true)
            {
                if (PlayingField.elements[fixedI, fixedJ].NameOfElement == "")
                {
                    PlayingField.elements[fixedI, fixedJ].NameOfElement = NameOfElement;
                    graphState.FillRectangle(Brushes.White, 0, 0, 40, 40);
                    if (PlayingField.Check(fixedI, fixedJ, NameOfElement) == true)
                    {
                        MessageBox.Show("Виграли " + NameOfElement + "!");
                        StartBTN.Text = "Старт";
                        graph.FillRectangle(Brushes.White, 0, 0, 601, 601);
                        GameStarted = false;
                    }
                    else if (PlayingField.GameOver())
                    {
                        MessageBox.Show("Нічия!");
                        StartBTN.Text = "Старт";
                        graph.FillRectangle(Brushes.White, 0, 0, 601, 601);
                        GameStarted = false;
                    }
                    else
                    {
                        NameOfElement = (NameOfElement == "хрестики") ? "нулики" : "хрестики";
                        Pen p = new Pen(Brushes.Red, 4);
                        if (NameOfElement == "хрестики")
                        {
                            graphState.DrawLine(p, 5, 5, 33, 33);
                            graphState.DrawLine(p, 33, 5, 5, 33);
                        }
                        else
                            graphState.DrawEllipse(p, 5, 5, 25, 25);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            graph = DrawPanel.CreateGraphics();
            graphState = PanelState.CreateGraphics();
        }
    }
}
