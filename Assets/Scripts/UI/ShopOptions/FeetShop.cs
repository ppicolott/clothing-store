using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegsShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneLegs, greenPants, platePants, robeSkirt;

    private Button noneLegsButton, greenPantsButton, platePantsButton, robeSkirtButton;
    private int noneLegsID, greenPantsID, platePantsID, robeSkirtID;

    private void Awake()
    {
        // ShopID
        noneLegsID = noneLegs.GetComponent<ShopID>().shopID;
        greenPantsID = greenPants.GetComponent<ShopID>().shopID;
        platePantsID = platePants.GetComponent<ShopID>().shopID;
        robeSkirtID = robeSkirt.GetComponent<ShopID>().shopID;

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
        Wearables.instance.SetClothes("legs", noneLegsID);
    }

    private void GreenPantsSelected()
    {
        Wearables.instance.SetClothes("legs", greenPantsID);
    }

    private void PlatePantsSelected()
    {
        Wearables.instance.SetClothes("legs", platePantsID);
    }

    private void RobeSkirtSelected()
    {
        Wearables.instance.SetClothes("legs", robeSkirtID);
    }
}
