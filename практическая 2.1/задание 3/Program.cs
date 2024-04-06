using System;
class HelloWorld {
    static void Main() {
      
        int[] nums = {1,2,3,1,4,5};
        bool povtor = false;
    
        for(int i = 0; i<nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    povtor = true;
                    break;
                }
            }
            if(povtor)
            {
                break;
            }
        }
    
        Console.WriteLine(povtor);
    
    }
}