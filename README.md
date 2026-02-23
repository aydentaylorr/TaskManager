A windows dsktop to-do list application built with C# and WinForms, featuring user authentication and full task management capabilities backed by REST API.

Features:
  - User Authenticantion: Register a new account or log in to an existing one
  - Task Management: Create, view, update and delete tasks (full CRUD)
  - Personal Task Lists: Each user has their own isolated task list
  - Clean WinForms UI: Intuitive desktop interface built with Windows Forms

Tech Stack:
  Frontent: C# WinForms
  Backend: C# Web API (ASP.NET)
  Language: C# (.NET)

Getting Started
  Prerequisites
    - .NET SDK (version 6.0 or later recommended)
    - Visual Studio 2022 (or any IDE supporting .NET)

  Running the application
    1. Clone the repository
    2. Open the solution, open TaskManager.sln in Visual Studio
    3. Start the API Set TaskManager.API as the startup project and run it
    4. Run the WinForms app Set TaskManager.WinForms as the startup project and run it

API Endpoints
  - POST     /auth/register     Register a new user
  - POST     /auth/login        Log in and receive a token
  - GET      /tasks             Get all tasks for the user
  - POST     /tasks             Create a new task
  - PUT      /tasks/{id}        Update an existing task
  - DELETE   /tasks/{id}        Delete a task

Usage
  1. Launch the application and register a new account, or log in with existing credentials
  2. Once authenticated, you'll be tasken to your dashboard
  3. From there you can add, edit, complete or delete tasks
