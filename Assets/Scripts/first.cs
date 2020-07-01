using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class first : MonoBehaviour
{
    public Button button;
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
        
    }

   private void OnButtonClick()
    {
        Debug.Log("Button clicked");
    }
}
