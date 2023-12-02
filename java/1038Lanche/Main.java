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

        int code;
        double qtd, total = 0;

        code = sc.nextInt();
        qtd = sc.nextDouble();

        switch (code) {
            case 1:
                total = qtd * 4.00;
                break;

            case 2:
                total = qtd * 4.50;
                break;

            case 3:
                total = qtd * 5.00;
                break;

            case 4:
                total = qtd * 2.00;
                break;

            case 5:
                total = qtd * 1.50;
                break;

            default:
                break;
        }

        System.out.printf("Total: R$ %.2f%n", total);

    }

}