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
        
    }

   public void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

}
