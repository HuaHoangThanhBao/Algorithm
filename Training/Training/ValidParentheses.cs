using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ValidParentheses
    {
        public bool IsValid(string s)//Kiểm tra xâu chuỗi có đóng mở ngoặc hợp lệ ko?
		{
			Stack a = new Stack();
			//string s là chuỗi xâu ngoặc sẽ nhập vào
			for (int i = 0; i < s.Length; i++)//duyệt lần lượt hết chuỗi
			{
				if (s[i] == '(' || s[i] == '[' || s[i] == '{')//nếu gặp dấu mở ngoặc
				{
					a.Push(s[i]);//push hết vào stack 
				}
				else //nếu gặp dấu đóng ngoặc
				{
					if (a.Count != 0)//nếu stack khác rỗng 
					{
						if (s[i] == ']')//kiểm tra xem phần tử ngoặc đỉnh stack có hợp với s[i] hay không
						{
							if (a.Peek().ToString() != "[")//không hợp
							{
								return false;//sai
							}
						}
						if (s[i] == ')')//kiểm tra xem phần tử ngoặc đỉnh stack có hợp với s[i] hay không
						{
							if (a.Peek().ToString() != "(")//không hợp
							{
								return false;//sai
							}
						}
						if (s[i] == '}')//kiểm tra xem phần tử ngoặc đỉnh stack có hợp với s[i] hay không
						{
							if (a.Peek().ToString() != "{")//không hợp
							{
								return false;//sai
							}
						}
						a.Pop();//kiểm tra xong xóa nó đi
					}
					else //nếu như stack rỗng, không hợp lệ, có dấu mở mà không có đóng
					{
						return false;
					}
				}
			}
			if (a.Count == 0) return true;
            else return false;
        }
    }
}
