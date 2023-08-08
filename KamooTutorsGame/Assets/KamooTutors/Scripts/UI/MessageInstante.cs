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
    
    void OnEnable() 
    {
        talkScreen = GetComponent<UIDocument>();
        textField = talkScreen.rootVisualElement.Q<TextField>("text_field");
        sendButton = talkScreen.rootVisualElement.Q<Button>("send_button");

        TemplateContainer chatBoxContainer = chatBoxRow.Instantiate();
        talkScreen.rootVisualElement.Q("chat_colunm").Add(chatBoxContainer);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
