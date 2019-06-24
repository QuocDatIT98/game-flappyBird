using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroudMove : MonoBehaviour {

    public float moveSpeed;
    public float moveRange;

    private Vector3 oldposition;
    private GameObject obj;
	// Use this for initialization
	void Start () {
        moveSpeed = 3;
        moveRange = 16.4f;

        obj = gameObject;
        oldposition = obj.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        obj.transform.Translate(new Vector3(-1* moveSpeed * Time.deltaTime,transform.position.y,0));
        if (Vector3.Distance(oldposition,obj.transform.position) > moveRange)
        {
            obj.transform.position = oldposition;
        }
	}
}
