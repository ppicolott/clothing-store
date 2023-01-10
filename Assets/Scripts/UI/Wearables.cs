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

    private void Awake()
    {

        // Check if there's no other instance

        instance = this;
    }

    public void SetTorso(int _index)
    {
        // Clothless
        if (_index == -1)
        {
            // Excluding cases when player select the same option
            if (torso.transform.childCount > 0)
            {
                Destroy(torso.transform.GetChild(0).gameObject);
            }
        }
        else
        {
            // Loading selected clothes
            List<bool> _torso = new List<bool>();
            for (int i = 0; i < clothes.torso.Length; i++)
            {
                _torso.Add(false);
            }
            _torso[_index] = true;

            // Displaying selected clothes
            for (int i = 0; i < _torso.Count; i++)
            {
                if (_torso[i])
                {
                    GameObject _newTorso;
                    _newTorso = Instantiate(clothes.torso[i], torso.transform);

                    // Maintaining same direction of previous clothes
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().frontIdle.activeInHierarchy)
                    {
                        _newTorso.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(true);
                        _newTorso.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(false);
                    }
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().rightIdle.activeInHierarchy)
                    {
                        _newTorso.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(true);
                        _newTorso.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(false);
                    }
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().leftIdle.activeInHierarchy)
                    {
                        _newTorso.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(true);
                        _newTorso.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(false);
                    }
                    if (body.transform.GetChild(0).gameObject.GetComponent<AnimationManager>().backIdle.activeInHierarchy)
                    {
                        _newTorso.GetComponent<AnimationManager>().frontIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().rightIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().leftIdle.gameObject.SetActive(false);
                        _newTorso.GetComponent<AnimationManager>().backIdle.gameObject.SetActive(true);
                    }

                    // Excluding clothless cases
                    if (torso.transform.childCount > 1)
                    {
                        // Removing previous clothes
                        Destroy(torso.transform.GetChild(0).gameObject);
                    }

                    // Resetting animations
                    if (torso.GetComponentInChildren<Animator>())
                    {
                        torso.GetComponentInChildren<Animator>().Rebind();
                    }
                }
            }
        }
    }











    public void SetHead(bool _chainHelmet, bool _chainHood, bool _leatherHat, bool _plateHelmet, bool _robeHood)
    {
        bool[] _head = { _chainHelmet, _chainHood, _leatherHat, _plateHelmet, _robeHood };

        for (int i = 0; i < _head.Length; i++)
        {
            if (_head[i])
            {
                //head.sprite = clothes.head[i];
            }
        }
    }

    //

    public void SetHands(bool _leatherBracers, bool _plateGloves)
    {
        bool[] _hands = { _leatherBracers, _plateGloves };

        for (int i = 0; i < _hands.Length; i++)
        {
            if (_hands[i])
            {
                //hands.sprite = clothes.hands[i];
            }
        }
    }

    public void SetLegs(bool _leatherBracers, bool _platePants, bool _robeSkirt)
    {
        bool[] _legs = { _leatherBracers, _platePants, _robeSkirt };

        for (int i = 0; i < _legs.Length; i++)
        {
            if (_legs[i])
            {
                //legs.sprite = clothes.legs[i];
            }
        }
    }

    public void SetFeet(bool _plateShoes)
    {
        //legs.sprite = clothes.legs[0];

        // bool[] _legs = { _plateShoes };
        // 
        // for (int i = 0; i < _legs.Length; i++)
        // {
        //     if (_legs[i])
        //     {
        //         legs.sprite = clothes.legs[i];
        //     }
        // }
    }
}
