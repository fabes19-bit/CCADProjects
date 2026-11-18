# MSSA CCAD — Running Directory of `dotnet run` Commands

Quick-reference commands to run every project in `C:\Users\Administrator\CCADProjects`.

---

## Quick Run Shortcuts

- **Run from inside any project folder:**
  ```powershell
  dotnet run
  ```
- **Run without rebuilding (faster if code didn't change):**
  ```powershell
  dotnet run --no-build --project "C:\Users\Administrator\CCADProjects\<ProjectName>"
  ```
- **Auto-rerun whenever you save a file:**
  ```powershell
  dotnet watch run --project "C:\Users\Administrator\CCADProjects\<ProjectName>"
  ```
- **In VS Code:** Open `Program.cs` and press `F5` (Debug) or `Ctrl+F5` (Run without debugging).

---

## Week 1 — Introduction to Programming (10975)

| Project | Description | Run Command |
| :--- | :--- | :--- |
| **Assignment1_1** | Compare two integers for equality | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_1"` |
| **Assignment1_2** | First 10 natural numbers & sum | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_2"` |
| **Assignment1_3** | Simple Calculator menu (+, -, *, /) | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_3"` |
| **Assignment1_3_1** | Area Calculator (Triangle, Square, Rectangle) | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_3_1"` |
| **Assignment1_3_2** | Array declarations, properties & methods | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_3_2"` |
| **Assignment1_3_3** | Read array elements & print in reverse | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_3_3"` |
| **Assignment1_4** | Combined: Point struct + Student class | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_4"` |
| **Assignment1_4_1** | Point struct (compare X coordinates) | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_4_1"` |
| **Assignment1_4_2** | Student class with private fields & public properties | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment1_4_2"` |

---

## Week 2 — OOP, Overloading, Abstraction & File I/O (10975)

| Project | Description | Run Command |
| :--- | :--- | :--- |
| **Assignment2_1** | Combined: Pet/Dog hierarchy + Maths overloading | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment2_1"` |
| **Assignment2_1_1** | Class hierarchy (`Pet` -> `Dog` -> breeds) | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment2_1_1"` |
| **Assignment2_1_2** | `Maths` class with overloaded `public static` methods | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment2_1_2"` |
| **Assignment2_2** | Abstract `Shape` (`Circle`, `Square`) area calculator | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment2_2"` |
| **Assignment2_3** | Combined: File I/O + Tip Calculator | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment2_3"` |
| **Assignment2_3_1** | Write & read dummy details with `BasicDetails.txt` | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment2_3_1"` |
| **Assignment2_3_2** | Tip calculator using `:C` and `:P` format specifiers | `dotnet run --project "C:\Users\Administrator\CCADProjects\Assignment2_3_2"` |

---

## Challenge Questions

| Project | Description | Run Command |
| :--- | :--- | :--- |
| **ChallengeQuestion1** | Fahrenheit temperature to weather state | `dotnet run --project "C:\Users\Administrator\CCADProjects\ChallengeQuestion1"` |
| **ChallengeQuestion2** | User ID & password login (3-attempt lockout) | `dotnet run --project "C:\Users\Administrator\CCADProjects\ChallengeQuestion2"` |
| **ChallengeQuestion3** | Number & width descending triangle pattern | `dotnet run --project "C:\Users\Administrator\CCADProjects\ChallengeQuestion3"` |
| **ChallengeQuestion4** | Student roll no, marks, total, percentage & division | `dotnet run --project "C:\Users\Administrator\CCADProjects\ChallengeQuestion4"` |
