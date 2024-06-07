# Refactoring User Service

This repository contains a refactored implementation of a User Service. The User Service is responsible for deleting user information. The project is built using .NET and C# and demonstrates principles of clean code and refactoring.

## Features

- **Delete User**: Remove a user from the system.

## Getting Started

### Prerequisites

- .NET SDK 6.0 or later
- Visual Studio 2022 or later

### Installation

1. Clone the repository:

```bash
git clone https://github.com/VelSkorp/RefactoringUserService.git
```

2. Navigate to the project directory:

```bash
cd RefactoringUserService
```

3. Open the solution file in Visual Studio:

```bash
RefactoringUserService.sln
```

4. Restore NuGet packages:

In Visual Studio, right-click on the solution and select `Restore NuGet Packages`.

5. Build and run the application:

Press `F5` or click the `Run` button in Visual Studio to start the application.

## Usage

Once the application is running, you can interact with the User Service through API endpoints. Below are some examples of how to use the API.

### Delete a User

```http
DELETE /api/users/{id}
```

## Contributing

Contributions are welcome! Please submit issues or pull requests with any improvements, bug fixes, or new features.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.