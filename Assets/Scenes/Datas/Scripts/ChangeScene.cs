using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{

    public void ChangeLaScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

}
