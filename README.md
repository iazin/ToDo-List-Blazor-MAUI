# ToDo-List-Blazor-MAUI

## Description

ToDo-List-Blazor-MAUI is a cross-platform application built using the Blazor framework with .NET MAUI. It allows users to create, edit, and delete tasks while managing their daily activities. Task data is automatically saved to a local SQLite database.

## Features

- *Task Management:* Create, edit, delete tasks.
- *Data Handling:* Automatic saving of task data to a local SQLite database.
- *Task Fields:* Each task includes the following fields:
  - *Task Name:* The name of the task.
  - *Date:* The due date of the task.
  - *Priority:* The priority level of the task.
  - *Status:* The current status of the task.
  - *Countdown:* Time remaining until the task is due.
  - *Content:* Detailed description of the task.

## Technology Stack

- *Backend:* C#, Blazor with .NET MAUI.
- *Frontend:* HTML, Bootstrap.
- *Database:* SQLite.

## Getting Started

### Prerequisites

To run this project locally, you will need:

- Visual Studio 2022 or later with the .NET Multi-platform App UI development workload
- .NET 8 SDK
- A compatible device or emulator

### Installation

1. Clone the repository:
```sh
   git clone https://github.com/iazin/ToDo-List-Blazor-MAUI.git
```
2. Open the project in Visual Studio:
```sh
   cd ToDo-List-Blazor-MAUI
```
   Open the solution file (.sln) in Visual Studio.
3. Restore the required packages:
```sh
   dotnet restore
```
4. Build the project:
```sh
   dotnet build
```
5. Run the application:
   - For Android:
  ```sh
     dotnet run -f net8.0-android
  ```
   - For iOS:
  ```sh
     dotnet run -f net8.0-ios
  ```
   - For Windows:
  ```sh
     dotnet run -f net8.0-windows
  ```
   - For Mac:
  ```sh
     dotnet run -f net8.0-maccatalyst
  ```
6. The application should now be running on your selected platform.

## Usage

1. *Creating a Task:* Click on the "Add Task" button, fill in the task details, and save.
2. *Editing a Task:* Click on the task you want to edit, update the details, and save.
3. *Deleting a Task:* Click on the delete icon next to the task you want to remove.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
