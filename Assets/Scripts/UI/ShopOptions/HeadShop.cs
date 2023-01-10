using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHead, chainHelmet, chainHood, leatherHat, plateHelmet, robeHood;

    private Button noneHeadButton, chainHelmetButton, chainHoodButton, leatherHatButton, plateHelmetButton, robeHoodButton;
    private ShopID noneHeadID, chainHelmetID, chainHoodID, leatherHatID, plateHelmetID, robeHoodID;

    private void Awake()
    {
        // ShopID
        noneHeadID = noneHead.GetComponent<ShopID>();
        chainHelmetID = chainHelmet.GetComponent<ShopID>();
        chainHoodID = chainHood.GetComponent<ShopID>();
        leatherHatID = leatherHat.GetComponent<ShopID>();
        plateHelmetID = plateHelmet.GetComponent<ShopID>();
        robeHoodID = robeHood.GetComponent<ShopID>();

        // Buttons
        noneHeadButton = noneHead.GetComponent<Button>();
        chainHelmetButton = chainHelmet.GetComponent<Button>();
        chainHoodButton = chainHood.GetComponent<Button>();
        leatherHatButton = leatherHat.GetComponent<Button>();
        plateHelmetButton = plateHelmet.GetComponent<Button>();
        robeHoodButton = robeHood.GetComponent<Button>();

        // Buttons actions
        noneHeadButton.onClick.AddListener(NoneHeadSelected);
        chainHelmetButton.onClick.AddListener(ChainHelmetSelected);
        chainHoodButton.onClick.AddListener(ChainHoodSelected);
        leatherHatButton.onClick.AddListener(LeatherHatSelected);
        plateHelmetButton.onClick.AddListener(PlateHelmetSelected);
        robeHoodButton.onClick.AddListener(RobeHoodSelected);
    }

    private void NoneHeadSelected()
    {
        Wearables.instance.SetClothes("head", noneHeadID.shopID);
        CurrencyManager.instance.purchasePrice = noneHeadID.shopPrice;
    }

    private void ChainHelmetSelected()
    {
        Wearables.instance.SetClothes("head", chainHelmetID.shopID);
        CurrencyManager.instance.purchasePrice = chainHelmetID.shopPrice;
    }

    private void ChainHoodSelected()
    {
        Wearables.instance.SetClothes("head", chainHoodID.shopID);
        CurrencyManager.instance.purchasePrice = chainHoodID.shopPrice;
    }

    private void LeatherHatSelected()
    {
        Wearables.instance.SetClothes("head", leatherHatID.shopID);
        CurrencyManager.instance.purchasePrice = leatherHatID.shopPrice;
    }

    private void PlateHelmetSelected()
    {
        Wearables.instance.SetClothes("head", plateHelmetID.shopID);
        CurrencyManager.instance.purchasePrice = plateHelmetID.shopPrice;
    }

    private void RobeHoodSelected()
    {
        Wearables.instance.SetClothes("head", robeHoodID.shopID);
        CurrencyManager.instance.purchasePrice = robeHoodID.shopPrice;
    }
}
