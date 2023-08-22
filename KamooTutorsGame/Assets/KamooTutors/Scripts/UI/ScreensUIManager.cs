using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

namespace KamooTutor
{
public class ScreensUIManager : MonoBehaviour
{

    public static ScreensUIManager instance;

    UIDocument talkScreen;

    void Awake()
    {
        // Garante que o objeto funcione como Singleton.
        if(instance == null) 
        {
            instance = this;
        }
        else 
        {
            Destroy(this.gameObject);
        }

        CheckCurrentScreen();
    }

    public UIDocument GetTalkScreenDocument()
    {
        return talkScreen;
    }

    public void ToggleChatVisibility(bool state)
    {
        VisualElement chatPanel = talkScreen.rootVisualElement.Q<VisualElement>("chat_panel");
        if(state)
        {
            chatPanel.style.visibility = Visibility.Visible;
        }
        else if(!state)
        {
            chatPanel.style.visibility = Visibility.Hidden;
        }
    }

    public void ActivateButtons()
    {
        GameObject.Find(GameObjectsName.talkScreenDocument).GetComponent<TalkScreenButtons>().SetButtons(talkScreen);
    }

    void ActivateTalkScreen()
    {
        talkScreen = GameObject.Find(GameObjectsName.talkScreenDocument).GetComponent<UIDocument>();
        ActivateButtons();
    }

    public void CheckCurrentScreen()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case "WorldViewScene":
                break;
            default:
                ActivateTalkScreen();
                break;
        }
    }

}
}