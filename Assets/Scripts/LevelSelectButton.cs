using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButton : MonoBehaviour
{
    public string LevelToLoad;

    public GameObject star1, star2, star3;

    // Start is called before the first frame update
    void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);

        if(PlayerPrefs.HasKey(LevelToLoad + "_Star1 "))
        {
            star1.SetActive(true);
        }

        if (PlayerPrefs.HasKey(LevelToLoad + "_Star2 "))
        {
            star2.SetActive(true);
        }

        if (PlayerPrefs.HasKey(LevelToLoad + "_Star3 "))
        {
            star3.SetActive(true);
        }
    }

   public void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

}
