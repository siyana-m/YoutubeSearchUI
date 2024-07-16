# YoutubeSearchUI

## Overview

This project is a Razor Pages application designed to serve as the UI for searching youtube videos. The IDE used is Visual Studio 2022 with the technology .NET 7, and the programming language used is C#. For fronted, HTML/CSS is used. This repository contains the source code and resources required to deploy and run the application.

## Directory Structure

The project is structured as follows:

```
YoutubeSearchAppInterface/
├── Connected Services/
├── Dependencies/
├── Properties/
├── wwwroot/
├── Models/
│ ├── SearchResponse.cs
│ └── SearchResult.cs
├── Pages/
│ ├── Shared/
│ │ ├── _Layout.cshtml
│ │ ├── _ValidationScriptsPartial.cshtml
│ ├── _ViewImports.cshtml
│ ├── _ViewStart.cshtml
│ ├── Error.cshtml
│ ├── Index.cshtml
│ ├── Privacy.cshtml
├── appsettings.json
├── Program.cs
├── YoutubeSearchAppInterface.csproj
└── README.md
```

### Key Directories and Files

- **Connected Services/**: Contains service references.
- **Dependencies/**: Contains project dependencies.
- **Properties/**: Contains project properties and settings.
- **wwwroot/**: Contains static files such as CSS, JavaScript, and images.
- **Models/**: Contains the data models used in the application.
  - **SearchResponse.cs**: Data model for the search response.
  - **SearchResult.cs**: Data model for individual search results.
- **Pages/**: Contains Razor Pages for the application.
  - **Shared/**: Contains shared layout and partial views.
    - **_Layout.cshtml**: Layout page for the application.
    - **_ValidationScriptsPartial.cshtml**: Partial view for validation scripts.
  - **_ViewImports.cshtml**: Contains common directives for the Razor Pages.
  - **_ViewStart.cshtml**: Defines layout page for Razor Pages.
  - **Error.cshtml**: Razor Page for displaying error messages.
  - **Index.cshtml**: Main Razor Page for the application.
  - **Privacy.cshtml**: Razor Page for the privacy policy.
- **appsettings.json**: Configuration settings for the application.
- **Program.cs**: Main program entry point.
- **YoutubeSearchAppInterface.csproj**: Project file for the application.
- **README.md**: The readme file you are currently reading.

## Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) with ASP.NET and Web Development workload installed
- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 7.0 or later)

## Setup and Installation

1. **Clone the repository:**
    ```sh
    git clone https://github.com/siyana-m/YoutubeSearchUI.git
    cd YoutubeSearchAppInterface
    ```

2. **Open the solution in Visual Studio:**
    - Open `YoutubeSearchAppInterface.sln` in Visual Studio.

3. **Build the project:**
    - Go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.

4. **Run the application:**
    - Press `F5` or go to `Debug` > `Start Debugging`.


## Running Tests

To run any tests for the application (if applicable), use Visual Studio's built-in testing tools.

## Contributing

Contributions are welcome! Please create an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact

For any questions or feedback, please contact siskataam32@gmail.com.

## Notes

The project is still under development. There may be issues. In case of finding one, please contact siskataam32@gmail.com.
