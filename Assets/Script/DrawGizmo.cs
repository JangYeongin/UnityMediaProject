using UnityEngine;
using System.Collections;

public class DrawGizmo : MonoBehaviour {

	void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 1);
    }
}
