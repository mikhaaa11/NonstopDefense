using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour{
    public static bool isGamePaused = true;

    public GameObject pauseMenuUI;
    public GameObject nonstopDefenseUI;

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (isGamePaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        nonstopDefenseUI.SetActive(true);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        nonstopDefenseUI.SetActive(false);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuittingGame(){
        Application.Quit();
    }
}
