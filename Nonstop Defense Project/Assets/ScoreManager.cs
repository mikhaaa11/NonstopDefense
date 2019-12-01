using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

    public GameObject gameOverUI;
    public GameObject NonstopDefenseTextUI;

	public int lives = 20;
	public int money = 100;

	public Text moneyText;
	public Text livesText;

    public bool isGameOver = false;


	public void LoseLife(int l = 1) {
		lives -= l;
		if(lives <= 0) {
			GameOver();
		}
	}

	public void GameOver() {
		Debug.Log("Game Over");
        // TODO: Send the player to a game-over screen instead!
        isGameOver = true;
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        NonstopDefenseTextUI.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Retry(){
        gameOverUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void LoadMenu2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuittingGame2()
    {
        Application.Quit();
    }

    void Update() {
		// FIXME: This doesn't actually need to update the text every frame.
		moneyText.text = "Money: $" + money.ToString();
		livesText.text = "Lives: "  + lives.ToString();

	}

}
