using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopping : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public bool shop = true;  
    public float timer;
    
    
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (shop == true)
        {
            if (Input.GetKey(KeyCode.B))
            {
                panel.SetActive(true);
                panel2.SetActive(false);
                
                if(timer <= 0)
                {
                    shop = false;
                    timer = 0.5f;
                } 
            }
        }
        if (shop == false)
        {
            if (Input.GetKey(KeyCode.B))
            {
                panel.SetActive(false);
                panel2.SetActive(true);

                if (timer <= 0)
                {
                    shop = true;
                    timer = 0.5f;
                }
            }
        }






    }
}
