using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
    /// <summary>
    /// Lớp hình vuông có các cạnh bằng nhau nên chỉ cần khai báo 1 field
    /// </summary>
	internal class Square : Rectangle
	{
        private int _height;
        private int _width;

        public override int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}
