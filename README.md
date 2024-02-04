# 2-unity

## Project Name: XR CLASS

## Project Description: 
We have developed a VR app that caters the education system of shcools and colleges, fullfilling the lack of visualization of complex topics. In this project, we have developed custom labs for certain topics for Biology and Chemistry for school students. We aim to popularize AR/VR education in tier-2 and tier-3 cities by making it affordable.

## Purpose: 
The puporse of the project is to make the understanding of complex topics easier through comprehensive VR labs. Students will be able to understand complex topics like the Solid State or components of heart very easily. They will be able to interact with the application, thus making studying fun, interactive and affordable.

## Features:

- **Custom VR Labs:**
  - Developed custom labs for specific topics in Biology and Chemistry.
  - Tailored content to match the curriculum of schools and colleges.

- **Interactive Learning:**
  - Provides an immersive learning experience through Virtual Reality.
  - Allows students to interact with 3D models and simulations, enhancing understanding.

- **Topic Coverage:**
  - Covers complex topics such as Solid State in Chemistry or detailed components of the heart in Biology.
  - Aims to address challenging subjects that may require visualization for better comprehension.

- **Comprehensive Content:**
  - Includes detailed explanations, annotations, and visual representations of concepts.
  - Offers a comprehensive understanding of each topic.

- **User-Friendly Interface:**
  - Intuitive interface designed for students of various age groups.
  - Easy navigation for a seamless learning experience.

- **Fun and Engaging:**
  - Makes studying enjoyable through gamified elements and interactive activities.
  - Encourages participation and active involvement in the learning process.

- **Affordable:**
  - The whole application merely requrires Rs. 2000 to experience.
  - Far better than Occulus in terms of affordability.

## How XR class Addresses Future Challenges?
The challenges that can arrive in future are scalability and other business related issues. We have a fullproof business plan to tackle the challenges.

## Business Plan
For scaling this idea from just a mere project to actual business, we need to hire a team and take up contracts from different instituions to build custom VR labs for them. In Our case, the institutions shall be schools and colleges. 

## Revenue
We shall take up orders from a certain institutions and charge them a monthly retainer for our custom VR classes. This shall bring in regular money to the firm.

# Team Members:
1. Sarthak Awasthi (Leader): Unity developer in this project. Has full understanding of Unity and Unreal engine. Fully efficient in C#.
2. Shubhankar Nath: AI developer in the project. Proficient in Python and all its Librararies. Has great understanding of AI and ML.
3. Ujjwal Sinha: UI/UX designer. Ujjwal is proficient in FIGMA and has a great instinct on what goes best in any design.
4. Tejas Kumar: Blender developer, knows blender as well as Python. Tejas is a web developer who uses Django.

# Tech Stack
- Unity: Cross-platform game engine for 2D/3D development.
- Blender: Open-source 3D modeling and animation software.
- Android Development: Creating apps for the Android operating system using Java/Kotlin and Android Studio.
- C# (Programing Language): It combines the power of object-oriented programming with the flexibility of a modern, type-safe language.
- Convai: enable NPCs with intelligence such that they can converse naturally with user via voice or text.

# How To Run The Project?
Step 1 - Install Unity and download Unity Editor version of 2019.4.37f1<br />
Step 2 - Open the downloaded folder of our GitHub repository on Unity.<br />
Step 3 - Change the build setting to Android and add all the scenes in "Scenes in Build".<br />
Step 4 - Connect your phone with the help of a USB Cable while ensuring that USB debugging in on.<br />
Step 5 - Enable VR Cardboard setting from "Build Setting Player" section.<br />
Step 6 - Click on "Build and Run" and save the APK file on your device. Wait till the deployment is done successfully and the app will be installed on your phone.<br />
Step 7 - Safely place your phone inside VR Cardboard and get ready to dive into the immerive world of Virtual Education!<br />

# Core Code
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtolab : MonoBehaviour
{
  public void scenechange(){
    SceneManager.LoadScene("Lab");
  }
}
```
The above code is one of the most vital aspects of our project. It enables us to change from one scene to another. Our project clearly utilizes a lot of scripts having similar functionality like gotodark, gotonacl, gotoorganic, etc.
