using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControrller : MonoBehaviour {

    public float flyPower;
    GameObject obj;
    GameObject gameController;
    public AudioClip flyChip;
    public AudioClip gameOverChip;
    
    

    private AudioSource audioSource;
    private Animator anim;
    // Use this for initialization
    void Start () {
        flyPower = 300;
        obj = gameObject;
        anim = obj.GetComponent<Animator>();
    
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyChip;

        anim.SetFloat("isFly", 0);
        anim.SetBool("isDead", false);


        if (gameController==null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (!gameController.GetComponent<GameController>().isEndGame)
            {
                audioSource.Play();
                
            }

            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
           
        }
        anim.SetFloat("isFly", obj.GetComponent<Rigidbody2D>().velocity.y);
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("cong diem");
        gameController.GetComponent<GameController>().GetPoint();
    }
    void EndGame()
    {
        
        audioSource.clip = gameOverChip;
        audioSource.Play();
        gameController.GetComponent<GameController>().EndGame();
        anim.SetBool("isDead", true);
    }
}
