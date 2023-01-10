using System.Collections;
using System.Collections.Generic;
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
        Instantiate(_body, body.transform);
        Instantiate(_hair, hair.transform);
        Instantiate(_head, head.transform);
        Instantiate(_torso, torso.transform);
        Instantiate(_hands, hands.transform);
        Instantiate(_legs, legs.transform);
        Instantiate(_feet, feet.transform);

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
