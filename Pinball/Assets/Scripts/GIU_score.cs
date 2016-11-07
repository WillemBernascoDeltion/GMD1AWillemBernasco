using UnityEngine;
using System.Collections;

public class GIU_score : MonoBehaviour {

    public int huidigeScore;
    public int highScore;
    public int levens;
    public bool bool1 = true;
    public bool bool2 = true;
    public bool bool3 = true;

    public Texture2D plaatje;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (levens == 3)
        {

            bool1 = true;
            bool2 = true;
            bool3 = true;
        }

        if (levens == 2)
        {
            bool1 = true;
            bool2 = true;
            bool3 = false;

        }

        if (levens == 1)
        {
            bool1 = true;
            bool2 = false;
            bool3 = false;
        }
    }
        void OnGUI ()
    {

        if(bool1 == true)
        {

            GUI.DrawTexture(new Rect(0, 0, 60, 60), plaatje);

        }

        if (bool2 == true)
        {

            GUI.DrawTexture(new Rect(60, 0, 60, 60), plaatje);

        }

        if (bool3 == true)
        {

            GUI.DrawTexture(new Rect(120, 0, 60, 60), plaatje);

        }
    }
}
