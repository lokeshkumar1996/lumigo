using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechanger : MonoBehaviour
{
    public Sprite happy1;
    public Sprite happy2;
    public Sprite happy3;
    public Sprite sad1;
    public Sprite sad2;
    public Sprite sad3;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
      target = GameObject.Find("player").transform;  
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = happy1;

        if(Vector2.Distance(transform.position, target.position) > 0 && Vector2.Distance(transform.position, target.position) <= 5 )
         this.gameObject.GetComponent<SpriteRenderer>().sprite = happy3;
        else if (Vector2.Distance(transform.position, target.position) > 5 && Vector2.Distance(transform.position, target.position) <= 10)
         this.gameObject.GetComponent<SpriteRenderer>().sprite = happy2;
        else if (Vector2.Distance(transform.position, target.position) > 10 && Vector2.Distance(transform.position, target.position) <= 15)
         this.gameObject.GetComponent<SpriteRenderer>().sprite = happy1;   
        else if (Vector2.Distance(transform.position, target.position) > 15 && Vector2.Distance(transform.position, target.position) <= 20)
         this.gameObject.GetComponent<SpriteRenderer>().sprite = sad1;
        else if (Vector2.Distance(transform.position, target.position) > 20 && Vector2.Distance(transform.position, target.position) <= 25)
         this.gameObject.GetComponent<SpriteRenderer>().sprite = sad2;
        else  this.gameObject.GetComponent<SpriteRenderer>().sprite = sad3;
    }
}
