using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraAssignment3
{
    public class Ball
    {
        private int _size;
        private int _throw;
        private Color _color;

        public Ball(int size, Color color, int Throw = 0)
        {
            _size = size;
            _throw = Throw;
            _color = color;
        }

        public void pop()
        {
            this._size = 0;
        }

        public void Throw()
        {
            if(this._size != 0)
            {
                this._throw++;
            }
        }

        public int thrown()
        {
            return this._throw;
        }


    }
}
