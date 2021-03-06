﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    private UnityEngine.UI.Text text;
    private float score = 0;

    public string format = "00000000";

	// Use this for initialization
	void Start () {
        text = GetComponent<UnityEngine.UI.Text>();
        OnReset();
	}

    public void OnReset() {
        score = 0;
    }

    public void OnScoreInc(float inc) {
        score += inc;
    }

    public void OnScoreDec(float inc) {
        score -= inc;
        score = Mathf.Max(score, 0);
    }

	// Update is called once per frame
	void Update () {
        text.text = score.ToString(format);
	}
}
