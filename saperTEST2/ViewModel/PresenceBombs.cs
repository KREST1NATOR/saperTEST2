using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace saperTEST2.ViewModel
{
    public class MinesweeperBombCounter
    {
        private readonly Button[,] _buttons;
        private readonly int _rowCount;
        private readonly int _columnCount;

        public MinesweeperBombCounter(Button[,] buttons)
        {
            _buttons = buttons;
            _rowCount = buttons.GetLength(0);
            _columnCount = buttons.GetLength(1);
        }

        public int GetBombCount(int row, int column)
        {
            int bombCount = 0;

            // Проверяем каждую соседнюю кнопку
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = column - 1; j <= column + 1; j++)
                {
                    // Пропускаем текущую кнопку и проверяем, что соседняя кнопка находится в пределах игрового поля
                    if ((i == row && j == column) || i < 0 || i >= _rowCount || j < 0 || j >= _columnCount)
                    {
                        continue;
                    }

                    // Если соседняя кнопка содержит бомбу, увеличиваем счетчик
                    if (_buttons[i, j].Tag != null && (bool)_buttons[i, j].Tag)
                    {
                        bombCount++;
                    }
                }
            }

            return bombCount;
        }
    }
}
