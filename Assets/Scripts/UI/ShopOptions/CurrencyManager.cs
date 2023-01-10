using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    [SerializeField]
    private Clothes clothes;

    [SerializeField]
    private Button purchaseButton;

    [SerializeField]
    private TMP_Text funds;

    [SerializeField]
    private TMP_Text[] priceTags;

    public static CurrencyManager instance;
    public int purchasePrice;

    private void Awake()
    {
        instance = this;
        clothes.funds = 1500;
        funds.text = "$ " + clothes.funds;
        purchaseButton.onClick.AddListener(Purchase);
    }

    private void Update()
    {
        foreach (TMP_Text tmp in priceTags)
        {
            int priceTag = tmp.GetComponentInParent<ShopID>().shopPrice;
            tmp.text = "$ " + priceTag * (1 - clothes.shopDiscount);
        }
    }

    private void Purchase()
    {
        if (clothes.funds >= purchasePrice)
        {
            clothes.funds -= purchasePrice;
            funds.text = "$ " + clothes.funds;
            Wearables.instance.PurchasedItems();
        }
    }
}
