using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Options(){
        Debug.Log("Zmieniamyu ustawienia");
    }

    public void QuitGame(){
        Debug.Log("Zamykamy grę");
    }
}
