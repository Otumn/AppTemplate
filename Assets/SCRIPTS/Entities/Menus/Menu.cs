using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Otumn.Frigo
{
    public class Menu : Entity
    {
        [SerializeField] private string menuName = "Menu";
        [SerializeField] private GameObject menuGO;

        public virtual void FocusMenu()
        {
            menuGO.SetActive(true);
        }

        public virtual void UnfocusMenu()
        {
            menuGO.SetActive(false);
        }
    }
}
