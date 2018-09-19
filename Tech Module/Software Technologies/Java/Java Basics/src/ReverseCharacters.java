import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ReverseCharacters {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String firstChar = reader.readLine();
        String secondChar = reader.readLine();
        String thirdChar = reader.readLine();

        System.out.println(thirdChar+secondChar+firstChar);
    }
}
