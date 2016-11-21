using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score_update : MonoBehaviour {

    public Text scoreCount;
    public static int score;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        scoreCount.text = "score: " + score;
    }
}
