using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSimulate : MonoBehaviour {

    public float moveSpeed = Screen.width;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SimulateMouseMove();
        SimulateMouseClick();
    }
    //Cursor simulation
    void SimulateMouseMove()
    {
        float player_moveX = Input.GetAxis("Horizontal");
        float player1_moveY = Input.GetAxis("Vertical");

        if (player_moveX != 0 || player1_moveY != 0)
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.Move, (int)(player_moveX * moveSpeed * Time.deltaTime), (int)(player1_moveY * moveSpeed * Time.deltaTime));
        }
    }

    void SimulateMouseClick()
    {
        if (Input.GetButtonDown("A"))
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
        }

        if (Input.GetButtonUp("A"))
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
        }

        if (Input.GetButtonDown("B"))
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightDown);
        }

        if (Input.GetButtonUp("B"))
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightUp);
        }
    }
}
