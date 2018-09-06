import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class VowelOrDigit {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        char firstChar = reader.readLine().charAt(0);

        if (Character.isDigit(firstChar)){
            System.out.println("digit");
        }else if(firstChar == 'a' ||
                firstChar == 'e' ||
                firstChar == 'o' ||
                firstChar == 'u' ||
                firstChar == 'i'){
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }

    }
}
