# underware.VDA
.NET Library for parsing VDA EDI file.

You can parse VDA interchange into object structure. Export it into the xml or search data via Linq.

```c#
//Load interchange from file
var interchange = Interchange.FromFile(filePath);

//And export it into xml if needed
Console.WriteLine(interchange.ToXml());

```

See more in underware.VDA.Examples project. 
