using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Tools
{
    public abstract class SavasAraci //Bu sınıf sadece miras vermekle görevli olduğu için abstract olarak tanımladık.
    {
        // Bu metod miras alınan her sınıfta farklı olarak kullanılacaksa abstract olarak tanımladık.
        public abstract void Saldir(); 
        // abstract bir metod yazabilmemiz için sınıfın da abstract bir sınıf olması gerekir.
    }
}
