using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomPlayer : MonoBehaviour
{
    [SerializeField]
    private AnimationManager[] animations;

    [SerializeField]
    private Button clockwiseButton, counterClockwiseButton;

    private void Awake()
    {
        clockwiseButton.onClick.AddListener(RotateClockwise);
        counterClockwiseButton.onClick.AddListener(RotateCounterClockwise);
    }

    private void Update()
    {
        LoadAnimationList();
    }

    public void LoadAnimationList()
    {
        animations = GetComponentsInChildren<AnimationManager>();
    }

    private void RotateClockwise()
    {
        LoadAnimationList();

        foreach (AnimationManager anim in animations)
        {
            if (anim.frontIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(true);
                anim.backIdle.gameObject.SetActive(false);
            }
            else if (anim.rightIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(true);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
            }
            else if (anim.leftIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(true);
            }
            else if (anim.backIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(true);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
            }
        }
    }

    private void RotateCounterClockwise()
    {
        LoadAnimationList();

        foreach (AnimationManager anim in animations)
        {
            if (anim.frontIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(true);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
            }
            else if (anim.rightIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(true);
            }
            else if (anim.leftIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(true);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
            }
            else if (anim.backIdle.gameObject.activeInHierarchy)
            {
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(true);
                anim.backIdle.gameObject.SetActive(false);
            }
        }
    }
}
