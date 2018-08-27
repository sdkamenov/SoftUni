import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {

        int[] nums = Arrays
                .stream(new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int count = 0;
        int maxCount = 0;
        int woop = 0;

        for (int i = 0; i < nums.length - 1; i++) {
            if (nums[i] < nums[i + 1]) {
                count++;
                if (maxCount < count) {
                    woop = i - count;
                    maxCount = count;
                }
            } else {
                count = 0;
            }

        }
        for (int i = woop + 1; i <= woop + maxCount + 1; i++) {
            System.out.printf(nums[i] + " ");

        }
    }
}
