using System.Text.RegularExpressions;

namespace Extension_Method
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("아이디를 입력하세요 : ");
            string id = Console.ReadLine();

            if (id.IsAllowedID())
            {
                Console.WriteLine("ID가 유효합니다.");
            }
            else
            {
                Console.WriteLine("ID에 허용되지 않는 특수문자가 있습니다.");
            }
        }

        
    }
    public static class Extension
    {
        public static bool IsAllowedID(this string id)
        {
            //정규표현식
            //Regex regex = new Regex(id); //부분 문자열이 아니라 문자 하나를 보는거라 이거까진 굳이?
            
            //for (int i = 0; i < id.Length; i++)
            //{
            //    if (id[i] == '!' || id[i] == '@' || id[i] == '#' || id[i] == '$' || id[i] == '%' || id[i] == '^' || id[i] == '&' || id[i] == '*')
            //        return true;

            //}
            //return false;
            // //반복문을 돌려도 되고..


            if (id.Contains('!') || id.Contains('@') || id.Contains('#') || id.Contains('$') || id.Contains('%') || id.Contains('^') || id.Contains('&') || id.Contains('*'))
                return false;
            else
                return true;
            

            //string.Contains의 시간복잡도도 생각하면 그냥 반복문 돌리는게 더 빠르나?
            //포함하면 true, 포함하지 않으면 false라 true 나오자마자 결과내는건 낫긴하지만
            //결국 어느걸 하던 조건이 너무 길어져버린다
            //스위치문으로 하면 아래로 길어지는데 

            

            
            
        }
    }
}
