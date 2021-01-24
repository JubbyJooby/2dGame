using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipGhost : Score
{
    public Color[] colors = null;
    // Start is called before the first frame update
    public Player player;

    public void SetColor(int colorIndex)
    {
        if (colorIndex == 0)
        {
            player.SetColor(colors[colorIndex]);
        }
        if (colorIndex == 1 && highscore >= 25)
            player.SetColor(colors[colorIndex]);
            player.health = 4;
        if (colorIndex == 2 && highscore >= 50)
            player.SetColor(colors[colorIndex]);
            player.health = 5;
        if (colorIndex == 3 && highscore >= 100)
            player.SetColor(colors[colorIndex]);
            player.health = 7;
        if (colorIndex == 4 && highscore >= 250)
            player.SetColor(colors[colorIndex]);
            player.health = 12;
   }


}
