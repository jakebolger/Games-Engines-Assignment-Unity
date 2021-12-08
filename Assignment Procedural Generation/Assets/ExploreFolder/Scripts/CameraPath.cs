using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPath : MonoBehaviour
{
	//Creating variable for speed
	//
	public float speed = 3f;
	//variable for the transform of the path
	//
	public Transform pathParent;
	//transform off the points
	//
	Transform targetPoint;
	//creating an index
	//
	int index;

	//OnDrawGizmos method called every fram to draw the checkpoints in the scene view. (visual aids)
	//
	void OnDrawGizmos()
	{
		//creating two vector3s
		//
		Vector3 from;
		Vector3 to;
		//for loop to set from and to vectors, get position of parent, and put them into from and to vectors
		//
		for (int a = 0; a < pathParent.childCount; a++)
		{
			from = pathParent.GetChild(a).position;
			to = pathParent.GetChild((a + 1) % pathParent.childCount).position;
			//setting colours and drawing lines
			//
			Gizmos.color = new Color(1, 0, 0);
			Gizmos.DrawLine(from, to);
		}
	}
	//start function to set index to 0 and set targert point to pathParent.Getchild(index)
	//
	void Start()
	{
		index = 0;
		targetPoint = pathParent.GetChild(index);
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
		if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
		{
			index++;
			index %= pathParent.childCount;
			targetPoint = pathParent.GetChild(index);
		}
	}
}
