using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScreen : MonoBehaviour
{
    // Start is called before the first frame update
   public void btn_change(string scence_name)
    {
        SceneManager.LoadScene(scence_name);
    }
}
