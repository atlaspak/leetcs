public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        int i = 0;
        
        while(true){
            int val1 = strToInt(v1,i);
            int val2 = strToInt(v2,i);
            
            if(val1 > val2)
                return 1;            
            if(val2 > val1)
                return -1;            
            i++;   
            if(i >= v1.Length && i >= v2.Length )
                return 0;
        }
    }
    
    public int strToInt(string[] strArr,int i){
        if(strArr.Length <= i)
            return 0;        
        else if(String.IsNullOrEmpty(strArr[i]))
            return 0;
        return Int32.Parse(strArr[i]);
    }
}
