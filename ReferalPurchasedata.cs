using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ReferalPurchasedata 
{
    // Start is called before the first frame update
    public int noads;
    public int ReferalClaimed;
    public int otherreferalclaimed;

    public void savedata()
    {
        SaveSystempurchase.savedatapurchase(this);
    }

    public void loaddata()
    {
       ReferalPurchasedata data = SaveSystempurchase.loaddatapurchase();
       //local 
       noads = data.noads;
       ReferalClaimed = data.ReferalClaimed;
       otherreferalclaimed =  data.otherreferalclaimed;
    }
}
