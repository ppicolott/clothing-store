using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorsoShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneTorso, chainJacket, chainMail, leatherShirt, LeatherJacket, plateMail, robeShirt;

    private Button noneTorsoButton, chainJacketButton, chainMailButton, leatherShirtButton, leatherJacketButton, plateMailButton, robeShirtButton;
    private ShopID noneTorsoID, chainJacketID, chainMailID, leatherShirtID, leatherJacketID, plateMailID, robeShirtID;

    private void Awake()
    {
        // ShopID
        noneTorsoID = noneTorso.GetComponent<ShopID>();
        chainJacketID = chainJacket.GetComponent<ShopID>();
        chainMailID = chainMail.GetComponent<ShopID>();
        leatherShirtID = leatherShirt.GetComponent<ShopID>();
        leatherJacketID = LeatherJacket.GetComponent<ShopID>();
        plateMailID = plateMail.GetComponent<ShopID>();
        robeShirtID = robeShirt.GetComponent<ShopID>();

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
        Wearables.instance.SetClothes("torso", noneTorsoID.shopID);
        CurrencyManager.instance.purchasePrice = noneTorsoID.shopPrice;
    }

    private void ChainJacketSelected()
    {
        Wearables.instance.SetClothes("torso", chainJacketID.shopID);
        CurrencyManager.instance.purchasePrice = chainJacketID.shopPrice;
    }

    private void ChainMailSelected()
    {
        Wearables.instance.SetClothes("torso", chainMailID.shopID);
        CurrencyManager.instance.purchasePrice = chainMailID.shopPrice;
    }

    private void LeatherShirtSelected()
    {
        Wearables.instance.SetClothes("torso", leatherShirtID.shopID);
        CurrencyManager.instance.purchasePrice = leatherShirtID.shopPrice;
    }

    private void LeatherJacketSelected()
    {
        Wearables.instance.SetClothes("torso", leatherJacketID.shopID);
        CurrencyManager.instance.purchasePrice = leatherJacketID.shopPrice;
    }

    private void PlateMailSelected()
    {
        Wearables.instance.SetClothes("torso", plateMailID.shopID);
        CurrencyManager.instance.purchasePrice = plateMailID.shopPrice;
    }

    private void RobeShirtSelected()
    {
        Wearables.instance.SetClothes("torso", robeShirtID.shopID);
        CurrencyManager.instance.purchasePrice = robeShirtID.shopPrice;
    }
}
