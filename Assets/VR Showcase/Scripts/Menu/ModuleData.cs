using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TCO.VRShowcase
{
    [CreateAssetMenu]
    [Serializable]
    public class ModuleData : ScriptableObject
    {
        public Texture Thumbnail;
        public string Title;
        [TextArea]
        public string Description;
        public string SceneName;
    }
}
