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

        double imposto = 0;
        double salario;

        salario = sc.nextDouble();

        if (salario <= 2000.00) {
            System.out.println("Isento");
        } else if (salario <= 3000.00) {
            imposto = (salario - 2000.00) * 0.08;
            System.out.printf("R$ %.2f%n", imposto);
        } else if (salario <= 4500.00) {
            imposto = (1000.00 * 0.08) + (salario - 3000.00) * 0.18;
            System.out.printf("R$ %.2f%n", imposto);
        } else {
            imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + (salario - 4500.00) * 0.28;
            System.out.printf("R$ %.2f%n", imposto);
        }

        sc.close();
    }

}