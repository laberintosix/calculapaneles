/*Problema
El problema a resolver consiste en encontrar la máxima cantidad de rectángulos de dimensiones “a” y “b” (paneles solares)
que caben dentro de un rectángulo de dimensiones “x” e “y” (techo), según se muestra en la siguiente figura:
*/

//Declarar variables
int alturaPanel, anchoPanel, alturaTecho, anchoTecho, resultado;
string seguir = "y";
//bienvenida y solicitud de datos
while(seguir == "y" || seguir == "Y")
{
    Console.WriteLine("Bienvenido al sistema Calcula Paneles\n debes bridarme algunos valores para calcular cuantos paneles caben en un techo");
    Console.WriteLine("Necesito que me des las medidas del panel solar\n ¿Cual es la altura del panel solar?");
    alturaPanel = int.Parse(Console.ReadLine());

    Console.WriteLine("¿Cuál es el ancho del panel solar?");
    anchoPanel = int.Parse(Console.ReadLine());

    Console.WriteLine("Necesito que me des las medidas del techo");
    Console.WriteLine("¿Cuál es la altura del techo?");
    alturaTecho = int.Parse(Console.ReadLine());

    Console.WriteLine("¿Cual el ancho del techo?");
    anchoTecho = int.Parse(Console.ReadLine());

    resultado = CalcularPaneles(alturaPanel, anchoPanel, alturaTecho, anchoTecho);

    Console.WriteLine("En el techo indicado caben: " + resultado + " paneles solares\n");
    Console.WriteLine("¿Decea realizar otro calculo?\n para continuar ingrese la letra 'Y' o 'N' para salir");
    seguir = Console.ReadLine();
    Console.Clear();
    if (seguir != "y" || seguir != "Y")
    {
        Console.WriteLine("Gracias por usar 'Calcula Paneles'");
    }

}

static int CalcularPaneles(int alturaPanel, int anchoPanel, int alturaTecho, int anchoTecho)
{
    int techo, panelSolar, resultado;
    panelSolar = alturaPanel * anchoPanel;
    techo = alturaTecho * anchoTecho;
    resultado = techo / panelSolar;
    return resultado;
}
    

