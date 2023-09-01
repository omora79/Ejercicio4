// Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia y área de
// las siguientes figuras geométricas: cuadrado, rectángulo, triángulo y círculo. Mostrar en
// pantalla los valores calculados por cada figura geométrica.


// 1 clases y metodo

public class ejercicio4
{
    static void Main(string[] Args)
    {
        //2 definir las variables

        double ladoCuadrado, baseRec, ladoRec, lado1, lado2, lado3, alturaTriangulo, radio, perCuadrado, perRec, 
            perTria, perCirculo, areaCuadrado, areaRect, areaTriangulo, areaCirculo;

        // pedir laos datos

        Console.WriteLine("Ingrese lado del cuadrado: ");
        ladoCuadrado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la base del rectangulo: ");
        baseRec = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese lado del rectangulo: ");
        ladoRec = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese lado 1 del triangulo: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese lado 2 del triangulo: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese lado 3 del triangulo: ");
        lado3 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Ingrese la altura del triangulo: ");
        alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese elradio del circulo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        // 4 calculos

        areaCuadrado = ladoCuadrado * ladoCuadrado;
        perCuadrado = 4 * ladoCuadrado;
        areaRect = baseRec * ladoRec;
        perRec = 2*baseRec + ladoRec * 2;
        areaTriangulo = (lado1 * alturaTriangulo)/2;
        perTria = lado1 + lado2 + lado3;
        areaCirculo = 3.1416 * radio * radio;
        perCirculo = 2 * 3.1416 * radio;

        // 5 mostrar en pantalla

        Console.WriteLine($"el area del cuadrado es: {areaCuadrado} y su perimetro es: {perCuadrado} ");
        Console.WriteLine($"el area del rectangulo es: {areaRect} y su perimetro es: {perRec} ");
        Console.WriteLine($"el area del triangulo es: {areaTriangulo} y su perimetro es: {perTria} ");
        Console.WriteLine($"el area del circulo es: {areaCirculo} y su perimetro es: {perCirculo} ");
    
    
    }
}