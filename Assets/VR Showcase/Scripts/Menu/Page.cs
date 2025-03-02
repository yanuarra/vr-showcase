using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TCO.VRShowcase
{
    public class Page : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent _unityEvent_OnOpen;
        [SerializeField]
        private UnityEvent _unityEvent_OnClose;
        [SerializeField]
        private GameObject _page;

        private void Start()
        {
            if (!PageManager.Instance.IsDefaultPage(this))
            {
                Close();
            }
        }

        public void Open()
        {
            _page.SetActive(true);
            _unityEvent_OnOpen?.Invoke();
        }

        public void Close()
        {
            _unityEvent_OnClose?.Invoke();
            _page.SetActive(false);
        }
    }
}
