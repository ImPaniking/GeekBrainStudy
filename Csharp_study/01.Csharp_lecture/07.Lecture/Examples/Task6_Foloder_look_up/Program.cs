//Задача посмотреть содержимое папки по адресу

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
        Console.WriteLine($"{indent}{item.Name}");
}
string path = @"F:\GeekBrainStudy\Csharp_study";
CatalogInfo(path);