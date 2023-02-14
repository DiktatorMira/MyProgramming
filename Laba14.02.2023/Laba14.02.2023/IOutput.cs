using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14._02._2023 {
    internal interface IOutput {
        void Show();
        void Show(string info);
    }
    internal interface IMath {
        int Max();
        int Min();
        double Avg();
        bool Search(int find);
    }
    internal interface ISort {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool is_asc);
    }
}
