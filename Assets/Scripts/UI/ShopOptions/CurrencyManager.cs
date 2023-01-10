using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    [SerializeField]
    private Button purchaseButton;

    private void Awake()
    {
        purchaseButton.onClick.AddListener(Purchase);
    }

    private void Purchase()
    {
        // Coins

        Wearables.instance.PurchasedItems();
    }
}
