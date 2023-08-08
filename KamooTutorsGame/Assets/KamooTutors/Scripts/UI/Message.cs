using UnityEngine;
using UnityEngine.UIElements;

public class Message : MonoBehaviour
{

    UIDocument chatBoxRow;
    Label messageText;
    VisualElement icon;

    public Message(string _msg, Sprite iconSprite)
    {
        messageText.text = _msg;
        if(iconSprite != null) icon.style.backgroundImage = new StyleBackground(iconSprite);
    }
}