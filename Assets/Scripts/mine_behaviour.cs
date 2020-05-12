using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine_behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<player_controller>().TakeDamage(damage);
    }
}
