using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tetris;

public class Tetramino
{
    private Point currPosition;
    private Point[] currShape;
    private Brush currColor;
    private bool rotate;
    public Tetramino()
    {
        currPosition = new Point(0, 0);
        currColor = Brushes.Transparent;
        currShape = setRandomShape();

    }
    private Point[] setRandomShape()
    {
        Random rand = new Random();
        switch (rand.Next() % 7)
        {
            case 0:
                rotate = true;
                currColor = Brushes.Cyan;
                return new Point[]
                {
                        new Point(0,0),
                        new Point(-1,0),
                        new Point(1,0),
                        new Point(2,0),
                };
            case 1:
                rotate = true;
                currColor = Brushes.Blue;
                return new Point[]
                {
                        new Point(1,-1),
                        new Point(-1,0),
                        new Point(0,0),
                        new Point(1,0),
                };
            case 2:
                rotate = true;
                currColor = Brushes.Orange;
                return new Point[]
                {
                        new Point(0,0),
                        new Point(-1,0),
                        new Point(1,0),
                        new Point(1,-1),
                };
            case 3:
                rotate = true;
                currColor = Brushes.Yellow;
                return new Point[]
                {
                        new Point(0,0),
                        new Point(0,1),
                        new Point(1,0),
                        new Point(1,1),
                };
            case 4:
                rotate = true;
                currColor = Brushes.Green;
                return new Point[]
                {
                        new Point(0,0),
                        new Point(-1,0),
                        new Point(0,-1),
                        new Point(1,0),
                };
            case 5:
                rotate = true;
                currColor = Brushes.Purple;
                return new Point[]
                {
                        new Point(0,0),
                        new Point(-1,0),
                        new Point(0,-1),
                        new Point(1,0),
                };
            case 6:
                rotate = true;
                currColor = Brushes.Red;
                return new Point[]
                {
                        new Point(0,0),
                        new Point(-1,0),
                        new Point(0,1),
                        new Point(1,1),
                };
            default:
                return null;
        }
    }
}
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
