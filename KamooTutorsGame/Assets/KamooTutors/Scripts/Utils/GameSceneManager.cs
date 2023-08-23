using UnityEngine;
using UnityEngine.SceneManagement;

namespace KamooTutor
{

public class GameSceneManager : MonoBehaviour
{

    public static GameSceneManager instance;

    void Awake() 
    {
        if(instance == null) 
        {
            instance = this;
        }
        else 
        {
            Destroy(this.gameObject);
        }
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}

}