using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;
    public Tile tilePrefab;

    public void GenerateMap()
    {
        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                Tile spawnedTile = Instantiate(tilePrefab, new Vector2(x, y), Quaternion.identity, this.transform);
            }
        }
    }
}
