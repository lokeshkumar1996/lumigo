using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randominstantiate : MonoBehaviour
{
    public GameObject[] debrisPrefabs;
    public int count;
    float height ;
    float width ;


    // Start is called before the first frame update
    void Start()
    {
        Vector2 topRightCorner = new Vector2(1, 1);
        Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = edgeVector.y - 4 ;
      width = edgeVector.x - 2;

        for( int i=0; i<count; i++){
        Instantiate(debrisPrefabs[Random.Range(0,debrisPrefabs.Length)], new Vector3(Random.Range(-width, width),Random.Range(-height, height),0),  Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {

        

    }
}
