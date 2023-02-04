using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data/MenuData")]
public class SO_MenuData : ScriptableObject
{
    public Scene[] sceneList;
    public bool[] scenesUnlocked;
}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data/PlayerData")]
public class SO_PlayerData : ScriptableObject
{
    //example
    public string PlayerName;
}
