using System;
using UnityEngine;

public class Animalerie : MonoBehaviour
{
    [SerializeField] private Chat monChat;
    private Chat ChatDeBenji;
    private void Start()
    {
        Debug.Log(monChat.GetName());
        ChatDeBenji = GetComponent<Chat>();
        Debug.Log(ChatDeBenji.GetName());
        monChat.name = "bouboule";
        
        
    }
}
