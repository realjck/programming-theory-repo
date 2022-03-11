using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject splashscreen;
    [SerializeField] private GameObject tutoscreen;
    [SerializeField] private GameObject menuButtons;
    private bool isMenuOpen;

    // manage clicks
    public void ClickButtonMenu(){
        splashscreen.SetActive(false);
        ShowMenu(!isMenuOpen);
    }
    private void ShowMenu(bool visibility){
        menuButtons.SetActive(visibility);
        isMenuOpen = visibility;
    }

    public void ClickAddButton(int animalIndex){
        tutoscreen.SetActive(false);
        //TODO
        Debug.Log("spawn animal "+animalIndex);
        ShowMenu(false);
    }
}
