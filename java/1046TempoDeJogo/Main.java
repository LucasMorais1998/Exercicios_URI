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

        int startTime, endTime, duration;
        int startDay = 0;
        int endDay = 24;

        startTime = sc.nextInt();
        endTime = sc.nextInt();

        if (startTime < endTime)
            duration = endTime - startTime;
        else
            duration = (endDay - startTime) + (startDay + endTime);

        System.out.printf("O JOGO DUROU %d HORA(S)%n", duration);

    }

}