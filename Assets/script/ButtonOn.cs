using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOn : MonoBehaviour
{
    public GameObject upgrades;

    
    public void upgradepanel()
    {
        
            upgrades.SetActive(true);
            Debug.Log("Clicking this bitch");
        
        
    }
}
