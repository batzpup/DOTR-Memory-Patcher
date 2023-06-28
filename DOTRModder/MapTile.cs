using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DOTRModder
{
    public class MapTile
    {
        Terrain terrain;
        Rectangle rect;
        public Bitmap img;
        bool hovered;
        public static int tileSize = 70;
        ResourceManager resources = new ResourceManager(typeof(Form1));
        
        public MapTile()
        {
            terrain = Terrain.NORMAL;
            rect = new Rectangle(0, 0, tileSize, tileSize);
            hovered = false;
            img = GetImageFromTerrain(terrain);
        }
        public MapTile(Terrain t)
        {
            terrain = t;
            rect = new Rectangle(0, 0, tileSize, tileSize);
            hovered = false;
            //img = (Bitmap)Image.FromFile($"C:\\Users\\Batzpup\\source\\repos\\DOTRModder\\DOTRModder\\Resources\\{terrain}.png");
            img = GetImageFromTerrain(t);

        }

        public byte GetTerrainAsByte()
        {
            return (byte)terrain;
        }

        public Rectangle GetRect()
        {
            return rect;
        }

        public Terrain GetTerrain()
        {
            return terrain;
        }

        public static Bitmap? GetImageFromTerrain(Terrain t)
        {
            string resourceName = t.ToString();
            return Properties.Resources.ResourceManager.GetObject(resourceName) as Bitmap;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(img, rect);
            if (hovered)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Red)), rect);
            }
        }


        public void SetRect(int x, int y)
        {
            rect.X = x;
            rect.Y = y;
        }
        public void SetTerrain(Terrain t)
        {
            img = (Bitmap)Image.FromFile($"C:\\Users\\Batzpup\\source\\repos\\DOTRModder\\DOTRModder\\Resources\\{terrain}.png");
            terrain = t;
        }
        public void SetHovered(bool b)
        {
            hovered = b;
        }
    }

}
