﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDirt : Block
{


    protected override void ThrowItem()
    {
        base.ThrowItem();
    }

    [ContextMenu("OnHit")]
    public override void OnHit()
    {
        base.OnHit();
    }


}