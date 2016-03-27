using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muistipeli
{
    public interface IControl
    {
        #region Reset
        void Reset(int size);
        #endregion
        #region Set
        void Set(int i, int j, Mark mark);
        void Set(int i, Mark mark);
        #endregion
    }
}