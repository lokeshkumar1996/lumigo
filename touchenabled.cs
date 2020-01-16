using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchenabled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint((Input.GetTouch (0).position)), Vector2.zero);
                if(hit.collider != null)
                {
                gameObject.GetComponent<playermove>().enabled = true;
                //Debug.Log ("Touched it");
                }
                else
                {
                gameObject.GetComponent<playermove>().enabled = false;
                }
        }*/
        
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
        Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit raycastHit;
        if (Physics.Raycast(raycast, out raycastHit))
            {
                gameObject.GetComponent<playermove>().enabled = true;
                //Debug.Log ("Touched it");
                }
                else
                {
                gameObject.GetComponent<playermove>().enabled = false;
            }
        }






















    }
}
