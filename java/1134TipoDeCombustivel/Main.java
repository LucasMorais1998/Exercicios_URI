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

        int alcool = 0, gasolina = 0, diesel = 0;
        String code = "";

        ArrayList<String> validCodes = new ArrayList<>();
        validCodes.add("1");
        validCodes.add("2");
        validCodes.add("3");
        validCodes.add("4");

        while (!code.equals("4")) {
            code = sc.nextLine();
            while (!validCodes.contains(code)) {
                code = sc.nextLine();
            }

            if (code.equals("1")) {
                alcool++;
            }

            if (code.equals("2")) {
                gasolina++;
            }

            if (code.equals("3")) {
                diesel++;
            }
        }

        System.out.println("MUITO OBRIGADO");
        System.out.println("Alcool: " + alcool);
        System.out.println("Gasolina: " + gasolina);
        System.out.println("Diesel: " + diesel);

        sc.close();

    }

}