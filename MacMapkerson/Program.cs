// See https://aka.ms/new-console-template for more information
using MacMapkerson;

IValidador MiValidador = new Validador01();
IFabricaEjercito MiFabrica = new FabricaEjercito();
MiFabrica.Validador = MiValidador;

IColeccionEjercito Militronchos = new ColeccionEjercito();
IColeccionEjercito Pistolos = new ColeccionEjercito();

Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Ametrallador));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.InfanteriaBasica));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Sanitario));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.CanonAntiaereo));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.Canon));
Militronchos.Add(MiFabrica.DameEjercito(EnumTipoArma.TorpederoMovil));

/////////////////////// original 9 opciones /////////////////

var entrada = "";
while (entrada.ToUpper() != "X")
{
    entrada = MuestraOpciones();
    switch (entrada)
    {
        case "1": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteMX7899)); break;
        case "2": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.TanqueAtaqueSombrasVB98)); break;
        case "3": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.TransporteRapidoTAXIN66)); break;
        case "4": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.Ametrallador)); break;
        case "5": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.InfanteriaBasica)); break;
        case "6": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.Sanitario)); break;
        case "7": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.CanonAntiaereo)); break;
        case "8": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.Canon)); break;
        case "9": Pistolos.Add(MiFabrica.DameEjercito(EnumTipoArma.TorpederoMovil)); break;
    }
}
string MuestraOpciones()
{
        Console.Clear();
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
    Console.WriteLine("¿Has terminado de añadir unidades?: X para ir a datos de ejercito");
    return Console.ReadLine();
}

var entrada2 = "";


while (entrada2.ToUpper() != "X")
{
    Militronchos.Add((IMilitar)Pistolos);
    entrada2 = MuestraOpciones2();
    switch (entrada2)
    {
        case "0":
            Console.Clear(); 
            Console.WriteLine($"-----------------------------------------------------------");
            Console.WriteLine("El ejercito TOTAL consiste en los siguientes datos:");
            Console.WriteLine($"Elementos que hay en el Ejercito:  {Militronchos.dameCuantos()}");
            Console.WriteLine($"Potencia de fuego del Ejercito:  {((IMilitar)Militronchos).PotenciaDeFuego}");
            Console.WriteLine($"Blindaje Total del Ejercito:  {((IMilitar)Militronchos).Blindaje}");
            Console.WriteLine($"Capacidad de movimiento del Ejercito:  {((IMilitar)Militronchos).Velocidad}");
            Console.WriteLine($"Coste del Ejercito:  {((IMilitar)Militronchos).Precio}");
            Console.WriteLine($"Capacidad Militar del Ejercito:  {Militronchos.dameCapacidadMilitar()}");
            Console.WriteLine($"");
            break;
        case "L":
        case "l":
            Console.WriteLine($"El ejercito contiene los siguientes elementos:");
            Console.WriteLine($"{Militronchos.Listar()}");
            Console.WriteLine($"----- Grupo 2 del ejercito contiene -----");
            Console.WriteLine($"{Pistolos.Listar()}"); break;
    }
}
string MuestraOpciones2()
{

    Console.WriteLine($"------------------------------------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("Para ver los datos del ejercito");
    Console.WriteLine("0 - Mostrar Datos tecnicos de combate");
    Console.WriteLine("L - Mostrar Lista de elementos");
    Console.WriteLine("");
    Console.WriteLine("¿Que Desea Hacer?: X para salir");
    return Console.ReadLine();
}