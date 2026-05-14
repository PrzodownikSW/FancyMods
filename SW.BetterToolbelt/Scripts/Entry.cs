using System.Reflection;

namespace Harmony
{
    public class Entry : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            HarmonyLib.Harmony harmony = new HarmonyLib.Harmony(_modInstance.Name);
            Log.Out(" Loading Patch: " + this.GetType().ToString());
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
