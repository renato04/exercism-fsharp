module BankAccount

type Account ={
    Balance: decimal option list
    Opened: bool
}

let mkBankAccount() = 
    {Balance = List.empty ; Opened = false}

let openAccount account = 
    {account with Opened = true}

let closeAccount account = failwith "You need to implement this function."

let getBalance account = 
    account.Balance
    |> List.sumBy (fun value -> Option.defaultValue 0m value)
    |> Some

let updateBalance change account =
    
    let update transactions =
        {account with Balance = transactions}
    
    account.Balance
    |> List.append [Some(change)]
    |> update
   
    