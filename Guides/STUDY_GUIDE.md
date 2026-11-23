# MSSA CCAD — Running Cohort Study Guide (C# / .NET)

A living study guide tracking every core programming and OOP concept covered in the **MSSA CCAD** cohort, linked to your completed projects.

---

## Week 1 — C# Fundamentals (10975)

### 1. Variables, Data Types & Console I/O
- **Projects:** `Assignment1_1`, `ChallengeQuestion1`, `ChallengeQuestion2`
- **Common Value Types:** `int` (whole numbers), `double` (floating point), `float` (single-precision, suffix `f`), `decimal` (high-precision money/financial, suffix `m`), `char` (single character in `' '`), `bool` (`true`/`false`).
- **Reference Type:** `string` (text in `" "`).
- **Safe Input Parsing:**
  ```csharp
  // Convert (throws FormatException on bad input):
  int num = Convert.ToInt32(Console.ReadLine());

  // TryParse (recommended — avoids crashing on invalid input):
  if (double.TryParse(Console.ReadLine(), out double temp))
  {
      // use temp safely
  }
  ```

### 2. Control Flow (Conditionals & Loops)
- **Projects:** `Assignment1_1`, `Assignment1_2`, `Assignment1_3`, `Assignment1_3_1`, `Assignment2_4_2`, `Assignment2_4_3`, `ChallengeQuestion1`, `ChallengeQuestion2`
- **`if / else if / else`**: Evaluate range conditions in order (e.g., temperature thresholds in `ChallengeQuestion1`).
- **`switch`**: Clean multi-branch selection (e.g., menu options in `Assignment1_3`, `Assignment2_1_2`).
- **`for` loop**: Best when you know the exact iteration count (`for (int i = 0; i < n; i++)`).
- **`while` loop**: Best when looping until a condition changes (e.g., keeping a menu alive or counting up to `maxAttempts = 3` in `ChallengeQuestion2`).
- **`break` vs `continue`**:
  - `break` exits the loop immediately.
  - `continue` skips the rest of the current iteration and jumps to the next one.

### 3. Methods
- **Projects:** `Assignment1_3`, `Assignment1_3_1`
- Break logic into reusable blocks (`static void Add(double a, double b)` or returning values like `static int Add(int a, int b)`).
- Expression-bodied methods: `static void Add(double a, double b) => Console.WriteLine(a + b);`

### 4. Arrays
- **Projects:** `Assignment1_3_2`, `Assignment1_3_3`, `Assignment2_4_1`
- Fixed-size, zero-indexed collections (`0` to `Length - 1`).
- **Declaration styles:**
  ```csharp
  int[] a = new int[3];                // Size first
  int[] b = new int[] { 50, 10, 40 };  // Explicit init
  string[] c = { "C#", "Cloud" };      // Shorthand
  ```
- **Key `Array` Properties & Methods:**
  - `.Length` (total items), `.Rank` (number of dimensions)
  - `Array.Sort(arr)`, `Array.Reverse(arr)`, `Array.IndexOf(arr, value)`, `Array.Clear(arr, startIndex, count)`

### 5. Structs vs. Classes & Encapsulation
- **Projects:** `Assignment1_4`, `Assignment1_4_1`, `Assignment1_4_2`
- **`struct`** (e.g., `Point`): **Value type** (stored on the stack/inline, copied by value). Great for small data bundles like coordinates (`X`, `Y`).
- **`class`** (e.g., `Student`): **Reference type** (allocated on the heap, variables hold a reference). Supports full inheritance and polymorphism.
- **Encapsulation (Private Fields + Public Properties):**
  Keep data members `private` and expose controlled access via `public` properties (`get` / `set`):
  ```csharp
  private int studentId;
  public int StudentId
  {
      get { return studentId; }
      set { studentId = value; }
  }
  ```

---

## Week 2 — Object-Oriented Programming & I/O (10975)

### 6. Inheritance & Polymorphism (Class Hierarchies)
- **Projects:** `Assignment2_1`, `Assignment2_1_1`
- **Inheritance (`:`)**: A derived (child) class inherits members from a base (parent) class (`class Dog : Pet`).
- **Constructor Chaining (`: base(...)`)**: Calls the parent class constructor to initialize inherited state.
- **Runtime Polymorphism (`virtual` + `override`)**:
  - Mark a base method `virtual` so derived classes can specialize it with `override`.
  - Storing `Beagle`, `WelshTerrier`, and `Boxer` in a `List<Pet>` lets `p.MakeSound()` dispatch to the right implementation at runtime.

### 7. Method Overloading (Compile-Time Polymorphism)
- **Projects:** `Assignment2_1`, `Assignment2_1_2`
- Multiple methods share the **same name** in the same class, differentiated by **parameter count** or **parameter types** (not return type alone).
  ```csharp
  public static int Add(int num1, int num2) => num1 + num2;
  public static decimal Add(decimal num1, decimal num2, decimal num3) => num1 + num2 + num3;
  public static float Multiply(float num1, float num2) => num1 * num2;
  public static float Multiply(float num1, float num2, float num3) => num1 * num2 * num3;
  ```
- **Static Methods (`public static`)**: Called directly on the class (`Maths.Add(2, 3)`) without creating an object instance.
- **Naming tip:** Avoid naming your class `Math` because it collides with `System.Math`.

### 8. Abstract Classes & Abstract Methods
- **Projects:** `Assignment2_2`
- **`abstract class Shape`**:
  - **Cannot** be instantiated directly (`new Shape()` is a compiler error).
  - Acts as a blueprint sharing common properties (`Id`, `Name`, `Color`) and enforcing a contract via `abstract` methods (`public abstract double CalculateArea();`).
- **Concrete Derived Classes (`Circle`, `Square`)**:
  - **Must** `override` every `abstract` method from the base class.
  - Circle area: $\pi r^2$ (`Math.PI * Radius * Radius`).
  - Square area: $\text{side}^2$ (`Side * Side`).

### 9. File I/O (`System.IO`)
- **Projects:** `Assignment2_3`, `Assignment2_3_1`
- Always wrap `StreamWriter` and `StreamReader` in a `using` block so file handles are automatically flushed and closed (even if an exception occurs):
  ```csharp
  using (StreamWriter writer = new StreamWriter(filePath))
  {
      writer.WriteLine("Name: Jordan Avery");
  }

  using (StreamReader reader = new StreamReader(filePath))
  {
      string? line;
      while ((line = reader.ReadLine()) != null)
      {
          Console.WriteLine(line);
      }
  }
  ```
- Wrap file operations in `try / catch` to handle permission or missing-file errors gracefully.

### 10. Standard Numeric Format Specifiers
- **Projects:** `Assignment2_3`, `Assignment2_3_2`, `ChallengeQuestion4`
- Format numbers cleanly inside interpolated strings (`$"{value:SPECIFIER}"`):
  | Specifier | Meaning | Example Input | Formatted Output |
  | :--- | :--- | :--- | :--- |
  | `:C` | Currency (local culture) | `85.5m` | `$85.50` |
  | `:P` | Percentage (multiplies by 100 and adds `%`) | `0.18m` | `18.00%` |
  | `:P0` / `:P1` | Percentage with 0 or 1 decimal place | `0.18m` | `18%` / `18.0%` |
  | `:F2` | Fixed-point with 2 decimal places | `78.5398` | `78.54` |
  | `:N0` | Number with thousands separators | `1250000` | `1,250,000` |

### 11. Nested Loops, Multi-Value Input Parsing & Computed Properties
- **Projects:** `ChallengeQuestion3`, `ChallengeQuestion4`
- **Nested `for` Loops (Pattern Printing):**
  Outer loop controls rows; inner loop controls how many characters print on each row:
  ```csharp
  for (int row = width; row >= 1; row--)
  {
      for (int col = 0; col < row; col++)
          Console.Write(number);
      Console.WriteLine();
  }
  ```
- **Parsing Multiple Values on One Line (`string.Split`):**
  ```csharp
  string[] parts = input.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
  ```
- **Computed (Read-Only) Properties:**
  Derive values dynamically from other properties so they never fall out of sync:
  ```csharp
  public double TotalMarks => PhysicsMarks + ChemistryMarks + ComputerApplicationMarks;
  public double Percentage => TotalMarks / 3.0;
  ```

---

## Week 3 — Advanced C# Concepts & Algorithms (20483)

### 12. String Mutability vs. StringBuilder (`System.Text.StringBuilder`)
- **Projects:** `Assignment3_1`, `Assignment3_1_1`
- **Microsoft Learn Reference:** [*How to concatenate strings in C#* & *StringBuilder Class (.NET API Browser)*](https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder)
- **`System.String` Immutability:**
  In C#, `string` is an immutable reference type. Every time you concatenate strings using the `+` or `+=` operator inside a loop, the CLR allocates an entirely **new string object** on the managed heap and copies all previous characters into it. For $N$ loop iterations, this results in $O(N^2)$ memory churn and triggers garbage collection (GC) pressure.
- **`System.Text.StringBuilder`:**
  Represents a mutable sequence of characters. It maintains an internal character array buffer that dynamically expands as needed:
  ```csharp
  StringBuilder sb = new StringBuilder();
  for (int i = 2; i < 100; i += 2)
  {
      if (sb.Length > 0)
          sb.Append(' ');
      sb.Append(i);
  }
  return sb.ToString();
  ```
  - Appends characters in amortized $O(1)$ time.
  - Generates zero intermediate string heap allocations during the loop.
  - Converts back to a standard string via `.ToString()` only once when completed.

### 13. Boolean Logic & Gregorian Leap Year Rules
- **Projects:** `Assignment3_1`, `Assignment3_1_2`
- **Microsoft Learn Reference:** [*DateTime.IsLeapYear Method* & *C# Boolean Logical Operators*](https://learn.microsoft.com/en-us/dotnet/api/system.datetime.isleapyear)
- **Algorithm Rules:**
  According to the Gregorian calendar:
  1. A year divisible by 4 is a leap year (`year % 4 == 0`).
  2. **Exception:** If divisible by 100, it is **not** a leap year (`year % 100 != 0`).
  3. **Exception to the Exception:** If divisible by 400, it **is** a leap year (`year % 400 == 0`).
- **C# Implementation:**
  ```csharp
  public static bool IfYearIsLeap(int year)
  {
      return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
  }
  ```
- **Operator Precedence & Short-Circuit Evaluation (`&&` and `||`):**
  Microsoft Learn highlights that C#'s conditional logical operators (`&&` and `||`) use **short-circuit evaluation**:
  - In `A && B`, if `A` evaluates to `false`, `B` is never evaluated.
  - In `A || B`, if `A` evaluates to `true`, `B` is never evaluated.

### 14. String Traversal & Character Inspection
- **Projects:** `Assignment3_1`, `Assignment3_1_3`
- **Microsoft Learn Reference:** [*Strings - C# Programming Guide* & *Char Struct*](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
- **Strings as Read-Only Collections of Characters:**
  In C#, `string` implements `IEnumerable<char>`. You can inspect characters individually using an indexer (`str[i]`) or with a `foreach` loop:
  ```csharp
  int spaceCount = 0;
  foreach (char ch in str)
  {
      if (ch == ' ')
          spaceCount++;
  }
  ```
- **Performance Tip:** Iterating via `foreach (char ch in str)` avoids index calculations and checks character values directly without creating intermediate string tokens.

### 15. Array Mutation, Bounds Safety & Early Loop Exit (`break`)
- **Projects:** `Assignment3_1`, `Assignment3_1_4`
- **Microsoft Learn Reference:** [*Arrays - C# Programming Guide* & *Iteration statements - break statement*](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements#the-break-statement)
- **Reference Semantics with Arrays:**
  When passing an array `int[] arr` to a method, the reference to the array on the heap is passed. Any element assignment `arr[i] = 0` mutates the underlying array elements directly in place.
- **Preventing `IndexOutOfRangeException`:**
  When inspecting adjacent elements (`arr[i]` and `arr[i + 1]`), the loop upper bound must be strictly less than `arr.Length - 1`:
  ```csharp
  for (int i = 0; i < arr.Length - 1; i++)
  {
      if (arr[i] == 1 && arr[i + 1] == 1)
      {
          arr[i] = 0;
          arr[i + 1] = 0;
          break; // Halts iteration immediately after the first occurrence
      }
  }
  ```
- **Early Exit (`break`):**
  The `break` statement terminates the closest enclosing iteration loop immediately, ensuring that subsequent pairs of consecutive ones remain untouched.

### 16. Multidimensional (2D) Arrays vs. Jagged Arrays (`int[,]` vs. `int[][]`)
- **Projects:** `Assignment3_2`, `Assignment3_2_1`
- **Microsoft Learn Reference:** [*Multidimensional Arrays - C# Programming Guide*](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays) & [*Array.GetLength Method*](https://learn.microsoft.com/en-us/dotnet/api/system.array.getlength)
- **Rectangular Multidimensional Array (`int[,]`):**
  A 2D array in C# represents a fixed grid (matrix) where every row has the exact same number of columns:
  ```csharp
  int[,] matrix = {
      { 2, 3, 4 },
      { 1, 4, 6 }
  };
  ```
  - **Memory Layout:** Allocated as a single contiguous block of memory on the managed heap.
  - **Dimensions (Rank):** `matrix.Rank` is `2`.
  - **Querying Bounds:**
    - `matrix.Length`: Total element count across all dimensions ($2 \times 3 = 6$).
    - `matrix.GetLength(0)`: Number of rows (dimension index 0).
    - `matrix.GetLength(1)`: Number of columns (dimension index 1).
- **Row-Major Traversal:**
  Iterate using nested `for` loops where the outer loop traverses rows and the inner loop traverses columns:
  ```csharp
  for (int r = 0; r < matrix.GetLength(0); r++)
  {
      Console.Write("|");
      for (int c = 0; c < matrix.GetLength(1); c++)
      {
          Console.Write($" {matrix[r, c]} |");
      }
      Console.WriteLine();
  }
  ```
- **Difference from Jagged Arrays (`int[][]`):**
  - **2D Array (`int[,]`):** Rectangular; single heap allocation; accessed via `matrix[r, c]`.
  - **Jagged Array (`int[][]`):** "Array of arrays"; each inner array is an independent heap object with potentially different lengths; accessed via `jagged[r][c]`.

### 17. Matrix Arithmetic & Element-Wise Operations
- **Projects:** `Assignment3_2`, `Assignment3_2_2`
- **Microsoft Learn Reference:** [*Multidimensional Arrays - C# Programming Guide*](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays) & [*Indexer operator [] - C# Reference*](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#indexer-operator-)
- **Matrix Addition Rules:**
  Two matrices $A$ and $B$ can be added if and only if they share identical dimensions ($M \times N$). The sum matrix $C = A + B$ is formed by adding elements at identical coordinates:
  $$C[i, j] = A[i, j] + B[i, j] \quad \text{for } 0 \le i < M, \, 0 \le j < N$$
- **C# Implementation:**
  ```csharp
  int[,] sum = new int[size, size];
  for (int i = 0; i < size; i++)
  {
      for (int j = 0; j < size; j++)
      {
          sum[i, j] = first[i, j] + second[i, j];
      }
  }
  ```
- **Performance & Cache Locality:**
  Because .NET stores 2D arrays in row-major order, traversing rows in the outer loop `i` and columns in the inner loop `j` accesses adjacent memory addresses sequentially, ensuring optimal CPU L1/L2 data cache utilization.

### 18. Operator Overloading
- **Projects:** `Assignment3_2`, `Assignment3_2_3`
- **Microsoft Learn Reference:** [*Operator overloading - C# reference*](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading)
- **Concept & Syntax Rules:**
  - Operator overloading enables user-defined types (classes and structs) to customize the behavior of built-in C# operators (`+`, `-`, `*`, `==`, `<`, etc.).
  - **Declaration Signature:** An operator overload must always be declared as `public static`.
  - **Type Requirement:** At least one of the operator's parameters must be of the containing class or struct type.
  - **Return Type:** The return type does not have to be the containing type; it can be any valid C# type (e.g., returning `double` when calculating total or difference of geometric properties).
- **Example Implementation (Circle Area Operators):**
  ```csharp
  public class Circle
  {
      public double Radius { get; set; }
      public double Area => Math.PI * Radius * Radius;

      // Overloaded '+' operator: adds areas of two circles
      public static double operator +(Circle c1, Circle c2)
      {
          if (c1 == null || c2 == null) return 0;
          return c1.Area + c2.Area;
      }

      // Overloaded '-' operator: difference of areas
      public static double operator -(Circle c1, Circle c2)
      {
          if (c1 == null || c2 == null) return 0;
          return Math.Abs(c1.Area - c2.Area);
      }
  }
  ```
- **Operator Overloading Guidelines:**
  - Overloaded operators cannot change operator precedence or associativity rules defined by the C# language.
  - If comparison operators (`==` and `!=`, `<` and `>`) are overloaded, they must be overloaded in matching pairs.

### 19. Method Parameter Modifiers: `params` and `out`
- **Projects:** `Assignment3_2`, `Assignment3_2_4`
- **Microsoft Learn Reference:** [*params collection parameter modifier - C# reference*](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params) & [*out parameter modifier - C# reference*](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier)
- **The `params` Modifier (Variable-Length Argument Lists):**
  - Specifies that a method parameter can accept zero or more arguments of the given type, passed as a comma-separated argument list or as an existing array.
  - **Rules:**
    1. Only one `params` keyword is allowed in a method signature.
    2. It must be the **last** parameter in the parameter list.
    3. The parameter type must be a single-dimensional array (e.g., `params double[] numbers`).
- **The `out` Modifier (Definite Assignment & Output Arguments):**
  - Passes arguments by reference. Unlike standard value parameters, variables passed to `out` parameters do not need to be initialized before being passed into the method.
  - **Definite Assignment Rule:** The callee (called method) **must** assign a value to every `out` parameter on all possible code paths before returning.
  - Enables methods to return multiple pieces of data to the caller without creating custom wrapper classes or structs.
- **Example Implementation:**
  ```csharp
  public static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
  {
      total = 0;
      if (numbers == null || numbers.Length == 0)
      {
          average = 0;
          return;
      }

      foreach (double num in numbers)
      {
          total += num;
      }
      average = total / numbers.Length;
  }

  // Invocation:
  CalculateTotalAndAverage(out double total, out double avg, 10, 15, 20, 30);
  ```

### 20. Array Searching Algorithms & Linear Search
- **Projects:** `Assignment3_2`, `Assignment3_2_5`
- **Microsoft Learn Reference:** [*Arrays - C# Programming Guide*](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/) & [*Array.IndexOf Method*](https://learn.microsoft.com/en-us/dotnet/api/system.array.indexof)
- **Linear Search Mechanics:**
  - Iterates sequentially from index $0$ to $\text{Length} - 1$ through the array, comparing each element with the target search item.
  - **Early Exit:** As soon as an element matches the target, the current index is returned immediately, terminating further iterations.
  - **Sentinel Value (`-1`):** In C# and computer science conventions, valid array indices are 0-based ($\ge 0$). Returning `-1` unambiguously signals that the search item does not exist in the collection.
- **Complexity Analysis:**
  - **Best Case:** $O(1)$ — Target is at index 0.
  - **Worst Case:** $O(N)$ — Target is at the very last index or not present at all.
  - **Average Case:** $O(N)$ — Target is found halfway through on average ($\approx N/2$ operations).
  - **Space Complexity:** $O(1)$ auxiliary space (operates in-place).
- **Example Implementation:**
  ```csharp
  public static int Search(int[] arr, int target)
  {
      if (arr == null) return -1;

      for (int i = 0; i < arr.Length; i++)
      {
          if (arr[i] == target)
          {
              return i; // Target found
          }
      }

      return -1; // Target not found
  }
  ```

---

## Interview & Exam Quick-Check Questions (Weeks 1–3)
1. **Struct vs. Class:** What's the difference? *(Value type on stack vs. reference type on heap; structs don't support class inheritance.)*
2. **Overloading vs. Overriding:** What's the difference? *(Overloading = same name, different signature, resolved at compile time; Overriding = derived class replaces `virtual`/`abstract` base method, resolved at runtime.)*
3. **Why use `decimal` instead of `double` for money?** *(`decimal` uses base-10 floating point, avoiding binary rounding errors in financial calculations.)*
4. **Why wrap `StreamWriter`/`StreamReader` in `using`?** *(Ensures `Dispose()` is called automatically to flush buffers and release OS file locks.)*
5. **Can you instantiate an `abstract` class?** *(No — you must inherit from it in a concrete class and implement all `abstract` members.)*
6. **Why is `StringBuilder` faster than string concatenation in loops?** *(String is immutable, so concatenation creates a new heap object on every step. `StringBuilder` uses a mutable character buffer and expands in-place without reallocation.)*
7. **What is short-circuit evaluation in C#?** *(`&&` and `||` stop evaluating right-hand operands as soon as the outcome is guaranteed: `false && ...` skips right, `true || ...` skips right.)*
8. **Why does modifying an array inside a method change the caller's array?** *(Arrays are reference types stored on the heap; the method receives a copy of the reference pointing to the same underlying array memory.)*
9. **What is the difference between `arr.Length` and `arr.GetLength(0)` on a 2D array?** *(`arr.Length` returns the total number of elements across all dimensions; `arr.GetLength(0)` returns the number of rows in the first dimension.)*
10. **What is operator overloading and what are the syntax rules in C#?** *(Overloading allows custom classes/structs to define behavior for operators like `+` and `-`. Must be declared `public static`, and at least one operand must be of the declaring type.)*
11. **What are the rules and constraints when using the `params` keyword?** *(Only one `params` parameter is allowed per method, it must be the last parameter, and it must be a single-dimensional array.)*
12. **How does an `out` parameter differ from a `ref` parameter?** *(`out` parameters do not need to be initialized by the caller prior to passing, but the called method is required under definite assignment rules to set a value before returning. `ref` parameters require caller initialization.)*
13. **What is the time complexity of linear search, and why does `Search` return `-1` if not found?** *(Time complexity is $O(N)$ in the worst/average case. `-1` is used as a sentinel value because valid 0-based array indices are $\ge 0$.)*
