using ATM.Account;
using ATM.Models;
using ATM.Operations;
using ATM.Oprations;

AccountService accountService = new();
CardService cardService = new(accountService);
Operations operations = new(accountService);
User gio = new User(Guid.NewGuid(),"Giorgi","Chikovani","48001024276",new DateTime(2001,02,25));
User gigi = new User(Guid.NewGuid(),"Giorgi","Chanturia","01023016449",new DateTime(2005,05,13));


Console.WriteLine("Ordering Card");
var giosCurs = new List<Currencies>() { Currencies.GEL, Currencies.USD, Currencies.EUR };
var card = cardService.OrderCard(gio, giosCurs);
Console.WriteLine($"Card creationg process result - {card}");

Console.WriteLine("Deposit money");
Console.WriteLine(operations.MakeDeposit(Currencies.GEL, 500, gio, card));

Console.WriteLine("Withdraw money");
Console.WriteLine(operations.Withdraw(Currencies.GEL, 900, gio, card));

Console.WriteLine(operations.Withdraw(Currencies.GEL, 300, gio, card));