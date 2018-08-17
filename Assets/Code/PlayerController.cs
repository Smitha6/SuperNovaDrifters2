using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject player;

    private int playerSpeed = 7;
    private Rigidbody2D body;
    private Transform my;
    private Camera cam;


    // Use this for initialization
    void Start () {
        cam = Camera.main;
        my = GetComponent<Transform>();
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        //---Rotation---
        //Distance from camera to object.
        float camDis = cam.transform.position.y - my.position.y;
        //Get the mouse position in world space. Using camDis for the Z axis.
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));
        float AngleRad = Mathf.Atan2(mouse.y - my.position.y, mouse.x - my.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;
        body.rotation = angle - 90;
        
        //---Movement---
        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.up * Time.deltaTime * playerSpeed;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position += Vector3.down * Time.deltaTime * playerSpeed;
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.position += Vector3.left * Time.deltaTime * playerSpeed;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position += Vector3.right * Time.deltaTime * playerSpeed;
        }
        

    }
}
