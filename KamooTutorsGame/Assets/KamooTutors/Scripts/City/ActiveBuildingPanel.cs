using UnityEngine;

namespace KamooTutor
{

public class ActiveBuildingPanel : MonoBehaviour 
{
    
    [SerializeField]
    GameObject panel;

    bool state = false;

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)) TogglePanelActive();
    }

    void TogglePanelActive()
    {
        panel.SetActive(!state);
        state = !state;
    }
    
}

}