# GeoFence

GeoFence is a small virtual reality prototype built in Unity. You put on a headset, move around a virtual space, and a "fence" in the scene reacts when you or your hand touches it. It is an early experiment in using trigger zones in VR to build a virtual boundary that warns you when you cross it.

## What it does

- Runs a first-person VR scene with the Unity XR Interaction Toolkit (hands or controllers, ray, poke, direct and teleport interactors).
- Contains a 3D "bezel" frame model imported from Bezi (glTF) that acts as the scene content.
- A fence object is tagged `Fence`. The script `Assets/collition.cs` listens for trigger events on it and prints `zap enter`, `zap continues` and `zap exit` to the console when something enters, stays in, or leaves the fence.
- Targets standalone Android VR headsets such as Meta Quest (Oculus and OpenXR loaders are configured).

## Tech stack

- Unity 2022.3.20f1 (URP-style XR template assets)
- C#
- XR Interaction Toolkit 2.5.3, XR Management 4.4.1, Oculus XR Plugin 4.1.2, OpenXR 1.10.0
- glTFast 6.2.0 (via OpenUPM) and the Bezi Unity Bridge (from GitHub) for importing the 3D model
- TextMesh Pro 3.0.8

## Try it

### Quickest way: install the prebuilt APK

The repository includes a prebuilt Android build, `andrioid.apk` (the file name has a typo, it is kept as is). It was built for a standalone Android VR headset.

1. Enable developer mode on your headset.
2. Connect it to your computer and run `adb install andrioid.apk`.
3. Start the app from the "Unknown sources" section of your app library.

The APK is built with the default Unity package name `com.DefaultCompany.NewUnityProject`.

### Build from source

1. Install Unity Hub and Unity **2022.3.20f1** with the Android Build Support module.
2. Clone this repository and add the folder as a project in Unity Hub.
3. Open the project. Unity downloads the packages listed in `Packages/manifest.json` (this needs internet access to the Unity registry, OpenUPM and GitHub).
4. Open `Assets/New Scene.unity`.
5. To test without a headset, use the XR Device Simulator from the XR Interaction Toolkit samples and press Play.
6. To run on a headset, go to File > Build Settings, switch to Android, add the open scene, and click Build And Run with the headset connected.

Note that `EditorBuildSettings.asset` has no scenes listed, so you must add `New Scene` to the build yourself.

## Project layout

- `Assets/New Scene.unity`: the main scene
- `Assets/collition.cs`: fence collision script
- `Assets/BeziFiles/`: 3D frame model imported from Bezi
- `Assets/Samples/`, `Assets/VRTemplateAssets/`, `Assets/XRI/`, `Assets/XR/`: Unity XR sample content and settings
- `Packages/`, `ProjectSettings/`: Unity package and project configuration
- `andrioid.apk`: prebuilt Android build

## Status

Prototype. It runs as a VR scene and the fence detects contact, but the fence only prints messages. There is no sound, haptic or visual warning yet.

## Credits

- XR Interaction Toolkit starter assets and the VR template assets are Unity samples.
- The frame model comes from [Bezi](https://www.bezi.com/) through the Bezi Unity Bridge.
- Liberation Sans font (SIL Open Font License) ships with TextMesh Pro.

No license file is included yet, so by default all rights are reserved by the author.
