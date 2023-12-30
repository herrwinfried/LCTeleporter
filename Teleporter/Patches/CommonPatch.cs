﻿using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Teleporter.Patches
{
    // This class controls all common behaviour changes between both the inverse teleporter and the normal teleporter.
    [HarmonyPatch]
    internal class CommonPatch
    {

        // This class controls start of round patches for both teleporters.
        [HarmonyPatch(typeof(StartOfRound))]
        internal class StartOfRoundPatch
        {
            private static FieldInfo cooldownProp = typeof(ShipTeleporter).GetField("cooldownTime", BindingFlags.Instance | BindingFlags.NonPublic);

            [HarmonyPatch("StartGame"), HarmonyPostfix]
            private static void StartGame()
            {
                // if (ConfigSettings.EnableResetTeleport.Value)
                // {
                ResetCooldown();
                // }
                
            }

            [HarmonyPatch("EndOfGame"), HarmonyPostfix]
            private static void EndOfGame()
            {
                // if (ConfigSettings.EnableResetTeleport.Value)
                // {
                ResetCooldown();
                // }
            }

            [HarmonyPatch("EndOfGameClientRpc"), HarmonyPostfix]
            private static void EndOfGameClientRpc()
            {
                // if (ConfigSettings.EnableResetTeleport.Value)
                // {
                    ResetCooldown();
                // }
            }

            private static void ResetCooldown()
            {
                ShipTeleporter[] array = UnityEngine.Object.FindObjectsOfType<ShipTeleporter>();
                foreach (ShipTeleporter obj in array)
                {
                    cooldownProp.SetValue(obj, 0f);
                }
            }
        }

    }

}