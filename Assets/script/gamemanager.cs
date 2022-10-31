using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI golddisplay;

    private Building buildingtoplace;
    public GameObject grid;

    public custemcuster custemct;

    public tile[] tiles;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("startscreen");
        }
        golddisplay.text = gold.ToString();
        if (Input.GetMouseButtonDown(0) && buildingtoplace != null)
        {
            tile  nearestTile = null;
            float nearestdistance = float.MaxValue;
            foreach(tile Tile in tiles)
            {
                float dist = Vector2.Distance(Tile.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
                if(dist < nearestdistance)
                {
                    nearestdistance = dist;
                    nearestTile = Tile;
                }
            }
            if(nearestTile.isoccupied == false)
            {
                Instantiate(buildingtoplace, nearestTile.transform.position, Quaternion.identity);
                buildingtoplace = null;
                nearestTile.isoccupied = true;
                grid.SetActive(false);
                custemct.gameObject.SetActive(false);
                Cursor.visible = true;

            }
        }
    }

    public void buybuilding(Building building)
    {
        if(gold >= building.cost)
        {
            custemct.gameObject.SetActive(true);
            custemct.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
            Cursor.visible = false;


            gold -= building.cost;
            buildingtoplace = building;
            grid.SetActive(true);
        }
    }
}
