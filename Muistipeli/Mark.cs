using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Muistipeli
{

    public class Mark
    {
        string id;
        object content;
        public Mark()
        {

        }
        public Mark(string id, System.Windows.Controls.Image image)
        {
            content = image;
            this.id = id;
        }

        public Mark(string id, string path)
        {
            this.id = id;
            Image image = new Image();
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri(path, UriKind.Relative);
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();
            image.Source = src;
            content = image;
        }

        public object Content
        {
            get
            {
                return content;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public object Empty { get { return Marks.empty; } }

    }
}