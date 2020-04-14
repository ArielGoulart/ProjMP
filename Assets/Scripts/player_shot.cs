using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shot : MonoBehaviour
{
    public GameObject shot;
    public GameObject mine;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shot, player.transform.position, player.transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(mine, player.transform.position, player.transform.rotation);
        }
    }
}
