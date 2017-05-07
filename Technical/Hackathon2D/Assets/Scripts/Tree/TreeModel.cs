using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Request 
{
    public Block Item;
    public int Total;
    public int count;
  
    public Request(Block item, int total)
    {
        this.Item = item;
        this.Total = total;
        this.count = 0;
    }

};
[System.Serializable]
public class RequestModel
{
    public BlockType type;
    public Sprite spr;

    public Sprite getSprite()
    {
        return spr;
    }

}
public class TreeModel : MonoBehaviour {

    private int treeLevel;
    public List<Request> requestList;
    public List<RequestModel> spriteRequest;
    public List<GameObject> ListItemRequest;
    
    
	void Start () {
        Request req1 = new Request(new Block(), 10);
        requestList.Add(req1);
        Request req2 = new Request(new Block(), 10);
        requestList.Add(req2);
        Request req3 = new Request(new Block(), 10);
        requestList.Add(req3);
        Request req4 = new Request(new Block(), 10);
        requestList.Add(req4);

        SetImageItem();


    }
	
	void Update () {
		
	}

    public void updateTreeImage()
    {

    }

    public void setRequest(Request[] request)
    {
        foreach(Request req in request)
        {
            this.requestList.Add(req);
        }
    }

    public List<Request> getRequest() 
    {
        return this.requestList;
    }

    public void AddItem(Block item)
    {
        foreach(Request req in requestList)
        {
            if(req.Item.type == item.type)
            {
                req.count++;
                return;
            }
        }
    }

    public bool checkGrow()
    {
        foreach (Request req in requestList)
        {
            if (req.count != req.Total)
            {
                return false;
            }
        }

        return true;
    }

    public void SetImageItem()
    {
        for(int i = 0; i < requestList.Count; i++)
        {
            RequestItem reqItem = ListItemRequest[i].GetComponent<RequestItem>();
            Sprite sprite = spriteRequest[i].spr;
            reqItem.setImage(sprite);
            reqItem.setText(requestList[i]);
            
        }
    }

}