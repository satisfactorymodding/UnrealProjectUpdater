# Unreal Project Updater

Resources and GitHub actions used in updating the Satisfactory Modding Unreal project from dumps of the game's files.
Runs on a self hosted Windows runner.

## Components

### SML_HooksOnly/SML

AssetDumper requires SML (hooking) for dumping meshes.
SML_HooksOnly is a stripped down version of SML that only implements hooking features,
meaning it is less likely to break and easier to fix between updates.

### SML_HooksOnly/SMLEditor

This may no longer be needed, need to investigate.

### CustomAssets, ForceGeneratePackages, SkipSavePackages

Lists of files for the Asset Generator and updateSML action to reference.
