using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FeetShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneFeet, plateShoes;

    [SerializeField]
    private TMP_Text feetText;

    [SerializeField]
    private Image noneFeetSelected, plateShoesSelected;
    private Color32 notSelected, selected;

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

        notSelected = new Color32(241, 238, 226, 255);
        selected = new Color32(255, 212, 0, 255);
    }

    private void OnDisable()
    {
        noneFeetSelected.color = notSelected;
        plateShoesSelected.color = notSelected;
        feetText.text = "0";
    }

    private void NoneFeetSelected()
    {
        Wearables.instance.SetClothes("feet", noneFeetID.shopID);
        CurrencyManager.instance.purchasePrice.Add(noneFeetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateShoesID.shopPrice);
        feetText.text = noneFeetID.shopPrice.ToString();
        noneFeetSelected.color = selected;
        plateShoesSelected.color = notSelected;
    }

    private void PlateShoesSelected()
    {
        Wearables.instance.SetClothes("feet", plateShoesID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneFeetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(plateShoesID.shopPrice);
        feetText.text = plateShoesID.shopPrice.ToString();
        noneFeetSelected.color = notSelected;
        plateShoesSelected.color = selected;
    }
}
