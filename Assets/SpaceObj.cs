using UnityEngine;
using System.Collections;

enum ObjState { MOVE, STOP}

public class SpaceObj : MonoBehaviour {

    public float moveSpeed = 1.0f;

    private Transform currPos;
    private Rigidbody currRigid;
    private ObjState currState;
    private Vector3 currVelocity;

    void OnEnable() {
        currPos = this.GetComponent<Transform>();
        currRigid = this.GetComponent<Rigidbody>();
        currVelocity = Vector3.zero;
    }

    void FixedUpdate() {
        switch(currState)
        {
            case ObjState.MOVE:
                currRigid.velocity = currVelocity;
                break;

            case ObjState.STOP:
                currRigid.velocity = Vector3.zero;
                  
                break;
        }
        
    }

    void SetVelocity(Vector3 _vel)
    {
        currVelocity = _vel;
    }	
}
