using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour {
    public float moveSpeed;

    public float minY;
    public float maxY;
    public float oldposition;
    private GameObject obj;
    // Use this for initialization
    void Start()
    {
        moveSpeed = 3;
      
        obj = gameObject;
        oldposition = 10;
        minY = -1;
        maxY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * moveSpeed * Time.deltaTime, 0, 0));
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("chay chay chay");
        if(other.gameObject.tag.Equals("reset"))
        obj.transform.position = new Vector3(oldposition, Random.Range(minY,maxY+1),0);
    }
}
