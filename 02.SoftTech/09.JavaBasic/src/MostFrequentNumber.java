import java.util.Arrays;
import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String[] args) {
        int[] nums = Arrays.stream(new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int count = 0;
        int maxCount =0;
        int frqNumber = nums[0];

        for (int i = 0; i < nums.length; i++) {
            for (int j = i; j < nums.length; j++) {
                if (nums[i] == nums[j]){
                    count++;
                }
                if (count > maxCount){
                    maxCount = count;
                    frqNumber = nums[i];
                }

            }
            count = 0;

        }
        System.out.println(frqNumber);
    }
}
