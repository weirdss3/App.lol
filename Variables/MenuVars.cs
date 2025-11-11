using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using easyInputs;
using UnityEngine;
using UnityEngine.UI;
using App.lol.Utilities;

namespace App.lol
{
    internal class MenuVars
    {
        public static bool righthanded { get; private set; }
        public static bool lefthanded { get; private set; }

        public static void Var()
        {
            righthanded = EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand);
            lefthanded = EasyInputs.GetSecondaryButtonDown(EasyHand.LeftHand);
        }
        public static GameObject menuObj = null;
        public static GameObject background = null;
        public static GameObject canvasObj = null;
        public static GameObject clickerObj = null;
        public static GameObject clickerObj2 = null;
        public static GameObject disconnectButton = null;

        // Text
        public static Text title;
        public static Text categorytitle;

        // Player & Physics
        public static Rigidbody currentMenuRigidbody = null;
        public static Vector3 previousVelocity = Vector3.zero;
        public const float velocityThreshold = 0.05f;
        public static VRRig vrrig;

        // Colors
        public static Color32 BackgroundColor = ColorLib.SuperDarkGrey;
        public static Color32 DisconnectButtonColor = ColorLib.Black;
        public static Color32 BackToStartButtonColor = ColorLib.Black;
        public static Color32 PageButtonsColor = ColorLib.Black;
        public static Color32 ModEnabledColor = ColorLib.Blue;
        public static Color32 ModDisabledColor = ColorLib.Black;
        public static Color32 ClickerColor = ColorLib.White;
        public static Color32 SettingsButtonColor = ColorLib.Black;
        public static Color32 SettingsButtonTextColor = ColorLib.White;
        public static Color32 TitleTextColor = ColorLib.Blue;
        public static Color32 ModsTextColor = ColorLib.White;
        public static Color32 DisconnectButtonTextColor = ColorLib.Blue;
        public static Color32 BackToStartTextColor = ColorLib.Blue;
        public static Color32 PageButtonsTextColor = ColorLib.Blue;












    }
}
