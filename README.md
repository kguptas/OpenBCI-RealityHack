# OpenBCI-RealityHack [change once we decide name]

## Project Setup

### Software
1. **Clone the GitHub Repo** with CLI or GitHub Desktop
   1. Set up a License and README file
   2. Select the Unity .gitignore file

2. **Install Git LFS**

3. **Open the Project via Unity Hub**
   1. Open Unity Hub → **Add** → select the cloned repository (root directory) → **Add Project**
      1. _It’s recommended that all collaborators use the **same version of Unity**!_ See below for the version that we used.

4. **OpenBCI's Galea Setup**
   * _The Galea private software downloads are accessible to Galea owners via http://portal.galea.co/docs_
   1. Install the Galea GUI
   2. Install the OpenBCI SDK
      1. In the Unity Editor with the project open, navigate to **Package Manager**
      2. Click + and then select **Add Package from tarbell**
      3. Select your local download of the OpenBCI SDK (.tgz file) to add it to the project
   3. Configure Unity project for OpenBCI Galea:
      1. Navigate to **Project Folder** → **Packages** → **OpenBCI SDK**
      2. Select the **Galea (Beta)** prefab → drag and drop into Project Hierarchy 
        * If prompted to install TMP Essentials: Click Yes, delete Galea (Beta) prefab, then drag and drop Galea (Beta) prefab into Project Hierarchy _again_
     
5. **Varjo Setup**
   * _It was recommended to use the Varjo XR Plugin (also referred to as the 'Unity XR SDK' for Varjo) via their [online documentation](https://developer.varjo.com/docs/unity-xr-sdk/unity-xr-sdk)_
   1. Install the Varjo XR Plugin
      1. In the Unity Editor with the project open, navigate to **Package Manager**
      2. Click + and then select **Add Package from git URL**
      3. Enter the git URL to add the SDK to the project: https://github.com/varjocom/VarjoUnityXRPlugin.git
   2. Configure Unity project for Varjo Aero (the head-mounted display used in our version of the Galea Beta):
      1. Navigate to **Edit** → **Project Settings** → **XR Plugin Management**
         1. Enable Varjo
         2. Navigate to **Varjo** (within XR Plugin Management) -> enable Opaque _(since we're not using mixed reality passthrough i.e. the Varjo XR-3)_

### Hardware
* [add files here]
* Galea
* Varjo Aero
* Olfactory Display


## References
### Olfactory Displays
* Project Nebula

### Research Papers

### 3D Assets


## Contact Information
* [Ashley Neall](https://aneall.github.io/)
* Peter He
* Kriti Gupta
* Grace Jin
