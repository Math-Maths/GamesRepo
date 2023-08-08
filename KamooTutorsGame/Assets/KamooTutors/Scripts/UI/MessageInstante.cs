using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MessageInstante : MonoBehaviour
{

    UIDocument talkScreen;
    TextField textField;
    Button sendButton;
    VisualElement chatBoxRoot;
    Label textMessage;
    
    public VisualTreeAsset chatBoxRow;
    
    void OnEnable() 
    {
        talkScreen = GetComponent<UIDocument>();
        textField = talkScreen.rootVisualElement.Q<TextField>("text_field");
        sendButton = talkScreen.rootVisualElement.Q<Button>("send_button");
        
        sendButton.RegisterCallback<ClickEvent>(OnClickSend);

        // TemplateContainer chatBoxContainer = chatBoxRow.Instantiate();
        // talkScreen.rootVisualElement.Q("chat_colunm").Add(chatBoxContainer);
    }

    void OnClickSend(ClickEvent evt)
    {
        if(textField.value != null && textField.value.Length > 0)
        {
            // Debug.Log(textField.value);
            // textField.value = "";
            // TemplateContainer chatBoxContainer = chatBoxRow.Instantiate();
            // talkScreen.rootVisualElement.Q("chat_colunm").Add(chatBoxContainer);
            chatBoxRoot = chatBoxRow.Instantiate();
            textMessage = chatBoxRoot.Q<Label>("text");
            textMessage.text = textField.value;

            talkScreen.rootVisualElement.Q("chat_colunm").Add(chatBoxRoot);
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
