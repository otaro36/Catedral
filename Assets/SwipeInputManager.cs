using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwipeInputManager : MonoBehaviour
{
    private delegate void StarTouch(Vector2 position, float time);
    private event StarTouch OnStartTouch;

    private delegate void EndTouch(Vector2 position, float time);
    private event EndTouch OnEndTouch;

    private delegate void Tapped();
    private event Tapped OnTapped;

    private delegate void MulitTapped();
    private event MulitTapped OnMultiTapped;

    public delegate void LeftSwipe();
    public event LeftSwipe OnSwipeLeft;

    public delegate void RightSwipe();
    public event RightSwipe OnSwipeRight;

    public delegate void UpSwipe();
    public event UpSwipe OnSwipeUp;

    public delegate void DownSwipe();
    public event DownSwipe OnSwipeDown;

    public float minimumDistance = 15f;
    public float maximumTime = 1f;
    [Range(0f,1f)] public float directionThreshold = 0.9f;

    private Vector2 starPosition, endPosition;
    private float startTimr, endTime;

    private Tpuch inputActions;
    private void Awake()
    {
        inputActions = new Tpuch();
    }
    private void OnEnable()
    {
        inputActions.Enable();
        OnStartTouch += SwipeStart;
        OnEndTouch += SwipeEnd;
    }
    private void OnDisable()
    {
        inputActions?.Disable();
        OnStartTouch -= SwipeStart;
        OnEndTouch -= SwipeEnd;
    }
    private void Start()
    {
        inputActions.Touch.PrimaryContact.started += ctx => StarTouchPrimary(ctx);
        inputActions.Touch.PrimaryContact.canceled += ctx => EndTouchPrimary(ctx);
        inputActions.Touch.Tap.performed+= ctx => TappedPerformed(ctx);
        inputActions.Touch.MultiTap.performed += ctx => MultiTappedPerformed(ctx);
    }

    private void MultiTappedPerformed(InputAction.CallbackContext ctx)
    {
        if (OnMultiTapped != null)
        {
            OnMultiTapped();
        }
    }

    private void TappedPerformed(InputAction.CallbackContext ctx)
    {
        if (OnTapped!=null)
        {
            OnTapped();
        }
    }



    private void StarTouchPrimary(InputAction.CallbackContext ctx)
    {
        if (OnStartTouch!=null)
        {
            OnStartTouch(ScreenPosition(),(float)ctx.startTime);
        }
    }
    private void EndTouchPrimary(InputAction.CallbackContext ctx)
    {
        if (OnEndTouch != null)
        {
            OnEndTouch(ScreenPosition(), (float)ctx.time);
        }
    }
    private Vector2 ScreenPosition()
    {
        return inputActions.Touch.PrimaryPosition.ReadValue<Vector2>();
    }

    private void SwipeEnd(Vector2 position, float time)
    {
        starPosition = position;
        startTimr= time;
        DetecteSwipe();

    }

    private void SwipeStart(Vector2 position, float time)
    {
        endPosition = position;
        endTime = time;
        
    }

    private void DetecteSwipe()
    {
        if (Vector3.Distance(starPosition,endPosition)>=minimumDistance&&(endTime-startTimr)<maximumTime)
        {
            Vector3 direction = endPosition - starPosition;
            Vector2 direction2D=new Vector2(direction.x,direction.y).normalized;
            SwipeDirection(direction2D);
        }
    }
    private void SwipeDirection(Vector2 direction)
    {
        if (Vector2.Dot(Vector2.up, direction) > directionThreshold)
        {
            if (OnSwipeUp!=null)
            {
                OnSwipeUp();
            }
        }
        else if (Vector2.Dot(Vector2.down, direction) > directionThreshold)
        {
            if (OnSwipeDown != null)
            {
                OnSwipeDown();
            }
        }
        else if (Vector2.Dot(Vector2.left, direction) > directionThreshold)
        {
            if (OnSwipeLeft != null)
            {
                OnSwipeLeft();
            }
        }
        else if (Vector2.Dot(Vector2.right, direction) > directionThreshold)
        {
            if (OnSwipeRight != null)
            {
                OnSwipeRight();
            }
        }
    }
}
