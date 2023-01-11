using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HeadShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHead, chainHelmet, chainHood, leatherHat, plateHelmet, robeHood;

    [SerializeField]
    private TMP_Text headText;

    [SerializeField]
    private Image noneHeadSelected, chainHelmetSelected, chainHoodSelected, leatherHatSelected, plateHelmetSelected, robeHoodSelected;
    private Color32 notSelected, selected;

    private Button noneHeadButton, chainHelmetButton, chainHoodButton, leatherHatButton, plateHelmetButton, robeHoodButton;
    private ShopID noneHeadID, chainHelmetID, chainHoodID, leatherHatID, plateHelmetID, robeHoodID;

    private void Awake()
    {
        // ShopID
        noneHeadID = noneHead.GetComponent<ShopID>();
        chainHelmetID = chainHelmet.GetComponent<ShopID>();
        chainHoodID = chainHood.GetComponent<ShopID>();
        leatherHatID = leatherHat.GetComponent<ShopID>();
        plateHelmetID = plateHelmet.GetComponent<ShopID>();
        robeHoodID = robeHood.GetComponent<ShopID>();

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

        notSelected = new Color32(241, 238, 226, 255);
        selected = new Color32(255, 212, 0, 255);
    }

    private void OnDisable()
    {
        noneHeadSelected.color = notSelected;
        chainHelmetSelected.color = notSelected;
        chainHoodSelected.color = notSelected;
        leatherHatSelected.color = notSelected;
        plateHelmetSelected.color = notSelected;
        robeHoodSelected.color = notSelected;
        headText.text = "0";
    }

    private void NoneHeadSelected()
    {
        Wearables.instance.SetClothes("head", noneHeadID.shopID);
        CurrencyManager.instance.purchasePrice.Add(noneHeadID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHoodID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherHatID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeHoodID.shopPrice);
        headText.text = noneHeadID.shopPrice.ToString();
        noneHeadSelected.color = selected;
        chainHelmetSelected.color = notSelected;
        chainHoodSelected.color = notSelected;
        leatherHatSelected.color = notSelected;
        plateHelmetSelected.color = notSelected;
        robeHoodSelected.color = notSelected;
    }

    private void ChainHelmetSelected()
    {
        Wearables.instance.SetClothes("head", chainHelmetID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHeadID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(chainHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHoodID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherHatID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeHoodID.shopPrice);
        headText.text = chainHelmetID.shopPrice.ToString();
        noneHeadSelected.color = notSelected;
        chainHelmetSelected.color = selected;
        chainHoodSelected.color = notSelected;
        leatherHatSelected.color = notSelected;
        plateHelmetSelected.color = notSelected;
        robeHoodSelected.color = notSelected;
    }

    private void ChainHoodSelected()
    {
        Wearables.instance.SetClothes("head", chainHoodID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHeadID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(chainHoodID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherHatID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeHoodID.shopPrice);
        headText.text = chainHoodID.shopPrice.ToString();
        noneHeadSelected.color = notSelected;
        chainHelmetSelected.color = notSelected;
        chainHoodSelected.color = selected;
        leatherHatSelected.color = notSelected;
        plateHelmetSelected.color = notSelected;
        robeHoodSelected.color = notSelected;
    }

    private void LeatherHatSelected()
    {
        Wearables.instance.SetClothes("head", leatherHatID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHeadID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHoodID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(leatherHatID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeHoodID.shopPrice);
        headText.text = leatherHatID.shopPrice.ToString();
        noneHeadSelected.color = notSelected;
        chainHelmetSelected.color = notSelected;
        chainHoodSelected.color = notSelected;
        leatherHatSelected.color = selected;
        plateHelmetSelected.color = notSelected;
        robeHoodSelected.color = notSelected;
    }

    private void PlateHelmetSelected()
    {
        Wearables.instance.SetClothes("head", plateHelmetID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHeadID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHoodID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherHatID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(plateHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeHoodID.shopPrice);
        headText.text = plateHelmetID.shopPrice.ToString();
        noneHeadSelected.color = notSelected;
        chainHelmetSelected.color = notSelected;
        chainHoodSelected.color = notSelected;
        leatherHatSelected.color = notSelected;
        plateHelmetSelected.color = selected;
        robeHoodSelected.color = notSelected;
    }

    private void RobeHoodSelected()
    {
        Wearables.instance.SetClothes("head", robeHoodID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneHeadID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainHoodID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherHatID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateHelmetID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(robeHoodID.shopPrice);
        headText.text = robeHoodID.shopPrice.ToString();
        noneHeadSelected.color = notSelected;
        chainHelmetSelected.color = notSelected;
        chainHoodSelected.color = notSelected;
        leatherHatSelected.color = notSelected;
        plateHelmetSelected.color = notSelected;
        robeHoodSelected.color = selected;
    }
}
