using UnityEngine;

[CreateAssetMenu(fileName = "Clothes", menuName = "Scriptable Objects/Clothes")]
public class Clothes : ScriptableObject
{
    [Header("Player Funds")]
    [Space(5)]
    public int funds;

    // Provides price variation across game map
    [Space(10)]
    [Header("Shop Discount")]
    [Space(5)]
    [Range(0, 1)]
    public float shopDiscount;

    [Space(10)]
    [Header("Hair")]
    [Space(5)]
    public GameObject[] hair;

    [Space(10)]
    [Header("Head")]
    [Space(5)]
    public GameObject[] head;

    [Space(10)]
    [Header("Torso")]
    [Space(5)]
    public GameObject[] torso;

    [Space(10)]
    [Header("Hands")]
    [Space(5)]
    public GameObject[] hands;

    [Space(10)]
    [Header("Legs")]
    [Space(5)]
    public GameObject[] legs;

    [Space(10)]
    [Header("Feet")]
    [Space(5)]
    public GameObject[] feet;
}
