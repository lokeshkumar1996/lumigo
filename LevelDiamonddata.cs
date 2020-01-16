using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelDiamonddata
{
    //public static LevelDiamonddata instance;

    public int leveldone;
    public int diamonds;

    public void savedata()
    {
        SaveSystem.savedata(this);
    }

    public void loaddata()
    {
       LevelDiamonddata data = SaveSystem.loaddata();
       //local 
       leveldone = data.leveldone;
       diamonds = data.diamonds;
    }

    
   
}
