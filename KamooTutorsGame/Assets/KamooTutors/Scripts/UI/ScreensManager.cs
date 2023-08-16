using UnityEngine;
using UnityEngine.UIElements;

namespace KamooTutor
{
public class ScreensManager : MonoBehaviour
{

    public static ScreensManager instance;

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

        talkScreen = GameObject.Find(GameObjectsName.talkScreenDocument).GetComponent<UIDocument>();
        GameObject.Find(GameObjectsName.talkScreenDocument).GetComponent<TalkScreenButtons>().SetButtons(talkScreen);
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

}
}