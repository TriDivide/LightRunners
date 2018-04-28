using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour {


    private float minX, maxX, minY, maxY;
	// Use this for initialization
	void Start () {
        setMinMaxXAndY();
	}

    // Update is called once per frame
    void Update() {
        if (transform.position.x < minX) {
            Vector3 temp = transform.position;
            temp.x = minX;
            transform.position = temp;
        }

        if (transform.position.x > maxX) {
            Vector3 temp = transform.position;
            temp.x = maxX;
            transform.position = temp;
        }
        if (transform.position.y < minY) {
            Vector3 temp = transform.position;
            temp.y = minY;
            transform.position = temp;
        }

        if (transform.position.y > maxY) {
            Vector3 temp = transform.position;
            temp.y = maxY;
            transform.position = temp;
        }
    }

    void setMinMaxXAndY() {
        Vector3 Bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        minY = Bounds.y - 0.5f;
        maxY = -Bounds.y + 0.5f;

        minX = Bounds.x - 0.5f;
        maxX = -Bounds.x + 0.5f;
    }
}
