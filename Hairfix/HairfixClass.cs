using System.Linq;
using MelonLoader;
using UnityEngine;
using Hairfix;

[assembly: MelonInfo(typeof(HairfixClass),"HairFix", "1.0.0", "blankochan")]
[assembly: MelonGame("Buckethead Entertainment", "RUMBLE")]
[assembly: MelonColor(255, 255, 170, 238)] // #FAE pink :3

namespace Hairfix; // worlds simplist fucking mod
public class HairfixClass : MelonMod
{
    private const string comment = "simpliest bug ever qwq";
    public override void OnSceneWasLoaded(int _, string sceneName)
    {
        if (sceneName == "Loader") return;
        Mesh frenchBob = Resources.FindObjectsOfTypeAll<Mesh>().First(mesh => mesh.name == "Top7");
        frenchBob.colors32 = Enumerable.Repeat(new Color32(255, 0, 0, 255), frenchBob.colors32.Length).ToArray();
    }
}