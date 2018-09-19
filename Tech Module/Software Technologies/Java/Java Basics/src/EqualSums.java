import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        int[] numbers = Arrays.stream(new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        for (int i = 0; i < numbers.length; i++) {

            int sumLeft = 0;
            int sumRight = 0;

            for (int j = 0; j < i; j++) {
                sumLeft += numbers[j];
            }

            for (int k = i + 1; k < numbers.length; k++) {
                sumRight += numbers[k];
            }

            if (sumLeft == sumRight) {
                System.out.println(i);
                return;
            }
        }
        System.out.println("no");
    }
}
