# CloudQA Task 1 – Selenium Automation

## Overview
This project automates three fields on the CloudQA Automation Practice Form using C# and Selenium WebDriver.

## Automated Fields
1. First Name – Enters "Mohammad".
2. Gender – Selects Male.
3. State – Selects India from the dropdown.

## Technologies Used
- C#
- .NET
- Selenium WebDriver
- Chrome Browser

## Setup Instructions

1. Install the .NET SDK.
2. Install Google Chrome.
3. Clone this repository.
4. Open the project folder in the terminal.
5. Restore dependencies:

```bash
dotnet restore
```

## How to Run

Run with the default URL:

```bash
dotnet run
```

Run with a custom URL:

```bash
dotnet run -- "https://app.cloudqa.io/home/AutomationPracticeForm"
```

## Approach
- Uses label text and DOM relationships to locate form elements.
- Avoids relying directly on fixed IDs, names, and CSS classes.
- Uses explicit waits before interacting with the form.
- Includes exception handling.

## Limitations
- Locator reliability depends on the labels and their relationships with the corresponding form elements.
- Major changes to the page structure or visible labels may require locator updates.
- The dropdown is labelled State, but its available options are countries.

