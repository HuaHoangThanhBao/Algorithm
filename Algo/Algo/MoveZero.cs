using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class MoveZero
    {
        //Di chuyển những số 0 xuống cuối mảng
        public void MoveZeroes(int[] nums)
        {
            //Biến đếm những phần tử ko phải số 0
            int count = 0;

            //Duyệt mảng xem phần tử nào ko phải số 0 thì sắp lại chúng theo thứ tự
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)

                    //Sắp lại các phần tử ko phải số 0 theo thứ tự bắt đầu từ 0 đếm lên
                    nums[count++] = nums[i];

            //Bây giờ tất cả các phần tử đã đưa lên đầu dãy theo thứ tự
            //Biến count đã chạy tới sau cuối (vị trí có thể hiểu là vị trí cho những phần tử 0 còn lại)
            while (count < nums.Length)
                //Gán chúng = 0
                nums[count++] = 0;
        }
    }
}
