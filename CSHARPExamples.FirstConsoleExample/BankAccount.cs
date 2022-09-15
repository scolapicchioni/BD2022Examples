namespace CSHARPExamples.FirstConsoleExample; 
struct BankAccount {
    public string AccountNumber;
    public decimal Balance;
    public AccountType AccountType;
}

enum AccountType { 
    Savings,
    Checkings
}
