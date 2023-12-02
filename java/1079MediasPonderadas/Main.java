import java.io.IOException;
import java.util.ArrayList;
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

        int n;
        double value1, value2, value3;

        n = sc.nextInt();

        for (int i = 0; i < n; i++) {
            value1 = sc.nextDouble();
            value2 = sc.nextDouble();
            value3 = sc.nextDouble();

            double media = ((value1 * 2) + (value2 * 3) + (value3 * 5)) / 10.0;
            System.out.printf("%.1f%n", media);
        }

        sc.close();

    }

}