using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;

    public float Jump_Force;

    public bool Bird_Is_Alive;

    private bool Falling;

    public float Falling_Rotation_Speed;

    public GameProgression gp;

   public PipeSpawnerScript pss;

    public GameObject Game_Over_Screen;

    private bool Death_Sound_Played;

    public GameObject Egg;


    // Start is called before the first frame update
    void Start()
    {
        Bird_Is_Alive = true;

        Death_Sound_Played = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Bird_Is_Alive == true || Input.GetKeyDown(KeyCode.UpArrow) && Bird_Is_Alive == true || Input.GetKeyDown(KeyCode.Space) && Bird_Is_Alive == true)
        {
            rb.velocity = new Vector2(0, Jump_Force);

            rb.constraints = RigidbodyConstraints2D.None;

            Falling = true;

            transform.rotation = Quaternion.Euler(0f, 0f, 25f);

            FindObjectOfType<AudioManager>().Play("Jump");

            gp.enabled = true;

            pss.enabled = true;
        }


        if (Falling == true)
        {
          Rotate_Down();
        }



        if (transform.position.y >= 14.85f || transform.position.y <= -14.85f)
        {
            Bird_Is_Alive = false;

            Game_Over_Screen.SetActive(true);

            if (Death_Sound_Played == false)
            {
                FindObjectOfType<AudioManager>().Play("Death");

                Death_Sound_Played = true;
            }

        }



        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Egg, transform.position, transform.rotation);
        }
    }


   void Rotate_Down()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, -25f), Falling_Rotation_Speed * Time.deltaTime);
  }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe") && Bird_Is_Alive == true || collision.gameObject.CompareTag("Button") && Bird_Is_Alive == true)
        {
            Bird_Is_Alive = false;

            Game_Over_Screen.SetActive(true);

            if (Death_Sound_Played == false)
            {
                FindObjectOfType<AudioManager>().Play("Death");

                Death_Sound_Played = true;
            }
            

            


        }
    }


    






}
