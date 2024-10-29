// породжуючі, структурні, поведінкові

// adapter(класів, об'єктів)

// адаптує несумістні інтерфейси

using _001_Adapter;



Claim(new Adapter());



static void Claim(ITarget target)
{
    target.Request();
}