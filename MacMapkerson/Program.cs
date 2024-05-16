// See https://aka.ms/new-console-template for more information
using MacMapkerson;

//Console.WriteLine("Vuecencia General MacMapekerson");
//Console.WriteLine($"");
//Console.WriteLine("¿Quiere configurar su ejercito?");

IValidador MiValidador = new Validador01();
IFabricaEjercito MiFabrica = new FabricaEjercito();
MiFabrica.Validador = MiValidador;

IColeccionEjercito Militronchos = new ColeccionEjercito();

Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Ametrallador));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.InfanteriaBasica));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Sanitario));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.CanonAntiaereo));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Canon));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TorpederoMovil));

Console.WriteLine("El ejercito BASE consiste en los siguientes datos:");
Console.WriteLine($"Elementos que hay en el Ejercito:  {Militronchos.dameCuantos()}");
Console.WriteLine($"Potencia de fuego del Ejercito:  {Militronchos.damePotenciaDeFuegoTotal()}");
Console.WriteLine($"Blindaje Total del Ejercito:  {Militronchos.dameBlindajeTotal()}");
Console.WriteLine($"Capacidad de movimiento del Ejercito:  {Militronchos.dameCapMovimiento()}");
Console.WriteLine($"Coste del Ejercito:  {Militronchos.dameCosteAcumulado()}");
Console.WriteLine($"Capacidad Militar del Ejercito:  {Militronchos.dameCapacidadMilitar()}");


//var selector = "";

//string Caballeria()
//{
//    var entrada = "";
//    while (entrada.ToUpper() != "X")
//    {
//        entrada = MuestraCaballeria();
//        switch (entrada)
//        {
//            case "1":
//                Console.WriteLine("Seleccionaste Caballeria");
//                Console.WriteLine("Selecciona una opción:");
//;               Console.WriteLine("Selecciona una opción:");
//                int opcionCaballeria = Convert.ToInt32(Console.ReadLine());

//                // Crear el objeto correspondiente a la opción seleccionada y añadirlo a Militronchos
//                switch (opcionCaballeria)
//                {
//                    case 1:
//                        // Añadir un jinete a Militronchos
//                        Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899));
//                        break;
//                    case 2:
//                        // Añadir un vehículo a Militronchos
//                        Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98));
//                        break;
//                    case 3:
//                        // Añadir un vehículo a Militronchos
//                        Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66));
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida");
//                        return;
//                }
//                break;
//            case "2":
//                Infanteria; break;
//            case "3":
//                Artilleria; break;
//        }
//    }
//}

//string MuestraCaballeria()
//{
//    Console.WriteLine("1 - Transporte MX7899");
//    Console.WriteLine("2 - Tanque de Ataque Sombras VB98");
//    Console.WriteLine("3 - Transporte Rapido TAXIN 66");
//}



//while (selector.ToUpper() !="0")
//{
//    selector = MuestraArmas();
//    switch (selector)
//    {
//        case "1": Caballeria() ; break;
//        case "2": Infanteria() ; break;
//        case "3": Artilleria() ; break;
//    }
//}
//string MuestraArmas()
//{
//    return Console.ReadLine();
//}


//var entrada = "";
//while (entrada.ToUpper() != "X")
//{
//    entrada = MuestraOpciones();
//    switch (entrada)
//    {
//        case "1":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899)); break;
//        case "2":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98)); break;
//        case "3":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66)); break;
//        case "4":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Ametrallador)); break;
//        case "5":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.InfanteriaBasica)); break;
//        case "6":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Sanitario)); break;
//        case "7":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.CanonAntiaereo)); break;
//        case "8":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Canon)); break;
//        case "9":
//            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TorpederoMovil)); break;
//    }
//}





/////////////////////// original 9 opciones /////////////////


var entrada = "";
while (entrada.ToUpper() != "X")
{
    entrada = MuestraOpciones();
    switch (entrada)
    {
        case "1":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899)); break;
        case "2":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98)); break;
        case "3":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66)); break;
        case "4":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Ametrallador)); break;
        case "5":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.InfanteriaBasica)); break;
        case "6":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Sanitario)); break;
        case "7":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.CanonAntiaereo)); break;
        case "8":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Canon)); break;
        case "9":
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TorpederoMovil)); break;
        case "0":
            Console.WriteLine($"-----------------------------------------------------------");
            Console.WriteLine($"Elementos que hay en el Ejercito:  {Militronchos.dameCuantos()}");
            Console.WriteLine($"Potencia de fuego del Ejercito:  {Militronchos.damePotenciaDeFuegoTotal()}");
            Console.WriteLine($"Blindaje Total del Ejercito:  {Militronchos.dameBlindajeTotal()}");
            Console.WriteLine($"Capacidad de movimiento del Ejercito:  {Militronchos.dameCapMovimiento()}");
            Console.WriteLine($"Coste del Ejercito:  {Militronchos.dameCosteAcumulado()}");
            Console.WriteLine($"Capacidad Militar del Ejercito:  {Militronchos.dameCapacidadMilitar()}");
            Console.WriteLine($""); 
            break;
        case "L":
            Console.WriteLine($"El ejercito contiene los siguientes elementos:");
            Console.WriteLine($"{Militronchos.Listar()}"); break;
        case "l":
            Console.WriteLine($"El ejercito contiene los siguientes elementos:");
            Console.WriteLine($"{Militronchos.Listar()}"); break;
    }
}

string MuestraOpciones()
{
    Console.WriteLine($"------------------------------------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("Seleccione el elemento a añadir de los siguientes 9:");
    Console.WriteLine("Elementos de CABALLERIA");
    Console.WriteLine("1 - Transporte MX7899");
    Console.WriteLine("2 - Tanque de Ataque Sombras VB98");
    Console.WriteLine("3 - Transporte Rapido TAXIN 66");
    Console.WriteLine("Elementos de INFANTERIA");
    Console.WriteLine("4 - Infanteria Basica");
    Console.WriteLine("5 - Ametrallador");
    Console.WriteLine("6 - Sanitario");
    Console.WriteLine("Elementos de ARTILLERIA");
    Console.WriteLine("7 - Canon Antiaereo");
    Console.WriteLine("8 - TorpederoMovil");
    Console.WriteLine("9 - Canon");
    Console.WriteLine("");
    Console.WriteLine("Para ver los datos del ejercito");
    Console.WriteLine("0 - Mostrar Datos tecnicos de combate");    
    Console.WriteLine("L - Mostrar Lista de elementos");
    Console.WriteLine("");
    Console.WriteLine("¿Que Desea Hacer?: X para salir");
    return Console.ReadLine();
}