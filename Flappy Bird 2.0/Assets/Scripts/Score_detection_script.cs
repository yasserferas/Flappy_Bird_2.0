using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_detection_script : MonoBehaviour
{
    public ScoreManager sm; 

    public BirdScript bs;

   

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("Logic manager").GetComponent<ScoreManager>();

        bs = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();

        
    }

    private void Update()
    {
        if (bs.Bird_Is_Alive == false)
        {
            this.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird") && bs.Bird_Is_Alive == true)
        {
            sm.add_score(1);
            FindObjectOfType<AudioManager>().Play("Score");
        }
    }



}
