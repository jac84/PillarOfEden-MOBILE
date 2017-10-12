using UnityEngine;
using System.Collections;

public class WatcherScript : MonoBehaviour {
    [SerializeField]
    private GameObject[] myTowers;

	// Update is called once per frame
	void Update () {
        if(Input.touchCount > 0)
        {
            Touch myTouch = Input.touches[0]; // The first touch
            Instantiate(myTowers[0], new Vector3(myTouch.position.x, myTouch.position.y, 0), Quaternion.identity);
            // Just instantiates a rook tower where the touch was
        }
	}
}
