public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> Unique = new(); 
        foreach(int i in nums) {
            if(!Unique.ContainsKey(i)) {
                Unique.Add(i, 0);
            }
             Unique[i] += 1;

             if(Unique[i] > nums.Length / 2 )
             return i;
        }
        return 0;
    }
}