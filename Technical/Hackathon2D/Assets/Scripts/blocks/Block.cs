using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType
{
    None,

    Dirt,
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
    Ground2,

    Boom
}

public class Block : MonoBehaviour
{
    public BlockType type;
    public int row;
    public int col;

    public int healthMax;
    private int health;

    
    void Awake()
    {
        health = healthMax;
    }

    // test click vào đây
    // !!! không sử dụng hàm này, hãy xài OnHit();
    void OnMouseDown()
    {
        this.OnHit();
        MovementController.instance.SetNewPosition(this.transform.position, this);
    }

    // khi mà người dùng táng block này
    public void OnHit()
    {
        health--;

        if (health <= 0)
        {
            gameObject.SetActive(false);
            OnDie();
        }        
    }
    protected virtual void OnDie() {}

    // lấy toạ độ đã làm tròn
    public Vector2 Pos()
    {
        return new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
    }

    public virtual void Reset()
    {
        gameObject.SetActive(true);
        health = healthMax;
    }
}
