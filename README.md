
# 📒 Simple Contact Management App (C# Console Application)

## 🧾 Description
This is a beginner-friendly **C# console application** that allows users to manage a simple contact list. It includes core **CRUD functionality** and supports saving/loading contacts from a CSV file.

The project is ideal for C# learners to practice key concepts such as **Object-Oriented Programming (OOP)**, **LINQ**, **File I/O**, and **Exception Handling**.

---

## 🎯 Features
- ✅ Add new contact (Name, Phone, Email)
- 🔍 Search contact by name (case-insensitive)
- ❌ Delete contact by name
- 💾 Save contact list to CSV file
- 📂 Load contact list from CSV file
- ⏳ *(Optional)*: Async file read/write support

---

## 📁 Project Structure

```
ContactManagerApp/
├── Program.cs                    // Entry point, menu handling
├── Models/
│   └── Contact.cs               // Contact data model
├── Services/
│   └── ContactManager.cs        // Business logic (CRUD + CSV)
├── Utils/
│   └── InputHelper.cs           // Input validation, login helper
├── Data/
│   └── contacts.csv             // Contact data storage
└── ContactManagerApp.csproj     // Project configuration
```

---

## 🛠 Technologies Used
- C# (.NET 6 or .NET Core)
- OOP, LINQ, Exception Handling
- `StreamReader` / `StreamWriter` for File I/O
- *(Optional)* `async/await` for async file access

---

## ▶️ How to Run

1. **Clone the repository**:
   ```bash
   git clone https://github.com/QuocAn06/Mini-Project-01
   cd ContactManagerApp
   ```

2. **Build the project**:
   ```bash
   dotnet build
   ```

3. **Run the application**:
   ```bash
   dotnet run
   ```

---

## 🔐 (Optional) Login Feature
> A basic login mechanism is included in `InputHelper.cs`.  
> Default credentials (for demo):  
> **Username:** `admin`  
> **Password:** `123`

---

## 👤 Author
- Name: An Le  
- Role: Learner – Backend Developer  
- GitHub: [https://github.com/QuocAn06]  
- Email: [lenguyenquocan116@gmail.com]

---

## 📌 Notes
- The `contacts.csv` file is stored under the `Data/` directory.
- Make sure the `Data/` folder exists before running the application.
