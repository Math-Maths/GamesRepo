using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MessageInstante : MonoBehaviour
{

    UIDocument talkScreen;
    TextField textField;
    Button sendButton;
    
    public VisualTreeAsset chatBoxRow;
    public VisualTreeAsset answerChatBoxRow;
    
    void OnEnable() 
    {
        talkScreen = GetComponent<UIDocument>();
        textField = talkScreen.rootVisualElement.Q<TextField>("text_field");
        sendButton = talkScreen.rootVisualElement.Q<Button>("send_button");
        
        sendButton.RegisterCallback<ClickEvent>(OnClickSend);
    }

    void OnClickSend(ClickEvent evt)
    {
        if(textField.value != null && textField.value.Length > 0)
        {
            SendMessage(chatBoxRow);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SendMessage(answerChatBoxRow);
        }
    }

    void SendMessage(VisualTreeAsset chatBox)
    {
        VisualElement chatBoxRoot = chatBox.Instantiate();
        Label textMessage = chatBoxRoot.Q<Label>("text");
        textMessage.text = textField.value;
        talkScreen.rootVisualElement.Q("chat_colunm").Add(chatBoxRoot);
    }
}
