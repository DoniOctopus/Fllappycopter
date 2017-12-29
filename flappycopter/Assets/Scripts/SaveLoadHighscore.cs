using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SaveLoadHighscore : MonoBehaviour {

	// inisialisasi variabel

    public Text teksHighscore;

	void Start () {
		// menampilkan highscore
        teksHighscore.text = "Highscore = " + LoadHighscore().ToString();
	}

	// melakukan load highscore yang berasal dari scene main
    public static int LoadHighscore()
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 0);
        }
        else
        {
            hg = PlayerPrefs.GetInt("highscore");
        }

        return hg;
    }

	//menyimpan highscore
    public static void SaveHighscore(int score){
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore",0);
        }
        else
        {
            hg = PlayerPrefs.GetInt("highscore");
            if (score > hg)
            {
                hg = score;
            }
            PlayerPrefs.SetInt("highscore", hg);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
