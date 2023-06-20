using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private bool isGoingLeft = false;
    private bool isGoingRight = false;

    private void GoLeft()
    {
        isGoingLeft = true;
        isGoingRight = false;
    }

    private void GoRight()
    {
        isGoingRight = true;
        isGoingLeft = false;
    }

    private void Update()
    {
        bool isAPressed = Input.GetKey(KeyCode.A);
        bool isDPressed = Input.GetKey(KeyCode.D);

        if (isGoingLeft && !isAPressed)
        {
            isGoingLeft = false;
        }
        else if (isGoingRight && !isDPressed)
        {
            isGoingRight = false;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if (endTouchPosition.x < startTouchPosition.x)
            {
                GoLeft();
            }

            if (endTouchPosition.x > startTouchPosition.x)
            {
                GoRight();
            }
        }

        if (isGoingLeft)
        {

            PressAndHoldKey(KeyCode.A);
        }

        if (isGoingRight)
        {

            PressAndHoldKey(KeyCode.D);
        }
    }

    private void PressAndHoldKey(KeyCode key)
    {

        if (!Input.GetKey(key))
        {

            Input.GetKeyDown(key);
        }
    }

    private void ReleaseKey(KeyCode key)
    {

        if (Input.GetKey(key))
        {

            Input.GetKeyUp(key);
        }
    }

}
