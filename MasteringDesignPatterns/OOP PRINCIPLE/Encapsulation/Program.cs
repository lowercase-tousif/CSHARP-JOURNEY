using System;
using MasteringDesignPatterns;

BankAccount bankAccount = new BankAccount(100);

Console.WriteLine($"Current balance: {bankAccount.GetBalance()}");
bankAccount.deposit(100);

Console.WriteLine($"Current balance: {bankAccount.GetBalance()}");

// Withdraw amount
bankAccount.withdraw(50);
Console.WriteLine($"Current balance: {bankAccount.GetBalance()}");


// setting a new balance
bankAccount.SetBalance(200);

Console.WriteLine($"Current balance: {bankAccount.GetBalance()}");

