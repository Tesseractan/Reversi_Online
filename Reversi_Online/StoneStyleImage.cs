using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reversi_Online
{
    static class StoneStyleImage
    {
        private static Dictionary<int, Pair<Image>> dictionary;
        static StoneStyleImage()
        {
            dictionary = new Dictionary<int, Pair<Image>>();
            dictionary[0] = new Pair<Image>(Properties.Resources.white, Properties.Resources.black);
            dictionary[1] = new Pair<Image>(Properties.Resources.white1, Properties.Resources.black1);

        }
        public static Image FromIDAndColor(int id, PlayerColor playerColor)
        {
            try
            {
                if (playerColor == PlayerColor.White)
                {
                    return dictionary[id].A;
                }
                else if (playerColor == PlayerColor.Black)
                {
                    return dictionary[id].B;
                }
                else
                {
                    return null;
                }
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}
