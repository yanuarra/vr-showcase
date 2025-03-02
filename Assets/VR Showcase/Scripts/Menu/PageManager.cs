using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TCO.VRShowcase
{
    public class PageManager : Singleton<PageManager>
    {
        [SerializeField]
        private Page _defaultPage;
        private Page _currentPage;

        private void Start()
        {
            OpenPage(_defaultPage);
        }

        public void OpenPage(Page page)
        {
            CloseCurrentPage();
            _currentPage = page;
            _currentPage.Open();
        }

        private void CloseCurrentPage()
        {
            if (_currentPage != null)
            {
                _currentPage.Close();
            }
        }

        public bool IsDefaultPage(Page page)
        {
            return _defaultPage == page;
        }
    }
}
