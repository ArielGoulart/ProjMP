using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player_controller : MonoBehaviourPun
{
    // Start is called before the first frame update
    private ScriptableObject teste;
    public float max_health = 100f;
    public float cur_health = 0f;
    void Start()
    {
    
        cur_health = max_health;   
    }

    // Update is called once per frame
    void Update()
    {
        if(cur_health <= 0)
        {
           Die();
        }
    }

    public void TakeDamage (float damage)
    {
        cur_health -= damage;
    }

    [PunRPC]
    void Die()
    {
        PhotonNetwork.Destroy(gameObject);
    }
}
