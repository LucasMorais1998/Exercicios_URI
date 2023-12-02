import java.io.IOException;
import java.util.Scanner;

/**
 * IMPORTANT:
 * O nome da classe deve ser "Main" para que a sua solução execute
 * Class name must be "Main" for your solution to execute
 * El nombre de la clase debe ser "Main" para que su solución ejecutar
 */
public class Main {

    public static void main(String[] args) throws IOException {

        Scanner sc = new Scanner(System.in);

        double a, b, c;
        double triangleArea, circleArea, trapezoidArea, squareArea, rectangleArea;

        a = sc.nextDouble();
        b = sc.nextDouble();
        c = sc.nextDouble();

        triangleArea = (a * c) / 2;
        circleArea = 3.14159 * Math.pow(c, 2);
        trapezoidArea = ((a + b) * c) / 2;
        squareArea = Math.pow(b, 2);
        rectangleArea = a * b;

        System.out.printf("TRIANGULO: %.3f%n", triangleArea);
        System.out.printf("CIRCULO: %.3f%n", circleArea);
        System.out.printf("TRAPEZIO: %.3f%n", trapezoidArea);
        System.out.printf("QUADRADO: %.3f%n", squareArea);
        System.out.printf("RETANGULO: %.3f%n", rectangleArea);

        sc.close();

    }

}