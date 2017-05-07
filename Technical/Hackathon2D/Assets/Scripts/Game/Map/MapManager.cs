using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public float scrollSpeed;
    public Transform scrollTransform;

    public List<List<BlockType>> matrix;

    public const float constX = -3.5f;
    public const float constY = 2f;
    public const float between = 1f;


    private float distance = 0;
    private float time = 0;

	// Use this for initialization
	void Start () {
        Setup();    
	}
	
	// Update is called once per frame
	void Update () {
        scrollTransform.position += Vector3.up * scrollSpeed * Time.deltaTime;
        distance += scrollSpeed * Time.deltaTime;
       
        this.time += Time.deltaTime;
        if(this.time >= 1)
        {
            CreateLine();
            time = 0;
        }
       
	}

    public int max = 0;

    [ContextMenu("CreateLine")]
    void CreateLine()
    {
        float posY = constY - between * max + distance;
        AddLine(posY);
        Debug.Log("Create Line");
    }

    void Setup()
    {
        matrix = new List<List<BlockType>>();
        // Create Block here
        for (int i = 0; i < MapConfig.height; i++)
        {
            float posY = constY - between * max;
            AddLine(posY);
        }
    }

    void Render()
    {
        
    }

    
    void AddLine(float posY)
    {
        List<BlockType> l = new List<BlockType>();
        for (int i = 0; i < MapConfig.width; i++)
        {
            float posX = constX + between * i;
            int type = Random.Range(0, BlockManager.instance.GetLength());

            l.Add((BlockType)type);
            GameObject go = Instantiate(BlockManager.instance.GetBlockByID(type),
                    new Vector3(posX, posY), Quaternion.identity, scrollTransform) as GameObject;
        }
        this.matrix.Add(l);
        max++;
    }
}
