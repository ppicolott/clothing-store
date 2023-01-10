using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHead, chainHelmet, chainHood, leatherHat, plateHelmet, robeHood;

    private Button noneHeadButton, chainHelmetButton, chainHoodButton, leatherHatButton, plateHelmetButton, robeHoodButton;
    private int noneHeadID, chainHelmetID, chainHoodID, leatherHatID, plateHelmetID, robeHoodID;

    private void Awake()
    {
        // ShopID
        noneHeadID = noneHead.GetComponent<ShopID>().shopID;
        chainHelmetID = chainHelmet.GetComponent<ShopID>().shopID;
        chainHoodID = chainHood.GetComponent<ShopID>().shopID;
        leatherHatID = leatherHat.GetComponent<ShopID>().shopID;
        plateHelmetID = plateHelmet.GetComponent<ShopID>().shopID;
        robeHoodID = robeHood.GetComponent<ShopID>().shopID;

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
        Wearables.instance.SetClothes("head", noneHeadID);
    }

    private void ChainHelmetSelected()
    {
        Wearables.instance.SetClothes("head", chainHelmetID);
    }

    private void ChainHoodSelected()
    {
        Wearables.instance.SetClothes("head", chainHoodID);
    }

    private void LeatherHatSelected()
    {
        Wearables.instance.SetClothes("head", leatherHatID);
    }

    private void PlateHelmetSelected()
    {
        Wearables.instance.SetClothes("head", plateHelmetID);
    }

    private void RobeHoodSelected()
    {
        Wearables.instance.SetClothes("head", robeHoodID);
    }
}
