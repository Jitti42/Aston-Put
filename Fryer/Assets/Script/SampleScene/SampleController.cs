using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SampleController : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("BonusScene");
    }

}
