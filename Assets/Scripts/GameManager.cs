using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    
    private GameObject player;
    private int score = 0;
    private int maxCoins;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<MovementController>().pickupEvent += ScoreUpdate;
        maxCoins = GameObject.FindGameObjectsWithTag("Collectible").Length;
    }

    private void ScoreUpdate(){
        score++;
        if(score == maxCoins){
            scoreText.text = "You Won!";
            Invoke(nameof(NextLevel), 2f);
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
