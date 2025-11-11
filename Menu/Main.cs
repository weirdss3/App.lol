using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.lol.Menu;
using easyInputs;
using MelonLoader;
using UnityEngine;

namespace App.lol
{
    // WHY IS THIS SO HARD AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
    internal class Main : MelonMod
    {
        public static GameObject menu;
        public static GameObject menuBackground;
        public static GameObject Pagebuttons;
        public static void Open()
        {

            bool ToOpen = EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand);
        }

        public static void CreateMenu()
        {
           menu = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(menu.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(menu.GetComponent<BoxCollider>());
            UnityEngine.Object.Destroy(menu.GetComponent<Renderer>());
            menu.transform.localScale = new Vector3(0.1f, 0.3f, 0.3825f);
            menuBackground = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(menuBackground.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(menuBackground.GetComponent<BoxCollider>());
            menuBackground.transform.parent = menu.transform;
            menuBackground.transform.rotation = Quaternion.identity;
            menuBackground.transform.localScale = new Vector3(0.1f, 1f, 1f);
            menuBackground.GetComponent<Renderer>().material.color = MenuVars.BackgroundColor;
            menuBackground.transform.position = new Vector3(0.05f, 0f, 0f);

            if (MenuHandler.PageButtons)
            {

            }
        }
    }
}
