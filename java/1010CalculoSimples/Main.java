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

        int cod1, num1, cod2, num2;
        double value1, value2, total1, total2;

        cod1 = sc.nextInt();
        num1 = sc.nextInt();
        value1 = sc.nextDouble();
        total1 = num1 * value1;

        cod2 = sc.nextInt();
        num2 = sc.nextInt();
        value2 = sc.nextDouble();
        total2 = num2 * value2;

        System.out.printf("VALOR A PAGAR: R$ %.2f%n", (total1 + total2));

        sc.close();

    }

}