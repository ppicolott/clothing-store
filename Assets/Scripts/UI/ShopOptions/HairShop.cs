using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HairShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHair, mediumHair;

    private Button noneHairButton, mediumHairButton;
    private ShopID noneHairID, mediumHairID;

    private void Awake()
    {
        // ShopID
        noneHairID = noneHair.GetComponent<ShopID>();
        mediumHairID = mediumHair.GetComponent<ShopID>();

        // Buttons
        noneHairButton = noneHair.GetComponent<Button>();
        mediumHairButton = mediumHair.GetComponent<Button>();

        // Buttons actions
        noneHairButton.onClick.AddListener(NoneHairSelected);
        mediumHairButton.onClick.AddListener(MediumHairSelected);
    }

    private void NoneHairSelected()
    {
        Wearables.instance.SetClothes("hair", noneHairID.shopID);
        CurrencyManager.instance.purchasePrice = noneHairID.shopPrice;
    }

    private void MediumHairSelected()
    {
        Wearables.instance.SetClothes("hair", mediumHairID.shopID);
        CurrencyManager.instance.purchasePrice = mediumHairID.shopPrice;
    }
}
