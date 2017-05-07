using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public float srollSpeed;

    List< List<int> > matrix;

    public GameObject block;

    public const float constX = -3.5f;
    public const float constY = 2f;
    public const float between = 1f;

	// Use this for initialization
	void Start () {
        Setup();    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Setup()
    {
        matrix = new List<List<int>>();
        for (int i = 0; i < MapConfig.height; i++)
        {
            AddLine();
        }

        // Create Block here
        for (int i = 0; i < MapConfig.height; i++)
        {
            float posY = constY - between * i;
            for (int j = 0; j < MapConfig.width; j++)
            {
                float posX = constX + between * j;

                // Instantiate block here
                GameObject go = Instantiate(block, new Vector3(posX, posY), Quaternion.identity, transform) as GameObject;
            }
        }
    }

    void Render()
    {
        
    }


    void AddLine()
    {
        List<int> row = new List<int>();
        for (int i = 0; i < MapConfig.width; i++)
        {
            row.Add(Random.Range(0, MapConfig.width));
        }
    }

    void RemoveLine()
    {
        matrix.RemoveAt(0);
    }

    void ReplaceLine()
    {
        RemoveLine();
        AddLine();
    }
}
