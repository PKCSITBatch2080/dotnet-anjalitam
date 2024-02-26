using System.Collections.Generic;

class Coll
{
    void Learn()
    {

        // One  dimensional 
        byte[] ages=[78, 23,45,67,12,34,56,7,8];
        string[] names=["anisha", "resma", "namrata"];
      
        // Multi
        int [,] studentsInClassRoom =new int[7,6];
        studentsInClassRoom[0,0] =0;
        studentsInClassRoom[0,1]=1;
        studentsInClassRoom[0,2]=2;
        studentsInClassRoom[0,3]=30;


        // Jagged Array
        int[][] studentsInClassRoom2 =[[1,2,3],[3,4],[2,4,5,6]];

        // Collections
        List<int> ageList = [3,4,5,7,7,8];
        List<string> nameList = ["anjali", "anisha", "rekha"]; //O(n) , n=3000000
         
         Dictionary<string, long> countryPopulation = new();
         countryPopulation.Add("Nepal", 2342342342);
         countryPopulation.Add("India",7927298945);
         countryPopulation.Add("USA",38427911);
         countryPopulation.Add("China", 234234256753);

    var p = countryPopulation["India"];

    }
}