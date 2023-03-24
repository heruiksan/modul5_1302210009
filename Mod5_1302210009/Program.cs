// See https://aka.ms/new-console-template for more information
using Mod5_1302210009;
long a = 13;
long b = 02;
long c = 21;

Penjumlahan<long> hasil = new Penjumlahan<long>();
hasil.JumlahTigaAngka(a, b, c);

SimpleDataBase<int> data = new SimpleDataBase<int>();
data.AddNewData(13);
data.AddNewData(02);
data.AddNewData(21);
data.printAllData();