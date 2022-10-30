using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    public Transform target;
    Vector2 localscale;

    void Start()
    {
        localscale = transform.localScale;
    }
    void Update()
    {
        enemy hp = target.GetComponent<enemy>();
        localscale.x = hp.Health;
        transform.localScale = localscale;
    }
}
