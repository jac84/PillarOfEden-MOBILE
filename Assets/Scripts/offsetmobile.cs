using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offsetmobile : MonoBehaviour {
    public float offsetxrotation;
    public float offsety;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(offsetxrotation, transform.rotation.y, transform.rotation.z);
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
}
