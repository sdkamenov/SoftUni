import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class IntegerToHexAndBinary {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String input = reader.readLine();

        int number = Integer.parseInt(input);

        System.out.println(Integer.toHexString(number).toUpperCase());
        System.out.println(Integer.toBinaryString(number));

    }
}
