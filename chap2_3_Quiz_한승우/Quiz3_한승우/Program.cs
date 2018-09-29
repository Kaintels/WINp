using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Point { A = 4, B = 3, C = 2, D = 1}

namespace Quiz3_한승우
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = Point.A;
            Point B = Point.B;
            Point C = Point.C;
            Point D = Point.D;

            int i = (int)A;
            string i_1 = (string)"A";
            int j = (int)B;
            string j_1 = (string)"B";
            int k = (int)C;
            string k_1 = (string)"C";
            int l = (int)D;
            string l_1 = (string)"D";


            Data_Member a = new Data_Member("강호동", "경영학과", j_1, + j);
            Data_Member b = new Data_Member("김팔팔", "간호학과", i_1, + i);
            Data_Member c = new Data_Member("유재석", "생명과학과", k_1, + k);
            Data_Member d = new Data_Member("최왼손", "일본어학과", l_1, + l);
            Data_Member e = new Data_Member("한승우", "카메카트로닉스학과", j_1, + j);
            a.Print_Data_Member();
            b.Print_Data_Member();
            c.Print_Data_Member();
            d.Print_Data_Member();
            e.Print_Data_Member();
        }
    }
}
struct Data_Member {
    public String Name;
    public String Major;
    public String Grade;
    public int Point;
    public Data_Member(string aName, string aMajor, string aGrade, int aPoint)
    {
        Name = aName;
        Major = aMajor;
        Grade = aGrade;
        Point = aPoint;
    }
    public void Print_Data_Member()
    {
        Console.WriteLine("이름 : {0}, 학과 : {1}, 학점 등급 : {2} 학점 : {3}", Name, Major, Grade, Point);
    }

}
