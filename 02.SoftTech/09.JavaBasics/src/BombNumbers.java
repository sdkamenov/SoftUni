import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Integer> nums = Arrays
                .stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int[] bombs = Arrays
                .stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int bombNumber = bombs[0];
        int bombRange = bombs[1];

        while (nums.contains(bombNumber)) {
            int position = nums.indexOf(bombNumber);
            int start = Math.max(position - bombRange, 0);
            int end = Math.min(position + 1 + bombRange, nums.size());
            nums.subList(start, end).clear();
        }

        int sum = nums.stream().mapToInt(Integer::intValue).sum();
        System.out.println(sum);
    }
}
