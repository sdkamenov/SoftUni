import java.util.Scanner;
import java.util.TreeMap;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        TreeMap<String, String> phonebook = new TreeMap<>();

        while (!input.equals("END")) {
            String[] tokens = input.split(" ");
            String command = tokens[0];

            switch (command) {
                case "A":
                    String name = tokens[1];
                    String number = tokens[2];
                    phonebook.put(name, number);
                    break;
                case "S":
                    String contact = tokens[1];
                    if (!phonebook.containsKey(contact)) {
                        System.out.printf("Contact %s does not exist.%n", contact);
                    } else {
                        System.out.printf("%s -> %s%n", contact, phonebook.get(contact));
                    }
                    break;
            }
            input = scanner.nextLine();
        }
    }
}
