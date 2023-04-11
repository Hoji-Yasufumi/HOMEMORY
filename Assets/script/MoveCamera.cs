using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float sensitivility;

    float fingerTouchPosX; //タップし、指が画面に触れた瞬間の指のx座標
    float fingerLeavePosX; //タップし、指が画面から離れた瞬間のx座標
    float fingerNowPosX; //現在の指のx座標

    float fingerTouchPosY; //タップし、指が画面に触れた瞬間の指のy座標
    float fingerLeavePosY; //タップし、指が画面から離れた瞬間のy座標
    float fingerNowPosY; //現在の指のy座標

    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        //指が画面に触れた瞬間のx座標を取得
        if(Input.GetMouseButtonDown(0))
        {
            fingerTouchPosX = Input.mousePosition.x;
            fingerTouchPosY = Input.mousePosition.y;
        }

        //指を画面から離した瞬間のx座標を取得
        if(Input.GetMouseButtonUp(0))
        {
            fingerLeavePosX = Input.mousePosition.x;
            fingerLeavePosY = Input.mousePosition.y;
        }

        //指が画面に触れている間の座標を取得
        if(Input.GetMouseButton(0))
        {
            fingerNowPosX = Input.mousePosition.x;
            fingerNowPosY = Input.mousePosition.y;
            float diffDistanceX = fingerNowPosX - fingerTouchPosX;
            float diffDistanceY = fingerNowPosY - fingerTouchPosY;
            diffDistanceX *= sensitivility;
            diffDistanceY *= sensitivility;

            float newX = Mathf.Clamp(pos.x+diffDistanceX, -2.5f, 2.5f);
            float newY = Mathf.Clamp(pos.y+diffDistanceY, -1f, 1f);
            pos.x = newX;
            pos.y = newY;
            myTransform.position = pos;

            fingerTouchPosX = fingerNowPosX;
            fingerTouchPosY = fingerNowPosY;
        }

        /*
        //指を画面にposDiff時間しか触れていないとタッチ判定
        if(Mathf.Abs(fingerTouchPosX - fingerLeavePosX) < posDiff)
        {
            Debug.Log("Touch");
        }

        //PosDiff時間以上触れているとスワイプ判定
        if(fingerNowPosX - fingerTouchPosX >= posDiff)
        {
            if(judgeFingerTouch)
            {
                pos.x += 0.01f;
                Debug.Log("MoveToRiget");
            }
        }
        else if(fingerNowPosX - fingerTouchPosX >= -posDiff)
        {
            if(judgeFingerTouch)
            {
                pos.x -= 0.01f;
                Debug.Log("MoveToLeft");
            }
        }

        */
    }
}
