using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Photon.Menu
{
    public class Main_Menu : MonoBehaviourPunCallbacks
    {
        [SerializeField] private GameObject findOpponentPanel = null;
        [SerializeField] private GameObject waitingStatusPanel = null;
        [SerializeField] private TextMeshProUGUI waitingStatusText = null;

        private bool isConnecting = false;
        private const string GameVersion = "0.2";
        private const int MaxPlayerPerRoom = 2;

        private void Awake() => PhotonNetwork.AutomaticallySyncScene = true;

        public void FindOpponent()
        {
            isConnecting = true;
            findOpponentPanel.SetActive(false);
            waitingStatusPanel.SetActive(true);
            waitingStatusText.text = "Procurando partida...";

            if (PhotonNetwork.IsConnected)
            {
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                PhotonNetwork.GameVersion = GameVersion;
                PhotonNetwork.ConnectUsingSettings();
            }

        }

        public override void OnConnectedToMaster()
        {
            Debug.Log("Connected to Master");

            if (isConnecting)
            {
                PhotonNetwork.JoinRandomRoom();
            }
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            waitingStatusPanel.SetActive(false);
            findOpponentPanel.SetActive(true);
            Debug.Log($"Disconnected due to: {cause}");
        }
        public override void OnJoinRandomFailed(short returnCode, string message)
        {
            Debug.Log("No Clients are waiting for an opponent, creating a new room");
            PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = MaxPlayerPerRoom });
        }
        public override void OnJoinedRoom()
        {
            Debug.Log("client successfully joined a room");
            int playerCount = PhotonNetwork.CurrentRoom.PlayerCount;
            if(playerCount != MaxPlayerPerRoom)
            {
                waitingStatusText.text = "Esperando oponente...";
                Debug.Log("client is waiting for an opponent");
            }
            else
            {
                waitingStatusText.text = "Oponente encontrado!";
                Debug.Log("matching is ready to begin");
            }
        }
        public override void OnPlayerEnteredRoom(Player newPlayer)
        {
            if(PhotonNetwork.CurrentRoom.PlayerCount == MaxPlayerPerRoom)
            {
                PhotonNetwork.CurrentRoom.IsOpen = false;
                waitingStatusText.text = "Oponente encontrado!";
                Debug.Log(" match is ready to begin");

                PhotonNetwork.LoadLevel("Arena01");
            }
        }
    }

}
