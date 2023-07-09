using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject BottomPipe;

    
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject != null)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(BottomPipe.transform.position.y + 6, BottomPipe.transform.position.y + 10), transform.position.z);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            BottomPipe.transform.position = new Vector3(BottomPipe.transform.position.x, BottomPipe.transform.position.y - 30, BottomPipe.transform.position.z);

            Debug.Log("heyy");
            Destroy(collision);
        }
    }
}
