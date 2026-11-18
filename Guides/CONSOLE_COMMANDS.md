# MSSA CCAD — Useful Console Commands Reference

A running cheat sheet of PowerShell, `.NET CLI`, `Git`, and `VS Code` commands for daily cohort work.

---

## 1. .NET CLI (`dotnet`) Commands

| Command | What It Does |
| :--- | :--- |
| `dotnet --version` | Check installed .NET SDK version (`10.0.403`) |
| `dotnet new console -o ProjectName --use-program-main` | Create a new C# console app with classic `Program`/`Main` structure |
| `dotnet build` | Compile the project in the current folder |
| `dotnet build "C:\Path\To\Project"` | Compile a specific project without `cd`-ing into it |
| `dotnet run` | Build and run the project in the current folder |
| `dotnet run --project "C:\Path\To\Project"` | Build and run a specific project from anywhere |
| `dotnet run --no-build` | Run immediately using the last compiled build |
| `dotnet watch run` | Automatically rebuild and rerun whenever you save a `.cs` file |
| `dotnet clean` | Remove build outputs (`bin/` and `obj/` artifacts) |
| `dotnet restore` | Restore NuGet packages/dependencies |
| `dotnet test` | Run unit tests (for xUnit/NUnit/MSTest projects) |
| `dotnet new sln -n SolutionName` | Create a `.sln` solution file to group multiple projects |
| `dotnet sln add ProjectName\ProjectName.csproj` | Add a project to a solution |

---

## 2. Git & GitHub Commands

### Daily Push Workflow (inside `C:\Users\Administrator\CCADProjects`)
```powershell
git status                               # See modified/untracked files
git add .                                # Stage all changes
git commit -m "Describe your changes"    # Save a local snapshot
git push origin main                     # Upload commits to GitHub
```

### Checking History & Syncing
| Command | What It Does |
| :--- | :--- |
| `git status --short` | Compact list of changed/untracked files |
| `git log -n 5 --oneline` | View the last 5 commits on one line each |
| `git diff` | See exact line-by-line changes before staging |
| `git pull origin main` | Download and merge latest changes from GitHub |
| `git remote -v` | Verify which GitHub repo is linked |

### Fixing Mistakes Safely
| Command | What It Does |
| :--- | :--- |
| `git restore <file>` | Discard unstaged edits to a single file |
| `git restore --staged <file>` | Unstage a file without losing your code edits |
| `git commit --amend -m "New message"` | Fix the typo in your last commit message (before pushing) |

---

## 3. PowerShell Navigation & File Management

| Command | Alias / Short | What It Does |
| :--- | :--- | :--- |
| `Set-Location "C:\Users\Administrator\CCADProjects"` | `cd` | Change current directory |
| `cd ..` | — | Move up one folder |
| `Get-Location` | `pwd` | Print current working directory |
| `Get-ChildItem` | `ls` / `dir` | List files and folders in current directory |
| `Clear-Host` | `cls` / `clear` | Clear the terminal screen |
| `New-Item -ItemType Directory Name` | `mkdir Name` | Create a new folder |
| `Get-Content file.txt` | `cat file.txt` | Print a text file's contents in the terminal |
| `Ctrl + C` | — | Stop/cancel a running console program immediately |
| `Up / Down Arrow` | — | Cycle through previous terminal commands |
| `Tab` | — | Autocomplete file/folder names and commands |

---

## 4. Visual Studio Code CLI & Shortcuts

### CLI Commands
```powershell
code .                                   # Open current folder in VS Code
code "C:\Users\Administrator\CCADProjects"           # Open CCADProjects workspace
code "C:\Users\Administrator\CCADProjects\Assignment2_2\Program.cs"  # Open specific file
```

### Must-Know VS Code Keyboard Shortcuts
| Shortcut | Action |
| :--- | :--- |
| `` Ctrl + ` `` | Toggle integrated terminal open/closed |
| `Ctrl + Shift + P` | Open Command Palette (search any VS Code action) |
| `Ctrl + P` | Quick-open any file by typing its name |
| `Shift + Alt + F` | Auto-format C# code cleanly |
| `Ctrl + /` | Comment / uncomment selected lines |
| `F5` / `Ctrl + F5` | Start Debugging / Run without Debugging |
| `F9` | Toggle breakpoint on current line |
| `F10` / `F11` | Step Over / Step Into while debugging |
| `Ctrl + S` | Save current file (`Ctrl + K, S` saves all files) |
