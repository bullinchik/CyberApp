using CyberApp.Data;

Console.WriteLine("Migrator running..");

using (var context = new DatabaseContext())
{
    var stats = context.Stats.ToList();
}