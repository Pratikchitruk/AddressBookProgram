using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;




var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
{
    HasHeaderRecord = false
};

string ImportFilePath = @"C:\Users\Admin\OneDrive\Desktop\CSV\CSVFile\User.csv";

using var streamReader = new StreamReader(ImportFilePath);
using var csvReader = new CsvReader(streamReader, csvConfig);

string value;
while (csvReader.Read())
{
    for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
    {
        Console.Write($"{value} ");
    }

    Console.WriteLine();
}



