using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string nameOfScene;

    private void Start()
    {
        SceneManager.LoadScene(nameOfScene);
    }
}
