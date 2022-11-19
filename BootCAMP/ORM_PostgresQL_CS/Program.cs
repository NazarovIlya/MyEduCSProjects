App<Worker> app =
// new App<Worker>(new ListRepository());
new App<Worker>(new PostgresRepository("test"));

app.Create(new("Васильев Иван", 22, 3312));
app.Create(new("Петров Макар", 44, 4562));
app.Create(new("Иванов Василий ", 33, 1245));

app.Print(); Console.WriteLine("====");


// app.SetRepo(new ListRepository());

// app.Create(new("Сидоров Фома", 33, 1245));
// app.Create(new("vdvd vdfv ", 33, 1245));
// app.Create(new("vdfvd vdfv ", 33, 1245));
// app.Create(new("Ивvfdvан vdfv ", 33, 1245));
// app.Create(new("vdfv vdf ", 33, 1245));

// app.Print(); Console.WriteLine("====");

// app.Update(3, new(" Новый Иван Васильев ", 33, 1245));
// app.Print(); Console.WriteLine("====");


// app.Print(); Console.WriteLine();

// app.Remove(2);

// app.Print(); Console.WriteLine();

// app.Update(1, new("Ilya Naz", 122, 31312));
// app.Print(); Console.WriteLine();