using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuSrcpt : MonoBehaviour
{
    public void gotoMainMenu () {
        SceneManager.LoadScene("MainMenu");
    }
}
