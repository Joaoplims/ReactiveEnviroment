using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

namespace JP.UI
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(CanvasGroup))]
    public class UIScreen : MonoBehaviour
    {
        [Header("Properties")]
        [Tooltip("Select a Main UI Element from this screen to be on focus")]
        public Selectable Selectable;

        [Header("Events")]
        public UnityEvent OnScreenOpen = new UnityEvent();
        public UnityEvent OnScreenClose = new UnityEvent();


        private Animator animator;
        void Start()
        {
            animator = GetComponent<Animator>();
        }
        
        public virtual void OpenScreen()
        {
            OnScreenOpen?.Invoke();
            HandleAnimator("show");
            
        }

        public virtual void CloseScreen()
        {
            OnScreenClose?.Invoke();
            HandleAnimator("hide");
        }



        private void HandleAnimator(string trigger)
        {
            animator?.SetTrigger(trigger);
        }
    }
}