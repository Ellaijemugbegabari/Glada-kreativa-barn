using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Ella
public class PlayButton : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("Spel");
    }
}
