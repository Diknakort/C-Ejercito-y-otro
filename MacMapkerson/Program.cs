﻿// See https://aka.ms/new-console-template for more information
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
//ISuperUnidad SoldadoUniversal = new TanqueAtaqueSombrasVB98();
while (entrada.ToUpper() != "X")
{
    entrada = MuestraOpciones();
    switch (entrada)
    {
        case "1":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899));
            Console.WriteLine("Has sumado al ejercito un Transporte MX7899"); break;
        case "2":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98));
            Console.WriteLine("Has sumado al ejercito un Tanque de Ataque Sombras VB98"); break;
        case "3":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66));
            Console.WriteLine("Has sumado al ejercito un Transporte Rapido TAXIN66 "); break;
        case "4":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Ametrallador));
            Console.WriteLine("Has sumado al ejercito un Ametrallador "); break;
        case "5":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.InfanteriaBasica));
            Console.WriteLine("Has sumado al ejercito un Infanteria Basica "); break;
        case "6":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Sanitario));
            Console.WriteLine("Has sumado al ejercito un Sanitario "); break;
        case "7":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.CanonAntiaereo)); Console.WriteLine("Has sumado al ejercito un Canon Antiaereo "); break;
        case "8":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Canon)); Console.WriteLine("Has sumado al ejercito un Canon "); break;
        case "9":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TorpederoMovil)); Console.WriteLine("Has sumado al ejercito un Torpedero Movil "); break;
        case "0":
            Console.Clear();
            Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.SuperTanque)); Console.WriteLine("Has sumado al ejercito un Super Tanque "); break;
        case "D":
        case "d":
            Console.Clear();
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
            Console.Clear();
            Console.WriteLine($"El ejercito contiene los siguientes elementos:");
            Console.WriteLine($"{Militronchos.Listar()}"); break;
    }
}
string MuestraOpciones()
{
    Console.WriteLine($"------------------------------------------------------------------------------------");
    Console.WriteLine("Seleccione el elemento a añadir de los siguientes 9:");
    Console.WriteLine("Elementos de CABALLERIA");
    Console.WriteLine("1 - Transporte MX7899");
    Console.WriteLine("2 - Tanque de Ataque Sombras VB98");
    Console.WriteLine("3 - Transporte Rapido TAXIN 66");
    Console.WriteLine("");
    Console.WriteLine("Elementos de INFANTERIA");
    Console.WriteLine("4 - Infanteria Basica");
    Console.WriteLine("5 - Ametrallador");
    Console.WriteLine("6 - Sanitario");
    Console.WriteLine("");
    Console.WriteLine("Elementos de ARTILLERIA");
    Console.WriteLine("7 - Canon Antiaereo");
    Console.WriteLine("8 - TorpederoMovil");
    Console.WriteLine("9 - Canon");
    Console.WriteLine("");
    Console.WriteLine("Elementos Mejorados");
    Console.WriteLine("0 - SuperTank");
    Console.WriteLine("");
    Console.WriteLine("Para ver los datos del ejercito");
    Console.WriteLine("D - Mostrar Datos tecnicos de combate");    
    Console.WriteLine("L - Mostrar Lista de elementos");
    Console.WriteLine("");
    Console.WriteLine("¿Que Desea Hacer?: X para salir");
    return Console.ReadLine();
}