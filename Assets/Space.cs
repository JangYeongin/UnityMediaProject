using UnityEngine;
using System.Collections.Generic;

public class Space
{
    public ObjectType spaceType;

    /*
    // LR이면 : left가 DrawBuff이고 right가 SendBuff이다.
    // RL이면 : right가 DrawBuff이고 left가 SendBuff이다. 
     */
    public SpaceDir spaceDir;

    public TargetDevice leftDevice;
    public TargetDevice rightDevice;

    public BoxCollider LeftBoxCol;
    public BoxCollider RightBoxCol;

    // L Buffer, R Buffer.
    public Queue<Vector3> leftBuff;
    public Queue<Vector3> rightBuff;

    public bool isNotEmptyBuff()
    {
        // Buffer가 비어있는지 확인하는 역활.

        switch (spaceDir)
        {
            case SpaceDir.LEFT:     /* RL */
                if (rightBuff.Count == 0)
                    return false;

                return true;

            case SpaceDir.RIGHT:    /* LR */
                if (leftBuff.Count == 0)
                    return false;

                return true;

            case SpaceDir.ZERO:     /* 초기상태 */
                Debug.Log("읽어올 버퍼가 없습니다.");

                return false;
        }

        return false;
    }

    public bool GetPosFromBuffer(out Vector3 outPos)
    {
        // Buffer를 읽어오는 역활을 한다.

        outPos = Vector3.zero;

        switch (spaceDir)
        {
            case SpaceDir.LEFT:     /* RL */
                if (rightBuff.Count == 0)
                    return false;

                outPos = rightBuff.Dequeue();

                return true;

            case SpaceDir.RIGHT:    /* LR */
                if (leftBuff.Count == 0)
                    return false;

                outPos = leftBuff.Dequeue();

                return true;

            case SpaceDir.ZERO:     /* 초기상태 */
                Debug.Log("읽어올 버퍼가 없습니다.");

                return false;
        }

        return false;
    }
}
