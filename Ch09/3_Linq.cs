﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 날 짜 : 2022/06/21
///  이 름 : 최희원
///  내 용 : Linq (p525)
///
/// 
/// Linq 
/// - Linq(Language Intergrated Query)는 collection 형태의 데이터를 가공처리하기 위한 C# Query Language(질의 언어)
/// - Linq를 사용해서 DB와 함께 데이터를 쉽게 관리
/// 

namespace Ch09
{
    internal class _3_Linq
    {
        class Member
        {
            private string uid;                                         /// 2 블럭지정
            private string name;
            private int age;

            public Member(string uid, string name, int age)             /// 2-1 블럭지정 - 빠른작업 리펙터링 - 필드캡슐화
            {
                this.uid = uid;
                this.name = name;
                this.age = age;
            }

            public string Uid { get => uid; set => uid = value; }       /// 2-1 블럭지정 - 빠른작업 리펙터링 - 생성자 생성
            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
        }


        static void Main1(string[] args)
        {

            /// 컬렉션 생성
            List<int> dataset = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /// 짝수 데이터 추출
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();


            /// 방법1. for문 이용
            foreach (int n in dataset)
            {
                if (n % 2 == 0) { result1.Add(n); }
            }

            /// 방법2. 람다식 이용
            dataset.ForEach((n) =>
            {
                if (n % 2 == 0) { result2.Add(n); }
            });

            /// 방법3. Linq 이용    (데이터 가공하는 표준언어가 SQL)
            var result3 = from n in dataset
                          where n % 2 == 0
                          select n;

            Console.WriteLine("result1 : " + string.Join(", ", result1));
            Console.WriteLine("result2 : " + string.Join(", ", result2));
            Console.WriteLine("result3 : " + string.Join(", ", result3));

            /// dataset에서 데이터가 5 이상 큰 순서대로 출력
            var result4 = from n in dataset
                          where n >= 5
                          orderby n descending
                          select n;

            Console.WriteLine("result4 : " + string.Join(", ", result4));

            /// 객체 리스트 Linq 이용
            List<Member> members = new List<Member>();
            members.Add(new Member("a101", "김유신", 25));
            members.Add(new Member("a102", "김춘추", 23));
            members.Add(new Member("a103", "장보고", 35));
            members.Add(new Member("a104", "강감찬", 45));
            members.Add(new Member("a105", "이순신", 55));

            /// 30세 이상, 이름 사전순
            var result5 = from member in members
                          where member.Age >= 30
                          orderby member.Name ascending
                          select member;

            foreach (Member m in result5)
            {
                Console.WriteLine("{0}, {1}, {2}", m.Uid, m.Name, m.Age);
            }

        }
    }
}
