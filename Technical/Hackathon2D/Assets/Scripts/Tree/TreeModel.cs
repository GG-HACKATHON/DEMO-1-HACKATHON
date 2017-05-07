using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Request 
{
    public Block Item;
    public int countRequest;
    public int countItem;
  
    public Request(Block item, int countRequest)
    {
        this.Item = item;
        this.countRequest = countRequest;
        this.countItem = 0;
    }

};
[System.Serializable]
public class RequestModel
{
    public BlockType type;
    public Sprite spr;

    public Sprite getSprite(BlockType type)
    {
        return spr;
    }

}
public class TreeModel : MonoBehaviour {

    private int treeLevel;
    public List<Request> requestList;
    public List<RequestModel> spriteRequest;

    
    
	void Start () {
		
	}
	
	void Update () {
		
	}

    void setRequest(Request[] request)
    {
        foreach(Request req in request)
        {
            this.requestList.Add(req);
        }
    }

    List<Request> getRequest() 
    {
        return this.requestList;
    }

    void AddItem(Block item)
    {
        foreach(Request req in requestList)
        {
            if(req.Item.type == item.type)
            {
                req.countItem++;
                return;
            }
        }
    }

    public bool checkGrow()
    {
        foreach (Request req in requestList)
        {
            if (req.countItem != req.countRequest)
            {
                return false;
            }
        }

        return true;
    }

    public void SetImageItem()
    {
        
    }
}
