using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSkill : Block
{

    // kích hoạt skill
    protected override void OnDie()
    {
        switch (type)
        {
            case BlockType.Boom:
                Debug.Log("booom!");
                break;
        }
    }
}
