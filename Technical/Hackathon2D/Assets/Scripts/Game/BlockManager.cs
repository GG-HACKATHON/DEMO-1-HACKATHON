using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoSingleton<BlockManager> {

    [System.Serializable]
    public class BlockProperty
    {
        [HideInInspector]
        public int blockID;
        public GameObject block;
    }

    public List<BlockProperty> blocks;
    public Dictionary<int, GameObject> dict;

    private void Awake()
    {
        MakeDictionary();
    }

    public void MakeDictionary()
    {
        for (int i = 0; i < blocks.Count; i++)
        {
            blocks[i].blockID = i;
        }

        dict = new Dictionary<int, GameObject>();
        foreach (BlockProperty bp in blocks)
        {
            if (!dict.ContainsKey(bp.blockID))
            {
                dict.Add(bp.blockID, bp.block);
            }
        }
    }

    public GameObject GetBlockByID(int blockID)
    {
        if (dict.ContainsKey(blockID))
        {
            return dict[blockID];
        }
        else
        {
            Debug.Log("Block does not exist");
            return null;
        }
    }

    public int GetLength()
    {
        return blocks.Count;
    }
}
