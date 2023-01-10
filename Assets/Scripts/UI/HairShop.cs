using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HairShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneHair, mediumHair;

    private Button noneHairButton, mediumHairButton;
    private int noneHairID, mediumHairID;

    private void Awake()
    {
        // ShopID
        noneHairID = noneHair.GetComponent<ShopID>().shopID;
        mediumHairID = mediumHair.GetComponent<ShopID>().shopID;

        // Buttons
        noneHairButton = noneHair.GetComponent<Button>();
        mediumHairButton = mediumHair.GetComponent<Button>();

        // Buttons actions
        noneHairButton.onClick.AddListener(NoneHairSelected);
        mediumHairButton.onClick.AddListener(MediumHairSelected);
    }

    private void NoneHairSelected()
    {
        Wearables.instance.SetClothes("hair", noneHairID);
    }

    private void MediumHairSelected()
    {
        Wearables.instance.SetClothes("hair", mediumHairID);
    }
}
