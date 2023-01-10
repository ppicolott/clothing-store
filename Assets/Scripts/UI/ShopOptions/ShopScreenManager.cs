using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ShopScreenManager : MonoBehaviour
{
    [SerializeField]
    private GameObject shopScreen;
    [SerializeField]
    private Button exitButton;

    private void Awake()
    {
        InputSystem.EnableDevice(Keyboard.current);
        exitButton.onClick.AddListener(CloseShopScreen);
    }

    private void CloseShopScreen()
    {
        InputSystem.EnableDevice(Keyboard.current);
        shopScreen.SetActive(false);
    }

    public void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            CloseShopScreen();
        }
    }
}
