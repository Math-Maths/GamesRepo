using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace KamooTutor
{
public class MessageInstante : MonoBehaviour
{

    UIDocument talkScreen;
    TextField textField;
    ScrollView scrollView;
    
    public VisualTreeAsset chatBoxRow;
    public VisualTreeAsset answerChatBoxRow;
    
    void OnEnable() 
    {
        talkScreen = ScreensManager.instance.GetTalkScreenDocument();

        scrollView = talkScreen.rootVisualElement.Q<ScrollView>("chat_colunm");
        textField = talkScreen.rootVisualElement.Q<TextField>("text_field");
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SendAnswer();
        }
    }

    public void SendMessage()
    {
        VisualElement chatBoxRoot = chatBoxRow.Instantiate();
        Label textMessage = chatBoxRoot.Q<Label>("text");
        textMessage.text = textField.value;
        talkScreen.rootVisualElement.Q("chat_colunm").Add(chatBoxRoot);
    }

    public void SendAnswer()
    {
        VisualElement chatBoxRoot = answerChatBoxRow.Instantiate();
        Label textMessage = chatBoxRoot.Q<Label>("text");
        textMessage.text = textField.value;
        talkScreen.rootVisualElement.Q("chat_colunm").Add(chatBoxRoot);
    }
}
}
