using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour
{
    public float speed = 1.0f;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        //this move the object left and right based on input
        transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
    }
}
