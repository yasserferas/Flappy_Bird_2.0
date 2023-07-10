using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject BottomPipe;

    public float OpeningLength;
    
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject != null)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(BottomPipe.transform.position.y + 4, BottomPipe.transform.position.y + 8), transform.position.z);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)        //there needs to be  one rigidbody on atleast one of the objects for ontriggerenter2d to work in this case i put the rigidbody on the projectile
    {
        if (collision.CompareTag("Projectile"))
        { 
            BottomPipe.transform.position = new Vector3(BottomPipe.transform.position.x, BottomPipe.transform.position.y - OpeningLength, BottomPipe.transform.position.z);

            Destroy(collision);
        }
    }
}
