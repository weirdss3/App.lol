using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.lol.Menu;
using easyInputs;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace App.lol
{
    // WHY IS THIS SO HARD AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
    internal class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
        
            
        }
        public static Font activeFont = Arial;
        public static Font Arial = Resources.GetBuiltinResource<Font>("Arial.ttf") as Font;
        public static GameObject menu;
        public static GameObject menuBackground;
        public static GameObject Pagebuttons;
        public static GameObject DisconnectButton;
        public static GameObject NextPage;
        public static GameObject PrevPage;
        public static void Open()
        {

            bool ToOpen = EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand);
        }

        public static void CreateMenu()
        {
            if (EasyInputs.GetSecondaryButtonDown(EasyHand.LeftHand))
            {
                Text text = new GameObject
                {
                    transform =
                {
                    parent = menuBackground.transform
                }
                }.AddComponent<Text>();
                text.font = activeFont;
                text.text = "App.lol";
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
                menuBackground.GetComponent<Renderer>().material.color = MenuVars.BackgroundColor;
                menuBackground.transform.position = new Vector3(0.05f, 0f, 0f);
                DisconnectButton = GameObject.CreatePrimitive(PrimitiveType.Cube);

            }

        }

        public static void Motdstuff()
        {
            GameObject.Find("motdtext").GetComponent<Text>().text = "Hello, Thanks for Testing App.lol, This Menu Was Made From SCRATCH \n Meaning Yes i used NO templates Skid if gay";
        }
    }
}
