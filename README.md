# 🚀 DSA LAB | Data Structures & Algorithms

<div align="center">

### Think. Code. Analyze. Repeat. 🧠

**A hands-on Data Structures & Algorithms laboratory built with C#, ASP.NET Core Web API, and Swagger UI.**

*From linked lists and array operations to algorithm benchmarking and complexity analysis.*

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)
![VS Code](https://img.shields.io/badge/VS_Code-007ACC?style=for-the-badge&logo=visualstudiocode&logoColor=white)

![Language](https://img.shields.io/badge/Language-C%23-blue)
![Project](https://img.shields.io/badge/Project-DSA_Laboratory-purple)
![API](https://img.shields.io/badge/API-REST-orange)
![Learning](https://img.shields.io/badge/Focus-Algorithms_%26_Complexity-success)

---

### 💡 Not just code that works. Code that makes sense.

</div>

## 🌌 The Mission

Data Structures and Algorithms are the foundation of efficient software development.

But reading algorithms in a textbook is one thing. **Building them, testing them, breaking them, and understanding their performance is where the real learning happens.**

This project transforms core DSA concepts into a collection of interactive REST API operations.

Instead of running separate console programs for every algorithm, you can explore operations directly through **Swagger UI**, inspect JSON responses, and experiment with different inputs.

### 🎯 What makes this project interesting?

- 🧩 Multiple data structures implemented in C#
- ⚙️ REST APIs for interacting with algorithms
- 🔍 Searching, insertion, deletion, updating, and traversal
- 🧠 Pointer-based linked list operations
- 📊 Big-O time and space complexity analysis
- ⚡ Traditional vs. Karatsuba multiplication
- ⏱️ Algorithm benchmarking
- 🧪 Interactive testing through Swagger
- 🚀 Five additional DSA enhancements

---

## 🧰 Technology Stack

| Technology | Purpose |
|---|---|
| **C#** | Core programming language |
| **ASP.NET Core** | Web API framework |
| **.NET** | Application runtime and SDK |
| **Swagger / OpenAPI** | Interactive API documentation |
| **Visual Studio Code** | Development environment |
| **Git & GitHub** | Version control and project hosting |

---

## 🧠 Explore the Data Structures

### 01 | Arrays 📦

Arrays provide indexed access to elements and form the foundation of many algorithms.

**Implemented operations:**

- Insert at beginning, end, or specific position
- Delete elements
- Update elements
- Linear search
- Traverse elements
- Reverse an array

```text
ORIGINAL ARRAY

[10] [20] [30] [40] [50]

          🔄 REVERSE

[50] [40] [30] [20] [10]
```

**Featured technique:** Two-pointer array reversal.

### 02 | Singly Linked List 🔗

A linear collection of nodes where each node contains data and a reference to the next node.

**Implemented operations:**

- Insert nodes at different positions
- Delete nodes
- Search for values
- Update node values
- Traverse the list
- Find the middle node

```text
HEAD
 |
 v
[10] -> [20] -> [30] -> [40] -> [50] -> NULL
                 ^
               MIDDLE
```

**Featured technique:** Slow and fast pointers to locate the middle node in O(n) time with O(1) auxiliary space.

### 03 | Doubly Linked List 🔁

A linked list where each node stores references to both the previous and next nodes.

**Implemented operations:**

- Forward traversal
- Backward traversal
- Insert and delete nodes
- Search and update
- Reverse the entire list

```text
BEFORE

NULL <- [10] <-> [20] <-> [30] <-> [40] -> NULL

AFTER REVERSAL

NULL <- [40] <-> [30] <-> [20] <-> [10] -> NULL
```

**Featured technique:** Reversing a list by swapping `Next` and `Prev` references.

### 04 | Circular Linked List 🔄

Unlike an ordinary singly linked list, a circular linked list connects its last node back to its first node.

**Implemented operations:**

- Insert at beginning
- Insert at end
- Insert at a specific position
- Delete from beginning or end
- Search for values
- Circular traversal

```text
      ┌─────────────────────────┐
      |                         |
      v                         |
    [10] -> [20] -> [30] -> [40]
```

**Featured technique:** Position-based insertion while preserving the circular connection.

---

## 🔥 My 5 DSA Enhancements

This repository extends the original academic lab with five additional implementations.

| # | Enhancement | Technique | Time | Auxiliary Space |
|---|---|---|---|---|
| 01 | Array Reversal | Two pointers | O(n) | O(1) |
| 02 | Find Middle Node | Slow / fast pointers | O(n) | O(1) |
| 03 | Reverse Doubly Linked List | Reference swapping | O(n) | O(1) |
| 04 | Circular List Insert at Position | Node traversal | O(n) worst case | O(1) |
| 05 | Complexity Analysis Report | Theoretical analysis | N/A | N/A |

### Why these enhancements?

The goal wasn't simply to add more methods.

It was to understand:

**How do algorithms manipulate data? Why do some approaches scale better? How can we achieve a result without allocating unnecessary memory?**

Each new operation demonstrates a practical algorithmic technique.

---

## ⚡ Beyond Data Structures

The project also includes several additional programming and algorithmic modules.

### 🧮 Multiplication Algorithms

Explore two different approaches to integer multiplication:

**Traditional Multiplication**

The familiar grade-school technique, with quadratic time complexity in the number of digits.

**Karatsuba Multiplication**

A divide-and-conquer algorithm that reduces the number of recursive multiplications.

| Algorithm | Theoretical Time |
|---|---|
| Traditional | O(n²) |
| Karatsuba | O(n^1.585) |

The project includes comparison and benchmarking functionality to help study their behavior.

### ⏱️ Algorithm Benchmarking

Use the complexity endpoints to run multiplication benchmarks across different input sizes and compare observed performance with theoretical complexity.

### 🧩 Additional Modules

The repository also includes modules for:

- Factorial operations
- Student management
- Reflection
- Application setup and configuration

These demonstrate how algorithms and C# programming concepts can be organized within a larger API application.

---

## 🌐 API Playground

**No separate frontend required.**

Swagger UI provides an interactive interface for executing API operations, submitting request bodies, and inspecting responses.

### Featured DSA Endpoints

| Method | Endpoint | Purpose |
|---|---|---|
| `POST` | `/api/array/reverse` | Reverse an array |
| `GET` | `/api/singlylinkedlist/middle` | Find the middle node |
| `POST` | `/api/doublylinkedlist/reverse` | Reverse a doubly linked list |
| `POST` | `/api/circularlinkedlist/insert-position` | Insert a node at a position |
| `GET` | `/api/complexity/dsa-operations` | View new algorithm complexity analysis |
| `GET` | `/api/complexity/analysis` | View multiplication complexity analysis |
| `GET` | `/api/complexity/benchmark` | Run multiplication benchmarks |

### Example API Request

**Insert a value into a circular linked list**

```http
POST /api/circularlinkedlist/insert-position
Content-Type: application/json
```

**Request body:**

```json
{
  "position": 1,
  "value": 15
}
```

**Example updated list:**

```json
[10, 15, 20, 30]
```

The API wraps the resulting data in a structured response with a message.

---

## 🗂️ Project Architecture

```text
📦 DataStructureAnalysis
│
├── 📂 Controllers
│   ├── ArrayController.cs
│   ├── CircularLinkedListController.cs
│   ├── ComplexityController.cs
│   ├── DoublyLinkedListController.cs
│   ├── FactorialController.cs
│   ├── MultiplicationController.cs
│   ├── ReflectionController.cs
│   ├── SetupController.cs
│   ├── SinglyLinkedListController.cs
│   └── StudentsController.cs
│
├── 📂 Models
│   └── Dtos.cs
│
├── 📂 Notes
│
├── 📂 Properties
│
├── 📂 Services
│   ├── ArrayOperations.cs
│   ├── BigOAnalysisService.cs
│   ├── CircularLinkedList.cs
│   ├── DoublyLinkedList.cs
│   ├── FactorialService.cs
│   ├── MultiplicationService.cs
│   ├── SinglyLinkedList.cs
│   ├── StudentManager.cs
│   └── TimingService.cs
│
├── .gitignore
├── appsettings.Development.json
├── appsettings.json
├── DSALabsApi.csproj
├── DSALabsApi.http
├── Program.cs
└── README.md
```

### 🏗️ How the application works

```text
             HTTP REQUEST
                  |
                  v
         ┌────────────────┐
         │   CONTROLLER   │
         └────────────────┘
                  |
                  v
         ┌────────────────┐
         │    SERVICE     │
         │ DSA ALGORITHM  │
         └────────────────┘
                  |
                  v
         ┌────────────────┐
         │   API RESULT   │
         │  JSON RESPONSE │
         └────────────────┘
```

**Controllers** handle HTTP requests.

**Services** contain the actual algorithms and application logic.

**Models** define request and response data structures.

**Program.cs** configures the application, dependency injection, and API middleware.

---

## 🚀 Run It Locally

### Prerequisites

Install the following:

- .NET SDK compatible with `DSALabsApi.csproj`
- Visual Studio Code or Visual Studio
- Git

### Step 1: Clone the repository

```bash
git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
```

### Step 2: Open the project

```bash
cd YOUR-REPOSITORY
```

### Step 3: Restore dependencies

```bash
dotnet restore
```

### Step 4: Build

```bash
dotnet build
```

### Step 5: Run

```bash
dotnet run
```

### Step 6: Explore Swagger

Open the local URL shown in your terminal and append:

```text
/swagger
```

For example, if the terminal displays `http://localhost:5000`, open:

```text
http://localhost:5000/swagger
```

The actual port may differ.

**Your DSA API is now ready for testing.** 🎉

---

## 📊 Understanding Big-O

Big-O notation describes how an algorithm's resource requirements grow as input size increases.

| Complexity | Description | Example |
|---|---|---|
| O(1) | Constant | Accessing an array element by index |
| O(log n) | Logarithmic | Binary search on a sorted array |
| O(n) | Linear | Traversing a linked list |
| O(n log n) | Linearithmic | Merge sort |
| O(n²) | Quadratic | Traditional nested-loop comparisons |

### A simple comparison

```text
INPUT SIZE       O(1)       O(n)       O(n²)

    10             1          10          100
   100             1         100       10,000
  1000             1        1000    1,000,000
```

These are illustrative growth values, not measured execution times.

> **The goal of algorithm analysis is not merely to make code faster. It's to understand how well a solution scales.**

---

## 🎯 Learning Outcomes

Through this project, I practiced:

- Writing structured and reusable C# code
- Implementing core data structures
- Working with node references and linked lists
- Designing algorithms using pointer techniques
- Understanding time and space complexity
- Building REST endpoints with ASP.NET Core
- Testing APIs using Swagger UI
- Reading and extending an existing codebase
- Organizing and documenting a GitHub repository

---

## 🧭 Future Roadmap

There's always another algorithm waiting to cause trouble.

- [ ] Stack and queue implementations
- [ ] Binary search trees
- [ ] Sorting algorithms
- [ ] Graph traversal using BFS and DFS
- [ ] Unit testing with xUnit
- [ ] Algorithm visualization
- [ ] Additional benchmarking and performance comparisons

---

## 🎓 Credits & Academic Context

This project is based on the original Data Structures and Algorithms lab repository:

**[KhaleelAfzal1990 / DataStructureAnalysis](https://github.com/KhaleelAfzal1990/DataStructureAnalysis)**

The original repository provides the foundation and starter implementations.

This version includes additional DSA operations and complexity explanations developed as part of an academic learning exercise.

Special thanks to the original author for providing the lab resources.

---

<div align="center">

## 💻 Code. Debug. Learn. Improve.

*Every algorithm starts as a problem. Every solution starts with understanding.*

**Built with C# 💜 | Powered by Logic 🧠 | Driven by Curiosity 🚀**

⭐ **If this repository helped you understand DSA, consider starring it!**

</div>