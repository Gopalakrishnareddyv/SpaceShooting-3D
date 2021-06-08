using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToNext()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToMain()
    {
        SceneManager.LoadScene(1);
    }
}
