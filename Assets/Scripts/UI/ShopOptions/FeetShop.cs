using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeetShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneFeet, plateShoes;

    private Button noneFeetButton, plateShoesButton;
    private ShopID noneFeetID, plateShoesID;

    private void Awake()
    {
        // ShopID
        noneFeetID = noneFeet.GetComponent<ShopID>();
        plateShoesID = plateShoes.GetComponent<ShopID>();

        // Buttons
        noneFeetButton = noneFeet.GetComponent<Button>();
        plateShoesButton = plateShoes.GetComponent<Button>();

        // Buttons actions
        noneFeetButton.onClick.AddListener(NoneFeetSelected);
        plateShoesButton.onClick.AddListener(PlateShoesSelected);
    }

    private void NoneFeetSelected()
    {
        Wearables.instance.SetClothes("feet", noneFeetID.shopID);
        CurrencyManager.instance.purchasePrice = noneFeetID.shopPrice;
    }

    private void PlateShoesSelected()
    {
        Wearables.instance.SetClothes("feet", plateShoesID.shopID);
        CurrencyManager.instance.purchasePrice = plateShoesID.shopPrice;
    }
}
