﻿using FinTOKMAK.UIStackSystem.Runtime;
using NaughtyAttributes;
using UnityEngine;

namespace DefaultNamespace
{
    [AddComponentMenu("FinTOKMAK/UI Stack System/UI Stack Element/Main Panel")]
    public class SampleMainPanelElement : UIPanelElement
    {
        #region UIPanelElement Callback
        
        public override void OnPush()
        {
            // Activate self
            gameObject.SetActive(true);
            
            base.OnPush();
        }

        public override void OnPop()
        {
            base.OnPop();
            
            // Deactivate self
            gameObject.SetActive(false);
        }

        public override void OnPause()
        {
            base.OnPause();
            
            // Deactivate self
            gameObject.SetActive(false);
        }

        public override void OnResume()
        {
            // Activate self
            gameObject.SetActive(true);
            
            base.OnResume();
        }

        #endregion
    }
}