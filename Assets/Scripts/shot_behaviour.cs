using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_behaviour : MonoBehaviour
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
        other.GetComponent<player_controller>().TakeDamage(damage);
    }
}
