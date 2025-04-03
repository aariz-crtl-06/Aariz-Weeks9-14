using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileSwapper : MonoBehaviour
{
    public Tilemap tilemap;

    public Tile grass;
    public Tile stone;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3Int gridPos = tilemap.WorldToCell(mousePos);

            Debug.Log(gridPos.ToString());

            if (tilemap.GetTile(gridPos) == stone)
            {
                Debug.Log("This is stone you dumbass turn me into grass idiot boy salaa panchood");
                tilemap.SetTile(gridPos, grass);
            }

            else
            {
                Debug.Log("This is grass, turn me into stone!");
                tilemap.SetTile(gridPos, stone);

            }
        }
    }
}
