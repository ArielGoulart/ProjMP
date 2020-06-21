using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class mine_behaviour : MonoBehaviourPun
{
    // Start is called before the first frame update
    public float damage;

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
