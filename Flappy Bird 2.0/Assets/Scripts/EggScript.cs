using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public float ProjectileSpeed;

    public float ProjectileLifetime;

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(ProjectileSpeed, transform.position.y);

        Destroy(gameObject, ProjectileLifetime);
    }

    
}
