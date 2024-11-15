using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour
{

    public GameObject OptionsPanel;
    public GameObject MainPanel;

    public GameObject EndGamePanel;
    public void StartGame(){
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void SettingSwitcher(bool isActive){
        OptionsPanel.SetActive(!isActive);
        MainPanel.SetActive(isActive);
    }

    public void ExitToMenu(){
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
