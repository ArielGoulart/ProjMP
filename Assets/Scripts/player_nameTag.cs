using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace photon.nametag
{

public class player_nameTag : MonoBehaviourPun
{
        [SerializeField] private TextMeshProUGUI NameTextTag;


    // Start is called before the first frame update
    void Start()
    {
            if (photonView.IsMine) { return; }

            SetName();
    }

        private void SetName()
        {
            NameTextTag.text = photonView.Owner.NickName;
        }


}
}
