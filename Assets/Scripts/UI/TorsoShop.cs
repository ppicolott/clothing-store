using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorsoShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneTorso, chainJacket, chainMail, leatherShirt, LeatherJacket, plateMail, robeShirt;

    private Button noneTorsoButton, chainJacketButton, chainMailButton, leatherShirtButton, leatherJacketButton, plateMailButton, robeShirtButton;
    private int noneTorsoID, chainJacketID, chainMailID, leatherShirtID, leatherJacketID, plateMailID, robeShirtID;

    private void Awake()
    {
        // ShopID
        noneTorsoID = noneTorso.GetComponent<ShopID>().shopID;
        chainJacketID = chainJacket.GetComponent<ShopID>().shopID;
        chainMailID = chainMail.GetComponent<ShopID>().shopID;
        leatherShirtID = leatherShirt.GetComponent<ShopID>().shopID;
        leatherJacketID = LeatherJacket.GetComponent<ShopID>().shopID;
        plateMailID = plateMail.GetComponent<ShopID>().shopID;
        robeShirtID = robeShirt.GetComponent<ShopID>().shopID;

        // Buttons
        noneTorsoButton = noneTorso.GetComponent<Button>();
        chainJacketButton = chainJacket.GetComponent<Button>();
        chainMailButton = chainMail.GetComponent<Button>();
        leatherShirtButton = leatherShirt.GetComponent<Button>();
        leatherJacketButton = LeatherJacket.GetComponent<Button>();
        plateMailButton = plateMail.GetComponent<Button>();
        robeShirtButton = robeShirt.GetComponent<Button>();

        // Buttons actions
        noneTorsoButton.onClick.AddListener(NoneTorsoSelected);
        chainJacketButton.onClick.AddListener(ChainJacketSelected);
        chainMailButton.onClick.AddListener(ChainMailSelected);
        leatherShirtButton.onClick.AddListener(LeatherShirtSelected);
        leatherJacketButton.onClick.AddListener(LeatherJacketSelected);
        plateMailButton.onClick.AddListener(PlateMailSelected);
        robeShirtButton.onClick.AddListener(RobeShirtSelected);
    }

    private void NoneTorsoSelected()
    {
        Wearables.instance.SetClothes("torso", noneTorsoID);
    }

    private void ChainJacketSelected()
    {
        Wearables.instance.SetClothes("torso", chainJacketID);
    }

    private void ChainMailSelected()
    {
        Wearables.instance.SetClothes("torso", chainMailID);
    }

    private void LeatherShirtSelected()
    {
        Wearables.instance.SetClothes("torso", leatherShirtID);
    }

    private void LeatherJacketSelected()
    {
        Wearables.instance.SetClothes("torso", leatherJacketID);
    }

    private void PlateMailSelected()
    {
        Wearables.instance.SetClothes("torso", plateMailID);
    }

    private void RobeShirtSelected()
    {
        Wearables.instance.SetClothes("torso", robeShirtID);
    }
}
