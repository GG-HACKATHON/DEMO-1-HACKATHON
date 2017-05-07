using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Iron,
    Bronze,
    Silver,
    Gold,

    GemBlue,
    GemRed,
    GemGreen,
    GemWhite,

    Bone
}


public class Item : MonoBehaviour
{
    public ItemType type;

    void OnCollisionEnter2D(Collision2D col)
    {
        Give();
    }

    protected virtual void Give()
    {

    }

	
}
