using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float moveSpeed;

    private float timeMove;

    private Vector3 newPosition;

    private GameObject player;

    private enum Status
    {
        FINISH,
        GOING
    }

    private Status status;

	// Use this for initialization
	void Start () {
        timeMove = 0;
        newPosition = Vector3.zero;
        status = Status.FINISH;
        player = gameObject.transform.root.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        MouseHandle();
        UpdateStatus();
	}

    void MouseHandle()
    {
        if(Input.GetMouseButton(0))
        {
            newPosition = GetNewPosition(Input.mousePosition);
            Debug.Log("Player " + player.transform.position + ", new pos " + newPosition);
            if(player.transform.position.y != newPosition.y ||
                player.transform.position.x != newPosition.x)
            {
                status = Status.GOING;
            }
        }
    }

    void UpdateStatus()
    {
        //Debug.Log("Player " + player.transform.position + ", new pos " + newPosition);
        if (status == Status.GOING)
        {
            Vector3 tempPosition = player.transform.position;
            if (timeMove <= 0)
            {
               
                if(tempPosition.y != newPosition.y)
                    tempPosition.y += (player.transform.position.y < newPosition.y) ? 1 : -1;
                else
                    tempPosition.x += (player.transform.position.x < newPosition.x) ? 1 : -1;
                timeMove = 0.2f;
            }
            else
            {
                timeMove -= Time.deltaTime;
            }

            player.transform.position = tempPosition;
            if (player.transform.position.y == newPosition.y && player.transform.position.x == newPosition.x)
                status = Status.FINISH;

        }
        Debug.Log(status);
    }

    Vector3 GetNewPosition(Vector3 position)
    {
        Vector3 screenPosition = ScreenPosition(position);
        Vector3 newPosition = Vector3.zero;
        newPosition.x = (int)screenPosition.x;
        newPosition.y = (int)screenPosition.y;
        newPosition.z = (int)screenPosition.z;

        return newPosition;
    }

    Vector3 ScreenPosition(Vector3 worldPosition)
    {
        Vector3 screenPoint = worldPosition;
        screenPoint.z = 10.0f; //distance of the plane from the camera
        return Camera.main.ScreenToWorldPoint(screenPoint);
    }

    void Test()
    {
        for (int i=0;i<7;i++)
        {

        }
    }
}
