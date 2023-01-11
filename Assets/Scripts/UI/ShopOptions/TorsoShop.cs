using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TorsoShop : MonoBehaviour
{
    [SerializeField]
    private GameObject noneTorso, chainJacket, chainMail, leatherShirt, leatherJacket, plateMail, robeShirt;

    [SerializeField]
    private TMP_Text torsoText;

    [SerializeField]
    private Image noneTorsoSelected, chainJacketSelected, chainMailSelected, leatherShirtSelected, leatherJacketSelected, plateMailSelected, robeShirtSelected;
    private Color32 notSelected, selected;

    private Button noneTorsoButton, chainJacketButton, chainMailButton, leatherShirtButton, leatherJacketButton, plateMailButton, robeShirtButton;
    private ShopID noneTorsoID, chainJacketID, chainMailID, leatherShirtID, leatherJacketID, plateMailID, robeShirtID;

    private void Awake()
    {
        // ShopID
        noneTorsoID = noneTorso.GetComponent<ShopID>();
        chainJacketID = chainJacket.GetComponent<ShopID>();
        chainMailID = chainMail.GetComponent<ShopID>();
        leatherShirtID = leatherShirt.GetComponent<ShopID>();
        leatherJacketID = leatherJacket.GetComponent<ShopID>();
        plateMailID = plateMail.GetComponent<ShopID>();
        robeShirtID = robeShirt.GetComponent<ShopID>();

        // Buttons
        noneTorsoButton = noneTorso.GetComponent<Button>();
        chainJacketButton = chainJacket.GetComponent<Button>();
        chainMailButton = chainMail.GetComponent<Button>();
        leatherShirtButton = leatherShirt.GetComponent<Button>();
        leatherJacketButton = leatherJacket.GetComponent<Button>();
        plateMailButton = plateMail.GetComponent<Button>();
        robeShirtButton = robeShirt.GetComponent<Button>();

        // Buttons actions
        noneTorsoButton.onClick.AddListener(NoneTorsoSelected);
        chainJacketButton.onClick.AddListener(ChainJacketSelected);
        chainMailButton.onClick.AddListener(ChainMailSelected);
        leatherShirtButton.onClick.AddListener(LeatherShirtSelected);
        leatherJacketButton.onClick.AddListener(LeatherJacketSelected);
        plateMailButton.onClick.AddListener(PlateMailSelected);
        robeShirtButton.onClick.AddListener(RobeShirtSelected);

        notSelected = new Color32(241, 238, 226, 255);
        selected = new Color32(255, 212, 0, 255);
    }

    private void OnDisable()
    {
        noneTorsoSelected.color = notSelected;
        chainJacketSelected.color = notSelected;
        chainMailSelected.color = notSelected;
        leatherShirtSelected.color = notSelected;
        leatherJacketSelected.color = notSelected;
        plateMailSelected.color = notSelected;
        robeShirtSelected.color = notSelected;
        torsoText.text = "0";
    }

    private void NoneTorsoSelected()
    {
        Wearables.instance.SetClothes("torso", noneTorsoID.shopID);
        CurrencyManager.instance.purchasePrice.Add(noneTorsoID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherShirtID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeShirtID.shopPrice);
        torsoText.text = noneTorsoID.shopPrice.ToString();
        noneTorsoSelected.color = selected;
        chainJacketSelected.color = notSelected;
        chainMailSelected.color = notSelected;
        leatherShirtSelected.color = notSelected;
        leatherJacketSelected.color = notSelected;
        plateMailSelected.color = notSelected;
        robeShirtSelected.color = notSelected;
    }

    private void ChainJacketSelected()
    {
        Wearables.instance.SetClothes("torso", chainJacketID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneTorsoID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(chainJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherShirtID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeShirtID.shopPrice);
        torsoText.text = chainJacketID.shopPrice.ToString();
        noneTorsoSelected.color = notSelected;
        chainJacketSelected.color = selected;
        chainMailSelected.color = notSelected;
        leatherShirtSelected.color = notSelected;
        leatherJacketSelected.color = notSelected;
        plateMailSelected.color = notSelected;
        robeShirtSelected.color = notSelected;
    }

    private void ChainMailSelected()
    {
        Wearables.instance.SetClothes("torso", chainMailID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneTorsoID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(chainMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherShirtID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeShirtID.shopPrice);
        torsoText.text = chainMailID.shopPrice.ToString();
        noneTorsoSelected.color = notSelected;
        chainJacketSelected.color = notSelected;
        chainMailSelected.color = selected;
        leatherShirtSelected.color = notSelected;
        leatherJacketSelected.color = notSelected;
        plateMailSelected.color = notSelected;
        robeShirtSelected.color = notSelected;
    }

    private void LeatherShirtSelected()
    {
        Wearables.instance.SetClothes("torso", leatherShirtID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneTorsoID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(leatherShirtID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeShirtID.shopPrice);
        torsoText.text = leatherShirtID.shopPrice.ToString();
        noneTorsoSelected.color = notSelected;
        chainJacketSelected.color = notSelected;
        chainMailSelected.color = notSelected;
        leatherShirtSelected.color = selected;
        leatherJacketSelected.color = notSelected;
        plateMailSelected.color = notSelected;
        robeShirtSelected.color = notSelected;
    }

    private void LeatherJacketSelected()
    {
        Wearables.instance.SetClothes("torso", leatherJacketID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneTorsoID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherShirtID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(leatherJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeShirtID.shopPrice);
        torsoText.text = leatherJacketID.shopPrice.ToString();
        noneTorsoSelected.color = notSelected;
        chainJacketSelected.color = notSelected;
        chainMailSelected.color = notSelected;
        leatherShirtSelected.color = notSelected;
        leatherJacketSelected.color = selected;
        plateMailSelected.color = notSelected;
        robeShirtSelected.color = notSelected;
    }

    private void PlateMailSelected()
    {
        Wearables.instance.SetClothes("torso", plateMailID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneTorsoID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherShirtID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(plateMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(robeShirtID.shopPrice);
        torsoText.text = plateMailID.shopPrice.ToString();
        noneTorsoSelected.color = notSelected;
        chainJacketSelected.color = notSelected;
        chainMailSelected.color = notSelected;
        leatherShirtSelected.color = notSelected;
        leatherJacketSelected.color = notSelected;
        plateMailSelected.color = selected;
        robeShirtSelected.color = notSelected;
    }

    private void RobeShirtSelected()
    {
        Wearables.instance.SetClothes("torso", robeShirtID.shopID);
        CurrencyManager.instance.purchasePrice.Remove(noneTorsoID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(chainMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherShirtID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(leatherJacketID.shopPrice);
        CurrencyManager.instance.purchasePrice.Remove(plateMailID.shopPrice);
        CurrencyManager.instance.purchasePrice.Add(robeShirtID.shopPrice);
        torsoText.text = robeShirtID.shopPrice.ToString();
        noneTorsoSelected.color = notSelected;
        chainJacketSelected.color = notSelected;
        chainMailSelected.color = notSelected;
        leatherShirtSelected.color = notSelected;
        leatherJacketSelected.color = notSelected;
        plateMailSelected.color = notSelected;
        robeShirtSelected.color = selected;
    }
}
