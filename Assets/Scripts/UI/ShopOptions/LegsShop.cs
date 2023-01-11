using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LegsShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneLegs, greenPants, platePants, robeSkirt;

    [SerializeField]
    private TMP_Text legsText;

    [SerializeField]
    private Image noneLegsSelected, greenPantsSelected, platePantsSelected, robeSkirtSelected;
    private Color32 notSelected, selected;

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

        notSelected = new Color32(241, 238, 226, 255);
        selected = new Color32(255, 212, 0, 255);
    }

    private void OnDisable()
    {
        noneLegsSelected.color = notSelected;
        greenPantsSelected.color = notSelected;
        platePantsSelected.color = notSelected;
        robeSkirtSelected.color = notSelected;
        legsText.text = "0";
    }

    private void NoneLegsSelected()
    {
        Wearables.instance.SetClothes("legs", noneLegsID.shopID);
        CurrencyManager.instance.purchasePrice.Add(noneLegsID.shopPrice);
        legsText.text = noneLegsID.shopPrice.ToString();
        noneLegsSelected.color = selected;
        greenPantsSelected.color = notSelected;
        platePantsSelected.color = notSelected;
        robeSkirtSelected.color = notSelected;
    }

    private void GreenPantsSelected()
    {
        Wearables.instance.SetClothes("legs", greenPantsID.shopID);
        CurrencyManager.instance.purchasePrice.Add(greenPantsID.shopPrice);
        legsText.text = greenPantsID.shopPrice.ToString();
        noneLegsSelected.color = notSelected;
        greenPantsSelected.color = selected;
        platePantsSelected.color = notSelected;
        robeSkirtSelected.color = notSelected;
    }

    private void PlatePantsSelected()
    {
        Wearables.instance.SetClothes("legs", platePantsID.shopID);
        CurrencyManager.instance.purchasePrice.Add(platePantsID.shopPrice);
        legsText.text = platePantsID.shopPrice.ToString();
        noneLegsSelected.color = notSelected;
        greenPantsSelected.color = notSelected;
        platePantsSelected.color = selected;
        robeSkirtSelected.color = notSelected;
    }

    private void RobeSkirtSelected()
    {
        Wearables.instance.SetClothes("legs", robeSkirtID.shopID);
        CurrencyManager.instance.purchasePrice.Add(robeSkirtID.shopPrice);
        legsText.text = robeSkirtID.shopPrice.ToString();
        noneLegsSelected.color = notSelected;
        greenPantsSelected.color = notSelected;
        platePantsSelected.color = notSelected;
        robeSkirtSelected.color = selected;
    }
}
