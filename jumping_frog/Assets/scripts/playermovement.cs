using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] public float speed = 10f;
    [SerializeField] public float jump = 100f;
    [SerializeField] public string horizontal_movement = "Horizontal";
    [SerializeField] public string vertical_movement = "Vertical";
    private Vector3 Dir;
    // Start is called before the first frame update
    private Rigidbody rb;
    private Vector3 curPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Dir = Vector3.zero;
        curPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if(transform.position != new Vector3(curPosition.x,curPosition.y,curPosition.z) + Dir){
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(curPosition.x,curPosition.y,curPosition.z) + Dir, speed*Time.deltaTime);
        }
        else{

            Dir = Vector3.zero;
            curPosition = transform.position;
            curPosition.x = Mathf.Round(curPosition.x);
            if(Input.GetAxisRaw(horizontal_movement) != 0){

                Dir.z = Input.GetAxisRaw(horizontal_movement);
                Move();
            }
            else if(Input.GetAxisRaw(vertical_movement) != 0){
                Dir.x = Input.GetAxisRaw(vertical_movement);
                Move();
            }
        }
    }
    void Move(){
        rb.AddForce(0,jump,0);
    }
}
