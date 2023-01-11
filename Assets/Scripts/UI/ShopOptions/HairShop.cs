using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HairShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHair, mediumHair;

    [SerializeField]
    private TMP_Text hairText;

    [SerializeField]
    private Image noneHairSelected, mediumHairSelected;
    private Color32 notSelected, selected;

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

        notSelected = new Color32(241, 238, 226, 255);
        selected = new Color32(255, 212, 0, 255);
    }

    private void OnDisable()
    {
        noneHairSelected.color = notSelected;
        mediumHairSelected.color = notSelected;
        hairText.text = "0";
    }

    private void NoneHairSelected()
    {
        Wearables.instance.SetClothes("hair", noneHairID.shopID);
        CurrencyManager.instance.purchasePrice.Add(noneHairID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(mediumHairID.shopPrice);
        hairText.text = noneHairID.shopPrice.ToString();
        noneHairSelected.color = selected;
        mediumHairSelected.color = notSelected;
    }

    private void MediumHairSelected()
    {
        Wearables.instance.SetClothes("hair", mediumHairID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHairID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(mediumHairID.shopPrice);
        hairText.text = mediumHairID.shopPrice.ToString();
        noneHairSelected.color = notSelected;
        mediumHairSelected.color = selected;
    }
}
