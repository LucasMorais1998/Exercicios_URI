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

        int n;
        int value;
        int in = 0;
        int out = 0;

        n = sc.nextInt();

        for (int i = 0; i < n; i++) {
            value = sc.nextInt();

            if (value >= 10 && value <= 20) {
                in++;
            } else {
                out++;
            }
        }

        System.out.printf("%d in%n", in);
        System.out.printf("%d out%n", out);

        sc.close();

    }

}