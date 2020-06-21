using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class shot_behaviour : MonoBehaviourPun
{
    public float speed;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Dano(other);
    }

    [PunRPC]
    public void Dano(Collider target)
    {
       
        target.GetComponent<player_controller>().TakeDamage(damage);

        Destroy(gameObject);

    }
}
