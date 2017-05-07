﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestItem : MonoBehaviour {

    public Image image;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setImage(Sprite sprite)
    {
        this.image.sprite = sprite;
    }

    public void setText(Request req)
    {
        this.text.text = req.count + "/" + req.Total;
    }
}
