using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Map : MonoBehaviour {

    List<int[]> list;

	// Use this for initialization
	void Start () {
        Setup(MapConfig.MAP_1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup(string path)
    {
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Debug.Log(line);
                }

            }
        }
        catch (Exception e)
        {
            Debug.Log("Can't read file from " + Directory.GetCurrentDirectory());
        }
    }
}
