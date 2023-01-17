using underware.VDA;


string filePath = Path.Join("Samples", "4913Sample.VDA");

var interchange = Interchange.FromFile(filePath);

Console.WriteLine(interchange.ToXml());