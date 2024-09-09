# ATM Simulation Project
## This project simulates an ATM system where users can create accounts, order cards, deposit and withdraw money, and manage their finances. The system is designed using Object-Oriented Programming principles, emphasizing separation of concerns, error handling, and modularity.

## Features
Account Creation: Users can create accounts with personal information.

Card Ordering: Users can order cards associated with their accounts in multiple currencies.

Deposit and Withdraw: Users can deposit money into their accounts and withdraw funds based on their balance.

Custom Exception Handling: Custom exceptions like UserNotFoundException for better error management.

Operations Logging: The system provides feedback on deposit and withdrawal operations, including errors when trying to withdraw more than the available balance.

## Technologies Used
C#: Main programming language.
.NET: Framework used for building the project.

# Project Structure
ATM.Models: Contains the core data models, such as User, Card, and Currencies.
ATM.Account: Provides services for managing accounts (AccountService), including creating and closing accounts.
ATM.Operations: Contains the main ATM operations, such as making deposits and withdrawals (Operations), and card services (CardService).
ATM.Exceptions: Custom exception classes for handling errors (e.g., UserNotFoundException).

# License
This project is licensed under the MIT License. See the LICENSE file for details.
