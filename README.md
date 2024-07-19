# Book Management System

## Overview

This project is a Book Management System designed to manage book records for a library. It offers functionalities to read book information from a text file, store the data using appropriate data structures, and allows users to add books manually, view books by category, and delete books based on their categories.

The system processes and categorizes the data for user-friendly display. It employs a queue-based data structure, along with other data structures, to manage books and implements filtering criteria to ensure relevant book records are maintained.

The application is developed using C# within the .NET framework and features a Windows Graphical User Interface (GUI) for interaction.

## Features

- **Add Books Manually:** Users can add book details including ISBN, authors, book name, publisher, released year, and category.
- **Load Books from File:** Users can load book records from a text file, which should be in a specified format.
- **View Books:** Books can be viewed by category, with options to filter by specific categories or view all books.
- **Delete Books:** Users can delete the top book from a specific category.

## Usage

### Main Application

- **Dashboard:** The main interface where users can navigate to different functionalities such as adding books, loading books from a file, or viewing books.
- **Add Book Form:** Enter book details and click "Add Book" to manually add a book.
- **Load Book File Form:** Select a text file with book data and click "Upload File" to load books into the system.
- **View Books Form:** Filter and view books by category, and delete the top book from a selected category.

### File Format for Book Data

- Each line in the text file should be in the following format:

  ```
  ISBN,Author1:Author2,BookName,Publisher,ReleasedYear,Category
  ```

  Example:

  ```
  978-3-16-148410-0,John Doe:Jane Smith,Introduction to Programming,Tech Publishers,2020,Computer Science
  ```

## Code Structure

### Files and Classes

- **`Program.cs`**
  - Entry point for the application. Starts the main form (Dashboard).

- **`AddBookForm.cs`**
  - Form for adding a new book manually. Validates input and adds book to the system.

- **`Dashboard.cs`**
  - Main form that provides navigation to other forms (AddBookForm, LoadBookFileForm, ViewBooksForm).

- **`LoadBookFileForm.cs`**
  - Form for loading book data from a file. Allows users to select and upload a text file.

- **`ViewBooksForm.cs`**
  - Form for viewing books. Provides options to filter books by category and delete books.

- **`Book.cs`**
  - Represents a book with properties like ISBN, authors, book name, publisher, released year, and category.

- **`BookDataStructure.cs`**
  - Manages a queue of books with filtering criteria. Implements a singleton pattern.

- **`DataManager.cs`**
  - Handles operations such as loading books, adding books, and displaying books. Interfaces with BookDataStructure and ProcessBooksData.

- **`ProcessBooksData.cs`**
  - Processes and manages categorized book stacks. Provides methods for adding, displaying, and deleting books.

- **`ReadDataFile.cs`**
  - Reads book data from a file and populates the BookDataStructure. Uses the singleton pattern.
 
## Contriution: 
Designed by Elisa, for Applied Data Structure final project. 
