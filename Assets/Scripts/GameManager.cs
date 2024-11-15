using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    
    GameObject player;
    public int score = 0;
    private int MaxCoins;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<MovementController>().pickupEvent += ScoreUpdate;
        MaxCoins = GameObject.FindGameObjectsWithTag("Collectible").Length;
    }

    private void ScoreUpdate(){
        score++;
        if(score == MaxCoins){
            scoreText.text = "You Won!";
            NextLevel();
            score = 0;
        }else{
            scoreText.text = "Score: " + score;
        }
    }

    public void NextLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1, LoadSceneMode.Single);
    }
}
