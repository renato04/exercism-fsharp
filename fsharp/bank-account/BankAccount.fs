module BankAccount
open System

let _lock = Object()

type Account ={
    mutable Balance: decimal option list
    mutable Opened: bool
}

let mkBankAccount() = 
    {Balance = List.empty ; Opened = false}

let openAccount account = 
    {account with Opened = true}

let closeAccount account =
    {account with Opened = false}    

let getBalance account = 
    if account.Opened then
        account.Balance
        |> List.sumBy (fun value -> Option.defaultValue 0m value)
        |> Some
    else 
        None

let updateBalance change account =
    lock _lock (fun () -> 
        account.Balance <- account.Balance
        |> List.append [Some(change)]
    )

    account
   
    