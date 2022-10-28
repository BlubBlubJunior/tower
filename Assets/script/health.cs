using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class health : MonoBehaviour
{
    public GameObject panel;
    public GameObject paneloff;
    public float Health = 10f;
    public TextMeshProUGUI healthdisplay;
    void Update()
    {
        healthdisplay.text = Health.ToString();
        if(Health <= 0)
        {
            panel.SetActive(true);
            paneloff.SetActive(false);
        }

    }
}
