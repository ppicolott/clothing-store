using UnityEngine;

[CreateAssetMenu(fileName = "Wearables", menuName = "Scriptable Objects/Wearables")]
public class Wearables : ScriptableObject
{
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
