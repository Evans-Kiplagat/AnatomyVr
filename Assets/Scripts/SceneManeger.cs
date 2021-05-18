using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManeger : MonoBehaviour
{
    [SerializeField] GameObject LoadingScreen;
    [SerializeField] Slider slider;
        
  public void Brain()
    {
        StartCoroutine(SceneBrain());
    }
    IEnumerator SceneBrain()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Brain");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }





    public void Cardiovascular()
    {
       StartCoroutine( SceneCardio());
        
    }

     IEnumerator SceneCardio ()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Cardiovascularr");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }


    public void DegestiveSystem()
    {
        StartCoroutine(SceneDegestive());
    }

    IEnumerator SceneDegestive()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Digestive_system");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }


    public void Heart()
    {
        StartCoroutine(SceneHeart());
    }

    IEnumerator SceneHeart()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Heart");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void Nervous()
    {
        StartCoroutine(SceneNervous());

    }

    IEnumerator SceneNervous()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Nervous");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
    public void Respiratory()
    {
        StartCoroutine(SceneRespiratory());
    }

    IEnumerator SceneRespiratory()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Respiratory");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
    public void Skeleton()
    {
        StartCoroutine(SceneSkeleton());

    }

    IEnumerator SceneSkeleton()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("skeleton");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void Skin()
    {
        StartCoroutine(SceneSkin());
    }
    IEnumerator SceneSkin()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Skin");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void Skull()
    {
        StartCoroutine(SceneSkull());
    }
    IEnumerator SceneSkull()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Skull");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void Liver()
    {
        StartCoroutine(SceneLiver());
    }
    IEnumerator SceneLiver()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Liver");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
    public void Colon()
    {
        StartCoroutine(SceneColon());
    }
    IEnumerator SceneColon()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Colon");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
    public void Home()
    {
        StartCoroutine(SceneHome());
    }
    IEnumerator SceneHome()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Home");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
    public void Lungs()
    {
        StartCoroutine(SceneLung());
    }
    IEnumerator SceneLung()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Lungs");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void Stomach()
    {
        StartCoroutine(SceneStomach());
    }
    IEnumerator SceneStomach()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Stomach");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void Trunk()
    {
        StartCoroutine(SceneTrunk());
    }
    IEnumerator SceneTrunk()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Trunk");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void legs()
    {
        StartCoroutine(Scenelegs());
    }
    IEnumerator Scenelegs()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Lower_ribs");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    public void Head()
    {
        StartCoroutine(SceneUpper());
    }
    IEnumerator SceneUpper()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Upper_ribs");
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
}
