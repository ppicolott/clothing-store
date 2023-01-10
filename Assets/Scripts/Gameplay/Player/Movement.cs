using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody;

    [SerializeField]
    private AnimationManager[] animations;

    [SerializeField]
    private float moveSpeed = 3f;

    private Movement singleInstance;
    public static Movement instance;

    private void LoadAnimationList()
    {
        animations = GetComponentsInChildren<AnimationManager>();
    }
    private void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        LoadAnimationList();

        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            // Move
            rigidBody.velocity = new Vector2(0f, -moveSpeed);

            foreach (AnimationManager anim in animations)
            {
                // Idle
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
                // Walk
                anim.frontWalk.gameObject.SetActive(true);
                anim.rightWalk.gameObject.SetActive(false);
                anim.leftWalk.gameObject.SetActive(false);
                anim.backWalk.gameObject.SetActive(false);
            }
        }
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            // Move
            rigidBody.velocity = new Vector2(moveSpeed, 0f);

            foreach (AnimationManager anim in animations)
            {
                // Idle
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
                // Walk
                anim.frontWalk.gameObject.SetActive(false);
                anim.rightWalk.gameObject.SetActive(true);
                anim.leftWalk.gameObject.SetActive(false);
                anim.backWalk.gameObject.SetActive(false);
            }
        }
        else if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            // Move
            rigidBody.velocity = new Vector2(-moveSpeed, 0f);

            foreach (AnimationManager anim in animations)
            {
                // Idle
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
                // Walk
                anim.frontWalk.gameObject.SetActive(false);
                anim.rightWalk.gameObject.SetActive(false);
                anim.leftWalk.gameObject.SetActive(true);
                anim.backWalk.gameObject.SetActive(false);
            }
        }
        else if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            // Move
            rigidBody.velocity = new Vector2(0f, moveSpeed);

            foreach (AnimationManager anim in animations)
            {
                // Idle
                anim.frontIdle.gameObject.SetActive(false);
                anim.rightIdle.gameObject.SetActive(false);
                anim.leftIdle.gameObject.SetActive(false);
                anim.backIdle.gameObject.SetActive(false);
                // Walk
                anim.frontWalk.gameObject.SetActive(false);
                anim.rightWalk.gameObject.SetActive(false);
                anim.leftWalk.gameObject.SetActive(false);
                anim.backWalk.gameObject.SetActive(true);
            }
        }
        else
        {
            // Stop
            rigidBody.velocity = Vector3.zero;

            foreach (AnimationManager anim in animations)
            {
                if (anim.frontWalk.gameObject.activeInHierarchy)
                {
                    // Idle
                    anim.frontIdle.gameObject.SetActive(true);
                    anim.rightIdle.gameObject.SetActive(false);
                    anim.leftIdle.gameObject.SetActive(false);
                    anim.backIdle.gameObject.SetActive(false);
                    // Walk
                    anim.frontWalk.gameObject.SetActive(false);
                    anim.rightWalk.gameObject.SetActive(false);
                    anim.leftWalk.gameObject.SetActive(false);
                    anim.backWalk.gameObject.SetActive(false);
                }
                else if (anim.rightWalk.gameObject.activeInHierarchy)
                {
                    // Idle
                    anim.frontIdle.gameObject.SetActive(false);
                    anim.rightIdle.gameObject.SetActive(true);
                    anim.leftIdle.gameObject.SetActive(false);
                    anim.backIdle.gameObject.SetActive(false);
                    // Walk
                    anim.frontWalk.gameObject.SetActive(false);
                    anim.rightWalk.gameObject.SetActive(false);
                    anim.leftWalk.gameObject.SetActive(false);
                    anim.backWalk.gameObject.SetActive(false);
                }
                else if (anim.leftWalk.gameObject.activeInHierarchy)
                {
                    // Idle
                    anim.frontIdle.gameObject.SetActive(false);
                    anim.rightIdle.gameObject.SetActive(false);
                    anim.leftIdle.gameObject.SetActive(true);
                    anim.backIdle.gameObject.SetActive(false);
                    // Walk
                    anim.frontWalk.gameObject.SetActive(false);
                    anim.rightWalk.gameObject.SetActive(false);
                    anim.leftWalk.gameObject.SetActive(false);
                    anim.backWalk.gameObject.SetActive(false);
                }
                else if (anim.backWalk.gameObject.activeInHierarchy)
                {
                    // Idle
                    anim.frontIdle.gameObject.SetActive(false);
                    anim.rightIdle.gameObject.SetActive(false);
                    anim.leftIdle.gameObject.SetActive(false);
                    anim.backIdle.gameObject.SetActive(true);
                    // Walk
                    anim.frontWalk.gameObject.SetActive(false);
                    anim.rightWalk.gameObject.SetActive(false);
                    anim.leftWalk.gameObject.SetActive(false);
                    anim.backWalk.gameObject.SetActive(false);
                }
            }
        }
    }
}
