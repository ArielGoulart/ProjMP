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
        var player = PhotonNetwork.Instantiate(playerPref.name , Vector3.zero, Quaternion.identity);
            PlayerCamera.Follow = player.transform;
            PlayerCamera.LookAt = player.transform;
          
        }
}
}
