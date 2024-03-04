// See https://aka.ms/new-console-template for more information
Console.WriteLine("GESTRION DE ARCHIVOS");
Console.WriteLine();

StreamWriter archivo = File.CreateText("archivo.txt");
archivo.WriteLine("Contenido en la primera linea");
archivo.WriteLine("Contenido en la segunda linea");
archivo.Close();
