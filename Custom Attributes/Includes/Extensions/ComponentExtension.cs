using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// 2020. 05. 18.
    /// <para/> Component 확장
    /// <para/> -----------------------------------------------------------------------------------
    /// <para/> [목록]
    /// <para/> GetComponentInChildrenOnly : 자기 게임오브젝트를 제외하고,
    /// <para/>                              자식 게임오브젝트들에서만 컴포넌트 가져오기
    /// <para/> GetComponentInParentOnly : 자기 게임오브젝트를 제외하고,
    /// <para/>                            부모 게임오브젝트들에서만 컴포넌트 가져오기
    /// <para/> 
    /// </summary>
    public static class ComponentExtension
    {
        /// <summary>
        /// <para/> 자기 게임오브젝트를 제외하고 자식 게임오브젝트들에서만 컴포넌트 가져오기
        /// </summary>
        public static Component Ex_GetComponentInChildrenOnly(this Component @this, Type targetType)
        {
            Transform transform = @this.transform;

            if (transform.childCount.Equals(0))
                return null;

            int childCount = transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                var targetComponent = transform.GetChild(i).GetComponentInChildren(targetType);
                if (targetComponent != null)
                    return targetComponent;
            }

            return null;
        }

        /// <summary>
        /// <para/> 자기 게임오브젝트를 제외하고 부모 게임오브젝트들에서만 컴포넌트 가져오기
        /// </summary>
        public static Component Ex_GetComponentInParentOnly(this Component @this, Type targetType)
        {
            Transform transform = @this.transform;

            if (transform.parent == null)
                return null;

            return transform.parent.GetComponentInParent(targetType);
        }

        /// <summary> 비활성화된 게임오브젝트를 포함하여 모든 자식 게임오브젝트에서 컴포넌트 찾기 </summary>
        public static Component Ex_GetComponentInAllChildren(this Component @this, Type targetType)
        {
            List<Transform> childrenTrList = new List<Transform>();
            Recur_GetAllChildrenTransform(childrenTrList, @this.transform);

            foreach (var tr in childrenTrList)
            {
                var found = tr.GetComponent(targetType);
                if (found != null)
                    return found;
            }
            return null;
        }
        public static void Recur_GetAllChildrenTransform(List<Transform> trList, Transform tr)
        {
            trList.Add(tr);
            int childCount = tr.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Recur_GetAllChildrenTransform(trList, tr.GetChild(i));
            }
        }
    }
}
