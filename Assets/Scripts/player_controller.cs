using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public float max_health = 100f;
    public float cur_health = 0f;
    void Start()
    {
        cur_health = max_health;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (float damage)
    {
        cur_health -= damage;
    }
}
