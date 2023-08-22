using UnityEngine;
using UnityEngine.UIElements;

namespace KamooTutor
{
public class TalkScreenButtons : MonoBehaviour 
{

    UIDocument talkScreen;

    Button sendButton, chatButton, microphoneButton, translateButton;


    void ActivateChat(ClickEvent click)
    {
        ScreensUIManager.instance.ToggleChatVisibility(true);
    }

    public void SetButtons(UIDocument talkDocument)
    {
        talkScreen = talkDocument;
        chatButton = GetButton(GameObjectsName.chatButton);
        chatButton.RegisterCallback<ClickEvent>(ActivateChat);

        sendButton = GetButton(GameObjectsName.sendButton);
        sendButton.RegisterCallback<ClickEvent>(SendMessage);

        microphoneButton = GetButton(GameObjectsName.microphoneButton);
        microphoneButton.RegisterCallback<ClickEvent>(ListenPlayer);

        translateButton = GetButton(GameObjectsName.translateButton);
        translateButton.RegisterCallback<ClickEvent>(TranslateChat);
    }

    Button GetButton(string button_name)
    {
        return talkScreen.rootVisualElement.Q<Button>(button_name);
    }

    void SendMessage(ClickEvent click)
    {
        MessageInstante messageInstante = GetComponent<MessageInstante>();
        messageInstante.SendMessage();
    }

    void ListenPlayer(ClickEvent click)
    {

    }

    void TranslateChat(ClickEvent click)
    {
        
    }

}
}