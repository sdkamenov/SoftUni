import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] email = scanner.nextLine().split("@");
        String username = email[0];
        String domain = email[1];
        String emailStr = email[0] + "@" + email[1];

        String text = scanner.nextLine();

        String censoredEmail = new String(new char[username.length()]).replace('\0', '*') + "@" + domain;
        String replaceString = text.replace(emailStr, censoredEmail);

        System.out.println(replaceString);
    }
}
