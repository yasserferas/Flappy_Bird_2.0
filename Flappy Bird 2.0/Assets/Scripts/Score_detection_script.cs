using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_detection_script : MonoBehaviour
{
    private ScoreManager sm;

    private BirdScript bs;

    private bool CanScore;
   

    // Start is called before the first frame update
    void Start()
    {

        sm = GameObject.FindGameObjectWithTag("Logic manager").GetComponent<ScoreManager>();

        bs = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();

        CanScore = true;

        
    }

    private void Update()
    {
        if (bs.Bird_Is_Alive == false)
        {
            this.enabled = false;
        }


        if (Input.GetKeyDown(KeyCode.E) && bs.CanShoot == true  && bs.Ammo > 0)
        {
            bs.Shoot();

        }

    }

    public void AddAmmo(int ammoaddition)
    {
        bs.Ammo = bs.Ammo + ammoaddition;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird") && bs.Bird_Is_Alive == true && CanScore == true)
        {
            sm.add_score(1);

            AddAmmo(1);

            FindObjectOfType<AudioManager>().Play("Score");

            CanScore = false;
           
        }
    }



}
