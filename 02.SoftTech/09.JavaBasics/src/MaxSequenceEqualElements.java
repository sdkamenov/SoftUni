import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceEqualElements {
    public static void main(String[] args) {

        int[] nums = Arrays
                .stream(new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        
        int count = 1;
        int maxCount = 0;
        int maxNumber = nums[0];

        for (int i = 0; i < nums.length-1; i++) {
            if (nums[i] == nums[i+1]){
                count++;
                if (maxCount <count){
                    maxCount = count;
                    maxNumber = nums[i];
                }
            }else{
                count =1;
            }
            
        }
        for (int i = 0; i < maxCount; i++) {
            System.out.printf("%d ", maxNumber);

        }
    }
}
