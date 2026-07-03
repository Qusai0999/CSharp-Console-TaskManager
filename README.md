# TaskManager

TaskManager is a polished, lightweight console application built with C# and .NET for organizing your daily to-dos from the terminal.

## What this app does

TaskManager helps you:
- add new tasks quickly
- mark tasks as completed or pending
- delete tasks you no longer need
- view all tasks or filter them by status
- keep your task list clear and easy to follow in a simple console experience

## Features

- Clean console-based interface
- Intuitive command-driven workflow
- Task status tracking with completed/pending states
- Easy filtering for all, pending, or completed tasks

## Available commands

- `add <title>` - create a new task
- `toggle <id>` - mark a task as completed or pending
- `delete <id>` - remove a task from the list
- `all` - display every task
- `pending` - show only unfinished tasks
- `completed` - show only completed tasks
- `exit` - close the application

## Getting started

### Prerequisites

- .NET SDK installed on your machine

### Run the app

From the project folder, run:

```bash
dotnet build
dotnet run
```

## Example usage

```text
>> add Finish project report
>> add Review pull request
>> toggle 1
>> completed
>> exit
```

## Why it’s useful

TaskManager is a great example of a small but complete console app that demonstrates:
- object-oriented design
- separation of concerns
- command-based user interaction
- straightforward task management workflows

Enjoy using TaskManager to stay organized!
