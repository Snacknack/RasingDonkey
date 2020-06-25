using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    class Class1 // 저장된 파일이 없을때 로드 되는 기본 값
    {
        public static int Gold = 10000;
        public static int Level = 1;
        public static int Exp = 0;
        public static int RequiredExp = 10;
    }

    class Class2 
    {
        public static bool InvIsOpened = false;
        public static bool EpStIsOpened = false;
        public static bool ShopIsOpened = false;

    }

    class Class3
    {
        public static bool LogOnOff = false;
        public static string Log;
    }
}
