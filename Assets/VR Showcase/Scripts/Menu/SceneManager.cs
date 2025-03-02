using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TCO.VRShowcase
{
    public class SceneManager : Singleton<SceneManager>
    {
        private string _sceneName;

        public void OpenScene(string sceneName)
        {
            _sceneName = sceneName;
            StartCoroutine(OpenSceneCoroutine());
        }


        private IEnumerator OpenSceneCoroutine()
        {
            yield return new WaitForEndOfFrame();
            UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName);
        }
    }
}
