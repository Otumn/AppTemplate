using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Otumn.Frigo
{
    public class MenusManager : Entity
    {
        [SerializeField] private Menu[] menuArray;

        private Menu currentMenu;
        private int currentMenuIndex;

        public override void OnManagersInitialized()
        {
            base.OnManagersInitialized();
            currentMenu = menuArray[0];
            currentMenuIndex = 0;
            currentMenu.FocusMenu();
        }

        public void SelectNewMenu(int menuInt)
        {
            if (menuInt >= menuArray.Length) return;
            if (menuArray[menuInt] == currentMenu) return;

            currentMenu.UnfocusMenu();
            currentMenu = menuArray[menuInt];
            currentMenuIndex = menuInt;
            currentMenu.FocusMenu();

            AppManager.appInstance.CallOnMenuSwitched(currentMenu);
        }

        public int CurrentMenuIndex { get => currentMenuIndex; }
    }
}
