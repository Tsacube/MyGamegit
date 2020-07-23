using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToScenes : MonoBehaviour
{
	public void ToLevels(int scenenumber)
    {
        SceneManager.LoadScene(scenenumber);
        Time.timeScale = 1;
    }
}
