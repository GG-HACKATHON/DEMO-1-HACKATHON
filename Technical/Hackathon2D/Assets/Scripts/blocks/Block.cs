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

    public GameObject[] items;
    
    void Awake()
    {
        health = healthMax;
    }

    void OnMouseDown()
    {
        this.OnHit();
        MovementController.instance.SetNewPosition(this.transform.position);
    }

    
    public virtual void OnHit()
    {
        health--;
        Debug.Log(health);
        if(health <= 0)
        {

            gameObject.SetActive(false);
        }


        // give something for player
        ThrowItem();
    }

    protected virtual void ThrowItem()
    {
        for (int i = 0; i < items.Length; i++)
        {
            Instantiate(items[i], transform.position, Quaternion.identity, null);
        }
    }


    public Vector2 Pos()
    {
        return new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
    }

    public virtual void Reset()
    {
        health = healthMax;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Detection")
        {
            Destroy(gameObject);
        }
    }
}
