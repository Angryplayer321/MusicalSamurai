using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    [Header("Links")] [SerializeField] private GameObject cubeTerrainPrefab;
    [Header("Parameters")]
    [Range(0, 100)]
    [SerializeField] private int terrainWidth;
    [Range(0, 100)]
    [SerializeField] private int terrainLength;
    // Start is called before the first frame update
    void Start()
    {
        GenerateTerrain();
    }
    void GenerateTerrain()
    {
        for (int x = 0; x < terrainWidth; x++)
        {
            for(int z = 0; z<terrainLength; z++)
            {
                GameObject cubeInstance = Instantiate(cubeTerrainPrefab);

                Vector3 cubePos = new Vector3(x, Mathf.PerlinNoise((x * 1.0f) / terrainWidth, 0.1f), z);

                cubeInstance.transform.position = cubePos;

            }
        }
    }

  
}
