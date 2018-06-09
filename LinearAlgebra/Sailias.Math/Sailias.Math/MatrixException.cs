using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailias.Math
{
    public class MatrixException : Exception
    {

        public MatrixException(string message, string helpUrl) : base(message)
        {
        }

    }
    public class MatrixAdditionException : MatrixException
    {
        private static string helpLink = "https://www.baidu.com/s?wd=%E7%9F%A9%E9%98%B5%E6%B1%82%E5%92%8C%E8%BF%90%E7%AE%97%E6%9D%A1%E4%BB%B6&rsv_spt=1&rsv_iqid=0xed380ba20002245d&issp=1&f=8&rsv_bp=1&rsv_idx=2&ie=utf-8&rqlang=cn&tn=baiduhome_pg&rsv_enter=1&rsv_t=d2a4k1Ux75pHXJd72qeQYGe9gnbuUS9JnvOmWhu3GHm1OoFzNxmKGoErPnejVxuIWhG0&oq=%25E7%259F%25A9%25E9%2598%25B5%25E6%25B1%2582%25E5%2592%258C%25E6%259D%25A1%25E4%25BB%25B6&inputT=2211&rsv_pq=86ed0c870002794f&rsv_sug3=44&rsv_sug1=35&rsv_sug7=100&rsv_sug2=0&rsv_sug4=9602";
        public MatrixAdditionException() : base("求和矩阵的行数和列数必须相等", helpLink)
        {
        }
    }
    public class MatrixMultiplicationException : MatrixException
    {
        private static string helpLink = "https://www.baidu.com/s?wd=%E7%9F%A9%E9%98%B5A%E5%B7%A6%E4%B9%98%E6%9D%A1%E4%BB%B6&rsv_spt=1&rsv_iqid=0xed380ba20002245d&issp=1&f=8&rsv_bp=1&rsv_idx=2&ie=utf-8&rqlang=cn&tn=baiduhome_pg&rsv_enter=1&rsv_t=3abbHz5YdUBLBOWL0L5j4yE1WQ87dVAPJM2B7kQSGBaeuqG7F1P2NyMWtmfQeHnZ7pVT&oq=%25E6%259C%25AA%25E5%25B0%2586%25E5%25AF%25B9%25E8%25B1%25A1%25E5%25BC%2595%25E7%2594%25A8%25E8%25AE%25BE%25E7%25BD%25AE%25E5%2588%25B0%25E5%25AF%25B9%25E8%25B1%25A1%25E7%259A%2584%25E5%25AE%259E%25E4%25BE%258B&inputT=9003&rsv_sug3=24&rsv_sug1=23&rsv_sug7=100&rsv_n=2&rsv_pq=d7517e47000238f5&rsv_sug2=0&rsv_sug4=9553";

        public MatrixMultiplicationException() : base("矩阵A左乘B：A矩阵的列数与B矩阵的行数必须相等", helpLink)
        {
        }
    }
    public class MatrixNullException : MatrixException
    {
        private static string helpLink = "https://www.baidu.com/s?wd=%E6%9C%AA%E5%B0%86%E5%AF%B9%E8%B1%A1%E5%BC%95%E7%94%A8%E8%AE%BE%E7%BD%AE%E5%88%B0%E5%AF%B9%E8%B1%A1%E7%9A%84%E5%AE%9E%E4%BE%8B&rsv_spt=1&rsv_iqid=0xed380ba20002245d&issp=1&f=8&rsv_bp=0&rsv_idx=2&ie=utf-8&tn=baiduhome_pg&rsv_enter=1&rsv_sug3=3&rsv_sug1=2&rsv_sug7=001&rsv_n=2";

        public MatrixNullException() : base("未将对象引用设置到对象的实例", helpLink)
        {
        }
    }
}
