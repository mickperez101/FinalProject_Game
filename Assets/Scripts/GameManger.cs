using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    //Skin

    public GameObject selectedskin;
    public GameObject Player;
    private Sprite playersprite;


    public GameObject selectedanimation;
    private RuntimeAnimatorController animate;


    // Start is called before the first frame update
    void Start()
    {
        //skin 

        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;

        Player.GetComponent<SpriteRenderer>().sprite = playersprite;

        //animation

       animate = selectedanimation.GetComponent<Animator>().runtimeAnimatorController;

       Player.GetComponent<Animator>().runtimeAnimatorController = animate;

       
        

    }

   


}
