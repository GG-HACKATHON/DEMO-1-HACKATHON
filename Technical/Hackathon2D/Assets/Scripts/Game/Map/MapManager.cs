using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public float srollSpeed;

    List< List<int> > matrix;

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
        for (int i = 0; i < MapConfig.width; i++)
        {
            AddLine();
        }

        // Create Block here
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
