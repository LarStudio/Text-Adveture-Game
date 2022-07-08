using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    //make scenes in between with _ e.g: 1_1, 2_3, 2_1
    
    public void S0()
    {
        SceneManager.LoadScene("s 0");
    }
    public void S1()
    {
        SceneManager.LoadScene("s 1");
    }
    public void S2()
    {
        SceneManager.LoadScene("s 2");
    }
    public void S3()
    {
        SceneManager.LoadScene("s 3");
    }
    public void S4()
    {
        SceneManager.LoadScene("s 4");
    }
    public void S5()
    {
        SceneManager.LoadScene("s 5");
    }
}
