using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace saperTEST2.ViewModel
{
    public class MinesweeperBoard
    {
        private readonly int _width;
        private readonly int _height;
        private readonly int _numMines;
        private readonly Button[,] _buttons;
        private readonly bool[,] _mines;

        public MinesweeperBoard(int width, int height, int numMines)
        {
            _width = width;
            _height = height;
            _numMines = numMines;
            _buttons = new Button[_width, _height];
            _mines = new bool[_width, _height];

            // Create and add the buttons to the grid
            for (int row = 0; row < _height; row++)
            {
                for (int col = 0; col < _width; col++)
                {
                    Button button = new Button();
                    button.Margin = new Thickness(5);
                    button.Tag = new Tuple<int, int>(col, row);
                    button.Click += Button_Click;
                    Grid.SetRow(button, row);
                    Grid.SetColumn(button, col);
                    grid.Children.Add(button);
                    _buttons[col, row] = button;
                }
            }

            // Place mines randomly on the board
            Random random = new Random();
            int numPlacedMines = 0;
            while (numPlacedMines < _numMines)
            {
                int x = random.Next(_width);
                int y = random.Next(_height);

                // If there's already a mine at this location, try again
                if (_mines[x, y])
                {
                    continue;
                }

                _mines[x, y] = true;
                numPlacedMines++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Tuple<int, int> position = (Tuple<int, int>)button.Tag;
            int x = position.Item1;
            int y = position.Item2;

            if (_mines[x, y])
            {
                // Handle mine explosion
            }
            else
            {
                // Handle revealing adjacent squares
            }
        }
    }
}
