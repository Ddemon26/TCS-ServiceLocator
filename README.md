
# TCS Service Locator

[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Unity](https://img.shields.io/badge/Unity-2020.3%2B-green.svg)](https://unity.com)
[![Issues](https://img.shields.io/github/issues/Ddemon26/TCS-ServiceLocator.svg)](https://github.com/Ddemon26/TCS-ServiceLocator/issues)

## Overview

The **TCS Service Locator** is a Unity-based implementation of the Service Locator pattern, designed to help developers manage global and scene-specific services efficiently. By decoupling service registration and retrieval, it provides a flexible architecture that simplifies service management in large Unity projects.

## Features

- **Global and Scene-based Service Management**:
   - The system allows for the registration and retrieval of services globally or within specific scenes.
   - Services can persist across scenes (global) or exist only in specific scenes (scene-specific).

- **Easy Service Registration and Access**:
   - Using the `ServiceManager`, services can be registered and accessed with minimal boilerplate.

- **Logging and Debugging**:
   - The `Logger` class is integrated to provide helpful debug logs and error reporting.

## Getting Started

### 1. Installing the Service Locator

To install the **TCS Service Locator**, you can simply clone the repository and integrate the `Runtime` folder into your Unity project.

### 2. Registering a Service

Services are registered using the `ServiceManager`. You can register services globally or to a specific scene.

Example:
```csharp
// Register a global service
ServiceLocatorGlobal.Instance.RegisterService<IMyService>(new MyService());

// Accessing a global service
IMyService myService = ServiceLocatorGlobal.Instance.GetService<IMyService>();
```

### 3. Scene-specific Services

Scene-specific services can be registered similarly, but are bound to a specific Unity scene.

Example:
```csharp
// Register a scene-specific service
ServiceLocatorScene.Instance.RegisterService<IMySceneService>(new MySceneService());

// Accessing a scene-specific service
IMySceneService sceneService = ServiceLocatorScene.Instance.GetService<IMySceneService>();
```

### 4. Example Usage

The `Tests` folder contains several example scripts to illustrate how to use the Service Locator pattern in a real-world Unity project. The provided examples include:

- **AudioManagerExampleOne.cs**: Demonstrates registering and using an audio manager service.
- **PlayerManagerExample.cs**: Shows how to manage player-related services.
- **ScoreManagerExample.cs**: Illustrates how to handle score management using the service locator.

### 5. Bootstrapping the Service Locator

The `Bootstrapper` class is responsible for initializing the service locator in the global context, ensuring that necessary services are available from the start of the game.

```csharp
// Bootstrapper for initializing global services
ServiceLocatorGlobal.Instance.ConfigureAsGlobal(true);
```

## Project Structure

- `Runtime/SeviceLocator`: Contains the core service locator implementation (`ServiceLocator.cs`, `ServiceManager.cs`, `Logger.cs`, etc.)
- `Tests`: Includes example scripts demonstrating how to use the service locator.

## Contribution

Contributions are welcome! If you encounter any bugs or have suggestions for improvements, please feel free to submit an issue or pull request on GitHub.

## License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.
