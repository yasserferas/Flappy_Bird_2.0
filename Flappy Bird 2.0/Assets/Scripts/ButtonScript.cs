using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject BottomPipe;

    public float OpeningLength;

    public bool LimitReached;

    public float LowestPos;

    public float HighestPos;

    public float OpeningSpeed;
    
    // Start is called before the first frame update
    void Start()
    {

        LimitReached = false;


        if (gameObject != null)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Random.Range(BottomPipe.transform.localPosition.y + LowestPos, BottomPipe.transform.localPosition.y + HighestPos), transform.localPosition.z);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        if (BottomPipe.transform.localPosition.y < -38)
        {
            LimitReached = true;
        }

        if (LimitReached == true)
        {
            BottomPipe.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
       


        
       
    }


    private void OnTriggerEnter2D(Collider2D collision)        //there needs to be  one rigidbody on atleast one of the objects for ontriggerenter2d to work in this case i put the rigidbody on the projectile
    {
        if (collision.CompareTag("Projectile") && LimitReached == false)
        {
            BottomPipe.GetComponent<Rigidbody2D>().velocity = new Vector2(0, OpeningSpeed);
        }
      
        
    }
}
