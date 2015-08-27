using UnityEngine;
using System.Collections;

public class InputMgr : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update(){
      int count = Input.touchCount;
      if( count == 0 ) return;
      for (int i = 0; i < count; ++i)
      {
          Touch touch = Input.GetTouch(i);
          Debug.Log("id:" + touch.fingerId + ",phase:" + touch.phase);
      }
    }
}
