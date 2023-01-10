using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandsShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHands, leatherBracers, plateGloves;

    private Button noneHandsButton, leatherBracersButton, plateGlovesButton;
    private int noneHandsID, leatherBracersID, plateGlovesID;

    private void Awake()
    {
        // ShopID
        noneHandsID = noneHands.GetComponent<ShopID>().shopID;
        leatherBracersID = leatherBracers.GetComponent<ShopID>().shopID;
        plateGlovesID = plateGloves.GetComponent<ShopID>().shopID;

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
        Wearables.instance.SetClothes("hands", noneHandsID);
    }

    private void LeatherBracersSelected()
    {
        Wearables.instance.SetClothes("hands", leatherBracersID);
    }

    private void PlateGlovesSelected()
    {
        Wearables.instance.SetClothes("hands", plateGlovesID);
    }
}
