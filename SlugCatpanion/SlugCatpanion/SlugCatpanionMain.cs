using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlugCatpanion
{
    // There are two types of dependencies:
    // 1. BepInDependency.DependencyFlags.HardDependency - The other mod *MUST* be installed, and your mod cannot run without it. This ensures their mod loads before yours, preventing errors.
    // 2. BepInDependency.DependencyFlags.SoftDependency - The other mod doesn't need to be installed, but if it is, it should load before yours.
    //[BepInDependency("author.some_other_mods_guid", BepInDependency.DependencyFlags.HardDependency)]
    // Of course, you should erase the line above. It's just an example.

    // As mentioned before, if the other modder uses constant strings, you can do something like this instead:
    // [BepInDependency(SomeOtherModMain.PLUGIN_GUID, BepInDependency.DependencyFlags.HardDependency)]

    // In general, it is considered bad form to directly put strings into the constructor of the BepInPlugin attribute.
    // By creating const string fields, other mods that depend on yours can import your mod's DLL file, and then their code can actually directly reference the data you put here!
    // This saves your fellow modders a lot of time and headache, and could potentially save you in the future too.
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class SlugCatpanionMain: BaseUnityPlugin
    {
        public const string PLUGIN_GUID = "slugcatpanion"; // This should be the same as the id in modinfo.json!
        public const string PLUGIN_NAME = "Slug Catpanion"; // This should be a human-readable version of your mod's name. This is used for log files and also displaying which mods get loaded. In general, it's a good idea to match this with your modinfo.json as well.
        public const string PLUGIN_VERSION = "1.0.0"; // This follows semantic versioning. For more information, see https://semver.org/ - again, match what you have in modinfo.json
        // It should go without saying, but for this to benefit other modders, the class *and* these const strings must be public.

        private void OnEnable()
        {
        }
    }
}
