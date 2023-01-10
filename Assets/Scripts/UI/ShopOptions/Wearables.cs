using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wearables : MonoBehaviour
{
    [SerializeField]
    private GameObject body, hair, head, torso, hands, legs, feet;

    [SerializeField]
    private Clothes clothes;

    public static Wearables instance;

    public Transform newBody, newHair, newHead, newTorso, newHands, newLegs, newFeet;

    private void Awake()
    {
        instance = this;
    }

    public void PurchasedItems()
    {
        newBody = body.transform.GetChild(0);
        newHair = hair.transform.GetChild(0);
        newHead = head.transform.GetChild(0);
        newTorso = torso.transform.GetChild(0);
        newHands = hands.transform.GetChild(0);
        newLegs = legs.transform.GetChild(0);
        newFeet = feet.transform.GetChild(0);

        Outfit.instance.SetOutfit(newBody, newHair, newHead, newTorso, newHands, newLegs, newFeet);
    }

    public void SetClothes(string _clothingSet, int _index)
    {
        // Getting selected clothing set and respective body part
        GameObject[] _wearable = clothes.head;
        GameObject _wearableTransform = head;
        switch (_clothingSet)
        {
            case "hair":
                _wearable = clothes.hair;
                _wearableTransform = hair;
                break;
            case "head":
                _wearable = clothes.head;
                _wearableTransform = head;
                break;
            case "torso":
                _wearable = clothes.torso;
                _wearableTransform = torso;
                break;
            case "hands":
                _wearable = clothes.hands;
                _wearableTransform = hands;
                break;
            case "legs":
                _wearable = clothes.legs;
                _wearableTransform = legs;
                break;
            case "feet":
                _wearable = clothes.feet;
                _wearableTransform = feet;
                break;
        }

        // Clothless
        if (_index == -1)
        {
            // Excluding cases when player select the same option
            if (_wearableTransform.transform.childCount > 0)
            {
                Destroy(_wearableTransform.transform.GetChild(0).gameObject);
            }
        }
        else
        {
            // Loading selected clothes
            List<bool> _clothesList = new List<bool>();
            for (int i = 0; i < _wearable.Length; i++)
            {
                _clothesList.Add(false);
            }
            _clothesList[_index] = true;

            // Displaying selected clothes
            for (int i = 0; i < _clothesList.Count; i++)
            {
                if (_clothesList[i])
                {
                    GameObject _newClothes;
                    _newClothes = Instantiate(_wearable[i], _wearableTransform.transform);

                    // Maintaining same direction of previous clothes
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().frontIdle.activeInHierarchy)
                    {
                        _newClothes.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(true);
                        _newClothes.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(false);
                    }
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().rightIdle.activeInHierarchy)
                    {
                        _newClothes.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(true);
                        _newClothes.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(false);
                    }
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().leftIdle.activeInHierarchy)
                    {
                        _newClothes.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(true);
                        _newClothes.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(false);
                    }
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().backIdle.activeInHierarchy)
                    {
                        _newClothes.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(false);
                        _newClothes.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(true);
                    }

                    // Excluding clothless cases
                    if (_wearableTransform.transform.childCount > 1)
                    {
                        // Removing previous clothes
                        Destroy(_wearableTransform.transform.GetChild(0).gameObject);
                    }

                    // Resetting animations
                    if (_wearableTransform.GetComponentInChildren<Animator>())
                    {
                        _wearableTransform.GetComponentInChildren<Animator>().Rebind();
                    }
                }
            }
        }
    }
}
