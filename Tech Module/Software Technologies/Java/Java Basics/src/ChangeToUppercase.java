import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        String pattern = "<upcase>(.*?)<\\/upcase>";

        Pattern pat = Pattern.compile(pattern);
        Matcher match = pat.matcher(input);

        for (int i = 0; i < input.length(); i++) {
            if (match.find()) {
                input = input.replace(match.group(), match.group(1).toUpperCase());
            }

        }
        System.out.println(input);
    }
}
