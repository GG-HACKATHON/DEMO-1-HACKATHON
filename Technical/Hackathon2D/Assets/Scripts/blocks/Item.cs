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

    // khi va chạm với cái gì đó
    void OnCollisionEnter2D(Collision2D col)
    {
        Give();
    }

    void Give()
    {

    }
}
