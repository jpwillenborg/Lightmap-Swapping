# Lightmap-Swapping
Swap multiple lightmap sets during runtime in Unity
<br><br>

![Project Image](<./.gitimages/Lightmap Swapping 01.png>)
<br><br>

![Project Image](<./.gitimages/Lightmap Swapping 02.png>)
<br><br>

## Project Description
This is a demonstration of how to swap out multiple sets of traditional lightmaps during runtime in Unity. The scene focuses on switching between three distinct sets: one for daytime, one for nighttime with emissive materials baked in (wall lamps on with realtime shadows) and one for nighttime without the emissive materials (wall lamps off). In addition to the mixed lighting in Shadowmask mode, an Adaptive Probe Volume is used for more logical blending of shadows.
<br>

Also added is the ability to adjust the white balance through post processing using a profile cloning method that maintains persistence between map sets.
<br>

Note: Some assets from the Unity Asset Store are required for a complete build. They are not included in this repo. Please see the Licenses section below for links to the assets. Otherwise, feel free to browse through the project files. Thanks.
<br><br>

## Player Controls
Move Player: A/D Keys -or- Left/Right Arrows
<br>
Jump: Spacebar
<br><br>

## Project Features
* Traditional lightmap swapping during runtime
* Mixed lighting using Shadowmask mode
* Emissive material swapping
* Adaptive Probe Volume for logical shadows
* Post process adjustment during runtime
* Framerate counter
<br><br>

## Licenses
[MIT](./LICENSE)
<br>

[Easy Character Movement 2](https://assetstore.unity.com/packages/tools/physics/easy-character-movement-2-193614) by Oscar Gracián: Required for the main scene. Available for purchase on the Unity Asset Store. Used under the standard Unity Asset Store EULA.
<br>

[Stylized Water 2](https://assetstore.unity.com/packages/vfx/shaders/stylized-water-2-170386) by Staggart Creations: Required for the main scene. Available for purchase on the Unity Asset Store. Used under the standard Unity Asset Store EULA.
<br>
