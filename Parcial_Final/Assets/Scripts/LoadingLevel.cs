using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingLevel : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        string levelToLoad = LoadLevel.nextLevel;
        StartCoroutine(StartLoading(levelToLoad));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StartLoading(string level) {
        yield return new WaitForSeconds(3);
        AsyncOperation operation = SceneManager.LoadSceneAsync(level);
        operation.allowSceneActivation = false;
        while (!operation.isDone)
        {
            if (operation.progress>=0.9f)
            {
                text.text = "Nivel Cargado";
                operation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
