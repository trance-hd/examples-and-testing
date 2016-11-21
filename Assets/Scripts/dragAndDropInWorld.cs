using UnityEngine;
using System.Collections;

public class dragAndDropInWorld : MonoBehaviour {
	private bool dragging = false;

	void OnMouseDown(){
		dragging = true;
	}

	void OnMouseUp(){
		dragging = false;
	}
	
	void Update(){
		Plane plane = new Plane (Vector3.up, new Vector3 (0, 30, 0));
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		float distance;
		if (dragging){

			if (plane.Raycast (ray, out distance)) {
				transform.position = ray.GetPoint (distance);
			}
		}
	}
}
