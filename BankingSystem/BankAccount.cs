namespace BankingSystem;
public class BankAccount {
    //var b = new BankAccount() {Id = 123}
    //b.Id = 3457839; //error


    //public int Id { get; required init; }

    //var b = new BankAccount(123);
    //var b = new BankAccount() {Id = 123}
    //b.Id = 3457839; //error

    private readonly int id;
    public int Id => id;
    public BankAccount(int id) {
        this.id = id;
    }


    public string AccountNumber;
    public decimal Balance;
    public AccountType AccountType;

    public override string ToString() {
        return $"{Id} - {AccountNumber} - {Balance}";
    }

    internal BankAccount() {

    }

    public void Deposit(decimal amount) {
        Balance += amount;
    }
}

public enum AccountType {
    Savings,
    Checkings
}
