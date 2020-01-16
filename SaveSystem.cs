using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class SaveSystem {
    
   public static void savedata(LevelDiamonddata leveldata )
   {
       BinaryFormatter formatter = new BinaryFormatter();
       string path = Application.persistentDataPath + "/level.number";
       FileStream stream =  new FileStream(path, FileMode.Create);
         
       formatter.Serialize(stream, leveldata);
       stream.Close();

       Debug.Log("savded");
       
   }

   public static LevelDiamonddata loaddata()
   {
       string path = Application.persistentDataPath + "/level.number";
       if(File.Exists(path))
       {
         BinaryFormatter formatter = new BinaryFormatter();
         FileStream stream =  new FileStream(path, FileMode.Open);  

        LevelDiamonddata data = formatter.Deserialize(stream) as LevelDiamonddata  ;
         stream.Close();
         Debug.Log("loaded");
         
        return data; 
       }
       else
       {
          Debug.Log("no file to load" + path);
          return null;  
       }

      
   }

  

}
