using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject iconPrefab;
    private GameObject player;
    private int score = 0;
    private int maxCoins;
    private Image[] icons;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<MovementController>().pickupEvent += ScoreUpdate;
        maxCoins = GameObject.FindGameObjectsWithTag("Collectible").Length;
        //generate uncollected icons
        icons = new Image[maxCoins];
        for(int i = 0; i < maxCoins; i++){
            Instantiate(iconPrefab, transform);
            GameObject newIcon = transform.GetChild(i).gameObject;
            icons[i] = newIcon.GetComponent<Image>();
        }
    }

    private void ScoreUpdate(){
        score++;
        for(int i = 0; i < score; i++){
                icons[i].color = Color.yellow;
        }
        if(score == maxCoins){
            Invoke(nameof(NextLevel), 1f);
            score = 0;
        }
    }

    public void NextLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1, LoadSceneMode.Single);
    }
}
