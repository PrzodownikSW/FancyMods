using HarmonyLib;
using UnityEngine;

public class Toolbelt_Patch
{
    [HarmonyPatch(typeof(Inventory), "PUBLIC_SLOTS_PLAYMODE", MethodType.Getter)]
    public class Patch_Inventory_PUBLIC_SLOTS_PLAYMODE
    {
        private static bool Prefix(Inventory __instance, ref int __result)
        {
            __result = 12;

            return false;
        }
    }

    [HarmonyPatch(typeof(Inventory), "SHIFT_KEY_SLOT_OFFSET", MethodType.Getter)]
    public class Patch_Inventory_SHIFT_KEY_SLOT_OFFSET
    {
        private static bool Prefix(Inventory __instance, ref int __result)
        {
            __result = 12;

            return false;
        }
    }

    [HarmonyPatch(typeof(PlayerActionsLocal), "InventorySlotWasPressed", MethodType.Getter)]
    public class Patch_PlayerActionsLocal_InventorySlotWasPressed
    {
        private static bool Prefix(PlayerActionsLocal __instance, ref int __result)
        {
            if (Input.GetKey(KeyCode.Minus))
            {
                __result = 10;

                return false;
            }

            if (!Input.GetKey(KeyCode.Equals))
                return true;

            __result = 11;

            return false;
        }
    }
}
