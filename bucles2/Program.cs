


//! Ejercicio 1 - If
Console.WriteLine("Datos del Cliente");
Console.WriteLine("Nombre:");
string name = Console.ReadLine();

Console.WriteLine("Correo:");
string email = Console.ReadLine();

Console.WriteLine("Tiene Cupon (si o no):");
string cupon = Console.ReadLine().ToLower();

if(cupon == "si"){
    string precio = "23$";
    Console.WriteLine("El Precio Es: " + precio);
}else{
    string precio = "50$";
    Console.WriteLine("El Precio Es: " + precio);
}


// !Ejercicio 2 - Switch

string[] lenguajes = {"C++","JAVA","C#"};

foreach(var lenguaje in lenguajes){
    Console.WriteLine("Los lenguajes son: " + lenguaje);
}

Console.WriteLine("Que Lenguaje Quiere Elegir");
int eleccion = Convert.ToInt32(Console.ReadLine());

switch(eleccion){
    case 1:
        Console.WriteLine(lenguajes[0]);
        break;
    case 2: 
        Console.WriteLine(lenguajes[1]);
        Console.WriteLine("Hola Mundo");
        break;
    case 3:
        Console.WriteLine(lenguajes[2]);
        break;
    default:
        Console.WriteLine("Todavía no tenemos es lenguaje :(");
        break;
}