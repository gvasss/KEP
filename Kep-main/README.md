# Citizen Service Request Management for ΚΕΠ (Κέντρα Εξυπηρέτησης Πολιτών)

This is a desktop application designed to manage and log citizen requests at ΚΕΠ (Citizen Service Centers) using Windows Forms (C#). It allows ΚΕΠ employees to record, modify, and search for service requests, making the process of handling requests more efficient.

## Table of Contents

- [Features](#features)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)

## Features

- **Request Logging**: Allows employees to log citizen requests with details such as name, contact info, request type, and submission time.
- **View Requests**: Displays all logged requests, both collectively and individually by citizen.
- **Modify Requests**: Edit the details of an existing citizen request.
- **Delete Requests**: Remove a request from the system.
- **Advanced Search**: Search for requests based on specific criteria (e.g., by name, request type, or date).
- **User-friendly Interface**: Intuitive and easy-to-use interface built with Windows Forms.

## Requirements

- Visual Studio 2019 (or later) with .NET Framework.
- Windows operating system.
- .NET Framework 4.7.2 or higher.

## Installation

1. Clone this repository to your local machine:

    ```bash
    git clone https://github.com/your-username/kep-request-management.git
    ```

2. Open the solution file (`WindowsFormsApp2.sln`) using Visual Studio.

3. Restore the NuGet packages and build the solution:

    - In Visual Studio, go to **Tools > NuGet Package Manager > Restore NuGet Packages**.
    - Then build the solution using **Build > Build Solution** or press `Ctrl + Shift + B`.

4. Run the application by pressing `F5` or selecting **Debug > Start Debugging**.

## Usage

1. **Log a new request**:
   - Fill in the citizen's details (name, email, phone number, etc.) and the type of request (e.g., certificate issuance).
   - Submit the request to log it into the system.

2. **View existing requests**:
   - Access all the requests in the system, or filter them by citizen name or request type.

3. **Modify or delete a request**:
   - Select an existing request from the list and either edit the details or delete it if needed.

4. **Search for requests**:
   - Use the search functionality to find requests based on various criteria (e.g., request type, date, etc.).
