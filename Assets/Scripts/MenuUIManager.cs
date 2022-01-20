using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    public InputField nameInput;
    
    // Start is called before the first frame update
    public void StartNew()
    {
        SetName();
        SceneManager.LoadScene(1);
    }

    void SetName()
    {
        InfoManager.Instance.TempName = nameInput.text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
