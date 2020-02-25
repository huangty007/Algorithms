using System;

namespace SortedAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSorted si=new InsertionSorted();
            int l=11;
            int[] nums=new int[l];
            Random rd=new Random(100);
            for (int i=1;i<l;i++){               
                nums[i]=rd.Next(1,100);
            }
            Console.Write("original：");
            for(int i=1;i<l;i++){
                Console.Write(nums[i]+" ");
            }
            si.Nums=nums;
            si.StraightInsertion();
            int[] r1=si.Nums;
            si.BinaryInsertion();
            int[] r2=si.Nums;
            Console.Write("\nsorted：");
            for(int i=1;i<l;i++){
                Console.Write(r2[i]+" ");
            }
            Console.Write("\n");
        }
    }
}
