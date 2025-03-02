using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TCO.VRShowcase
{
    public class ModuleSelectionPage : MonoBehaviour
    {
        [SerializeField]
        private List<ModuleData> _list_ModuleData;
        [SerializeField]
        private ObjectPool _pool_ModuleSelectionItem;
        [SerializeField]
        private Transform _container_ModuleSelectionItem;

        public void SpawnAllModuleSelectionItem()
        {
            ResetAllModuleSelectionItem();
            for (int i = 0; i < _list_ModuleData.Count; i++)
            {
                ModuleSelectionItem item = _pool_ModuleSelectionItem.GetObjectFromPool().GetComponent<ModuleSelectionItem>();
                item.transform.SetParent(_container_ModuleSelectionItem);
                item.transform.localPosition = Vector3.zero;
                item.transform.localRotation = Quaternion.identity;
                item.transform.localScale = Vector3.one;
                item.InitItem(_list_ModuleData[i]);
            }
        }

        private void ResetAllModuleSelectionItem()
        {
            ModuleSelectionItem[] items = _container_ModuleSelectionItem.GetComponentsInChildren<ModuleSelectionItem>();
            foreach (ModuleSelectionItem item in items)
            {
                _pool_ModuleSelectionItem.AddObjectToPool(item.gameObject);
            }
        }
    }
}
