using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    public bool isoccupied;

    public Color greencolor;
    public Color redcolor;

    private SpriteRenderer rend;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if(isoccupied == true)
        {
            rend.color = redcolor;
        }
        else
        {
            rend.color = greencolor;
        }
    }
}
