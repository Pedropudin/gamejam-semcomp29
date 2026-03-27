using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 
public class LevelLoader : MonoBehaviour 
{ 
	public Animator transition; 
	public float transitionTime = 1f;
    private float trasitionEndDelay = 0.2f;         // Delay in the end to ensure the transition is finished

    public void LoadLevel(string levelName)
    {
        StartCoroutine(LoadLevelCoroutine(levelName));
    }

    IEnumerator LoadLevelCoroutine(string levelName)
    {
        Debug.Log(levelName + " carregado");
        transition.SetTrigger("Start");  
        yield return new WaitForSeconds(transitionTime + trasitionEndDelay);
        SceneManager.LoadScene(levelName);
    }

}