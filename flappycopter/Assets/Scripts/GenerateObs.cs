using UnityEngine;
using System.Collections;

public class GenerateObs : MonoBehaviour {

	// inisiasi variabel
    public GameObject rocks;
    public int score = 0;
    GUIStyle guistyle = new GUIStyle();

	
	//ketika mulai 
	void Start () {
		
		//munculkan rintangan batu secara berulang 
        InvokeRepeating("CreateObstacle",1f,1.5f);
        Instantiate(rocks);
	}

	// menampilkan batu rintangan dan skor
    void CreateObstacle()
    {
        Instantiate(rocks); // memanggil hindaran
        score++;//menampilkan skor
        SaveLoadHighscore.SaveHighscore(score);
        if (score >= 2) // jika skor lebih dari sama dengan 2 buka stage medium
        {
            GUIManager.saveLevel(1);
        }
        if (score >= 4) // jika skor lebih dari sama dengan 4 buka stage hard
        {
            GUIManager.saveLevel(2); // save level
        }
    }

	//menampilkan GUI
    void OnGUI()
    {
        GUI.color = Color.black;
        guistyle.fontSize = 40;
        GUI.Label(new Rect(0, 0, 300, 50), "Score: " + score.ToString(), guistyle);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
