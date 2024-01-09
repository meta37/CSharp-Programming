﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Delegate
{
    internal class Specifier
    {
        /*******************************************************************
         * 지정자 (Specifier)
         * 
         * 델리게이트를 사용하여 미완성 상태의 함수를 구성
         * 매개변수로 전달한 지정자를 기준으로 함수를 완성하여 동작시킴
         * 기준을 정해주는 것으로 다양한 결과가 나올 수 있는 함수를 구성가능
         ********************************************************************/

        // <델리게이트를 지정자로 사용>
        // 매개변수로 함수에 필요한 기준을 전달
        // 전달한 기준을 통해 결과를 도출
        void Main()
        {
            int[] array = { 3, -2, 1, -4, 9, -8, 7, -6, 5 };

            int index1 = FindIndex(array, value => value == 7);     // 배열 중 값이 7인 데이터 인덱스 찾기
            int index2 = FindIndex(array, value => value < 0);      // 배열 중 값이 0보다 작은 데이터 인덱스 찾기
            int index3 = FindIndex(array, value => value > 5);      // 배열 중 값이 5보다 큰 데이터 인덱스 찾기
        }

        public static int FindIndex(int[] array, Predicate<int> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
