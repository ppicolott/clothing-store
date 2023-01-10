using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wearables : MonoBehaviour
{
    [SerializeField]
    private GameObject body, hair, head, torso, hands, legs, feet;

    [SerializeField]
    private Clothes clothes;

    // Head
    private bool chainHelmet, chainHood, leatherHat, plateHelmet, robeHood = false;
    // Torso
    private bool chainJacket, chainMail, leatherShirt, leatherJacket, plateMail, robeShirt = false;
    // Hands
    private bool leatherBracers, plateGloves = false;
    // Legs
    private bool greenPants, platePants, robeSkirt = false;
    // Feet
    private bool plateShoes = false;

    public static Wearables instance;

    private void Awake()
    {
        // Check if there's no other instance
        instance = this;
    }
    public void SetHead(bool _chainHelmet, bool _chainHood, bool _leatherHat, bool _plateHelmet, bool _robeHood)
    {
        chainHelmet = _chainHelmet;
        chainHood = _chainHood;
        leatherHat = _leatherHat;
        plateHelmet = _plateHelmet;
        robeHood = _robeHood;

        bool[] _head = { _chainHelmet, _chainHood, _leatherHat, _plateHelmet, _robeHood };

        for (int i = 0; i < _head.Length; i++)
        {
            if (_head[i])
            {
                //head.sprite = clothes.head[i];
            }
        }
    }

    public void SetTorso(bool _chainJacket, bool _chainMail, bool _leatherShirt, bool _leatherJacket, bool _plateMail, bool _robeShirt)
    {
        chainJacket = _chainJacket;
        chainMail = _chainMail;
        leatherShirt = _leatherShirt;
        leatherJacket = _leatherJacket;
        plateMail = _plateMail;
        robeShirt = _robeShirt;

        bool[] _torso = { _chainJacket, _chainMail, _leatherShirt, _leatherJacket, _plateMail, _robeShirt };

        for (int i = 0; i < _torso.Length; i++)
        {
            if (_torso[i])
            {
                Destroy(torso.transform.GetChild(0).gameObject);
                Instantiate(clothes.torso[i], torso.transform);

                // Temporary:
                if (torso.GetComponentInChildren<Animator>())
                {
                    body.GetComponentInChildren<Animator>().Rebind();
                    hair.GetComponentInChildren<Animator>().Rebind();
                    head.GetComponentInChildren<Animator>().Rebind();
                    torso.GetComponentInChildren<Animator>().Rebind();
                    hands.GetComponentInChildren<Animator>().Rebind();
                    legs.GetComponentInChildren<Animator>().Rebind();
                    feet.GetComponentInChildren<Animator>().Rebind();
                }
            }
        }
    }

    public void SetHands(bool _leatherBracers, bool _plateGloves)
    {
        leatherBracers = _leatherBracers;
        plateGloves = _plateGloves;

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
        greenPants = _leatherBracers;
        platePants = _platePants;
        robeSkirt = _robeSkirt;

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
        plateShoes = _plateShoes;
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
