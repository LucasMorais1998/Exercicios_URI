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

        int n = sc.nextInt();
        double value1, value2;

        for (int i = 0; i < n; i++) {
            value1 = sc.nextDouble();
            value2 = sc.nextDouble();

            if (value2 == 0) {
                System.out.println("divisao impossivel");
            } else {
                System.out.println((value1 / value2));
            }
        }

        sc.close();

    }

}