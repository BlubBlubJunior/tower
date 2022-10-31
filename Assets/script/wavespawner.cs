using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavespawner : MonoBehaviour
{
    public Transform enemyprefab;
    public Transform enemyprefab1;
    public Transform enemyprefab2;
    public Transform spawnpoint;

    public float timebetweenwaves = 5f;
    public float countdown = 1f;

    public int wavenumber = 5;
    public GameObject panel;
    bool spawnstart = true;
    

    void Update()
    {
        if (wavenumber >= 10)
        {
            panel.SetActive(true);
            spawnstart = false;
        }
        if (spawnstart == true)
        {
            if (countdown <= 0f)
            {
                StartCoroutine(spawnwaves());
                countdown = timebetweenwaves;
            }
        }
        

        countdown -= Time.deltaTime;
    }
    IEnumerator spawnwaves()
    {
        wavenumber++;
        for (int i = 0; i < wavenumber; i++)
        {

            spawnenemy();
            yield return new WaitForSeconds(0.25f);
           
            
            
        }
        
    }
    void spawnenemy()
    {
        Instantiate(enemyprefab,  spawnpoint.position, spawnpoint.rotation);
        Instantiate(enemyprefab1, spawnpoint.position, spawnpoint.rotation);
        Instantiate(enemyprefab2, spawnpoint.position, spawnpoint.rotation);
    }
}
