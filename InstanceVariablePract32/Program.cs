using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariablePract32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //java style
            Product product1 = new Product();
            product1.Equals(product1);
            product1.name = "감자";
            product1.price = 2000;

            //C# style
            Product product2 = new Product() { name = "고구마", price = 2100 };
            Product product3 = new Product() { name = "옥수수" };
            Product product4 = new Product() { price = 999999 };
            Product product5 = new Product() { price = 7777, name = "비트" };

            Console.WriteLine(Product.origin);
            Console.WriteLine(product1.name + " / " + product1.price);
            Console.WriteLine(product1);

            List<Student> list = new List<Student>();
            //list.Add(product); //안 됨
            list.Add(new Student() { name = "곽경희", grade = 1 });
            list.Add(new Student() { name = "권하은", grade = 2 }); //지움
            list.Add(new Student() { name = "김선혜", grade = 3 }); //봐야되는데 2로 내려가서 패스됨
            list.Add(new Student() { name = "김하늘", grade = 4 }); //지움
            list.Add(new Student() { name = "배서연", grade = 1 }); //봐야되는데 패스됨
            list.Add(new Student() { name = "백지민", grade = 2 }); //지움
            //=> 역 for문으로 지우면 해결됨
            
            List<Student> list2 = new List<Student>();
            //list.Add(product); //안 됨
            list2.Add(new Student() { name = "백지민", grade = 3 });
            list2.Add(new Student() { name = "권하은", grade = 2 });
            list2.Add(new Student() { name = "김선혜", grade = 1 });

            foreach(Student student in list)
            {
                Console.WriteLine(student.ToString());
            }
            foreach(Student student in list2)
            {
                Console.WriteLine(student.ToString());
            }

            //list 안에 인스턴스 지우기 (예외 발생)
/*            foreach(var item in list) //하나씩 가져오는 것이기 때문에 중간에 빠지면안 됨
            {
                if(item.grade == 3)
                {
                    list.Remove(item);
                }
            }*/

            //잘못 삭제되는 코드
/*            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].grade == 2)
                {
                    list.RemoveAt(i);
                }
            }*/

            //뒤에서부터 삭제하면 문제를 피할 수 있다.
            for(int i = list.Count - 1; i>=0; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            Console.WriteLine("------------------");
            foreach (Student student in list)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
