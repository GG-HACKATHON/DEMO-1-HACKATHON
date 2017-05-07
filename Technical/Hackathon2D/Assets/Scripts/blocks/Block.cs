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

    public int health;
    
    public void Awake()
    {

    }

    public void OnHit()
    {
        


        gameObject.SetActive(false);

        // give something for player
    }

    public Vector2 Pos()
    {
        return new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
    }
}
