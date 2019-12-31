using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;	
	public Vector3 offset;		
	
	
	void Update () {
		// Set our position to the players position and offset it
		transform.position = player.position + offset;
	}
}
