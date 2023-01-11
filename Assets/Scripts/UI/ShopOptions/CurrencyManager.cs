using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using static Unity.Burst.Intrinsics.X86.Avx;

public class CurrencyManager : MonoBehaviour
{
    [SerializeField]
    private Clothes clothes;

    [SerializeField]
    private Button purchaseButton;

    [SerializeField]
    private TMP_Text funds, totalAmountText;

    [SerializeField]
    private TMP_Text[] priceTags;

    private List <string> tempCartText;

    public static CurrencyManager instance;
    public List<int> purchasePrice;
    public int totalAmount;

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

        totalAmountText.text = "Total = $ " + totalAmount.ToString();
    }

    private void Purchase()
    {
        foreach (int item in purchasePrice)
        {
            totalAmount += item;
        }

        if (clothes.funds >= totalAmount)
        {
            clothes.funds -= totalAmount;
            funds.text = "$ " + clothes.funds;
            Wearables.instance.PurchasedItems();
        }

        purchasePrice.Clear();
        totalAmount = 0;
    }
}
