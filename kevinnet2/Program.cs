using System;

namespace kevinnet2
{
    //
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            kevinprint();
            int[] arr = {1, 2, 5, 6, 8, 5, 4, 3,94,99,33,45,12,34};
            //PopSort(arr);
            kevinkevin(arr);
        }

        static void kevinprint()
        {
            Console.WriteLine("hello kevin");
        }

        //冒泡排序
        static void PopSort(int[] list)
        {
            foreach (int k in list)
            {
                Console.WriteLine("kevin pop sort 输入的是:{0}", k);

            }
            Console.WriteLine("============kevin分割线===============");

            int temp;
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }

                }
            }

            foreach (int k  in list)
            {
                Console.WriteLine("kevin pop sort 结果是:{0}", k);

            }
            Console.WriteLine(list);

        }



        static void kevinsort(int[] array)
        {
            for (int i = 0; i < array.Length - 1;i++){
                for (int j = array.Length - 1; j > i;j--){
                    if (array[j] > array[j - 1]){
                        array[j] = array[j] + array[j - 1];
                        array[j - 1] = array[j] - array[j - 1];
                        array[j] = array[j] - array[j - 1];
                    }
                }
            }
            
        }
        static void kevinkevin(int[] list){

            foreach (var m in list)
            {
                Console.WriteLine(m);
                       
            }
            Console.WriteLine("--------分割线--------");
            int temp;
            for (int i = 0; i < list.Length -  1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }

                }
            }

            foreach (var l in list)
            {
                Console.WriteLine(l);
            }

        }


    }
}
