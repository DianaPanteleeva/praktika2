using System;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
      
        int[] candidates = {10,1,2,7,6,1,5 };
        int target = 8;
    
        List<List<int>>result = new List<List<int>>(); 
        Array.Sort(candidates);
    
        List<int> current = new List<int>();
        Combination(candidates,target,0,current,result);
    
        foreach(List<int> combinations in result)
        {
            foreach(int num in combinations)
            {
                Console.Write(num + " " );  
            }
            Console.WriteLine();
        }
    
    }
    
    static void Combination(int[] candidates, int target, int start,List<int> current, List<List<int>>result)
    {
        if(target == 0)
        {
            result.Add(new List<int>(current));
            return;
        } 
        for(int i = start; i < candidates.Length; i++)
        {
            if(candidates[i] > target)
            {
                break;  
            }
            if(i > start && candidates[i] == candidates[i-1])
            {
                continue;
            }
            current.Add(candidates[i]);
            int newTarget = target - candidates[i];
            int newStart = i + 1;
            Combination(candidates,newTarget,newStart, current, result);
            current.RemoveAt(current.Count - 1);
        }
        
    }
}