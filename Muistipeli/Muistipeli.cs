using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Muistipeli
{
    class MuistipeliGame : Game
    {
        bool filled;

        string[] marks;

        public override Mark Check()
        {
            return new Mark();
        }

        public void Suffle()
        {
            Random rnd = new Random();
            for (int i = content.GetLength(0) * content.GetLength(1)-1; i > 1; i--)
            {
                int j = rnd.Next(0, i + 1);
                Mark temp = content[j / content.GetLength(1), j % content.GetLength(1)];
                content[j / content.GetLength(1), j % content.GetLength(1)] = content[i / content.GetLength(1), i % content.GetLength(1)];
                content[i / content.GetLength(1), i % content.GetLength(1)] = temp;
            }
        }

        public void Fill()
        {
            Random rnd = new Random();
            Scan_dir("marks/");
            for (int i = 0; i < content.GetLength(0); i+=2)
            {
                for (int j = 0; j < content.GetLength(1); j++)
                {
                    int r = rnd.Next(marks.Length);
                    content[i, j] = new Mark(marks[r], marks[r]);
                    content[i+1, j] = new Mark(marks[r], marks[r]);
                }
            }
            filled = true;
            Suffle();
        }

        public void Scan_dir(string path)
        {
            marks = Directory.GetFiles(@"marks\");
        }

        public override void Reset(int size)
        {
            
            if (!filled)
            {
                base.Reset(size);
                Fill();
            }
            Suffle();
        }

    }
}
