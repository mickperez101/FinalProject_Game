using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class AnimationPick : MonoBehaviour
{
    //Animation Based on Selection
    public Animator ar;
    public List<RuntimeAnimatorController> animation = new List<RuntimeAnimatorController>();
    private int selectedAnimation = 0;
    public GameObject playerAnimation;

    private void Start()
    {
        selectedAnimation = 0;
        ar.runtimeAnimatorController = animation[selectedAnimation];
    }

    public void NextAnimation ()
    {
        selectedAnimation = selectedAnimation + 1;

        if (selectedAnimation == animation.Count)
        {
            selectedAnimation = 0;
        }

        ar.runtimeAnimatorController = animation[selectedAnimation];
    }

    public void PreviousAnimation()
    {
        if (selectedAnimation < 0)
        {
            selectedAnimation = animation.Count - 1;
        }

        ar.runtimeAnimatorController = animation[selectedAnimation];
    }

    public void EnterAnimation()
    {
        //Animation Selection
        PrefabUtility.SaveAsPrefabAsset(playerAnimation, "Assets/PreFabs/selectedAnimation.prefab");
        SceneManager.LoadScene(2);
        
    }

}
