using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

	// inisialisasi variabel
    public Button bEasy, bMed, bHard;
    
	
	void Start () {
		// mengambil variabel level yang sudah disimpan 
        try
        {
            loadButtonLevel();
            int levelState = LoadLevel();
            switch (levelState){
                case 0 :
                    bEasy.interactable = true;
                    break;
                case 1:
                    bEasy.interactable = true;
                    bMed.interactable = true;
                    break;
                case 2:
                    bEasy.interactable = true;
                    bMed.interactable = true;
                    bHard.interactable = true;
                    break;
            }
        }catch(NullReferenceException e){
            
        }
	}

	//load level berdasarkan skor yang disimpan
    public static int LoadLevel()
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level",0);
        }
        else
        {
            hg = PlayerPrefs.GetInt("level");
        }

        return hg;
    }

	// load button berdasarkan level
    void loadButtonLevel()
    {
        bEasy = GameObject.Find("easy").GetComponent<Button>();
        bMed = GameObject.Find("medium").GetComponent<Button>();
        bHard = GameObject.Find("hard").GetComponent<Button>();

        bEasy.interactable = bMed.interactable = bHard.interactable = false;
    }

	//menyimpan level berdasarkan skor
    public static void saveLevel(int level){
        if(!PlayerPrefs.HasKey("level")){
            PlayerPrefs.SetInt("level",0);
        }else{
            PlayerPrefs.SetInt("level",level);
        }
    }
	
	//load interface pilih level
    public void OnPlay()
    {
        SceneManager.LoadScene("multilevel");
    }

	// load level easy
    public void OnLevel1()
    {
        SceneManager.LoadScene("Main");
    }
	
	//load level medium
    public void OnLevel2()
    {
        SceneManager.LoadScene("Main");
    }

	
	//load level hard	
    public void OnLevel3()
    {
        SceneManager.LoadScene("Main");
    }

	//load interface credits
    public void OnCredits()
    {
        SceneManager.LoadScene("Credits");
    }

	//load interface help
    public void OnHelp()
    {
        SceneManager.LoadScene("Help");
    }

	//load interface menu
    public void OnBack()
    {
        SceneManager.LoadScene("Menu");
    }

	// Update is called once per frame
	void Update () {
	
	}
}
