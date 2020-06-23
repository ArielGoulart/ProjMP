using Cinemachine;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Photon.SpawnPlayer
{

    public class PlayerSpawner : MonoBehaviourPun
    {
        public static float teste;
        public float respawnTimer = 0f;
        public GameObject[] points;
        [SerializeField] private GameObject playerPref = null;
        [SerializeField] private CinemachineFreeLook PlayerCamera = null;

        private void Start()
        {
            //GameObject spawn = points[Random.Range(0, points.Length)];
            ////Vector3 position = spawn.transform.position;
            //var player = PhotonNetwork.Instantiate(playerPref.name, spawn.transform.position, Quaternion.identity);
            //PlayerCamera.Follow = player.transform;
            //PlayerCamera.LookAt = player.transform;
            Respawn();

        }
        private void Update()
        {
        }

        public void Respawn()
        {

            GameObject spawn = points[Random.Range(0, points.Length)];
            //Vector3 position = spawn.transform.position;
            var player = PhotonNetwork.Instantiate(playerPref.name, spawn.transform.position, Quaternion.identity);
            PlayerCamera.Follow = player.transform;
            PlayerCamera.LookAt = player.transform;
        }

        public Vector3 ChangePos()
        {
            GameObject spawn = points[Random.Range(0, points.Length)];
            Vector3 teste = spawn.transform.position;
            return teste;
        }
    }
}
