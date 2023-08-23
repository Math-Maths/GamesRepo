using UnityEngine;

namespace KamooTutor
{

public class Panel : MonoBehaviour
{

    [SerializeField]
    string sceneToGo;

    void OnMouseOver()
    {
        if(Input.GetMouseButtonUp(0))
        {
            GameSceneManager.instance.GoToScene(sceneToGo);
        }
    }

}

}