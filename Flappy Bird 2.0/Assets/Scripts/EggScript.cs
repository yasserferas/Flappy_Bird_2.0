using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public float ProjectileSpeed;

    public float ProjectileLifetime;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
       transform.position = transform.position + new Vector3(ProjectileSpeed * Time.deltaTime, 0,0);

        transform.rotation = Quaternion.Euler(0, 0, -90); 

            Destroy(gameObject, ProjectileLifetime);







    }

    
}
