namespace BankingSystem; 
public class Bank {
    private BankAccount[] accounts = new BankAccount[100];
    public int Count { get; private set; }

    public BankAccount OpenAccount() {
        BankAccount account = new BankAccount(); // { Id = Count + 1 };
        account.AccountNumber = "RABO" + account.Id;
        accounts[Count] = account;
        Count++;
        return account;
    }

    //rabo[i].Id
    public BankAccount this[int index] {
        get {
            return accounts[index];
        }

    }
    public BankAccount? this[string accountNumber] {
        get {
            for (int i = 0; i < Count; i++) {
                if (accounts[i].AccountNumber == accountNumber) {
                    return accounts[i];
                }
            }
            return null;
        }
    }
}
