// See https://aka.ms/new-console-template for more information
using MacMapkerson;

//Console.WriteLine("Vuecencia General MacMapekerson");
//Console.WriteLine($"");
//Console.WriteLine("¿Quiere configurar su ejercito?");

IValidador MiValidador = new Validador01();
IFabricaEjercito MiFabrica = new FabricaEjercito();
MiFabrica.Validador = MiValidador;
IColeccionEjercito Militronchos = new ColeccionEjercito();

//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Ametrallador));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.InfanteriaBasica));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Sanitario));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.CanonAntiaereo));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Canon));
//Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TorpederoMovil));

Console.WriteLine("El ejercito BASE consiste en los siguientes datos:");
Console.WriteLine($"Elementos que hay en el Ejercito:  {Militronchos.dameCuantos()}");
Console.WriteLine($"Potencia de fuego del Ejercito:  {Militronchos.damePotenciaDeFuegoTotal()}");
Console.WriteLine($"Blindaje Total del Ejercito:  {Militronchos.dameBlindajeTotal()}");
Console.WriteLine($"Capacidad de movimiento del Ejercito:  {Militronchos.dameCapMovimiento()}");
Console.WriteLine($"Coste del Ejercito:  {Militronchos.dameCosteAcumulado()}");
Console.WriteLine($"Capacidad Militar del Ejercito:  {Militronchos.dameCapacidadMilitar()}");
/////////////////////// original 9 opciones /////////////////
var entrada = "";
ISuperTank tank = new TanqueAtaqueSombrasVB98();
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
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.SuperTanque)); break;
        case "D":
        case "d":
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
    Console.WriteLine("Elementos Mejorados");
    Console.WriteLine("0 - SuperTank");
    Console.WriteLine("Para ver los datos del ejercito");
    Console.WriteLine("D - Mostrar Datos tecnicos de combate");    
    Console.WriteLine("L - Mostrar Lista de elementos");
    Console.WriteLine("");
    Console.WriteLine("¿Que Desea Hacer?: X para salir");
    return Console.ReadLine();
}