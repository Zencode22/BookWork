using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public string CharacterClass = "Ranger";

    void Start()
    {
        int CharacterHealth = 100;
        Debug.Log(CharacterClass + " - HP: " + CharacterHealth);
    }

    void CreateCharacter()
    {
        string CharacterName = "Aragon";
        Debug.Log(CharacterName + " - " + CharacterClass);
    }
}