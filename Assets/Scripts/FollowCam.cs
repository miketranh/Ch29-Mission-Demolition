using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
	static public FollowCam S;
	public GameObject poi;
	public float camZ;

	// Use this for initialization
	void Awake () {
		S = this;
		camZ = this.transform.position.z;
	
	}//end of Awake()
	
	// Update is called once per frame
	void Update () {
		if (poi == null)
			return;
		Vector3 destination = poi.transform.position;
		destination.z = camZ;
		transform.position = destination;
	
	}//end of Update()
}//end of FollowCam script