using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CheckersGame
{
    public class Board : IEnumerable<Cells>
    {
        private readonly Cells[,] _area;

        public State this[int row, int column]
        {
            get => _area[row, column].State;
            set => _area[row, column].State = value;
        }

        public Board()
        {
            _area = new Cells[8, 8];
            for (int i = 0; i < _area.GetLength(0); i++)
                for (int j = 0; j < _area.GetLength(1); j++)
                    _area[i, j] = new Cells();
        }

        public IEnumerator<Cells> GetEnumerator()
            => _area.Cast<Cells>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => _area.GetEnumerator();
    }
}
