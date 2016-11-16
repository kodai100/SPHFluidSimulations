﻿using UnityEngine;
using System.Collections;

public class WallAnimation : MonoBehaviour {

    private Vector3 min, max;
    private Vector3 length;
    public float speed = 1.0f;
    public float startTime = 10f;

	// Use this for initialization
	void Start () {
        min = GetComponent<GPUSPHParticleSystem>().MIN;
        max = GetComponent<GPUSPHParticleSystem>().MAX;
        length = max - min;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.realtimeSinceStartup > startTime){
            float res = min.x + length.x / 4 + length.x / 4 * Mathf.Sin(speed * Time.realtimeSinceStartup);
            GetComponent<GPUSPHParticleSystem>().MIN.x = res;
        }

    }
}