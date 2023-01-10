using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BttnTest : MonoBehaviour
{
    [SerializeField]
    private Button firstBttn, sndBttn;

    private void Awake()
    {
        firstBttn.onClick.AddListener(ChainMailSelected);
        sndBttn.onClick.AddListener(LeatherShirtSelected);
    }

    // Check player money and product cost

    private void ChainMailSelected()
    {
        FittingRoom.instance.SetTorso(true, false, false, false, false, false);
    }

    private void LeatherShirtSelected()
    {
        FittingRoom.instance.SetTorso(false, true, false, false, false, false);
    }
}
