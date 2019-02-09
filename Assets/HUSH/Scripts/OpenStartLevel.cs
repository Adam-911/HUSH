using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenStartLevel : MonoBehaviour {

    // Метод загрузки стартовой сцены  
    public void startGame() {
        SceneManager.LoadScene("Start");
    }
    
    // Метод закрывает приложение
    public void quitGame() {
        Application.Quit();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
