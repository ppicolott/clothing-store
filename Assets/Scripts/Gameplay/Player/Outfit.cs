using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Outfit : MonoBehaviour
{
    [SerializeField]
    private GameObject body, hair, head, torso, hands, legs, feet;

    public static Outfit instance;

    private void Awake()
    {
        instance = this;
    }

    public void SetOutfit(Transform _body, Transform _hair, Transform _head, Transform _torso, Transform _hands, Transform _legs, Transform _feet)
    {
        // Enables to add and to remove clothes
        if (_body)
        {
            Instantiate(_body, body.transform);
        }
        else if (!_body && body.transform.childCount > 0)
        {
            Destroy(body.transform.GetChild(0).gameObject);
        }
        if (_hair)
        {
            Instantiate(_hair, hair.transform);
        }
        else if (!_hair && hair.transform.childCount > 0)
        {
            Destroy(hair.transform.GetChild(0).gameObject);
        }
        if (_head)
        {
            Instantiate(_head, head.transform);
        }
        else if (!_head && head.transform.childCount > 0)
        {
            Destroy(head.transform.GetChild(0).gameObject);
        }
        if (_torso)
        {
            Instantiate(_torso, torso.transform);
        }
        else if (!_torso && torso.transform.childCount > 0)
        {
            Destroy(torso.transform.GetChild(0).gameObject);
        }
        if (_hands)
        {
            Instantiate(_hands, hands.transform);
        }
        else if (!_hands && hands.transform.childCount > 0)
        {
            Destroy(hands.transform.GetChild(0).gameObject);
        }
        if (_legs)
        {
            Instantiate(_legs, legs.transform);
        }
        else if (!_legs && legs.transform.childCount > 0)
        {
            Destroy(legs.transform.GetChild(0).gameObject);
        }
        if (_feet)
        {
            Instantiate(_feet, feet.transform);
        }
        else if (!_feet && feet.transform.childCount > 0)
        {
            Destroy(feet.transform.GetChild(0).gameObject);
        }

        // Change clothes (prevent from clones after clones)
        if (body.transform.childCount > 1)
        {
            Destroy(body.transform.GetChild(0).gameObject);
        }
        if (hair.transform.childCount > 1)
        {
            Destroy(hair.transform.GetChild(0).gameObject);
        }
        if (head.transform.childCount > 1)
        {
            Destroy(head.transform.GetChild(0).gameObject);
        }
        if (torso.transform.childCount > 1)
        {
            Destroy(torso.transform.GetChild(0).gameObject);
        }
        if (hands.transform.childCount > 1)
        {
            Destroy(hands.transform.GetChild(0).gameObject);
        }
        if (legs.transform.childCount > 1)
        {
            Destroy(legs.transform.GetChild(0).gameObject);
        }
        if (feet.transform.childCount > 1)
        {
            Destroy(feet.transform.GetChild(0).gameObject);
        }
    }
}
