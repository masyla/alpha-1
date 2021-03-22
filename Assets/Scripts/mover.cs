using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    [SerializeField] float fallSpeed = -2.5f;
    Rigidbody rb;
    //[SerializeField] public float ballSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float xMov = Input.GetAxis("Horizontal");
        float zMov = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(xMov, fallSpeed, zMov) * speed;

        //float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        //float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        //transform.Translate(xValue, 0, zvalue);


    }
}
