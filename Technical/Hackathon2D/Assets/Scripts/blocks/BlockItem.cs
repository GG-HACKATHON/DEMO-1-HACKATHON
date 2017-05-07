using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockItem : Block
{
    public GameObject[] items;

    protected override void OnDie()
    {
        // give something for player
        for (int i = 0; i < items.Length; i++)
        {
            Instantiate(items[i], transform.position, Quaternion.identity, null);
        }
    }
}
