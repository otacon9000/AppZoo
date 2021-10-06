using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text footer;
    public Image photo;


    public Card[] cards;




   public void DisplayCard(int cardNumber)
    {
        title.text = cards[cardNumber].title;
        description.text = cards[cardNumber].description;
        footer.text = cards[cardNumber].footer;
        photo.sprite = cards[cardNumber].photo;

    }

}
