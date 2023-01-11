using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HandsShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHands, leatherBracers, plateGloves;

    [SerializeField]
    private TMP_Text handsText;

    [SerializeField]
    private Image noneHandsSelected, leatherBracersSelected, plateGlovesSelected;
    private Color32 notSelected, selected;

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

        notSelected = new Color32(241, 238, 226, 255);
        selected = new Color32(255, 212, 0, 255);
    }

    private void OnDisable()
    {
        noneHandsSelected.color = notSelected;
        leatherBracersSelected.color = notSelected;
        plateGlovesSelected.color = notSelected;
        handsText.text = "0";
    }

    private void NoneHandsSelected()
    {
        Wearables.instance.SetClothes("hands", noneHandsID.shopID);
        CurrencyManager.instance.purchasePrice.Add(noneHandsID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherBracersID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateGlovesID.shopPrice);
        handsText.text = noneHandsID.shopPrice.ToString();
        noneHandsSelected.color = selected;
        leatherBracersSelected.color = notSelected;
        plateGlovesSelected.color = notSelected;
    }

    private void LeatherBracersSelected()
    {
        Wearables.instance.SetClothes("hands", leatherBracersID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHandsID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(leatherBracersID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateGlovesID.shopPrice);
        handsText.text = leatherBracersID.shopPrice.ToString();
        noneHandsSelected.color = notSelected;
        leatherBracersSelected.color = selected;
        plateGlovesSelected.color = notSelected;
    }

    private void PlateGlovesSelected()
    {
        Wearables.instance.SetClothes("hands", plateGlovesID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHandsID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherBracersID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(plateGlovesID.shopPrice);
        handsText.text = plateGlovesID.shopPrice.ToString();
        noneHandsSelected.color = notSelected;
        leatherBracersSelected.color = notSelected;
        plateGlovesSelected.color = selected;
    }
}
