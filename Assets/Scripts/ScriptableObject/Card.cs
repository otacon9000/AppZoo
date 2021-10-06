using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Card", menuName = "Card") ]
public class Card : ScriptableObject
{

    public string title;
    public string description;
    public string footer;
    public Sprite photo;
    
}
