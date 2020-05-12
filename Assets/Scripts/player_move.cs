using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float speed;
    public float turn_speed;
   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up,-turn_speed * Time.deltaTime);
            }
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up, turn_speed * Time.deltaTime);
            }
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0,-speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up, -turn_speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up, turn_speed * Time.deltaTime);
            }
        }
    }
}
