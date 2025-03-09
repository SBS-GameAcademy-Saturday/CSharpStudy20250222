using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FileName
    {
        public void Main()
        {
            // 문제 2 : 오른쪽 정렬된 직각 삼각형
            // 출력 예시 :
            //     *
            //    **
            //   ***
            //  ****
            // *****

            //지정된 갯수에 따라서 별을 출력한다.

            //* => 1개, ' ' => 4개 
            // *을 출력해야할 갯수 + ' ' 출력해야할 갯수 = 5
            for (int i = 0; i < 5 - 1; i++)
            {
                Console.Write(" "); //    
            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write("*");// *   
            }//     *

            Console.WriteLine();// 줄바꿈

            //* => 2개, ' ' => 3개 
            // *을 출력해야할 갯수 + ' ' 출력해야할 갯수 = 5
            for (int i = 0; i < 5 - 2; i++)
            {
                Console.Write(" "); //    
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write("*");// *   
            }//    **
            Console.WriteLine();// 줄바꿈

            //* => 3개, ' ' => 2개 
            // *을 출력해야할 갯수 + ' ' 출력해야할 갯수 = 5
            for (int i = 0; i < 5 - 3; i++)
            {
                Console.Write(" "); //    
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");// *   
            }//    **
            Console.WriteLine();// 줄바꿈


            //* => 4개, ' ' => 1개 
            // *을 출력해야할 갯수 + ' ' 출력해야할 갯수 = 5
            for (int i = 0; i < 5 - 4; i++)
            {
                Console.Write(" "); //    
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");// *   
            }//    **
            Console.WriteLine();// 줄바꿈

            //* => 5개, ' ' => 0개 
            // *을 출력해야할 갯수 + ' ' 출력해야할 갯수 = 5
            for (int i = 0; i < 5 - 5; i++)
            {
                Console.Write(" "); //    
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");// *   
            }//    **
            Console.WriteLine();// 줄바꿈
        }
    }
}
