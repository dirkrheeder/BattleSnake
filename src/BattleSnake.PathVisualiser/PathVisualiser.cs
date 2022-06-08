namespace BattleSnake.PathVisualiser;

public partial class PathVisualiser : Form
{
    const int width = 64;
    const int height = 32;
    Graphics paper;
    GridBox[][] m_rectangles;

    public PathVisualiser()
    {
        InitializeComponent();
        DoubleBuffered = true;

        this.BackColor = Color.Black;
        this.Width = (width + 1) * 20;
        this.Height = (height + 1) * 20 + 100;
        this.MaximumSize = new Size(this.Width, this.Height);
        this.MaximizeBox = false;

        m_rectangles = new GridBox[width][];
        for (int widthTrav = 0; widthTrav < width; widthTrav++)
        {
            m_rectangles[widthTrav] = new GridBox[height];
            for (int heightTrav = 0; heightTrav < height; heightTrav++)
            {
                //if (widthTrav == (width / 3) && heightTrav == (height / 2))
                //    m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Start);
                //else if (widthTrav == 41 && heightTrav == (height / 2))
                //    m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.End);
                //else
                m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Normal);
            }
        }
    }

    private void PathVisualiser_Paint(object sender, PaintEventArgs e)
    {
        paper = e.Graphics;
        //Draw

        for (int widthTrav = 0; widthTrav < width; widthTrav++)
        {
            for (int heightTrav = 0; heightTrav < height; heightTrav++)
            {
                m_rectangles[widthTrav][heightTrav].DrawBox(paper, BoxType.Normal);
            }
        }

        m_rectangles[2][2].SetObstacle(paper);
    }
}
