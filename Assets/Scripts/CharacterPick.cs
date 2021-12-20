using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class CharacterPick : MonoBehaviour
{

    //returns to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


    //Character Selection
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerskin;

   

    //Next Selection
    public void NextCharacter()
    {
        selectedSkin = selectedSkin + 1;
        
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }

        

        sr.sprite = skins[selectedSkin];
    }

    //Back Selection
    public void PreviousCharacter()
    {
        selectedSkin = selectedSkin - 1;


        
        if (selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }
        

        
        sr.sprite = skins[selectedSkin];

        
    }

 


    //enters the game
    public void EnterGame()
    {
        //Skin Selection
        
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/PreFabs/selectedskin.prefab");


        

    


        SceneManager.LoadScene(2);
    }

}
