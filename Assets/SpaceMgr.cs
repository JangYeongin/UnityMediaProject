using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <SpaceState>
/// READY : 각종 초기화를 진행하고 실행대기상태.
/// IDLE : 런타임 상태.
/// GAMEOVER : 새로운 유저가 Name을 입력. ( 모든 오브젝트가 파괴된다.)
/// WAIT : 런타임 상태 도중 메뉴를 터치한 상태.
/// </SpaceState>
public enum SpaceState {READY, IDLE, GAMEOVER, WAIT}

// Device 마다의 Type (15개)
public enum ObjectType {ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, ELEVEN, TWELVE, THIRTEEN, FOURTEEN, FIFTEEN }
public enum TargetDevice { ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, ELEVEN, TWELVE, THIRTEEN, FOURTEEN, FIFTEEN }

public enum SpaceDir {LEFT, RIGHT, ZERO}

public class SpaceMgr : MonoBehaviour {

    public SpaceState nowSpaceState = SpaceState.READY;

    public ObjectType currType;

    private Space nowSpaceInfo = new Space();

    void OnEnable() {
        nowSpaceInfo.spaceType = ObjectType.ONE;
        nowSpaceInfo.spaceDir = SpaceDir.ZERO;
        nowSpaceInfo.leftDevice = TargetDevice.ONE;
        nowSpaceInfo.rightDevice = TargetDevice.TWO;

        nowSpaceInfo.leftBuff = new Queue<Vector3>();
        nowSpaceInfo.rightBuff = new Queue<Vector3>();        
    }
	
	
	// Update is called once per frame
	void Update () {
	    switch(nowSpaceState)
        { 
            case SpaceState.READY:

            case SpaceState.IDLE:
                
             
                

                break;
        }
	}
}
