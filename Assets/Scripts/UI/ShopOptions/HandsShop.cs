using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandsShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHands, leatherBracers, plateGloves;

    private Button noneHandsButton, leatherBracersButton, plateGlovesButton;
    private ShopID noneHandsID, leatherBracersID, plateGlovesID;

    private void Awake()
    {
        // ShopID
        noneHandsID = noneHands.GetComponent<ShopID>();
        leatherBracersID = leatherBracers.GetComponent<ShopID>();
        plateGlovesID = plateGloves.GetComponent<ShopID>();

        // Buttons
        noneHandsButton = noneHands.GetComponent<Button>();
        leatherBracersButton = leatherBracers.GetComponent<Button>();
        plateGlovesButton = plateGloves.GetComponent<Button>();

        // Buttons actions
        noneHandsButton.onClick.AddListener(NoneHandsSelected);
        leatherBracersButton.onClick.AddListener(LeatherBracersSelected);
        plateGlovesButton.onClick.AddListener(PlateGlovesSelected);
    }

    private void NoneHandsSelected()
    {
        Wearables.instance.SetClothes("hands", noneHandsID.shopID);
        CurrencyManager.instance.purchasePrice = noneHandsID.shopPrice;
    }

    private void LeatherBracersSelected()
    {
        Wearables.instance.SetClothes("hands", leatherBracersID.shopID);
        CurrencyManager.instance.purchasePrice = leatherBracersID.shopPrice;
    }

    private void PlateGlovesSelected()
    {
        Wearables.instance.SetClothes("hands", plateGlovesID.shopID);
        CurrencyManager.instance.purchasePrice = plateGlovesID.shopPrice;
    }
}
