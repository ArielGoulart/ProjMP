using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Photon.Shot
{

    public class player_shot : MonoBehaviourPun
    {
        [SerializeField] private GameObject shot;
        [SerializeField] private GameObject mine;
        [SerializeField] private GameObject player;
        [SerializeField] private Transform aux_mine;
        [SerializeField] private Transform aux_shot;
        public AudioClip torpedo_shot;
        public AudioClip deploy_mine;
        AudioSource audioSource;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (photonView.IsMine)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Fire();
                    audioSource.PlayOneShot(torpedo_shot, 0.0f);

                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    FireMine();
                    audioSource.PlayOneShot(deploy_mine, 0.0f);
                }
            }

        }

        private void Fire()
        {
            PhotonNetwork.Instantiate(shot.name, aux_shot.transform.position, player.transform.rotation);
        }

        private void FireMine()
        {
            PhotonNetwork.Instantiate(mine.name, aux_mine.transform.position, player.transform.rotation);
        }
    }
}
