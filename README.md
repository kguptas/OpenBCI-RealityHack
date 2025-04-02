# NeuroScent
Mental well-being with immersive **scent**, **vision**, and __biofeedback__.

 * [Devpost](https://devpost.com/software/neuroscent)
 * [Video](https://vimeo.com/1059625069)
 * [OpenBCI Blog Feature](https://openbci.com/community/openbci-mit-reality-hack-2025/)

### Overview
1. [Project Setup](https://github.com/kguptas/OpenBCI-RealityHack/blob/master/README.md#project-setup)
2. [Software](https://github.com/kguptas/OpenBCI-RealityHack/blob/master/README.md#software)
3. [Hardware](https://github.com/kguptas/OpenBCI-RealityHack/blob/master/README.md#hardware)
4. [Acknowledgements](https://github.com/kguptas/OpenBCI-RealityHack/blob/master/README.md#acknowledgements)
5. [Contact Us](https://github.com/kguptas/OpenBCI-RealityHack/blob/master/README.md#contact-information)

## Project Setup
**Prerequisites** – Before we get started, make sure to install the following:
   1. Unity Hub
   2. Unity Editor
      * Version [**2022.3.56f1 LTS**](https://unity.com/releases/editor/whats-new/2022.3.56#notes)
        * Visual Studio Community 2022
        * Windows Build Support (IIL2CPP)
        * WebGL Build Support
   4. Arduino IDE
   5. Visual Studio IDE
      * Version **2022 (Community Edition)**
   6. Galea GUI

## Software
1. **Clone the GitHub Repo** with CLI or GitHub Desktop
   1. Set up a License and README file
   2. Select the Unity .gitignore file
   3. Initialize Git LFS _(if you intend to develop this project with others using version control)_

2. **Open the Project via Unity Hub**
   1. Open Unity Hub → **Add** → select the cloned repository (root directory) → **Add Project**
      1. _It’s recommended that all collaborators use the **same version of Unity**!_ Please refer above for the version that we used.

3. **OpenBCI's Galea Setup**
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
     
4. **Varjo Setup**
   * _It was recommended to use the Varjo XR Plugin (also referred to as the 'Unity XR SDK' for Varjo) via their [online documentation](https://developer.varjo.com/docs/unity-xr-sdk/unity-xr-sdk)_
   1. Install the Varjo XR Plugin
      1. In the Unity Editor with the project open, navigate to **Package Manager**
      2. Click + and then select **Add Package from git URL**
      3. Enter the git URL to add the SDK to the project: https://github.com/varjocom/VarjoUnityXRPlugin.git
   2. Configure Unity project for Varjo Aero (the head-mounted display used in our version of the Galea Beta):
      1. Navigate to **Edit** → **Project Settings** → **XR Plugin Management**
         1. Enable Varjo
         2. Navigate to **Varjo** (within XR Plugin Management) -> enable Opaque _(since we're not using mixed reality passthrough i.e. the Varjo XR-3)_

## Hardware
* Our NeuroScent system provides multi-modal biofeedback with multi-sensory immersion via __vision__ (Varjo Aero HMD) and __smell__ (Project Nebula). Below is a summarized outline of all of the hardware components:
 * Biofeedback – **OpenBCI Galea** *(which features PPG, EMG, EEG, EDA, EEG biosensors)*
    * In NeuroScent's current version *(as seen at MIT Reality Hack 2025)*, we only integrated **PPG** (heart rate), **EMG** (facial muscle movement), and **EEG** (non-invasive BCI with dry electrodes) – but the system's logic could be adapted to other sensing capaibilities
 * Vision – **Varjo Aero** *(VR-only head-mounted display)*
 * Smell – **Project Nebula** *(olfactory display as seen at IEEE VR 2024)*

### Olfactory Display Fabrication
* Please view [this documentation](https://docs.google.com/document/d/1BrtnZrWLWDk0qlDV_beyICGC32R3iqAFLgKVBNhAAQE/edit?usp=sharing) that Ashley Neall created with the guidance of Sophie Villenave – one of the Project Nebula authors. Project Nebula is a cartridge-based olfactory display project that was demoed to Ashley at IEEE VR 2024. We also highly recommend to read through [this paper](https://hal.science/hal-03838757v1/file/Nebula_VRST_2022%20%281%29.pdf) from VRST 2022.
* We recreated Project Nebula with limited supplies during the span of MIT Reality Hack 2025 _(which is a 3-day hackathon)_, so we highly recommend looking at the documentation above. We will add additional information (e.g. STL files, Arduino code, updated wiring diagram) as soon as we can.


## Acknowledgements
### Olfactory Display Literature
* [Nebula: An Affordable Open-Source and Autonomous Olfactory Display for VR Headsets](https://hal.science/hal-03838757v1/file/Nebula_VRST_2022%20%281%29.pdf)
  * [GitHub Repo](https://github.com/liris-xr/Nebula-Core?tab=readme-ov-file)

### Brain-Computer Interfacing Literature
* [will be added soon]

### 3D Assets
* [Low Poly Mountain Free](https://sketchfab.com/3d-models/low-poly-mountain-free-dabda46f9be2416c93a4b584be17786b) by Poly Craftsman
  * _Used for background mountain scenery_
* _Remaining assets modeled and/or generated with Unity built-in procedural features by our team_



## Contact Us
* [Ashley Neall](https://aneall.github.io/)
* Peter He
* Kriti Gupta
* Grace Jin
* Ximing Luo
