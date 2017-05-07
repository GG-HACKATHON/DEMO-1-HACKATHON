using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType
{
    Dirt,
    None,
    Ground,
    Iron,
    Bronze,
    Silver,
    Gold,
    GemBlue,
    GemRed,
    GemGreen,
    GemWhite,
    Bone,
    BlockBlack,
    BlockWhite,
    Ground2
}

public class Block : MonoBehaviour
{
    public BlockType type;

    public int healthMax;
    private int health;
    
    void Awake()
    {
        health = healthMax;
    }

    public void OnHit()
    {
        health--;
        if(health <= 0)
        {

            gameObject.SetActive(false);
        }


        // give something for player
        ThrowItem();
    }

    protected virtual void ThrowItem()
    {

    }


    public Vector2 Pos()
    {
        return new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
    }

    public virtual void Reset()
    {
        health = healthMax;
    }
}
