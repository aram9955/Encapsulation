using System;

namespace Encapsulation
{
    public class Circle
    {
        public Circle(int r)
        {
            _r = r;
        }
        private int _r;
        public int R
        {
            get
            {
                return _r;
            }
            set
            {

                {
                    if (value > 100)
                        _r = value;
                }
            }
        }
    }
}