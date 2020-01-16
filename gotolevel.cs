using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotolevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void nextlvl()
    {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
