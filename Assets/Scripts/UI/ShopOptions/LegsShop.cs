using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeetShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneFeet, plateShoes;

    private Button noneFeetButton, plateShoesButton;
    private int noneFeetID, plateShoesID;

    private void Awake()
    {
        // ShopID
        noneFeetID = noneFeet.GetComponent<ShopID>().shopID;
        plateShoesID = plateShoes.GetComponent<ShopID>().shopID;

        // Buttons
        noneFeetButton = noneFeet.GetComponent<Button>();
        plateShoesButton = plateShoes.GetComponent<Button>();

        // Buttons actions
        noneFeetButton.onClick.AddListener(NoneFeetSelected);
        plateShoesButton.onClick.AddListener(PlateShoesSelected);
    }

    private void NoneFeetSelected()
    {
        Wearables.instance.SetClothes("feet", noneFeetID);
    }

    private void PlateShoesSelected()
    {
        Wearables.instance.SetClothes("feet", plateShoesID);
    }
}
