using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    
    GameObject player;
    public int score = 0;
    private int _maxCoins;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<MovementController>().pickupEvent += ScoreUpdate;
        _maxCoins = GameObject.FindGameObjectsWithTag("Collectible").Length;
    }

    private void ScoreUpdate(){
        score++;
        if(score == _maxCoins){
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
