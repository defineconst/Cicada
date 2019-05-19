using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTSharp.Cicada.Models
{
    public class EnumKeyValue
    {
        public string EnumName { get; set; }
        public object EnumValue { get; set; }
    }
    public static class EnumExts
    {
        public static  void  BindingEnum<T>(this System.Windows.Forms.BindingSource source) where T:Enum
        {
            var t = typeof(T);
            List<EnumKeyValue> values = new List<EnumKeyValue>();
            Enum.GetNames(t).ToList().ForEach(s => values.Add(new EnumKeyValue() { EnumName = s, EnumValue =  Enum.Parse(t, s) }));
            source.DataSource = values;

        }
    }
}
