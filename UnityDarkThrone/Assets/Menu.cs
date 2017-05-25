using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void ButtonStart(int Tutorial)
    {
        SceneManager.LoadScene(Tutorial);
    }

}

