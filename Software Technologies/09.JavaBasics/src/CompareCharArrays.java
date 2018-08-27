import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] first = scanner.nextLine().trim().split("\\s");
        String[] second = scanner.nextLine().trim().split("\\s");

        if (first.length < second.length) {
            PrintArray(first);
            PrintArray(second);
        } else if (first.length > second.length) {
            PrintArray(second);
            PrintArray(first);
        }else{

            for (int i = 0; i < second.length; i++) {
                if (first[i].charAt(0) < second[i].charAt(0)) {
                    PrintArray(first);
                    PrintArray(second);
                    return;
                } else if (first[i].charAt(0) > second[i].charAt(0)){
                    PrintArray(second);
                    PrintArray(first);
                    return;
                }else   {
                    PrintArray(second);
                    PrintArray(first);
                    return;
                }
            }
        }



    }

    private static void PrintArray(String[] first) {
        for (int i = 0; i < first.length; i++) {
            System.out.print(first[i]);
        }
        System.out.println();
    }
}
