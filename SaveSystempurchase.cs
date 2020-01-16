using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class SaveSystempurchase {
    
   public static void savedatapurchase(ReferalPurchasedata data )
   {
       BinaryFormatter formatter = new BinaryFormatter();
       string path = Application.persistentDataPath + "/purchase.data";
       FileStream stream =  new FileStream(path, FileMode.Create);
         
       formatter.Serialize(stream, data);
       stream.Close();

       Debug.Log("saveedpurchase");
       
   }

   public static ReferalPurchasedata loaddatapurchase()
   {
       string path = Application.persistentDataPath + "/purchase.data";
       if(File.Exists(path))
       {
         BinaryFormatter formatter = new BinaryFormatter();
         FileStream stream =  new FileStream(path, FileMode.Open);  

        ReferalPurchasedata data = formatter.Deserialize(stream) as ReferalPurchasedata  ;
         stream.Close();
         Debug.Log("loadedpurchase");
         
        return data; 
       }
       else
       {
          Debug.Log("no file to load" + path);
          return null;  
       }

      
   }

  

}
