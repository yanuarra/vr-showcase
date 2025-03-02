using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TCO.VRShowcase
{
    public class ModuleSelectionItem : MonoBehaviour
    {
        [SerializeField]
        private RawImage _thumbnail;
        [SerializeField]
        private AspectRatioFitter _aspectRatioFitter;
        [SerializeField]
        private TMP_Text _text_Title;
        [SerializeField]
        private TMP_Text _text_Description;
        private ModuleData _moduleData;


        public void InitItem(ModuleData moduleData)
        {
            _moduleData = moduleData;
            _thumbnail.texture = _moduleData.Thumbnail;
            _aspectRatioFitter.aspectRatio = (float)_thumbnail.texture.width /(float)_thumbnail.texture.height;
            _text_Title.text = _moduleData.Title;
            _text_Description.text = _moduleData.Description;
        }

        public void OpenModule()
        {
            SceneManager.Instance.OpenScene(_moduleData.SceneName);
        }
    }
}
