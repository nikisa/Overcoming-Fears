using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public PlayerManager player;
    public float distance;
    Vector3 PlayerPOS = GameObject.Find("Player").transform.position;
    int DistanceAway = 10;



    // Use this for initialization
    void Start () {
        PlayerPOS = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        followPlayer();
    }

    void followPlayer() {
        
        GameObject.Find("MainCamera").transform.position = new Vector3(PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - DistanceAway);
    }
}
