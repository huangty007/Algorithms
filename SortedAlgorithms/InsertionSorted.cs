using System;

namespace SortedAlgorithms{

    public class InsertionSorted{
        //构造函数传参
        // public StraightInsertion(int[] nums){
        //     this.nums=nums;
        // }
        private int[] nums;
        // 访问器传参（value为set的默认参数用来记录类外赋值）
        public int[] Nums{
            get{return this.nums;}
            set{
                this.nums = value;
            }
        }

        //first idea:Simple Straight Insertion Algorithm O(n^2)
        public void StraightInsertion(){
            if(this.nums.Length==0 || this.nums==null){
                throw new Exception ("nums not exist!");
            }
            for(int i=2; i<this.nums.Length;i++){
                if(this.nums[i]<this.nums[i-1]){
                    this.nums[0]=this.nums[i];
                    this.nums[i]=this.nums[i-1];
                    int j;
                    for(j=i-2;nums[0]<nums[j];j--){
                        this.nums[j+1]=this.nums[j];
                    }
                    this.nums[j+1]=this.nums[0];
                }
            }
        }

        public void BinaryInsertion(){
            if(this.nums.Length==0 || this.nums==null){
                throw new Exception ("nums not exist!");
            }

        }

    }
}