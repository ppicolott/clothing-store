using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegsShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneLegs, greenPants, platePants, robeSkirt;

    private Button noneLegsButton, greenPantsButton, platePantsButton, robeSkirtButton;
    private ShopID noneLegsID, greenPantsID, platePantsID, robeSkirtID;

    private void Awake()
    {
        // ShopID
        noneLegsID = noneLegs.GetComponent<ShopID>();
        greenPantsID = greenPants.GetComponent<ShopID>();
        platePantsID = platePants.GetComponent<ShopID>();
        robeSkirtID = robeSkirt.GetComponent<ShopID>();

        // Buttons
        noneLegsButton = noneLegs.GetComponent<Button>();
        greenPantsButton = greenPants.GetComponent<Button>();
        platePantsButton = platePants.GetComponent<Button>();
        robeSkirtButton = robeSkirt.GetComponent<Button>();

        // Buttons actions
        noneLegsButton.onClick.AddListener(NoneLegsSelected);
        greenPantsButton.onClick.AddListener(GreenPantsSelected);
        platePantsButton.onClick.AddListener(PlatePantsSelected);
        robeSkirtButton.onClick.AddListener(RobeSkirtSelected);
    }

    private void NoneLegsSelected()
    {
        Wearables.instance.SetClothes("legs", noneLegsID.shopID);
        CurrencyManager.instance.purchasePrice = noneLegsID.shopPrice;
    }

    private void GreenPantsSelected()
    {
        Wearables.instance.SetClothes("legs", greenPantsID.shopID);
        CurrencyManager.instance.purchasePrice = greenPantsID.shopPrice;
    }

    private void PlatePantsSelected()
    {
        Wearables.instance.SetClothes("legs", platePantsID.shopID);
        CurrencyManager.instance.purchasePrice = platePantsID.shopPrice;
    }

    private void RobeSkirtSelected()
    {
        Wearables.instance.SetClothes("legs", robeSkirtID.shopID);
        CurrencyManager.instance.purchasePrice = robeSkirtID.shopPrice;
    }
}
