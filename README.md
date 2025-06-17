# AirSimPLE

## Download Source Code

Required Software:
+ git https://git-scm.com/
+ git-lfs https://git-lfs.com/

To clone the repository to a folder `airsimple-repo` and **download all asset files using Git LFS**:
```bash
git clone https://git.iimc.kyoto-u.ac.jp/chiao709hsieh/airsimple.git airsimple-repo
cd airsimple-repo/
git lfs pull
```

## Build the Project through Command Line

Required Software (Tested with the following on Windows 11):
+ Unreal Engine 5.2 https://www.unrealengine.com/en-US/unreal-engine-5
+ Microsoft Visual Studio 2022 Community Version https://visualstudio.microsoft.com/vs/community/

If you are building under Windows CMD, run the command
```bat
build-game.cmd
```

If you are building under Window Subsystem for Linux (WSL), run the following command under `airsimple-repo`
```shell
./build.WSL2.bash
```


## Open the Project in Unreal Editor

Open `AirSimPLE.uproject` under the `AirSimPLE` folder
