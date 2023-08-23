using CreditEnterprise.Class;

Console.Write("Informe o número do contrato: ");
int ContractNumber = int.Parse(Console.ReadLine());

DateTime TimeNow = DateTime.Now;

Console.Write("Informe o valor total do contrato: ");
double ContractValue = double.Parse(Console.ReadLine());

Console.Write("Deseja parcelar em quantos meses?: ");
int ContractPortion = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

ContractData c1 = new(ContractNumber, TimeNow, ContractValue, ContractPortion);
double value = c1.GetPortion();

Invoice i1 = new(TimeNow, ContractPortion, value);

i1.GenerateInvoice();