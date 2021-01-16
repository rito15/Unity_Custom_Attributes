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
            Component targetComponent = null;
            Transform transform = @this.transform;

            if (transform.childCount.Equals(0))
                return null;

            int childCount = transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                targetComponent = transform.GetChild(0).GetComponentInChildren(targetType);
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
    }
}
