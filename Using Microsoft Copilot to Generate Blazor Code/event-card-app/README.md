# Event Card App

## Overview
The Event Card App is a Blazor application that allows users to create and display event cards. Each event card includes essential information such as the event name, date, and location.

## Project Structure
```
event-card-app
├── src
│   ├── Components
│   │   └── EventCard.razor
│   └── Program.cs
├── event-card-app.csproj
└── README.md
```

## Components
### EventCard.razor
This component defines the structure of an event card. It includes fields for:
- **Event Name**: The name of the event.
- **Date**: The date when the event will take place.
- **Location**: The location of the event.

The component supports data binding for user input, allowing for dynamic updates to the event details.

## Setup Instructions
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd event-card-app
   ```
3. Restore the project dependencies:
   ```
   dotnet restore
   ```
4. Run the application:
   ```
   dotnet run
   ```

## Usage
Once the application is running, you can navigate to the Event Card component to create and view event cards. The user interface will allow you to input the event name, date, and location, which will be displayed on the card.

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.