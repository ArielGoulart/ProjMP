using Photon.Pun;
using Photon.SpawnPlayer;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player_controller : MonoBehaviourPun
{
    // Start is called before the first frame update
    private ScriptableObject teste;
    private GameObject test;
    public Image healthBar;

    public float max_health = 100f;
    public float cur_health = 0f;
    void Start()
    {
        cur_health = max_health;
        healthBar.fillAmount = cur_health / max_health;
        test = GameObject.FindGameObjectWithTag("Respawn");   
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cur_health < 0)
        {
           Die();
        }
    healthBar.fillAmount = cur_health / max_health;

    }

    public void TakeDamage (float damage)
    {
        cur_health -= damage;
    }

    [PunRPC]
    void Die()
    {
        
        //PhotonNetwork.Destroy(gameObject);
       // Destroy(gameObject);
        cur_health = 100;
        transform. position = test.GetComponent<PlayerSpawner>().ChangePos();
    }
}
