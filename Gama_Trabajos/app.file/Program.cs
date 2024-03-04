// See https://aka.ms/new-console-template for more information
Console.WriteLine("GESTION DE ARCHIVOS");

Console.WriteLine();

//Creacion de archivo

StreamWriter archivo = new StreamWriter("archivo.txt");
archivo.WriteLine("Contenido del archivo.");
archivo.WriteLine("Contenido en otra linea.");
archivo.Close();