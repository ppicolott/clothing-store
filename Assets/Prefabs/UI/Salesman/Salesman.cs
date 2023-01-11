using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Salesman : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject dialogScreen;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            if (Keyboard.current.enterKey.isPressed
            || Keyboard.current.numpadEnterKey.isPressed
            || Keyboard.current.spaceKey.isPressed)
            {
                dialogScreen.SetActive(true);
                InputSystem.DisableDevice(Keyboard.current);
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        dialogScreen.SetActive(true);
        InputSystem.DisableDevice(Keyboard.current);
    }
}
