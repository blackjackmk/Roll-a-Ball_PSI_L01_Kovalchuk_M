using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 5f;
    public int score = 0;

    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        if(Input.GetKey(KeyCode.A)){
            //rb.AddForce(0, 0, -thrust,ForceMode.Impulse);
            //rb.AddForce(Vector3.left * thrust);
            rb.AddForce(new Vector3(0,0,-1) * thrust);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddForce(new Vector3(0,0,1) * thrust);
        }
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(new Vector3(-1,0,0) * thrust);
        }
        if(Input.GetKey(KeyCode.S)){
            rb.AddForce(new Vector3(1,0,0) * thrust);
        }
        if(Input.GetButtonUp("Jump")){
            rb.AddForce(new Vector3(0,1,0) * thrust);
        }
    }

    public void AddPoint(){
        score += 1;
        if(score == 6){
            scoreText.text = "You Won!";
            NextLevel();
        }else{
            scoreText.text = "Score: " + score;
        }
        
    }

    public void NextLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1, LoadSceneMode.Single);
    }
}
