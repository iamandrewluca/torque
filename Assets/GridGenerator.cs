using System.Collections;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject hexPrefab;

    public int width = 5;

    public int height = 5;

    void Start()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 position = new Vector3((y % 2 == 1) ? x + 0.5f : x, y * 0.9f, 0);
                GameObject go = (GameObject)Instantiate(hexPrefab, position, Quaternion.identity);
                go.name = "Hex_" + x + "_" + y;
            }
        }
    }
}
