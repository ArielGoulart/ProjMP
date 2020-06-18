using Cinemachine;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Photon.SpawnPlayer
{

public class PlayerSpawner : MonoBehaviour
{

        [SerializeField] private GameObject playerPref = null;
        [SerializeField] private CinemachineFreeLook PlayerCamera = null;

        private void Start()
        {
            Vector3 position = new Vector3(Random.Range(-100f, 100f), 0, Random.Range(-100f, 100));
        var player = PhotonNetwork.Instantiate(playerPref.name , position, Quaternion.identity);
            PlayerCamera.Follow = player.transform;
            PlayerCamera.LookAt = player.transform;
          
        }
}
}
