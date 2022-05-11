using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int width = 4;
    [SerializeField]
    private int height = 4;
    [SerializeField]
    public GameObject prefab;    
    [SerializeField]
    public SpriteRenderer boardPrefab;

    private GameObject tempgameObject;



    private void Start()
    {
        GenerateGrid();
    }


    public void GenerateGrid()
    {
        var center = new Vector2((float)width / 2 - 0.5f, (float)height / 2 - 0.5f);
        boardPrefab.size = new Vector2(width, height);
        var board = Instantiate(boardPrefab, center, Quaternion.identity);

        Camera.main.transform.position = new Vector3(center.x, center.y, -10);

        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                tempgameObject=Instantiate(prefab, new Vector2(x, y), Quaternion.identity);
                tempgameObject.transform.parent = board.transform;
               
            }


        }
    }
}
