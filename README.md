# 📝 TestIndexer - C# Indexer Example

![C#](https://img.shields.io/badge/Language-C%23-blue?logo=c-sharp\&logoColor=white) ![Console App](https://img.shields.io/badge/Type-Console%20App-brightgreen)

A clean and practical **C# console application** demonstrating the use of **indexers** with **exception handling**, **array encapsulation**, and **dynamic access**.

---

## 🚀 Project Overview

This project shows how to:

* Use **indexers** to safely access private array elements.
* Encapsulate array data and enforce bounds checking.
* Handle invalid indices gracefully using **exceptions**.
* Dynamically display array elements using a **loop and length property** instead of hardcoded values.

---

## 🔹 Features

* ✅ Encapsulated private array of names.
* ✅ Safe access and modification using an indexer.
* ✅ Custom exception message `"Invalid index"` for out-of-range access.
* ✅ Flexible display loop using `Lenght` property.
* ✅ Easy to extend array size without changing loop logic.

---

## 💡 How It Works

1. Private array `Names` stores 5 string elements.
2. Indexer (`this[int index]`) allows getting and setting values safely.
3. `Lenght` property exposes the array length for dynamic looping.
4. `try-catch` handles any invalid index access and prevents runtime crashes.
5. `Main` method demonstrates assigning values and displaying all names.

---

## 🖥️ Sample Output

```
David Putin Pop Murli Tim
```

If an invalid index is accessed:

```
Invalid index
```

---

## ⚡ Usage Instructions

1. Clone the repository.
2. Open in **Visual Studio** or any C# IDE.
3. Build and run the project.
4. Modify or add names using the indexer.
5. Observe safe access and exception handling.

---

## 🔧 Technical Details

* **Language:** C#
* **Type:** Console Application
* **Array Size:** 5 (changeable via `Names` array)
* **Exception Handling:** `IndexOutOfRangeException`

---

## 👨‍💻 Author

**Parth Dubey**

---


### 🌟 Notes

* Using the `Lenght` property avoids magic numbers in loops.
* Try accessing `obj[5]` to see the `"Invalid index"` exception in action.
* Easily extendable for larger arrays or more complex data structures.
