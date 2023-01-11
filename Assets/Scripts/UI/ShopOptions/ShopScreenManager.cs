using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ShopScreenManager : MonoBehaviour
{
    [SerializeField]
    private GameObject dialogScreen, shopScreen, quitButton;
    [SerializeField]
    private Button buyButton, leaveButton, exitButton;

    private void Awake()
    {
        InputSystem.EnableDevice(Keyboard.current);
        buyButton.onClick.AddListener(OpenShopScreen);
        leaveButton.onClick.AddListener(CloseShopScreen);
        exitButton.onClick.AddListener(CloseShopScreen);
    }

    private void OpenShopScreen()
    {
        InputSystem.DisableDevice(Keyboard.current);
        dialogScreen.SetActive(false);
        shopScreen.SetActive(true);
        quitButton.SetActive(false);
    }
    private void CloseShopScreen()
    {
        InputSystem.EnableDevice(Keyboard.current);
        dialogScreen.SetActive(false);
        shopScreen.SetActive(false);
        quitButton.SetActive(true);
    }

    public void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            CloseShopScreen();
        }
    }
}
