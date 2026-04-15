# Generic Banking Repository Pattern

A C# console application demonstrating clean architecture principles through the implementation of the Generic Repository and Factory design patterns. This project simulates an in-memory data management system for Banks and Clients.

## 🏗️ Architecture & Patterns

* **Generic Repository Pattern:** Encapsulates the data access logic. The `GenericRepo<T>` implements standard CRUD operations for any entity inheriting from `BaseEntry`, promoting code reusability and reducing boilerplate.
* **Factory Pattern:** The `RepoFactory` abstracts the creation of repository instances, allowing for loose coupling and easier dependency management.
* **In-Memory Data Store:** Utilizes `IList<T>` for lightweight, immediate data manipulation without the overhead of a database connection during demonstration and testing.

## 📂 Project Structure

* **Models (`/Models`)**
    * `BaseEntry`: Abstract base class providing a common `Id` property.
    * `Bank`: Represents a bank entity (Name, Branch).
    * `Client`: Represents a client entity (FullName, AccountNumber, Balance, BankId).
* **Repository Layer (`/Repository_Layer`)**
    * `IRepo<T>`: Generic interface defining CRUD contracts.
    * `GenericRepo<T>`: Implementation of the repository operations against an in-memory list.
* **Factory Layer (`/Factory_Layer`)**
    * `IRepoFactory`: Interface for the repository factory.
    * `RepoFactory`: Concrete implementation that instantiates `GenericRepo<T>`.
* **Testing (`/Testing`)**
    * `TestClass`: Contains the execution logic, seeding initial data, and outputting formatted results to the console.

## 🚀 Features Demonstrated

1.  **Bulk Insertion:** Adding multiple records simultaneously using `AddRange`.
2.  **Data Retrieval:** Fetching all records (`GetAll`) and finding specific entities by ID (`Get`).
3.  **Data Mutation:** Updating properties (e.g., Client Balance) and saving changes via `Update`.
4.  **Deletion:** Removing records from the data store via `Delete`.
5.  **Console Formatting:** Utilizing `ConsoleColor` for readable, categorized terminal output.

## 💻 Getting Started

### Prerequisites
* .NET SDK (Compatible with .NET Core 3.1, .NET 5/6/7/8)
* Visual Studio or Visual Studio Code


