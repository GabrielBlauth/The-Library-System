# The Library System

**Author:** Gabriel Blauth de Araujo

## About

A simple console-based library management system built as an introductory Object-Oriented Programming exercise in C#. It models a small library catalog where users can view, borrow, and return books, using a `Dictionary` for fast lookups by title.

## Features

- **Display all books** — lists every book in the library along with its status (Available / Borrowed)
- **Borrow a book** — marks a book as borrowed, with a check to prevent borrowing a book that's already out
- **Return a book** — marks a book as available again, with a check to prevent returning a book that was never borrowed

## Technical Overview
- **Language:** C# (.NET Console Application)
- **Data structure:** `Dictionary<string, Book>` for O(1) lookup by title (case-insensitive)
- **Design:** simple two-class model — `Book` (data) and `Library` (behavior/business logic) — separating state from operations

## What This Demonstrates

This was an early exercise focused on OOP fundamentals: encapsulation (state managed inside `Library`, not exposed directly), basic input validation, and using the right data structure (`Dictionary`) for the access pattern needed. It's intentionally small in scope compared to later assignments — a good example of the starting point before moving on to database-backed, multi-role applications like the [Health App](https://github.com/GabrielBlauth/Health-App) or [Banking System](https://github.com/GabrielBlauth/Banking-System-Application).

## Getting Started

1. Clone the repository
2. Open `oop-assigment-2-A-2024-74154.sln` in Visual Studio
3. Run (F5) — the library starts pre-loaded with 4 sample books, ready to borrow/return/display
