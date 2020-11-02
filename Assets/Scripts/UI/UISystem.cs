using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace JP.UI
{
    public class UISystem : MonoBehaviour
    {
        public UIScreen CurrentScreen => currentScreen;
        public UIScreen PreviousScreen => previousScreen;
        public UnityEvent OnScreenChange = new UnityEvent();

        private UIScreen[] screens = new UIScreen[0];
        private UIScreen currentScreen;
        private UIScreen previousScreen;


        void Start()
        {
            screens = GetComponentsInChildren<UIScreen>(true);
        }

        public void SwitchScreens(UIScreen newScreen)
        {
            if (newScreen)
            {
                if (currentScreen)
                {
                    //currentScreen.Close();
                    previousScreen = currentScreen;
                }

                currentScreen = newScreen;
                currentScreen.gameObject.SetActive(true);
                //currentScreen.StartScreen();

                OnScreenChange?.Invoke();
            }
        }

        public void SwitchToPreviousScreen()
        {
            if (previousScreen) SwitchScreens(previousScreen);
        }
    }
}
