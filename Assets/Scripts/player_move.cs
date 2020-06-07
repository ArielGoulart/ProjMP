
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace photon.movement
{

    public class player_move : MonoBehaviourPun
    {
        [SerializeField] private float speed;
        [SerializeField] private float turn_speed;
        [SerializeField] private float acceleration;

        void Update()
        {
            if (photonView.IsMine)
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                {
                    if (acceleration < speed)
                    {
                        acceleration += 0.1f;
                    }
                    transform.Translate(0, 0, acceleration * Time.deltaTime);
                    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    {
                        transform.Rotate(Vector3.up, -turn_speed * Time.deltaTime);
                    }
                    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    {
                        transform.Rotate(Vector3.up, turn_speed * Time.deltaTime);
                    }
                }
                else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                {
                    if (acceleration > -speed)
                    {
                        acceleration -= 0.1f;
                    }
                    transform.Translate(0, 0, acceleration * Time.deltaTime);
                    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    {
                        transform.Rotate(Vector3.up, -turn_speed * Time.deltaTime);
                    }
                    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    {
                        transform.Rotate(Vector3.up, turn_speed * Time.deltaTime);
                    }
                }
                else
                {
                    if (acceleration > 0)
                    {
                        acceleration -= 0.1f;
                        transform.Translate(0, 0, acceleration * Time.deltaTime);
                        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                        {
                            transform.Rotate(Vector3.up, -turn_speed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                        {
                            transform.Rotate(Vector3.up, turn_speed * Time.deltaTime);
                        }
                    }
                    if (acceleration < 0)
                    {
                        acceleration += 0.1f;
                        transform.Translate(0, 0, acceleration * Time.deltaTime);
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
        }
    }
}
