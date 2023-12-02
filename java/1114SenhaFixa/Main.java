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

        String password = "";

        while (!password.equals("2002")) {
            password = sc.nextLine();

            if (password.equals("2002"))
                System.out.println("Acesso Permitido");
            else
                System.out.println("Senha Invalida");
        }

        sc.close();
    }

}